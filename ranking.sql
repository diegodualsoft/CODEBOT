# Host: localhost  (Version 5.6.17)
# Date: 2016-04-01 11:04:35
# Generator: MySQL-Front 5.3  (Build 5.21)

/*!40101 SET NAMES latin1 */;

#
# Structure for table "ranking"
#

DROP TABLE IF EXISTS `ranking`;
CREATE TABLE `ranking` (
  `nombre` varchar(255) NOT NULL DEFAULT '0',
  `cantidad` double NOT NULL DEFAULT '0',
  `fecha` date NOT NULL DEFAULT '0000-00-00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
