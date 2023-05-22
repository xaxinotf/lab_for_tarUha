--Запит - вибирати інформацію про користувачів із таблиці "Users", які зробили замовлення, використовуючи певний тип доставки.

SELECT u.Id, u.FirstName, u.LastName
FROM Users u
JOIN Orders o ON u.Id = o.UserId
JOIN ShipTypes st ON o.ShipTypeId = st.Id
WHERE st.Name = '@PaymentType'; --тип доставки