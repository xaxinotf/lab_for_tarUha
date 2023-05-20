--Retrieve the total count of orders for each payment type:

SELECT PaymentTypes.Name, COUNT(*) AS OrderCount
FROM Orders
JOIN PaymentTypes ON Orders.PaymentTypeId = PaymentTypes.Id
GROUP BY PaymentTypes.Name;