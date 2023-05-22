﻿--Retrieve the total number of products in each order

SELECT o.Id, COUNT(*) AS ProductCount
FROM Orders o
JOIN OrderProduct op ON o.Id = op.OrderId
WHERE o.DeliveryAddress LIKE '@Dostavka'
GROUP BY o.Id
