# Host: localhost  (Version 5.6.17)
# Date: 2016-04-01 19:40:55
# Generator: MySQL-Front 5.3  (Build 5.21)

/*!40101 SET NAMES latin1 */;

#
# Structure for table "01_04_2016"
#

CREATE TABLE `01_04_2016` (
  `nombre` varchar(255) DEFAULT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "09_01_2016"
#

CREATE TABLE `09_01_2016` (
  `nombre` varchar(255) DEFAULT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "14_01_2016"
#

CREATE TABLE `14_01_2016` (
  `nombre` varchar(255) DEFAULT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "14_1_2016"
#

CREATE TABLE `14_1_2016` (
  `nombre` varchar(255) NOT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "187288959_7"
#

CREATE TABLE `187288959_7` (
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
# Structure for table "27_01_2016"
#

CREATE TABLE `27_01_2016` (
  `nombre` varchar(255) DEFAULT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "27_1_2016"
#

CREATE TABLE `27_1_2016` (
  `nombre` varchar(255) NOT NULL,
  `cant` varchar(255) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "aumento"
#

CREATE TABLE `aumento` (
  `aumento` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`aumento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Structure for table "caja"
#

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
# Structure for table "cajaingreso"
#

CREATE TABLE `cajaingreso` (
  `nombre` varchar(255) NOT NULL DEFAULT '',
  `codigo` varchar(255) NOT NULL DEFAULT '',
  `precio` int(11) DEFAULT NULL,
  `cant` varchar(53) NOT NULL DEFAULT '0.00',
  `total` int(11) DEFAULT NULL,
  `costo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Structure for table "clientes"
#

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
# Structure for table "emision"
#

CREATE TABLE `emision` (
  `nfact` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `rut` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Structure for table "factcuad"
#

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
# Structure for table "factura"
#

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
# Structure for table "grillafactura"
#

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
# Structure for table "grillafacturaprov"
#

CREATE TABLE `grillafacturaprov` (
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
# Structure for table "informecompra"
#

CREATE TABLE `informecompra` (
  `fecha_mes_año` varchar(255) NOT NULL DEFAULT '',
  `fecha_completa` varchar(255) NOT NULL DEFAULT '',
  `iva` varchar(255) NOT NULL DEFAULT '',
  `totales` varchar(255) NOT NULL DEFAULT '',
  `nfact` varchar(255) NOT NULL DEFAULT '',
  `proveedor` varchar(300) NOT NULL DEFAULT '',
  `rut` varchar(255) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "informes"
#

CREATE TABLE `informes` (
  `informes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "informevent"
#

CREATE TABLE `informevent` (
  `nfact` int(11) DEFAULT NULL,
  `vendedor` varchar(255) DEFAULT NULL,
  `neto` varchar(255) DEFAULT NULL,
  `total` varchar(255) DEFAULT NULL,
  `cliente` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "libro"
#

CREATE TABLE `libro` (
  `fecha` varchar(255) DEFAULT NULL,
  `nfact` varchar(255) DEFAULT NULL,
  `impuestos` int(11) DEFAULT NULL,
  `costos` int(11) DEFAULT NULL,
  `totalventa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Structure for table "nfact"
#

CREATE TABLE `nfact` (
  `rut` varchar(255) DEFAULT NULL,
  `n_fact` int(11) NOT NULL DEFAULT '0',
  `fecha` varchar(255) DEFAULT NULL,
  `razon` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`n_fact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Structure for table "nfactimpresion"
#

CREATE TABLE `nfactimpresion` (
  `rut` varchar(255) DEFAULT NULL,
  `n_fact` varchar(11) NOT NULL DEFAULT '',
  `fecha` varchar(255) DEFAULT NULL,
  `razon` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`n_fact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "productos"
#

CREATE TABLE `productos` (
  `nombre_prod` varchar(255) NOT NULL DEFAULT '',
  `cod_interno` int(11) NOT NULL DEFAULT '0',
  `cod_barra` varchar(255) NOT NULL DEFAULT '',
  `precio_costo` int(11) NOT NULL DEFAULT '0',
  `precio_venta` int(11) NOT NULL DEFAULT '0',
  `Stock` varchar(110) DEFAULT NULL,
  `medida` varchar(255) DEFAULT NULL,
  `pesable` varchar(255) DEFAULT NULL,
  `margen` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cod_interno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "proveedores"
#

CREATE TABLE `proveedores` (
  `rut` varchar(255) DEFAULT NULL,
  `razon` varchar(255) DEFAULT NULL,
  `giro` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "ranking"
#

CREATE TABLE `ranking` (
  `nombre` varchar(255) NOT NULL DEFAULT '0',
  `cantidad` double NOT NULL DEFAULT '0',
  `fecha` date NOT NULL DEFAULT '0000-00-00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for table "recepcion"
#

CREATE TABLE `recepcion` (
  `nfact` varchar(255) DEFAULT NULL,
  `fecha` varchar(255) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `rut` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Structure for table "vendedores"
#

CREATE TABLE `vendedores` (
  `des_ven` varchar(255) NOT NULL DEFAULT '',
  `nom_ven` varchar(255) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
