-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 30-10-2018 a las 17:32:55
-- Versión del servidor: 5.7.21
-- Versión de PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `urubyte`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE IF NOT EXISTS `categorias` (
  `IdCategoria` int(8) NOT NULL,
  `Categoria` varchar(25) DEFAULT NULL,
  `Utilidad` int(8) DEFAULT NULL,
  PRIMARY KEY (`IdCategoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`IdCategoria`, `Categoria`, `Utilidad`) VALUES
(1, 'Gaseosas', 12),
(2, 'Verduras', 30),
(3, 'Comestibles', 20),
(4, 'Enlatados', 25),
(5, 'Limpieza', 30),
(6, 'BebidasAlcoholicas', 25),
(7, 'Fiambres', 30),
(8, 'Regaleria', 35),
(9, 'Libreria', 35),
(10, 'Varios', 30);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contienen`
--

DROP TABLE IF EXISTS `contienen`;
CREATE TABLE IF NOT EXISTS `contienen` (
  `Codigo_de_Producto` bigint(20) DEFAULT NULL,
  `Numero_de_pedido` int(11) DEFAULT NULL,
  `Descripcion` varchar(25) DEFAULT NULL,
  `Precio_Unitario` decimal(11,0) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `SubTotal` decimal(11,0) DEFAULT NULL,
  KEY `fk` (`Numero_de_pedido`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `contienen`
--

INSERT INTO `contienen` (`Codigo_de_Producto`, `Numero_de_pedido`, `Descripcion`, `Precio_Unitario`, `Cantidad`, `SubTotal`) VALUES
(1234, 12345, 'Arrox', '234', 2, '468'),
(1234, 1234, 'Arrox', '234', 1, '234'),
(1234, 1234, 'Arrox', '234', 2, '468'),
(1234, 1235, 'Arrox', '234', 1, '234'),
(207, 564, 'Kerocen', '600', 4, '600'),
(202, 564, 'Fideoh ', '80', 3, '80'),
(32132, 564, 'PapitaPalLoro', '50', 1, '50'),
(1234, 5656, 'Arrox', '234', 2, '234'),
(7730588000224, 699988, 'Dulce de leshe', '326', 1, '326'),
(7730967130016, 699988, 'MaestraBirra', '500', 1, '500'),
(12345, 699988, 'Perro', '200', 2, '400'),
(206, 5657, 'Panceta', '521', 8, '4168'),
(205, 46745, 'Leche', '150', 3, '450'),
(7806500174257, 46745, 'Pañuelillos', '66', 2, '132'),
(204, 12354, 'Galleta', '400', 1, '400'),
(1234, 45745, 'Arrox', '234', 1, '234'),
(1234, 5685, 'Arrox', '234', 1, '234'),
(1234, 568568, 'Arrox', '234', 5, '1170'),
(32132, 568568, 'PapitaPalLoro', '50', 7, '350'),
(12345, 568568, 'Perro', '200', 2, '400'),
(1234, 5685685, 'Arrox', '234', 9, '2106'),
(205, 14242, 'Leche', '150', 8, '1200'),
(7730967130016, 14242, 'MaestraBirra', '500', 5, '2500'),
(204, 14242, 'Galleta', '400', 2, '800'),
(78924468, 65545, 'Deo', '120', 2, '240');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `distribuyen`
--

DROP TABLE IF EXISTS `distribuyen`;
CREATE TABLE IF NOT EXISTS `distribuyen` (
  `RUT` int(11) NOT NULL,
  `Numero_de_Pedido` int(11) NOT NULL,
  `fecha_de_pedido` varchar(11) DEFAULT NULL,
  `categoria` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`RUT`),
  KEY `fk_Numero_de_Pedido` (`Numero_de_Pedido`),
  KEY `categoria` (`categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
CREATE TABLE IF NOT EXISTS `pedidos` (
  `Numero_de_pedido` int(11) NOT NULL,
  `Fecha_del_pedido` varchar(11) DEFAULT NULL,
  `Monto_total` decimal(11,0) DEFAULT NULL,
  `Proveedor` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Numero_de_pedido`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`Numero_de_pedido`, `Fecha_del_pedido`, `Monto_total`, `Proveedor`) VALUES
(1234, '19-10-2018', '468', 'lol'),
(1235, '19-10-2018', '234', 'lol'),
(564, '19-10-2018', '730', 'Totoo'),
(5656, '02-10-2018', '234', 'lol'),
(699988, '25-10-2018', '1226', 'tryrtyrty'),
(5657, '25-10-2018', '4168', 'Coco'),
(46745, '25-10-2018', '582', 'Shopi'),
(12354, '25-10-2018', '400', 'Shopi'),
(45745, '25-10-2018', '234', 'lol'),
(5685, '25-10-2018', '234', 'Trebol'),
(568568, '25-10-2018', '1920', 'lol'),
(5685685, '25-10-2018', '2106', 'lol'),
(14242, '27-10-2018', '4500', 'Lolks'),
(65545, '29-10-2018', '240', 'lol');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `Codigo_de_producto` varchar(25) NOT NULL,
  `Nombre` varchar(25) DEFAULT NULL,
  `Precio_de_venta` varchar(25) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Costo` varchar(25) DEFAULT NULL,
  `Fecha_de_vencimiento` varchar(11) DEFAULT NULL,
  `Categoria` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Codigo_de_producto`),
  KEY `Categoria` (`Categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Codigo_de_producto`, `Nombre`, `Precio_de_venta`, `Cantidad`, `Costo`, `Fecha_de_vencimiento`, `Categoria`) VALUES
('77303845', 'Corona Cerveza 710 ml', '161,25', 199, '129', 'NO', 'BebidasAlcoholicas'),
('77303846', 'Corona Cerveza 355 ml', '83,75', 199, '67', 'NO', 'BebidasAlcoholicas'),
('77303847', 'Corona Cerveza 210 ml', '51,25', 199, '41', 'NO', 'BebidasAlcoholicas'),
('77303848', 'Cerveza Pilsen 1L', '105,28', 100, '94', 'NO', 'BebidasAlcoholicas'),
('1234', 'Arroz', '120', 3, '100', '26-10-2018', 'Comestibles'),
('122413', 'Deo', '1601.6', 117, '1232', 'NO', 'Verduras'),
('23425245234', 'Fideo', '650', 23, '500', 'NO', 'Limpieza');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE IF NOT EXISTS `proveedores` (
  `RUT` varchar(25) NOT NULL,
  `Nombre` varchar(25) DEFAULT NULL,
  `Direccion` varchar(25) DEFAULT NULL,
  `Telefono` varchar(25) DEFAULT NULL,
  `Categoria` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`RUT`),
  KEY `Categoria` (`Categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`RUT`, `Nombre`, `Direccion`, `Telefono`, `Categoria`) VALUES
('1345344444444444444444444', 'Lolu', 'Awe', '45', 'Enlatados');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registradas_por`
--

DROP TABLE IF EXISTS `registradas_por`;
CREATE TABLE IF NOT EXISTS `registradas_por` (
  `ID_Venta` int(11) NOT NULL,
  `ID_Usuario` int(11) NOT NULL,
  PRIMARY KEY (`ID_Venta`),
  KEY `fk_ID_Usuario` (`ID_Usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tienen`
--

DROP TABLE IF EXISTS `tienen`;
CREATE TABLE IF NOT EXISTS `tienen` (
  `Codigo_de_producto` varchar(25) DEFAULT NULL,
  `ID_Venta` varchar(25) DEFAULT NULL,
  `Descripcion` varchar(25) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Precio_Unitario` varchar(25) DEFAULT NULL,
  `SubTotal` varchar(25) DEFAULT NULL,
  KEY `fk_Codigo_De_Producto` (`Codigo_de_producto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tienen`
--

INSERT INTO `tienen` (`Codigo_de_producto`, `ID_Venta`, `Descripcion`, `Cantidad`, `Precio_Unitario`, `SubTotal`) VALUES
('1234', '1234', 'Arrox', 3, '234', '702'),
('1234', '1235', 'Arrox', 4, '234', '936'),
('1234', '2342', 'arrox', 3, '234', '702'),
('12345', '2342', 'Perro', 3, '200', '600'),
('1234', '654', 'arrox', 2, '234', '468'),
('78924468', '56484', 'Deo', 2, '120', '240'),
('78924468', '5648446', 'Deo', 2, '120', '240'),
('78924468', '6484564', 'deo', 2, '120', '240'),
('34534534', '2345235', 'deo', 3, '200', '600'),
('34534534', '432432432', 'deo', 1, '200', '200'),
('205', '49936789', 'leche', 2, '150', '300'),
('6454654', '46456456', 'Deo', 5, '100', '500'),
('1234', '245456246', 'arrox', 3, '234', '702'),
('7730588000224', '245456246', 'Dulce de leshe', 5, '326', '1630'),
('500', '3645634', 'deo', 2, '100', '200'),
('500', '435634634', 'deo', 3, '100', '300'),
('77303845', '75675675', 'Corona Cerveza 710 ml', 1, '161,25', '161,25'),
('122413', '9999999999999999999999999', 'deo', 7, '1601.6', '11211.2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID_Usuario` varchar(25) NOT NULL,
  `Nombre` varchar(25) DEFAULT NULL,
  `Telefono` varchar(25) DEFAULT NULL,
  `Contrasena` varchar(125) DEFAULT NULL,
  `Tipo` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `Nombre`, `Telefono`, `Contrasena`, `Tipo`) VALUES
('pepin', 'Pepito', '656565', '3ff0764dedc8dd5a4df2ef845ea31c31a17c261f881700941660467c', 'Usuario'),
('julio', 'Julio Mendez', '1234', '99fb2f48c6af4761f904fc85f95eb56190e5d40b1f44ec3a9c1fa319', 'Admin'),
('juliooo', 'julo', '654', '91bf50365da6a5e2c11829baee8f1de77ea7fcb44338ee5134a23d6a', 'Usuario'),
('manolito', 'Manolo', '7656', 'e79b13dc411f9f8ad4ef8b0005e7793835a1efb92c5a81e9ff540170', 'Admin'),
('Kako', 'Carlos', '434', '3a32ee9b1f17a475f19fff1621594243098a1bf2d4f06f26975f26aa', 'Usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE IF NOT EXISTS `ventas` (
  `ID_Venta` varchar(25) NOT NULL,
  `Precio_total` varchar(25) DEFAULT NULL,
  `Fecha_de_Venta` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`ID_Venta`, `Precio_total`, `Fecha_de_Venta`) VALUES
('1234', '702', '27-10-2018'),
('1235', '936', '27-10-2018'),
('2342', '1302', '27-10-2018'),
('2345235', '600', '29-10-2018'),
('245456246', '2332', '29-10-2018'),
('3242342342343', '2160', '30-10-2018'),
('3645634', '200', '29-10-2018'),
('432432432', '200', '29-10-2018'),
('4325345', '0', '29-10-2018'),
('435634634', '300', '29-10-2018'),
('4534534', '0', '29-10-2018'),
('46456456', '500', '29-10-2018'),
('49936789', '300', '29-10-2018'),
('56484', '240', '29-10-2018'),
('5648446', '240', '29-10-2018'),
('6484564', '240', '29-10-2018'),
('654', '468', '29-10-2018'),
('75675675', '322,5', '29-10-2018'),
('9999999999999999999999999', '22422.4', '30-10-2018');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
