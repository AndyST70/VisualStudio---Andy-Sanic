-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Biblioteca
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Biblioteca
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Biblioteca` DEFAULT CHARACTER SET utf8 ;
USE `Biblioteca` ;

-- -----------------------------------------------------
-- Table `Biblioteca`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Usuario` (
  `idUsuario` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(150) NOT NULL,
  `apellido` VARCHAR(150) NOT NULL,
  `carnet` VARCHAR(10) NOT NULL,
  `correo` VARCHAR(150) NOT NULL,
  `fecha_nacimiento` DATE NOT NULL,
  `cui` VARCHAR(15) NOT NULL,
  `password` VARCHAR(100) NOT NULL,
  `idrol` INT NOT NULL,
  PRIMARY KEY (`idUsuario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Pais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Pais` (
  `idPais` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(150) NOT NULL,
  PRIMARY KEY (`idPais`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Autor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Autor` (
  `idAutor` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(150) NOT NULL,
  `Apellido` VARCHAR(150) NOT NULL,
  `Idpais` INT NOT NULL,
  PRIMARY KEY (`idAutor`),
  INDEX `Autor_idx` (`Idpais` ASC) VISIBLE,
  CONSTRAINT `Autor`
    FOREIGN KEY (`Idpais`)
    REFERENCES `Biblioteca`.`Pais` (`idPais`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Categoria` (
  `idCategoria` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(150) NULL,
  PRIMARY KEY (`idCategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Editorial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Editorial` (
  `idEditorial` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(150) NOT NULL,
  PRIMARY KEY (`idEditorial`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Libros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Libros` (
  `idLibros` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(150) NOT NULL,
  `FechaLanzamiento` DATE NOT NULL,
  `Cant_Disponible` INT NOT NULL,
  `imagen` VARCHAR(45) NOT NULL,
  `Precio` DOUBLE NOT NULL,
  `ubicacion` VARCHAR(200) NOT NULL,
  `CategoriaID` INT NOT NULL,
  `AutorID` INT NOT NULL,
  `EditorialID` INT NOT NULL,
  PRIMARY KEY (`idLibros`),
  INDEX `libros_autor_idx` (`AutorID` ASC) VISIBLE,
  INDEX `libros_genero_idx` (`CategoriaID` ASC) VISIBLE,
  INDEX `libros_editorial_idx` (`EditorialID` ASC) VISIBLE,
  CONSTRAINT `libros_autor`
    FOREIGN KEY (`AutorID`)
    REFERENCES `Biblioteca`.`Autor` (`idAutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `libros_genero`
    FOREIGN KEY (`CategoriaID`)
    REFERENCES `Biblioteca`.`Categoria` (`idCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `libros_editorial`
    FOREIGN KEY (`EditorialID`)
    REFERENCES `Biblioteca`.`Editorial` (`idEditorial`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Prestamos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Prestamos` (
  `idPrestamos` INT NOT NULL AUTO_INCREMENT,
  `fecha_prestamo` DATE NOT NULL,
  `idusuario` INT NOT NULL,
  `idlibro` INT NOT NULL,
  PRIMARY KEY (`idPrestamos`),
  INDEX `prestamo_usuario_idx` (`idusuario` ASC) VISIBLE,
  INDEX `prestamo_libros_idx` (`idlibro` ASC) VISIBLE,
  CONSTRAINT `prestamo_usuario`
    FOREIGN KEY (`idusuario`)
    REFERENCES `Biblioteca`.`Usuario` (`idUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `prestamo_libros`
    FOREIGN KEY (`idlibro`)
    REFERENCES `Biblioteca`.`Libros` (`idLibros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca`.`Devoluciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Biblioteca`.`Devoluciones` (
  `idDevoluciones` INT NOT NULL AUTO_INCREMENT,
  `fecha` DATE NOT NULL,
  `User_Registro` VARCHAR(150) NOT NULL,
  `idprestamos` INT NOT NULL,
  PRIMARY KEY (`idDevoluciones`),
  INDEX `devolucion_prestamo_idx` (`idprestamos` ASC) VISIBLE,
  CONSTRAINT `devolucion_prestamo`
    FOREIGN KEY (`idprestamos`)
    REFERENCES `Biblioteca`.`Prestamos` (`idPrestamos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
