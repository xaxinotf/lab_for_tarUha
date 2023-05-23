--Запит - отримати унікальні ідентифікатори замовлень, які містять продукти, замовлені в певному замовленні, виключаючи саме це замовлення.
SELECT DISTINCT o.Id
FROM [Orders] o
WHERE o.Id <> @oId AND NOT EXISTS( --minayemo @oId
	SELECT op.ProductsId
    FROM [OrderProduct] op
    WHERE op.OrderId = @OrderId --minayemo @OrderId
	EXCEPT 
    SELECT op.ProductsId
    FROM OrderProduct op
    WHERE op.OrderId = o.Id
)

--nor exist  ||notr exist@OrderId
-- not in 
--a не входить в бе я не чорт :(