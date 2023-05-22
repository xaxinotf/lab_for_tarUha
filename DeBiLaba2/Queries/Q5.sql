--Retrieve the orders that have the same payment type and ship type

SELECT o.Id, o.DeliveryAddress, st.Name AS ShipTypeName
FROM Orders o
JOIN ShipTypes st ON o.ShipTypeId = st.Id
WHERE st.Id IN (
	SELECT o_1.Id
	FROM ShipTypes o_1
	WHERE o_1.Name = '@PaymentType'
)