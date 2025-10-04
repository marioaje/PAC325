using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ProyectoFront.Models;
using System;

namespace ProyectoFront.Data
{
    public class AppDbContext : DbContext
    {
        //Creo un constructor vacio
        public AppDbContext ( DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        public DbSet<ProductoModel> Producto { get; set; }
        //Establcemos los modelos de datos.

        //      CREATE TABLE `u484426513_pac325`.`Producto` (
        //`Id` INT NOT NULL AUTO_INCREMENT,
        //`Nombre` VARCHAR(45) NOT NULL,
        //`Descripcion` VARCHAR(45) NOT NULL,
        //`Precio` DECIMAL NOT NULL,
        //`Cantidad` INT NOT NULL,
        //PRIMARY KEY(`Id`));
    }
}
