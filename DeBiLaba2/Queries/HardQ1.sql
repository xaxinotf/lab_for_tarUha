--Запит - отримати унікальні ідентифікатори замовлень, які містять продукти, замовлені в певному замовленні, виключаючи саме це замовлення.
SELECT DISTINCT o.Id
FROM [Orders] o
JOIN Products p ON p.Id IN (
    SELECT op.ProductsId
    FROM OrderProduct op
    WHERE op.OrderId = @OrderId --minayemo
)
WHERE o.Id <> @oId --minayemo
