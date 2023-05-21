﻿--Retrieve all products ordered by a specific user
SELECT p.Name, p.RelaiseFromAndDosing,p.ShelfLife
FROM Products p
JOIN OrderProduct op ON p.Id = op.ProductsId
JOIN Orders o ON op.OrderId = o.Id
WHERE o.UserId = @id;