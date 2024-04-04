-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bd_produto
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `bd_produto` ;

-- -----------------------------------------------------
-- Schema bd_produto
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bd_produto` DEFAULT CHARACTER SET latin1 ;
USE `bd_produto` ;

-- -----------------------------------------------------
-- Table `bd_produto`.`tbl_categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_produto`.`tbl_categoria` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(40) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = MyISAM
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bd_produto`.`tbl_tipousuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_produto`.`tbl_tipousuario` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = MyISAM
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bd_produto`.`tbl_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_produto`.`tbl_cliente` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(40) NOT NULL,
  `endereco` VARCHAR(100) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `telefone` VARCHAR(20) NOT NULL,
  `email` VARCHAR(40) NOT NULL,
  `senha` VARCHAR(20) NOT NULL,
  `tbl_tipousuario_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`, `tbl_tipousuario_id`),
  INDEX `fk_tbl_cliente_tbl_tipousuario1_idx` (`tbl_tipousuario_id` ASC))
ENGINE = MyISAM
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bd_produto`.`tbl_fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_produto`.`tbl_fornecedor` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `telefone` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = MyISAM
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `bd_produto`.`tbl_produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_produto`.`tbl_produto` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(50) NOT NULL,
  `preco` DOUBLE NOT NULL,
  `quantidade` INT(11) NOT NULL,
  `peso` DOUBLE NOT NULL,
  `tbl_categoria_id` INT(11) NOT NULL,
  `tbl_fornecedor_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`, `tbl_categoria_id`, `tbl_fornecedor_id`),
  INDEX `fk_tbl_produto_tbl_categoria_idx` (`tbl_categoria_id` ASC),
  INDEX `fk_tbl_produto_tbl_fornecedor1_idx` (`tbl_fornecedor_id` ASC))
ENGINE = MyISAM
DEFAULT CHARACTER SET = latin1;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;