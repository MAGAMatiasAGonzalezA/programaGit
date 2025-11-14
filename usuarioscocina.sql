-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 14-11-2025 a las 14:42:33
-- Versión del servidor: 8.3.0
-- Versión de PHP: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `usuarioscocina`
--

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `borrar_Item`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `borrar_Item` (IN `p_idItem` INT)   BEGIN
	DELETE FROM inventario WHERE inventario_id = p_idItem;
END$$

DROP PROCEDURE IF EXISTS `insert_item`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_item` (IN `p_usuario` VARCHAR(250), IN `p_item_nombre` VARCHAR(250), IN `p_cantidad` DOUBLE(250,3))   BEGIN
	INSERT INTO inventario (usuario, item_nombre, cantidad, fecha) VALUES (p_usuario, p_item_nombre, p_cantidad, NOW());
END$$

DROP PROCEDURE IF EXISTS `ver_inventario`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ver_inventario` ()   BEGIN
SELECT inventario.inventario_id, inventario.usuario, inventario.item_nombre, inventario.cantidad, DATE_FORMAT(inventario.fecha, '%d/%m/%Y') AS fecha
FROM inventario;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingredientesreceta`
--

DROP TABLE IF EXISTS `ingredientesreceta`;
CREATE TABLE IF NOT EXISTS `ingredientesreceta` (
  `id` int NOT NULL AUTO_INCREMENT,
  `receta_id` int NOT NULL,
  `item_nombre` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `cantidad` double(250,3) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ingredientesreceta_recetas` (`receta_id`),
  KEY `fk_ingredientesreceta_inventario` (`item_nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=222 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `ingredientesreceta`
--

INSERT INTO `ingredientesreceta` (`id`, `receta_id`, `item_nombre`, `cantidad`) VALUES
(52, 59, 'zapallo', 2.000),
(53, 57, 'papa', 5.000),
(63, 66, 'papa', 2.000),
(64, 66, 'higado', 2.000),
(65, 67, 'zapallo', 1.000),
(66, 67, 'crema', 0.500),
(67, 68, 'harina', 1.000),
(69, 69, 'harina', 1.000),
(71, 69, 'aceite', 1.000),
(73, 70, 'higado', 3.000),
(74, 70, 'dulce de leche', 3.000),
(75, 70, 'jamon', 3.000),
(78, 73, 'pepino', 1.000),
(79, 73, 'cebolla', 1.000),
(80, 73, 'crema', 1.000),
(81, 74, 'vainillas', 24.000),
(82, 74, 'huevo', 6.000),
(83, 74, 'huevo', 6.000),
(84, 74, 'azucar', 0.120),
(98, 65, 'jamon', 2.000),
(99, 65, 'zapallo', 2.000),
(105, 79, 'harina', 1.000),
(106, 79, 'levadura', 1.000),
(107, 79, 'aceite', 1.000),
(111, 96, 'caracol', 1.500),
(114, 126, 'leche', 1.500),
(115, 126, 'huevo', 2.000),
(116, 126, 'azucar', 0.350),
(117, 126, 'manteca', 0.050),
(118, 126, 'pan de miga', 3.000),
(119, 126, 'naranja', 2.000),
(120, 127, 'azucar', 0.300),
(121, 127, 'azucar impalpable', 0.300),
(122, 127, 'huevo', 9.000),
(123, 127, 'nuez', 0.100),
(124, 127, 'manteca', 0.300),
(125, 127, 'chocolate amargo', 0.500),
(126, 127, 'esencia de vainilla', 0.005),
(127, 127, 'harina', 0.375),
(128, 128, 'chocolate amargo', 0.500),
(129, 128, 'manteca', 0.500),
(130, 128, 'maicena', 0.120),
(131, 128, 'harina', 0.050),
(132, 128, 'azucar', 0.250),
(133, 128, 'polvo de hornear', 0.010),
(134, 128, 'huevo', 10.000),
(135, 130, 'harina', 0.300),
(136, 130, 'azucar', 0.400),
(137, 130, 'huevo', 10.000),
(138, 130, 'cacao amargo', 0.100),
(139, 74, 'crema', 0.300),
(140, 74, 'gelatina sin sabor', 0.030),
(141, 74, 'cafe al coñac', 0.080),
(142, 74, 'dulce de leche', 0.100),
(143, 131, 'huevo', 6.000),
(144, 131, 'chocolate amargo', 0.300),
(145, 131, 'manteca', 0.200),
(146, 131, 'azucar', 0.100),
(147, 131, 'crema', 0.400),
(148, 131, 'gelatina sin sabor', 0.030),
(149, 131, 'licor de chocolate', 0.150),
(150, 132, 'queso crema', 1.000),
(151, 132, 'crema', 0.300),
(152, 132, 'huevo', 6.000),
(153, 132, 'limon', 2.000),
(154, 132, 'edulcorante', 9.000),
(155, 132, 'gelatina sin sabor', 0.030),
(156, 133, 'harina', 0.150),
(157, 133, 'manteca', 0.150),
(158, 133, 'azucar', 0.150),
(159, 133, 'huevo', 1.000),
(160, 134, 'azucar impalpable', 0.090),
(161, 134, 'manteca', 0.150),
(162, 134, 'harina', 0.250),
(163, 134, 'huevo', 1.000),
(164, 134, 'esencia de vainilla', 0.005),
(165, 135, 'manzana verde', 3.000),
(166, 135, 'azucar', 0.450),
(167, 135, 'canela', 0.015),
(168, 136, 'azucar', 0.750),
(169, 136, 'huevo', 12.000),
(170, 137, 'manteca', 0.500),
(171, 137, 'azucar', 0.400),
(172, 137, 'huevo', 4.000),
(173, 137, 'polvo de hornear', 0.010),
(174, 137, 'harina', 1.000),
(175, 138, 'manteca', 0.250),
(176, 138, 'azucar impalpable', 0.100),
(177, 138, 'harina', 0.300),
(178, 138, 'polvo de hornear', 0.005),
(179, 138, 'huevo', 1.000),
(180, 138, 'chocolate amargo', 0.300),
(181, 138, 'crema', 0.100),
(182, 139, 'maicena', 0.500),
(183, 139, 'manteca', 0.150),
(184, 139, 'azucar impalpable', 0.150),
(185, 139, 'polvo de hornear', 0.010),
(186, 139, 'huevo', 9.000),
(187, 139, 'esencia de vainilla', 0.005),
(188, 140, 'azucar', 0.150),
(189, 140, 'manteca', 0.150),
(190, 140, 'huevo', 2.000),
(191, 140, 'dulce de batata', 0.200),
(192, 140, 'dulce de membrillo', 0.200),
(193, 140, 'chips de chocolate', 0.050),
(194, 141, 'huevo', 2.000),
(195, 141, 'azucar', 0.200),
(196, 141, 'manteca', 0.200),
(197, 141, 'harina leudante', 0.400),
(198, 141, 'sal', 0.002),
(199, 150, 'harina', 3.000),
(200, 150, 'azucar', 2.000),
(201, 150, 'manteca', 1.000),
(202, 151, 'papa', 0.567),
(203, 152, 'papa', 1.234),
(204, 152, 'zapallo', 1.234),
(205, 153, 'papa', 1.000),
(206, 153, 'azucar', 1.000),
(207, 154, 'aceite', 1.000),
(208, 154, 'ajo', 2.000),
(209, 154, 'arroz', 3.000),
(210, 155, 'arroz', 5.000),
(211, 155, 'azucar impalpable', 5.000),
(212, 156, 'jamon', 3.000),
(213, 157, 'arroz', 2.000),
(214, 157, 'batata', 2.000),
(215, 157, 'cebolla', 2.000),
(216, 158, 'aceite', 1.000),
(217, 158, 'ajo', 1.000),
(218, 158, 'azucar', 1.000),
(219, 159, 'leche', 5.000),
(220, 159, 'paceta', 3.000),
(221, 159, 'queso crema', 1.000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

DROP TABLE IF EXISTS `inventario`;
CREATE TABLE IF NOT EXISTS `inventario` (
  `inventario_id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `item_nombre` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `cantidad` double(250,3) NOT NULL,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`inventario_id`),
  UNIQUE KEY `item_nombre` (`item_nombre`),
  KEY `fk_inventario_usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`inventario_id`, `usuario`, `item_nombre`, `cantidad`, `fecha`) VALUES
(3, 'Mafiu', 'crema', 11.300, '2025-02-26 14:40:28'),
(4, 'Mafiu', 'papa', 16.000, '2025-02-21 15:40:11'),
(5, 'Flavia', 'pepino', 0.050, '2025-01-26 15:35:47'),
(6, 'chester', 'jamon crudo', 0.300, '2025-02-10 16:03:30'),
(7, 'Flavia', 'zanahoria', 129.000, '2025-01-21 15:55:51'),
(8, 'Mafiu', 'batata', 10.000, '2024-12-07 16:14:32'),
(9, 'Mafiu', 'panceta', 1.000, '2024-12-18 13:58:38'),
(10, 'Mafiu', 'rucula', 5.000, '2025-01-21 15:55:51'),
(11, 'Mafiu', 'harina', -5.050, '2025-02-26 16:24:42'),
(13, 'joaquin', 'queso', 3.000, '2024-12-15 13:35:17'),
(14, 'mateo', 'arroz', 5000.000, '2024-12-15 13:43:12'),
(16, 'Flavia', 'zapallo', 14.000, '2025-02-21 15:40:11'),
(17, 'Mafiu', 'higado', 12.000, '2025-01-25 14:25:09'),
(21, 'pepe', 'jamon', 3.000, '2025-01-26 15:35:51'),
(23, 'Mafiu', 'ajo', 3.000, '2025-01-01 15:56:01'),
(24, 'Mafiu', 'lechuga', 5.000, '2025-01-02 14:16:03'),
(25, 'Mafiu', 'tomate', 3.000, '2025-01-02 14:16:10'),
(26, 'Mafiu', 'leche', 3.500, '2025-02-26 16:24:49'),
(27, 'Mafiu', 'queso crema', 7.100, '2025-02-05 16:08:06'),
(28, 'Mafiu', 'queso parmesano', 2.000, '2025-01-02 14:16:50'),
(29, 'Mafiu', 'queso roquefort', 1.000, '2025-01-02 14:16:59'),
(30, 'Mafiu', 'remolacha', 10.000, '2025-01-02 14:17:13'),
(32, 'Mafiu', 'paceta', 4.000, '2025-01-02 14:21:13'),
(33, 'Mafiu', 'mayonesa', 5.000, '2025-01-07 15:39:51'),
(38, 'Mafiu', 'dulce de leche', 4.750, '2025-02-26 14:40:28'),
(40, 'Mafiu', 'dulce de leche repostero', 5.000, '2025-01-07 15:40:37'),
(41, 'Mafiu', 'cebolla', 199.000, '2025-01-26 15:35:47'),
(43, 'Mafiu', 'aceite', 994.400, '2025-01-26 15:35:34'),
(44, 'Mafiu', 'vainillas', 52.000, '2025-02-26 14:40:28'),
(45, 'Mafiu', 'levadura', 46.700, '2025-01-26 15:35:03'),
(46, 'Mafiu', 'caracol', 0.000, '2025-02-12 21:28:19'),
(47, 'Mafiu', 'huevo', 69.000, '2025-02-27 15:20:32'),
(48, 'Mafiu', 'azucar', 98.980, '2025-02-27 15:20:32'),
(49, 'Mafiu', 'manteca', 99.000, '2025-02-27 15:20:32'),
(50, 'Mafiu', 'naranja', 98.000, '2025-02-26 16:24:49'),
(51, 'Mafiu', 'azucar impalpable', 99.850, '2025-02-26 16:32:19'),
(52, 'Mafiu', 'nuez', 100.000, '2025-02-26 13:44:25'),
(53, 'Mafiu', 'chocolate amargo', 99.500, '2025-02-26 16:24:42'),
(54, 'Mafiu', 'esencia de vainilla', 99.995, '2025-02-26 16:32:19'),
(55, 'Mafiu', 'maicena', 99.380, '2025-02-26 16:32:19'),
(56, 'Mafiu', 'polvo de hornear', 99.980, '2025-02-26 16:32:19'),
(57, 'Mafiu', 'cacao amargo', 100.000, '2025-02-26 13:46:52'),
(58, 'Mafiu', 'gelatina sin sabor', 99.970, '2025-02-26 14:40:28'),
(59, 'Mafiu', 'cafe al coñac', 99.920, '2025-02-26 14:40:28'),
(60, 'Mafiu', 'cafe', 100.000, '2025-02-26 13:48:24'),
(61, 'Mafiu', 'licor de chocolate', 100.000, '2025-02-26 13:49:02'),
(62, 'Mafiu', 'queso mozzarella', 100.000, '2025-02-26 13:49:50'),
(63, 'Mafiu', 'limon', 100.000, '2025-02-26 13:50:14'),
(64, 'Mafiu', 'edulcorante', 100.000, '2025-02-26 13:50:36'),
(65, 'Mafiu', 'manzana verde', 100.000, '2025-02-26 13:51:03'),
(66, 'Mafiu', 'canela', 100.000, '2025-02-26 13:51:22'),
(67, 'Mafiu', 'dulce de batata', 99.600, '2025-02-27 15:20:32'),
(68, 'Mafiu', 'dulce de membrillo', 99.600, '2025-02-27 15:20:32'),
(69, 'Mafiu', 'chips de chocolate', 99.900, '2025-02-27 15:20:32'),
(70, 'Mafiu', 'harina leudante', 100.000, '2025-02-26 13:53:44'),
(71, 'Mafiu', 'sal', 100.000, '2025-02-26 13:54:00'),
(72, 'Mafiu', 'sal gruesa', 100.000, '2025-02-26 13:54:08'),
(73, 'Mafiu', 'pan de miga', 97.000, '2025-02-26 16:24:49');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientoplaza`
--

DROP TABLE IF EXISTS `movimientoplaza`;
CREATE TABLE IF NOT EXISTS `movimientoplaza` (
  `mp_id` int NOT NULL AUTO_INCREMENT,
  `plaza_id` int NOT NULL,
  `usuario` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `porciones` int NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `movimiento` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`mp_id`),
  KEY `fk_plaza_id` (`plaza_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `plaza`
--

DROP TABLE IF EXISTS `plaza`;
CREATE TABLE IF NOT EXISTS `plaza` (
  `receta_nombre` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `usuario` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `porciones` int NOT NULL,
  `plaza_id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`plaza_id`),
  KEY `fk_receta_nombre` (`receta_nombre`),
  KEY `fk_usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `plaza`
--

INSERT INTO `plaza` (`receta_nombre`, `usuario`, `fecha`, `porciones`, `plaza_id`) VALUES
('pure zapallo', 'Mafiu', '2025-01-08 17:10:24', 1, 2),
('calamar', 'Mafiu', '2025-01-08 17:10:53', 4, 4),
('calabaza al horno', 'Mafiu', '2025-01-25 14:21:34', 2, 6),
('dos', 'Mafiu', '2025-01-10 14:45:32', 1, 7),
('calamar', 'Mafiu', '2025-01-14 14:40:11', 1, 8),
('', 'Mafiu', '2025-01-25 14:22:05', -1, 9),
('dos', 'Mafiu', '2025-01-14 14:40:39', 1, 11),
('calabaza al horno', 'Mafiu', '2025-01-25 14:21:34', 2, 13),
('calabaza al horno', 'Mafiu', '2025-01-25 14:21:34', 2, 14),
('calamar', 'Mafiu', '2025-01-15 14:49:14', 1, 15),
('', 'Mafiu', '2025-01-25 14:22:05', -1, 16),
('', 'Mafiu', '2025-01-25 14:22:05', -1, 17),
('pan gordo', 'Mafiu', '2025-01-25 14:21:05', 3, 18),
('pan gordo', 'Mafiu', '2025-01-25 14:21:05', 3, 19),
('tricota', 'Mafiu', '2025-01-16 00:56:04', 2, 20),
('pure zapallo', 'Mafiu', '2025-01-21 14:46:00', 3, 21),
('tricota', 'Mafiu', '2025-01-21 14:46:20', 3, 22),
('dos', 'Mafiu', '2025-01-21 14:46:30', 1, 23),
('ensalada de pepinos', 'Mafiu', '2025-01-21 15:55:51', 2, 24),
('tiramisu', 'Mafiu', '2025-01-21 16:03:05', -12, 25),
('calamar', 'Mafiu', '2025-01-25 14:25:09', 1, 27),
('pan', 'Mafiu', '2025-01-25 14:35:31', 5, 28),
('pan', 'Mafiu', '2025-01-25 14:35:51', 5, 29),
('pan mucho', 'Mafiu', '2025-01-26 15:33:40', 2, 30),
('pan mucho', 'Mafiu', '2025-01-26 15:35:03', 3, 31),
('pan gordo', 'Mafiu', '2025-01-26 15:35:34', 3, 32),
('', 'Mafiu', '2025-01-26 15:35:39', -1, 33),
('pan', 'Mafiu', '2025-01-26 15:35:43', 5, 34),
('ensalada de pepinos', 'Mafiu', '2025-01-26 15:35:47', 2, 35),
('dos', 'Mafiu', '2025-01-26 15:35:51', 1, 36),
('', 'Mafiu', '2025-02-05 16:07:36', -1, 39),
('pan', 'Mafiu', '2025-02-05 16:07:42', 5, 40),
('tiramisu', 'Mafiu', '2025-02-05 16:08:06', 6, 42),
('caracol', 'Mafiu', '2025-02-10 16:05:20', 1, 44),
('caracol', 'Mafiu', '2025-02-12 21:28:19', 1, 45),
('tiramisu', 'Mafiu', '2025-02-26 14:40:28', 6, 47),
('molleaux', 'Mafiu', '2025-02-26 16:24:42', 8, 48),
('budin de naranja', 'Mafiu', '2025-02-26 16:24:49', 6, 49),
('galletitas pepas', 'Mafiu', '2025-02-27 15:20:32', -57, 51);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recetas`
--

DROP TABLE IF EXISTS `recetas`;
CREATE TABLE IF NOT EXISTS `recetas` (
  `receta_id` int NOT NULL AUTO_INCREMENT,
  `receta_nombre` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `ingredientes_cant` int NOT NULL,
  `procedimiento` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `usuario` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `porciones` int NOT NULL,
  PRIMARY KEY (`receta_id`),
  UNIQUE KEY `receta_nombre` (`receta_nombre`),
  KEY `fk_recetas_usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=160 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `recetas`
--

INSERT INTO `recetas` (`receta_id`, `receta_nombre`, `ingredientes_cant`, `procedimiento`, `usuario`, `porciones`) VALUES
(57, '', 1, 'Cambio', 'Mafiu', 3),
(59, 'pure zapallo', 1, 'cocinar y hacer pure', 'Mafiu', 3),
(65, 'dos', 2, 'dos', 'Mafiu', 1),
(66, 'calamar', 2, '2', 'Mafiu', 2),
(67, 'calabaza al horno', 2, 'meter al horno y poner crema', 'Mafiu', 4),
(68, 'pan', 3, 'mezclar y cocinar', 'Mafiu', 5),
(69, 'pan gordo', 3, 'lalala', 'Mafiu', 3),
(70, 'tricota', 3, 'tres pa tres', 'Mafiu', 3),
(73, 'ensalada de pepinos', 3, 'mezclar y comer', 'Mafiu', 2),
(74, 'tiramisu', 8, 'batir crema y poner vainillas', 'Mafiu', 6),
(79, 'pan mucho', 3, '3', 'Mafiu', 3),
(96, 'caracol', 1, 'cxaklkln', 'Mafiu', 1),
(126, 'budin de naranja', 6, 'mezclar y hornear', 'Mafiu', 6),
(127, 'brownie', 8, 'mezclar y hornear', 'Mafiu', 12),
(128, 'molleaux', 7, 'mezclar y hornear', 'Mafiu', 20),
(130, 'bizcochuelo de torta delicia', 4, 'mezclar y hornear', 'Mafiu', 12),
(131, 'marquis', 7, 'mezclar y enfriar ', 'Mafiu', 12),
(132, 'cheesecake', 6, 'mezclar y enfriar', 'Mafiu', 12),
(133, 'crumble', 4, 'mezclar y reservar', 'Mafiu', 4),
(134, 'masa apple crumble', 5, 'mezclar', 'Mafiu', 6),
(135, 'apple relleno', 3, 'cocinar', 'Mafiu', 12),
(136, 'merengue italiano', 2, 'batir', 'Mafiu', 4),
(137, 'galletitas de cafe', 5, 'mezclar y hornear', 'Mafiu', 4),
(138, 'galletitas rrelenas', 7, 'mezclar y rellenar', 'Mafiu', 4),
(139, 'alfajor de maicena masa', 6, 'mezclar y hornear', 'Mafiu', 4),
(140, 'galletitas pepas', 6, 'mezclar rellenar y hornear', 'Mafiu', 4),
(141, 'masa pasta flora', 5, 'mezclar', 'Mafiu', 1),
(150, 'talita', 3, 'mezclar', 'Mafiu', 3),
(151, 'papotas', 1, 'papaas', 'Mafiu', 4),
(152, 'que receta', 2, 'muy loco', 'Mafiu', 2),
(153, 'algorico', 2, 'apoijfsadpofjaspfoa.\r\naqwokfasokasdpfojas', 'Mafiu', 3),
(154, 'zapatos locos', 3, 'Un texto largo para ver como queda.\r\nOtro texto largo para ver como sigue.\r\nMas anotaciones para verificar como se ve.', 'Mafiu', 3),
(155, 'una nueva receta', 2, 'algo', 'Mafiu', 5),
(156, 'algo mas para probar', 1, '12312', 'Mafiu', 3),
(157, 'nueva receta 111', 3, 'szadfsazdfsa', 'Mafiu', 3),
(158, 'la cambie XD', 5, 'come y callate', 'Mafiu', 5),
(159, 'algo mas rico y copado', 6, 'fdhdfgsaer5yuaeryadery', 'Mafiu', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `password` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `password`) VALUES
(1, 'Flavia', '81dc9bdb52d04dc20036dbd8313ed055'),
(2, 'Mafiu', '81dc9bdb52d04dc20036dbd8313ed055'),
(6, 'sandro', '81dc9bdb52d04dc20036dbd8313ed055'),
(7, 'chester', '81dc9bdb52d04dc20036dbd8313ed055'),
(8, 'Ale', '81dc9bdb52d04dc20036dbd8313ed055'),
(9, 'Diego', '81dc9bdb52d04dc20036dbd8313ed055'),
(10, 'sandra', '81dc9bdb52d04dc20036dbd8313ed055'),
(11, 'joaquin', 'e796e897b03dfa33388c5e26154376de'),
(12, 'mateo', '771f01104d905386a134a676167edccc'),
(13, 'pedro', '81dc9bdb52d04dc20036dbd8313ed055'),
(14, 'juan', '81dc9bdb52d04dc20036dbd8313ed055'),
(15, 'pepe', '81dc9bdb52d04dc20036dbd8313ed055'),
(18, 'Richard', '$2b$12$EDqYv/p3Ji/7Cp1iR5zntO.og2DA1oZe9NwWdr/gky4q1QzJ2yhBa'),
(19, 'fabi', '$2b$12$gjFtkviP5bnV7PaZEf7rAuxClwbWu3A2EluO7k6JoOKHaxrxX3Pum'),
(20, 'mate', '$2b$12$hfkQemnfbRN8Dyg6GfivbOCV4o9c8ZyPqXbkwMl018Filf3qwyfWG'),
(31, 'abi', '$2b$12$dY9XVQVbsQylWn.C14TXu.Y3XjcDmS4h8vQJq0lim9553btPi4vCS'),
(44, 'tete', '$2b$12$HZkLqyN2AmWLqt9e2kWIDe0LhEuF3LdaoYaLaA.a/GafMIPwPEqQ.'),
(48, 'parri', '$2b$12$h83fvzGrwpFTwxjrAx8GoudECoGv1wfyREzBoeCRv17Ssev5s5DQO'),
(49, 'Cristian07', '$2b$12$LwXvqaPb5Mr5n5VxoW2IoOtwtumRPpqA/azjqw2fgLeL2ApyukVVK'),
(50, 'Camila123', '$2b$12$LqI6JJKiSkATjuIqJEm8YefOGo/ws9FfddiNeNcc2tk7L78WLPSSG'),
(51, 'Kdhsj', '$2b$12$u9OzHPI2CcJqZho6AUJKGejt.9m0fhE1dFG0t19rrJPVpQ46xxfzG'),
(55, 'Sancho', '$2b$12$N/1kmx0gtzUPgOh1l.r2guqTssBZxiYF5NMTJGmoSjaR2fa3gz/Ja'),
(56, 'Colita', '$2b$12$Xvw66kTJT2Dzkhd/gyuOJOOZVmzva.cf7KAZU.DGFhhraP4N8rpUu');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ingredientesreceta`
--
ALTER TABLE `ingredientesreceta`
  ADD CONSTRAINT `fk_ingredientesreceta_inventario` FOREIGN KEY (`item_nombre`) REFERENCES `inventario` (`item_nombre`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ingredientesreceta_recetas` FOREIGN KEY (`receta_id`) REFERENCES `recetas` (`receta_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `fk_inventario_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `movimientoplaza`
--
ALTER TABLE `movimientoplaza`
  ADD CONSTRAINT `fk_plaza_id` FOREIGN KEY (`plaza_id`) REFERENCES `plaza` (`plaza_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `plaza`
--
ALTER TABLE `plaza`
  ADD CONSTRAINT `fk_receta_nombre` FOREIGN KEY (`receta_nombre`) REFERENCES `recetas` (`receta_nombre`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `recetas`
--
ALTER TABLE `recetas`
  ADD CONSTRAINT `fk_recetas_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
