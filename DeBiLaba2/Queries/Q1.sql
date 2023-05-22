--Запит - підрахувати к-сть товарів у кожному замовленні з адресою доставки, що містить "***".

SELECT o.Id, COUNT(*) AS ProductCount
FROM Orders o
JOIN OrderProduct op ON o.Id = op.OrderId
WHERE o.DeliveryAddress LIKE '@Dostavka' --***
GROUP BY o.Id
