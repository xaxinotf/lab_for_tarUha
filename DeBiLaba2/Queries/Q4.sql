--Retrieve the users who have placed orders with a specific ship type

SELECT u.Id, u.FirstName, u.LastName
FROM Users u
JOIN Orders o ON u.Id = o.UserId
JOIN ShipTypes st ON o.ShipTypeId = st.Id
WHERE st.Name = '@PaymentType';