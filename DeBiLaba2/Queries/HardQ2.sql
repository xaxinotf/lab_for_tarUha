--Запит2 Отримати ідентифікатори замовлень, які не містять певні продукти, замовлені в іншому замовленні.
SELECT o.Id
FROM [Orders] o
WHERE o.Id <> @oId -- Replace 1 
AND NOT EXISTS (
    SELECT *
    FROM Products p
    LEFT JOIN OrderProduct op ON op.ProductsId = p.Id
    WHERE op.OrderId = @OrderId -- Replace 1
    AND p.Id NOT IN (
        SELECT op2.ProductsId
        FROM OrderProduct op2
        WHERE op2.OrderId = o.Id
    )
)
