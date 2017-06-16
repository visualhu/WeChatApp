-- --------------------------------------------------------
-- Host:                         bdm284884492.my3w.com
-- Server version:               5.1.73 - Source distribution
-- Server OS:                    unknown-linux-gnu
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for bdm284884492_db
DROP DATABASE IF EXISTS `bdm284884492_db`;
CREATE DATABASE IF NOT EXISTS `bdm284884492_db` /*!40100 DEFAULT CHARACTER SET gbk */;
USE `bdm284884492_db`;

-- Dumping structure for table bdm284884492_db.mp_appconfig
DROP TABLE IF EXISTS `mp_appconfig`;
CREATE TABLE IF NOT EXISTS `mp_appconfig` (
  `ID` varchar(50) NOT NULL,
  `AppName` varchar(50) NOT NULL,
  `AppID` varchar(50) NOT NULL,
  `AppSecret` varchar(50) NOT NULL,
  `AppQrCode` varchar(200) DEFAULT NULL,
  `ActiveStatus` bit(1) NOT NULL,
  `CreatedOn` datetime DEFAULT NULL,
  `CreatedBy` varchar(50) DEFAULT NULL,
  `UpdatedOn` datetime NOT NULL,
  `UpdatedBy` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=gbk;

-- Dumping data for table bdm284884492_db.mp_appconfig: 0 rows
DELETE FROM `mp_appconfig`;
/*!40000 ALTER TABLE `mp_appconfig` DISABLE KEYS */;
/*!40000 ALTER TABLE `mp_appconfig` ENABLE KEYS */;

-- Dumping structure for table bdm284884492_db.mp_menu
DROP TABLE IF EXISTS `mp_menu`;
CREATE TABLE IF NOT EXISTS `mp_menu` (
  `ID` varchar(50) NOT NULL,
  `Status` int(11) NOT NULL,
  `Menu` text NOT NULL,
  `ActiveStatus` bit(1) NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `CreatedBy` varchar(50) NOT NULL,
  `UpdatedOn` datetime DEFAULT NULL,
  `UpdatedBy` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=gbk;

-- Dumping data for table bdm284884492_db.mp_menu: 0 rows
DELETE FROM `mp_menu`;
/*!40000 ALTER TABLE `mp_menu` DISABLE KEYS */;
/*!40000 ALTER TABLE `mp_menu` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
