--Запит - отримати унікальні ідентифікатори замовлень, які містять продукти, замовлені в певному замовленні, виключаючи саме це замовлення.
SELECT DISTINCT o.Id
FROM [Orders] o
JOIN Products p ON p.Id IN (
    SELECT op.ProductsId
    FROM OrderProduct op
    WHERE op.OrderId = @OrderId -- Replace 1 with the desired Order Id
)
WHERE o.Id <> @oId -- Exclude the specified Order Id from the result
