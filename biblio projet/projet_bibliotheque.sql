-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 05, 2019 at 08:10 PM
-- Server version: 10.3.15-MariaDB
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projet_bibliotheque`
--

-- --------------------------------------------------------

--
-- Table structure for table `adderent`
--

CREATE TABLE `adderent` (
  `ID_A` int(11) NOT NULL,
  `nom_A` varchar(30) NOT NULL,
  `prenom_A` varchar(30) NOT NULL,
  `mail_A` varchar(40) NOT NULL,
  `num_A` varchar(20) NOT NULL,
  `mdp_A` varchar(25) NOT NULL,
  `ID_L` int(11) DEFAULT NULL,
  `ID_RA` int(11) DEFAULT NULL,
  `type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `adderent`
--

INSERT INTO `adderent` (`ID_A`, `nom_A`, `prenom_A`, `mail_A`, `num_A`, `mdp_A`, `ID_L`, `ID_RA`, `type`) VALUES
(1, 'EL KHAZENTI', 'Aymane', 'aelkhazenti', '13132313', 'test', 5, 1, 'admin'),
(3, '', '', '', '', '', 1, 5, 'utilisateur'),
(4, 'asd', 'asd', 'a', '2341', 'a', 5, 3, 'utilisateur');

-- --------------------------------------------------------

--
-- Table structure for table `auteur`
--

CREATE TABLE `auteur` (
  `ID_AU` int(11) NOT NULL,
  `nom_AU` varchar(30) NOT NULL,
  `prenom_AU` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `auteur`
--

INSERT INTO `auteur` (`ID_AU`, `nom_AU`, `prenom_AU`) VALUES
(1, '0', '0'),
(2, 'aymane', 'aym'),
(3, 'aym', 'aym'),
(4, 'saa', 'as'),
(5, 'as', 'as'),
(6, 'tessst', 'tessst'),
(7, 'sda', 'sdadd'),
(8, 'qweqwe', 'qweqw'),
(9, 'fgh', 'pop'),
(10, 'mnsjs', 'asdw');

-- --------------------------------------------------------

--
-- Table structure for table `livre`
--

CREATE TABLE `livre` (
  `ID_L` int(11) NOT NULL,
  `code_L` varchar(40) NOT NULL,
  `titre_L` varchar(40) NOT NULL,
  `nbr_de_page` int(11) NOT NULL,
  `nbr_de_copie` int(11) NOT NULL,
  `ID_AU` int(11) NOT NULL,
  `reservation` varchar(10) NOT NULL,
  `date_retour_l` date DEFAULT NULL,
  `validation` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `livre`
--

INSERT INTO `livre` (`ID_L`, `code_L`, `titre_L`, `nbr_de_page`, `nbr_de_copie`, `ID_AU`, `reservation`, `date_retour_l`, `validation`) VALUES
(1, 'test', 'ionic', 1212, 1, 6, 'non', '2019-07-18', 'non'),
(2, 'saaas', 'vb.net', 122, 11, 3, 'non', '2019-06-18', 'non'),
(3, 'asd23131', 'merise', 411, 4, 8, 'non', '2019-06-20', 'non'),
(4, 'qeq112', 'c++', 12, 31, 6, 'non', '2019-06-18', 'non'),
(5, 'asda', 'java', 32, 23, 6, 'non', '2019-07-01', 'non'),
(6, 'asd', 'teeest', 32, 32, 6, 'non', '2019-07-18', 'non'),
(8, '126sd', 'angular with fire', 200, 2, 9, 'non', NULL, 'non'),
(9, 'possa', 'tysga', 13, 2333, 10, 'non', NULL, 'non');

-- --------------------------------------------------------

--
-- Table structure for table `rapport`
--

CREATE TABLE `rapport` (
  `ID_RA` int(11) NOT NULL,
  `titre_RA` varchar(40) NOT NULL,
  `anne_RA` varchar(40) NOT NULL,
  `type_RA` int(11) NOT NULL,
  `reservation` varchar(10) NOT NULL,
  `date_retour_ra` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rapport`
--

INSERT INTO `rapport` (`ID_RA`, `titre_RA`, `anne_RA`, `type_RA`, `reservation`, `date_retour_ra`) VALUES
(1, 'azerty', '90', 0, 'non', '2019-06-18'),
(2, 'test', '12', 0, 'non', '2019-06-18'),
(3, 'python', '3', 0, 'non', '2019-06-18'),
(4, 'angular', '32', 0, 'non', '2019-06-18'),
(5, 'qwerty', '1311', 0, 'non', '2019-06-18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adderent`
--
ALTER TABLE `adderent`
  ADD PRIMARY KEY (`ID_A`),
  ADD KEY `ID_L` (`ID_L`),
  ADD KEY `ID_RA` (`ID_RA`);

--
-- Indexes for table `auteur`
--
ALTER TABLE `auteur`
  ADD PRIMARY KEY (`ID_AU`);

--
-- Indexes for table `livre`
--
ALTER TABLE `livre`
  ADD PRIMARY KEY (`ID_L`),
  ADD KEY `ID_AU` (`ID_AU`);

--
-- Indexes for table `rapport`
--
ALTER TABLE `rapport`
  ADD PRIMARY KEY (`ID_RA`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adderent`
--
ALTER TABLE `adderent`
  MODIFY `ID_A` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `auteur`
--
ALTER TABLE `auteur`
  MODIFY `ID_AU` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `livre`
--
ALTER TABLE `livre`
  MODIFY `ID_L` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `rapport`
--
ALTER TABLE `rapport`
  MODIFY `ID_RA` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adderent`
--
ALTER TABLE `adderent`
  ADD CONSTRAINT `adderent_ibfk_1` FOREIGN KEY (`ID_L`) REFERENCES `livre` (`ID_L`),
  ADD CONSTRAINT `adderent_ibfk_2` FOREIGN KEY (`ID_RA`) REFERENCES `rapport` (`ID_RA`);

--
-- Constraints for table `livre`
--
ALTER TABLE `livre`
  ADD CONSTRAINT `livre_ibfk_1` FOREIGN KEY (`ID_AU`) REFERENCES `auteur` (`ID_AU`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
