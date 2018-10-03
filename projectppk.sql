-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2018 at 02:11 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectppk`
--

-- --------------------------------------------------------

--
-- Table structure for table `mobil`
--

CREATE TABLE `mobil` (
  `id` int(11) UNSIGNED NOT NULL,
  `merk` varchar(50) NOT NULL,
  `tipe` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL,
  `plat_nomor` varchar(50) NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mobil`
--

INSERT INTO `mobil` (`id`, `merk`, `tipe`, `harga`, `plat_nomor`, `status`) VALUES
(1, 'Toyota', 'Avanza', 250000, 'N 1234 HJ', 1),
(2, 'Suzuki', 'Ertiga', 200000, 'F 4212 JT', 1),
(3, 'Toyota', 'Alphard', 750000, 'N 4451 JX', 1),
(4, 'Daihatsu', 'Xenia', 500000, 'AB 2513 JO', 1),
(5, 'Honda', 'Jazz', 400000, 'B 6103 KO', 1),
(6, 'Honda', 'Civic', 420000, 'AA 1293 J', 1),
(7, 'Honda ', 'CRV', 500000, 'AG 217 YR', 1),
(8, 'Toyota', 'Fortuner', 500000, 'B 1263 AD', 0),
(9, 'Toyota', 'Fortuner', 750000, 'D 3178 JH', 1),
(10, 'Daihatsu', 'Ayla', 300000, 'L 2314 FD', 1),
(11, 'Suzuki', 'Ertiga', 200000, 'AB 103 KO', 1),
(12, 'Suzuki', 'Ertiga', 200000, 'AB 1123 H', 0),
(13, 'Toyota', 'Avanza', 250000, 'S 2137 JD', 1),
(14, 'Toyota', 'Avanza', 250000, 'K 1378 IO', 0),
(15, 'Daihatsu', 'Xenia', 500000, 'N 582 OH', 0),
(16, 'Daihatsu', 'Xenia', 500000, 'AD 1233 I', 0),
(17, 'Honda', 'Jazz', 400000, 'H 568 CI', 1),
(18, 'Honda', 'Jazz', 1000000, 'N 0 OB', 0);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(11) UNSIGNED NOT NULL,
  `tanggal_pinjam` date NOT NULL,
  `tanggal_kembali` date NOT NULL,
  `nama` varchar(50) NOT NULL,
  `no_telpon` varchar(20) NOT NULL DEFAULT 'Tidak ada',
  `id_mobil` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id`, `tanggal_pinjam`, `tanggal_kembali`, `nama`, `no_telpon`, `id_mobil`) VALUES
(1, '2018-10-05', '2018-10-06', 'Agus', '082257466686', 16),
(2, '2018-10-05', '2018-10-08', 'Budi', '081257186672', 14),
(3, '2018-10-22', '2018-10-24', 'Doni', '088257186123', 15),
(4, '2018-10-16', '2018-10-18', 'Aldo', '081257123472', 12),
(17, '2018-10-03', '2018-10-05', 'Alma', '082155136378', 8),
(18, '2018-10-03', '2018-10-05', 'Andro', '08111111111', 18);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(10) UNSIGNED NOT NULL,
  `username` varchar(50) NOT NULL DEFAULT '0',
  `password` varchar(50) NOT NULL DEFAULT '0',
  `email` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `email`) VALUES
(1, 'farid', '123', 'farid.cuber@gmail.com'),
(2, 'kevin', '111', 'kevindominic@gmail.com'),
(3, 'arda', '999', 'ardafirdausr@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mobil`
--
ALTER TABLE `mobil`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `plat_nomor` (`plat_nomor`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `foreign_mobil` (`id_mobil`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `mobil`
--
ALTER TABLE `mobil`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `foreign_mobil` FOREIGN KEY (`id_mobil`) REFERENCES `mobil` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
