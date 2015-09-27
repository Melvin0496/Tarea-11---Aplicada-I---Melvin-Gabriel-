--create database Pelicula;

use Pelicula;

create table Categorias(
categoriaId int Primary key identity(1,1),
titulo varchar(50),
descripcion varchar(200)
);
