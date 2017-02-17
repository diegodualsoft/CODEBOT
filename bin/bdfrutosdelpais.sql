# Host: localhost  (Version: 5.5.24-log)
# Date: 2015-12-21 21:34:12
# Generator: MySQL-Front 5.3  (Build 4.249)

/*!40101 SET NAMES latin1 */;

#
# Structure for table "188747736_1"
#

DROP TABLE IF EXISTS `188747736_1`;
CREATE TABLE `188747736_1` (
  `rut` varchar(255) DEFAULT NULL,
  `nombre_contacto` varchar(255) DEFAULT NULL,
  `numero_factura` varchar(255) DEFAULT NULL,
  `razon_social` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `comuna` varchar(255) DEFAULT NULL,
  `ciudad` varchar(255) DEFAULT NULL,
  `vendedor` varchar(255) DEFAULT NULL,
  `NF` varchar(255) DEFAULT NULL,
  `palabras` varchar(255) DEFAULT NULL,
  `palabras2` varchar(255) DEFAULT NULL,
  `vcto` varchar(255) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `giro` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL,
  `mano_de_obra` int(11) DEFAULT NULL,
  `subtotales` int(11) DEFAULT NULL,
  `iva` int(11) DEFAULT NULL,
  `totales` int(11) DEFAULT NULL,
  `codigo` varchar(255) DEFAULT NULL,
  `nombre_producto` varchar(255) DEFAULT NULL,
  `precio_venta` int(11) DEFAULT NULL,
  `cantidad` varchar(255) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "188747736_1"
#

INSERT INTO `188747736_1` VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2','PAPAS FRITAS 10MM',2000,'3,056',6112),(NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','QUESO',7200,'1,528',11001),(NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),('188747736','OSWAL MOENA','1','DUALAPP','NOSE 55 20','CAUITN','TEMUCO','ASFF','DFGDFG','WETWTRSETWEFWEFEWFWEFWEFFEWFWEFWEFWEFWE','WEFWEFWEFWEFWEFEWFWEFEWFWEFWEFWEFWEFWEF','EWR','525445544','APLICACIONES PA','21_12_2015',NULL,17113,3251,20364,NULL,NULL,NULL,NULL,NULL);

#
# Structure for table "21_12_2015"
#

DROP TABLE IF EXISTS `21_12_2015`;
CREATE TABLE `21_12_2015` (
  `nombre` varchar(255) NOT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "21_12_2015"
#

INSERT INTO `21_12_2015` VALUES ('CHOCLO GRANEADO 250G','1','Gr'),('PAPAS FRITAS 10MM','1','Gr'),('PRIMAVERA 250G','1','Gr'),('QUESO','1','Kg');

#
# Structure for table "caja"
#

DROP TABLE IF EXISTS `caja`;
CREATE TABLE `caja` (
  `nombre` varchar(255) NOT NULL DEFAULT '',
  `codigo` varchar(255) NOT NULL DEFAULT '',
  `precio` int(11) DEFAULT NULL,
  `cant` varchar(53) NOT NULL DEFAULT '0.00',
  `total` int(11) DEFAULT NULL,
  `costo` int(11) DEFAULT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "caja"
#


#
# Structure for table "clientes"
#

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `rut` varchar(14) NOT NULL DEFAULT '',
  `razon_social` varchar(15) NOT NULL DEFAULT '',
  `giro` varchar(15) NOT NULL DEFAULT '',
  `nombres` varchar(20) NOT NULL DEFAULT '',
  `direccion` varchar(70) NOT NULL DEFAULT '',
  `telefono` varchar(12) NOT NULL DEFAULT '',
  `comuna` varchar(255) DEFAULT NULL,
  `ciudad` varchar(255) DEFAULT NULL,
  `vendedor` varchar(255) NOT NULL DEFAULT '',
  `NF` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`rut`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "clientes"
#

INSERT INTO `clientes` VALUES ('187288959','DUALSOFT SPA','INFORMATICA','DIEGO','LAS TORTOLAS 02946','82538693','CAUTIN','TEMUCO','fghj','DFGDFG'),('188747736','DUALAPP','APLICACIONES PA','OSWAL MOENA','NOSE 55 20','525445544','CAUITN','TEMUCO','asff','DFGDFG'),('758545454','RYP MINIMARKET','MINIMARKET','CRISTIAN R','LAS TORTOLAS 545','545454545','CAUTIN','TEMUCO','sadf','DFGGD');

#
# Structure for table "emision"
#

DROP TABLE IF EXISTS `emision`;
CREATE TABLE `emision` (
  `nfact` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `rut` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "emision"
#

INSERT INTO `emision` VALUES ('1','21_12_2015',20364,'188747736'),('2','21_12_2015',12530,'188747736');

#
# Structure for table "factcuad"
#

DROP TABLE IF EXISTS `factcuad`;
CREATE TABLE `factcuad` (
  `nfact` varchar(255) DEFAULT NULL,
  `caja` int(11) DEFAULT NULL,
  `restante` int(11) DEFAULT NULL,
  `tipopago` varchar(110) DEFAULT NULL,
  `cliente` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL,
  `totalfact` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "factcuad"
#


#
# Structure for table "factura"
#

DROP TABLE IF EXISTS `factura`;
CREATE TABLE `factura` (
  `tipo_documento` varchar(10) NOT NULL DEFAULT '',
  `numero_factura` int(11) NOT NULL AUTO_INCREMENT,
  `rut_cliente` varchar(12) NOT NULL DEFAULT '',
  `razon_social` varchar(30) NOT NULL DEFAULT '',
  `direccion` varchar(50) NOT NULL DEFAULT '',
  `giro` varchar(30) NOT NULL DEFAULT '',
  `fecha_emision` varchar(255) NOT NULL DEFAULT '',
  `tipo_de_pago` varchar(20) NOT NULL DEFAULT '',
  `nombre_producto` varchar(50) NOT NULL DEFAULT '',
  `codigo` int(6) NOT NULL DEFAULT '0',
  `cantidad_prod` int(1) NOT NULL DEFAULT '0',
  `subtotales` int(1) NOT NULL DEFAULT '0',
  `iva` int(3) NOT NULL DEFAULT '0',
  `totales` int(1) DEFAULT '0',
  PRIMARY KEY (`numero_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "factura"
#


#
# Structure for table "grillafactura"
#

DROP TABLE IF EXISTS `grillafactura`;
CREATE TABLE `grillafactura` (
  `cod_interno` varchar(255) DEFAULT NULL,
  `nombre_prod` varchar(255) DEFAULT NULL,
  `cod_barra` varchar(255) DEFAULT NULL,
  `precio_venta` int(11) DEFAULT NULL,
  `cantidad` varchar(30) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `precio_costo` int(11) DEFAULT NULL,
  `subtotal` int(11) DEFAULT NULL,
  `iva` int(11) DEFAULT NULL,
  `totales` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "grillafactura"
#


#
# Structure for table "informes"
#

DROP TABLE IF EXISTS `informes`;
CREATE TABLE `informes` (
  `informes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "informes"
#


#
# Structure for table "libro"
#

DROP TABLE IF EXISTS `libro`;
CREATE TABLE `libro` (
  `fecha` varchar(255) DEFAULT NULL,
  `nfact` varchar(255) DEFAULT NULL,
  `impuestos` int(11) DEFAULT NULL,
  `costos` int(11) DEFAULT NULL,
  `totalventa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "libro"
#

INSERT INTO `libro` VALUES ('21_12_2015','1',3251,11460,20364),('21_12_2015','2',2000,380,12530);

#
# Structure for table "nfact"
#

DROP TABLE IF EXISTS `nfact`;
CREATE TABLE `nfact` (
  `rut` varchar(255) DEFAULT NULL,
  `n_fact` varchar(11) NOT NULL DEFAULT '',
  `fecha` varchar(255) DEFAULT NULL,
  `razon` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`n_fact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "nfact"
#

INSERT INTO `nfact` VALUES ('188747736','1','21_12_2015','DUALAPP'),('188747736','2','21_12_2015','DUALAPP');

#
# Structure for table "nfactimpresion"
#

DROP TABLE IF EXISTS `nfactimpresion`;
CREATE TABLE `nfactimpresion` (
  `rut` varchar(255) DEFAULT NULL,
  `n_fact` varchar(11) NOT NULL DEFAULT '',
  `fecha` varchar(255) DEFAULT NULL,
  `razon` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`n_fact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "nfactimpresion"
#


#
# Structure for table "productos"
#

DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `nombre_prod` varchar(255) NOT NULL DEFAULT '',
  `cod_interno` varchar(255) NOT NULL DEFAULT '',
  `cod_barra` varchar(255) NOT NULL DEFAULT '',
  `precio_costo` int(11) NOT NULL DEFAULT '0',
  `precio_venta` int(11) NOT NULL DEFAULT '0',
  `Stock` int(11) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL,
  `pesable` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cod_interno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Data for table "productos"
#

INSERT INTO `productos` VALUES ('QUESO','1','1',5000,7200,30,'Kg',NULL),('PAPAS FRITAS 10MM','2','2',1250,2000,30,'Gr',NULL),('PRIMAVERA 250G','3','3',500,780,30,'Gr',NULL),('CHOCLO GRANEADO 250G','4','4',380,550,50,'Gr',NULL),('QUESO LAMINA 1KG','5','5',5600,7520,80,'Kg',NULL),('JARDINERA 300G','6','6',750,900,500,'Kg',NULL),('ARROZ 500G','7','7',500,780,50,'Kg',NULL),('PAPAS FRITAS 15MM','8','8',580,880,50,'Kg',NULL),('CARNE MOLIDA PF','9','9',500,700,50,'Kg',NULL);
