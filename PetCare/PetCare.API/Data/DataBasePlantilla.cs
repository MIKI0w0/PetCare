//--Crear la base de datos (si no existe) y seleccionar su uso
//CREATE DATABASE IF NOT EXISTS PetCare;
//USE PetCare;

//-- ==============================================
//--Tabla Cliente
//-- ==============================================
//CREATE TABLE Cliente(
//    IdCliente INT NOT NULL AUTO_INCREMENT,
//    Nombre VARCHAR(100) NOT NULL,
//    Telefono VARCHAR(20) NOT NULL,
//    Email VARCHAR(100),
//    PRIMARY KEY (IdCliente)
//) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

//-- ==============================================
//--Tabla Proveedor
//-- ==============================================
//CREATE TABLE Proveedor(
//    IdProveedor INT NOT NULL AUTO_INCREMENT,
//    Nombre VARCHAR(100) NOT NULL,
//    Telefono VARCHAR(20) NOT NULL,
//    Email VARCHAR(100),
//    PRIMARY KEY (IdProveedor)
//) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

//-- ==============================================
//--Tabla Mascota
//-- ==============================================
//CREATE TABLE Mascota(
//    IdMascota INT NOT NULL AUTO_INCREMENT,
//    Nombre VARCHAR(100) NOT NULL,
//    Especie VARCHAR(50) NOT NULL,
//    Raza VARCHAR(50) NOT NULL,
//    Edad INT,
//    IdCliente INT NOT NULL,
//    PRIMARY KEY (IdMascota),
//    CONSTRAINT FK_Mascota_Cliente FOREIGN KEY (IdCliente)
//        REFERENCES Cliente(IdCliente)
//        ON DELETE CASCADE ON UPDATE CASCADE
//) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

//-- ==============================================
//--Tabla Servicio
//-- ==============================================
//CREATE TABLE Servicio(
//    IdServicio INT NOT NULL AUTO_INCREMENT,
//    Nombre VARCHAR(100) NOT NULL,
//    Precio DECIMAL(10,2) NOT NULL,
//    PRIMARY KEY (IdServicio)
//) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

//-- ==============================================
//--Tabla Cita
//-- ==============================================
//CREATE TABLE Cita(
//    IdCita INT NOT NULL AUTO_INCREMENT,
//    FechaHora DATETIME NOT NULL,
//    IdMascota INT NOT NULL,
//    IdServicio INT NOT NULL,
//    PRIMARY KEY (IdCita),
//    CONSTRAINT FK_Cita_Mascota FOREIGN KEY (IdMascota)
//        REFERENCES Mascota(IdMascota)
//        ON DELETE CASCADE ON UPDATE CASCADE,
//    CONSTRAINT FK_Cita_Servicio FOREIGN KEY (IdServicio)
//        REFERENCES Servicio(IdServicio)
//        ON DELETE RESTRICT ON UPDATE CASCADE
//) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

//-- ==============================================
//--Tabla Producto
//-- ==============================================
//CREATE TABLE Producto(
//    IdProducto INT NOT NULL AUTO_INCREMENT,
//    Nombre VARCHAR(100) NOT NULL,
//    Precio DECIMAL(10,2) NOT NULL,
//    Stock INT NOT NULL,
//    IdProveedor INT NOT NULL,
//    PRIMARY KEY (IdProducto),
//    CONSTRAINT FK_Producto_Proveedor FOREIGN KEY (IdProveedor)
//        REFERENCES Proveedor(IdProveedor)
//        ON DELETE CASCADE ON UPDATE CASCADE
//) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

//-- ==============================================
//--Tabla CitaProducto(Tabla intermedia para la relación muchos a muchos)
//-- ==============================================
//CREATE TABLE CitaProducto(
//    IdCita INT NOT NULL,
//    IdProducto INT NOT NULL,
//    Cantidad INT NOT NULL,
//    PRIMARY KEY (IdCita, IdProducto),
//    CONSTRAINT FK_CitaProducto_Cita FOREIGN KEY (IdCita)
//        REFERENCES Cita(IdCita)
//        ON DELETE CASCADE ON UPDATE CASCADE,
//    CONSTRAINT FK_CitaProducto_Producto FOREIGN KEY (IdProducto)
//        REFERENCES Producto(IdProducto)
//        ON DELETE CASCADE ON UPDATE CASCADE
//) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;
//-- ==============================================
