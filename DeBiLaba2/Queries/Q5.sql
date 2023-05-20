--Retrieve the orders that have the same payment type and ship type

SELECT o.Id, o.DeliveryAddress, pt.Name AS PaymentTypeName, st.Name AS ShipTypeName
FROM Orders o
JOIN PaymentTypes pt ON o.PaymentTypeId = pt.Id
JOIN ShipTypes st ON o.ShipTypeId = st.Id
WHERE pt.Id = st.Id;