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
    empresa VARCHAR(100)
);

-- Crear la tabla de Licitaciones
CREATE TABLE Licitaciones (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    titulo VARCHAR(100),
    descripcion TEXT,
    fecha_inicio DATE,
    fecha_fin DATE,
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




-- ---------------------INSERSIONES DE DATOS --------------------------------------- --
select * from Clientes;
-- Insertar usuarios
INSERT INTO Usuarios (usuario, pass, email, rol) VALUES
    ('Admin', '123', 'admin@gmail.com', 'administrador'), 
    ('Fatima', '123', 'proveedor@gmail.com', 'proveedor'),
    ('Diego', '123', 'proveedor@gmail.com', 'cliente'),
    ('Ronald', '12345', 'ronald@gmail.com', 'cliente'),
    ('David', '12345', 'david@gmail.com', 'cliente'),
    ('Edwin', '12345', 'edwin@gmail.com', 'cliente');
 

INSERT INTO Clientes (nombre, email, telefono, empresa, id_usuario)
VALUES ('Diego Pablo Castillo', 'cr@email.com', '2345-6789', 'Casa Rivas', 3);
INSERT INTO Clientes (nombre, email, telefono, empresa, id_usuario)
VALUES ('Ronald Hernandez', 'Manteinance@email.com', '2345-6789', 'Manteinance HR', 4);
INSERT INTO Clientes (nombre, email, telefono, empresa, id_usuario)
VALUES ('David Flores', 'TechSolutions@email.com', '2302-0789', 'TechSolutions', 5);


INSERT INTO Proveedores (nombre, email, telefono, empresa)
VALUES ('Fatima Alexandra Castillo', 'glm@email.com', '2567-4567', 'GomezLee Marketing');
INSERT INTO Proveedores (nombre, email, telefono, empresa)
VALUES ('Sandra Garcia', 'markershare@gmail.com', '2567-4567', 'MarkerShare');

INSERT INTO Licitaciones (titulo, descripcion, fecha_inicio, fecha_fin, estado,id_cliente)
VALUES ('Licitación de Construcción', 'Construccion de edificio', '2023-10-31', '2023-11-30', '0',1);


select * from PropuestasEconomicas;
select * from Licitaciones;
select * from Proveedores;