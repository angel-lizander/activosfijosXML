create database contabilidad
go

use [contabilidad]
go

Create table asientos(
  noasiento int PRIMARY KEY,
  descripcion varchar(200),
  fechaasiento varchar(10),
  cuenta int, 
  tipomovimiento varchar(4),
  monto float(50)
)