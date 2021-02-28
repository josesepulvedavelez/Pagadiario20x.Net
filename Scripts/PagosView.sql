CREATE VIEW [dbo].[PagosView]
AS
SELECT
	Pagos.Fecha,
	Pagos.Pago,
	Pagos.ProximoPago,
	Pagos.Notas,
	Pagos.Activo,
	Pagos.PrestamoId,
	Pagos.CobradorId,
	Cobrador.Nombres,
	Pagos.PagoId
FROM
	Pagos INNER JOIN Cobrador
		ON Cobrador.CobradorId = Pagos.CobradorId