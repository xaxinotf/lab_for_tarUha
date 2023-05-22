--Цей запит по суті отримує замовлення, які мають принаймні один спільний продукт із замовленням 3, але не мають продуктів, які є ексклюзивними для замовлення 3. Не забудьте замінити 2 і 3 на потрібні ідентифікатори замовлення, які ви хочете порівняти.

SELECT o.Id
FROM Orders o
WHERE o.Id <> @oId --minayemo
AND NOT EXISTS (
    SELECT *
    FROM Products p
    WHERE NOT EXISTS (
        SELECT *
        FROM OrderProduct op
        WHERE op.OrderId = @OrderId --minayemo
        AND op.ProductsId = p.Id
    )
    AND EXISTS (
        SELECT *
        FROM OrderProduct op2
        WHERE op2.OrderId = o.Id
        AND op2.ProductsId = p.Id
    )
)