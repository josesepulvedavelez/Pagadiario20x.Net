Create ViEW [dbo].[PrestamoView]
AS
SELECT 
	   Cliente.Cedula AS [CC Cliente], 
	   Cliente.Nombres, 
	   Cliente.Telefono, 
	   Cliente.Celular, 
	   Cliente.Direccion,
	   Prestamo.PrestamoId,
	   Prestamo.No, 
	   Prestamo.Fecha, 
	   Prestamo.FechaLimite, 
	   DATEDIFF(DAY, Prestamo.Fecha, Prestamo.FechaLimite) AS Tiempo, 
	   Prestamo.Monto, 
	   Prestamo.Interes, 
	   Prestamo.FormaPago, 
	   Prestamo.TotalPagar / (DATEDIFF(DAY,Prestamo.Fecha, Prestamo.FechaLimite)) AS Cuota, 
	   Prestamo.TotalPagar, 
	   SUM(Pagos.Pago) AS TotalPagos, 
	   (Prestamo.Monto - SUM(Pagos.Pago)) AS Saldo 

FROM 
	Cliente INNER JOIN Prestamo
		ON Cliente.ClienteId = Prestamo.ClienteId

	LEFT JOIN Pagos
		ON Prestamo.PrestamoId = Pagos.PrestamoId

GROUP BY 
	Cliente.Cedula, 
	Cliente.Nombres, 
	Cliente.Telefono, 
	Cliente.Celular, 
	Cliente.Direccion,
	Prestamo.PrestamoId,
	Prestamo.No, 
	Prestamo.Fecha, 
	Prestamo.Monto, 
	Prestamo.Interes, 
	Prestamo.FormaPago, 
	Prestamo.FechaLimite, 
	Prestamo.TotalPagar

HAVING Prestamo.TotalPagar> 0