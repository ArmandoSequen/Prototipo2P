drop database hotelsancarlos;
create database hotelsancarlos;
use hotelsancarlos;

create table empresa(
	idEmpresa varchar(15) primary key not null,
	nit varchar(13) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table proveedor(
	idProveedor varchar(15),
	nombre varchar(100) not NULL,
	direccion varchar(500) not NULL,
	telefono int not NULL,
	email varchar(200) not NULL,
	idEmpresa varchar(15),
	stsproveedor varchar(1),
	primary key (idProveedor),
    
	foreign key (idEmpresa) references empresa (idEmpresa)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table inventario(
	Pkid varchar(15) primary key,
	Fktipoinventario varchar(15) not null

)engine=InnoDB DEFAULT CHARSET=latin1;

create table producto (
	pkid varchar(15) primary key,
	fkinventario varchar(15) not null,
	Nombre varchar(30) not null,
	Fkidlinea varchar(15) not null,
	Stock int not null,
    StockMaximo int not null,
    StockMinimo int not null,
	Costo float not null,
	Precio float not null,
	Estatus varchar(1),

	foreign key (fkinventario) references inventario (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table cliente(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	idTipo varchar(15) not null,
	apellido varchar(30) not null,
	nit varchar(15) not null,
	telefono varchar(15) not null,
	direccion varchar(50) not null,
	correo varchar(50) not null,
	estatus varchar(1)

)engine=InnoDB DEFAULT CHARSET=latin1;






     















