-- Crear la base de datos "Syscom"
CREATE DATABASE Syscom;

-- Usar la base de datos
USE Syscom;

-- Crear la tabla de Usuarios
CREATE TABLE Usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50),
    pass VARCHAR(255), 
    email VARCHAR(100),
    rol VARCHAR(50) 
);

CREATE TABLE Clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    email VARCHAR(100),
    telefono VARCHAR(20),
    empresa VARCHAR(100),
    id_usuario INT, 
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id) -- Clave foránea para la vinculación con Usuarios
);

-- Crear la tabla de Proveedores
CREATE TABLE Proveedores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    email VARCHAR(100),
    telefono VARCHAR(20),
    empresa VARCHAR(100),
    id_usuario INT, 
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id) -- Clave foránea para la vinculación con Usuarios
);

-- Crear la tabla de Licitaciones
CREATE TABLE Licitaciones (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    titulo VARCHAR(100),
    descripcion TEXT,
    fecha_inicio DATE,
    fecha_fin DATE,
	ganador BOOLEAN null,
    estado VARCHAR(50) null, 
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id)
);

-- Crear la tabla de Propuestas Económicas
CREATE TABLE PropuestasEconomicas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_licitacion INT,
    id_proveedor INT,
    precio DECIMAL(10, 2),
    FOREIGN KEY (id_licitacion) REFERENCES Licitaciones(id),
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id)
);

-- Crear la tabla de Productos
CREATE TABLE Productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre_producto VARCHAR(100),
    descripcion TEXT,
    precio_unitario DECIMAL(10, 2),
    cantidad INT,
    id_licitacion INT,
    FOREIGN KEY (id_licitacion) REFERENCES Licitaciones(id)
);
select * from Clientes;
-- Insertar usuarios
INSERT INTO Usuarios (usuario, pass, email, rol) VALUES
    ('Diego', '123', 'proveedor@ejemplo.com', 'cliente'),
    ('Fatima', '123', 'proveedor@ejemplo.com', 'proveedor'),
    ('Admin', '123', 'admin@ejemplo.com', 'administrador');
 
select * from Usuarios;