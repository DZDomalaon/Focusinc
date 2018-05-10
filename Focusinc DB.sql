-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema focusinc
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema focusinc
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `focusinc` DEFAULT CHARACTER SET utf8 ;
USE `focusinc` ;

-- -----------------------------------------------------
-- Table `focusinc`.`accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`accounts` (
  `ACCOUNT_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `ACCOUNT_NAME` VARCHAR(45) NULL DEFAULT NULL,
  `ACCOUNT_STATUS` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`ACCOUNT_ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`PC_properties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`PC_properties` (
  `PC_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `PC_ASSET_NO` VARCHAR(45) NULL,
  `PC_NAME` VARCHAR(45) NULL,
  `MANUFACTURED_DATE` DATE NULL DEFAULT NULL,
  `PC_MONTH&YEAR` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`PC_ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`assets`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`assets` (
  `ASSET_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `MOUSE` VARCHAR(45) NULL DEFAULT NULL,
  `KEYBOARD` VARCHAR(45) NULL DEFAULT NULL,
  `HEADSET` VARCHAR(45) NULL DEFAULT NULL,
  `MONITOR` VARCHAR(45) NULL DEFAULT NULL,
  `WEBCAM` VARCHAR(45) NULL DEFAULT NULL,
  `TELEPHONE` VARCHAR(45) NULL,
  `UPS` VARCHAR(45) NULL,
  `ASSET_PC_ID` INT(11) NOT NULL,
  PRIMARY KEY (`ASSET_ID`),
  INDEX `fk_assets_pc_lifespan1_idx` (`ASSET_PC_ID` ASC),
  CONSTRAINT `fk_assets_pc_lifespan1`
    FOREIGN KEY (`ASSET_PC_ID`)
    REFERENCES `focusinc`.`PC_properties` (`PC_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`person`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`person` (
  `PERSON_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `FIRSTNAME` VARCHAR(45) NULL DEFAULT NULL,
  `LASTNAME` VARCHAR(45) NULL DEFAULT NULL,
  `POSITION` VARCHAR(45) NULL DEFAULT NULL,
  `STATUS` VARCHAR(45) NULL DEFAULT NULL,
  `GMAIL_ACC` VARCHAR(45) NULL DEFAULT NULL,
  `SKYPE_ACC` VARCHAR(45) NULL DEFAULT NULL,
  `PERSON_ACCOUNT_ID` INT(11) NULL,
  PRIMARY KEY (`PERSON_ID`),
  INDEX `fk_person_accounts1_idx` (`PERSON_ACCOUNT_ID` ASC),
  CONSTRAINT `fk_person_accounts1`
    FOREIGN KEY (`PERSON_ACCOUNT_ID`)
    REFERENCES `focusinc`.`accounts` (`ACCOUNT_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`history`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`history` (
  `HISTORY_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `DT_TRANSACTION` DATETIME NULL DEFAULT NULL,
  `TYPE` VARCHAR(45) NULL DEFAULT NULL,
  `DESCRIPTION` VARCHAR(45) NULL DEFAULT NULL,
  `HISTORY_PERSON_ID` INT(11) NULL,
  `HISTORY_ASSET_ID` INT(11) NULL,
  PRIMARY KEY (`HISTORY_ID`),
  INDEX `fk_history_person1_idx` (`HISTORY_PERSON_ID` ASC),
  INDEX `fk_history_assets1_idx` (`HISTORY_ASSET_ID` ASC),
  CONSTRAINT `fk_history_assets1`
    FOREIGN KEY (`HISTORY_ASSET_ID`)
    REFERENCES `focusinc`.`assets` (`ASSET_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_history_person1`
    FOREIGN KEY (`HISTORY_PERSON_ID`)
    REFERENCES `focusinc`.`person` (`PERSON_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`floor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`floor` (
  `FLOOR_ID` INT NOT NULL,
  `FLOOR_NAME` VARCHAR(45) NULL,
  PRIMARY KEY (`FLOOR_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `focusinc`.`working_place`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`working_place` (
  `WP_ID` INT(11) NOT NULL AUTO_INCREMENT,
  `WORKSTATION_NO` VARCHAR(45) NULL DEFAULT NULL,
  `REMARKS` VARCHAR(45) NULL DEFAULT NULL,
  `WP_FLOOR_ID` INT NOT NULL,
  PRIMARY KEY (`WP_ID`),
  INDEX `fk_working_place_floor1_idx` (`WP_FLOOR_ID` ASC),
  CONSTRAINT `fk_working_place_floor1`
    FOREIGN KEY (`WP_FLOOR_ID`)
    REFERENCES `focusinc`.`floor` (`FLOOR_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `focusinc`.`working_place_hasPA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `focusinc`.`working_place_hasPA` (
  `WPH_PERSON_ID` INT(11) NULL,
  `WPH_WP_ID` INT(11) NULL,
  `WPH_ASSET_ID` INT(11) NULL,
  INDEX `fk_table1_person1_idx` (`WPH_PERSON_ID` ASC),
  INDEX `fk_table1_working_place1_idx` (`WPH_WP_ID` ASC),
  INDEX `fk_table1_assets1_idx` (`WPH_ASSET_ID` ASC),
  CONSTRAINT `fk_table1_person1`
    FOREIGN KEY (`WPH_PERSON_ID`)
    REFERENCES `focusinc`.`person` (`PERSON_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_table1_working_place1`
    FOREIGN KEY (`WPH_WP_ID`)
    REFERENCES `focusinc`.`working_place` (`WP_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_table1_assets1`
    FOREIGN KEY (`WPH_ASSET_ID`)
    REFERENCES `focusinc`.`assets` (`ASSET_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
