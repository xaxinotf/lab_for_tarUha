--Запит - повернути ім'я товару, інформацію про спосіб випуску та дозування, а також термін придатності для всіх товарів, пов'язаних із замовленнями, де ідентифікатор користувача відповідає значенню, переданому в параметрі @id.

SELECT p.Name, p.RelaiseFromAndDosing,p.ShelfLife
FROM Products p
JOIN OrderProduct op ON p.Id = op.ProductsId
JOIN Orders o ON op.OrderId = o.Id
WHERE o.UserId = @id; --***