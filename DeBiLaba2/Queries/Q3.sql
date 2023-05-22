--Запит - виконати підрахунок кількості замовлень для кожного типу платежу, де назва типу платежу містить рядок '****'.

SELECT PaymentTypes.Name, COUNT(*) AS OrderCount
FROM Orders
JOIN PaymentTypes ON Orders.PaymentTypeId = PaymentTypes.Id
GROUP BY PaymentTypes.Name
HAVING Name LIKE '@PayBinance' -- ***