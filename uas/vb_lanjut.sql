-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2020 at 08:46 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_lanjut`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fasilitas`
--

CREATE TABLE `tbl_fasilitas` (
  `ID_Fasilitas` char(20) NOT NULL,
  `Fasilitas` varchar(255) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_fasilitas`
--

INSERT INTO `tbl_fasilitas` (`ID_Fasilitas`, `Fasilitas`, `Keterangan`) VALUES
('FLS-00001', 'Hotel Golden Palace', 'Lantai 3\r\n'),
('FLS-00002', 'Hotel Madani', 'Lantai 5'),
('FLS-00003', 'BMW', 'Solar'),
('FLS-00004', 'Jeep', 'Pertamax');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jasa`
--

CREATE TABLE `tbl_jasa` (
  `ID_Jasa` char(20) NOT NULL,
  `Nama_Jasa` varchar(255) DEFAULT NULL,
  `Harga_Awal` double(255,0) DEFAULT NULL,
  `Harga_Sewa` double(255,0) DEFAULT NULL,
  `Laba` double(50,0) DEFAULT NULL,
  `Stok` varchar(11) DEFAULT NULL,
  `ID_Kategori` char(255) DEFAULT NULL,
  `ID_Fasilitas` char(255) DEFAULT NULL,
  `Kategori` varchar(100) DEFAULT NULL,
  `Diskon` varchar(50) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `Jumlah_Return` int(25) DEFAULT NULL,
  `Sub_Total_Laba` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_jasa`
--

INSERT INTO `tbl_jasa` (`ID_Jasa`, `Nama_Jasa`, `Harga_Awal`, `Harga_Sewa`, `Laba`, `Stok`, `ID_Kategori`, `ID_Fasilitas`, `Kategori`, `Diskon`, `Keterangan`, `Jumlah_Return`, `Sub_Total_Laba`) VALUES
('1010', 'Hotel Golden', 1000, 5000, 4000, '2', 'KTG-00001', 'FLS-00001', 'Gedung', '0', '0', 0, '8000'),
('1011', 'Hotel Lombok Raya', 2000, 3000, 1000, '5', 'KTG-00001', 'FLS-00001', 'Kendaraan', '0', '0', 0, '5000'),
('1012', 'BMw', 1000, 3000, 2000, '8', 'KTG-00002', 'FLS-00002', 'Dekorasi', '0', '0', 0, '16000'),
('1013', 'Dekorasi Tamu', 1000, 1200, 200, '5', 'KTG-00003', 'FLS-00003', 'Kendaraan', '0', '0', 0, '1000'),
('1014', 'vega', 1, 2, 1, '1', 'KTG-00002', 'FLS-00004', 'Kendaraan', '0', 'dd', 0, '1'),
('1015', 'vega', 1, 2, 1, '1', 'KTG-00002', 'FLS-00004', 'Kendaraan', '0', 'dd', 0, '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kategori`
--

CREATE TABLE `tbl_kategori` (
  `ID_Kategori` char(20) NOT NULL,
  `Kategori` varchar(255) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kategori`
--

INSERT INTO `tbl_kategori` (`ID_Kategori`, `Kategori`, `Keterangan`) VALUES
('KTG-00001', 'Gedung', 'Hotel'),
('KTG-00002', 'Kendaraan', 'Solar'),
('KTG-00003', 'Dekorasi', 'Panggung'),
('KTG-00004', 'Catering', 'Sate Lilit');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `ID_Pelanggan` char(100) NOT NULL,
  `Nama_Pelanggan` varchar(255) DEFAULT NULL,
  `No_Identitas` char(100) DEFAULT NULL,
  `Alamat` varchar(255) DEFAULT NULL,
  `Kontak` char(100) DEFAULT NULL,
  `Sisa_Hutang` double(255,0) DEFAULT NULL,
  `Terbayar` double(255,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`ID_Pelanggan`, `Nama_Pelanggan`, `No_Identitas`, `Alamat`, `Kontak`, `Sisa_Hutang`, `Terbayar`) VALUES
('111', 'Anjas Mara', '123', 'Mujur', '081', 1000, 100),
('112', 'Azhari', '234', 'Loteng', '081', 100, 100);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pengguna`
--

CREATE TABLE `tbl_pengguna` (
  `ID_Pengguna` varchar(255) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Tipe` varchar(255) DEFAULT NULL,
  `Pengguna` int(1) DEFAULT NULL,
  `Kategori` int(1) DEFAULT NULL,
  `Fasilitas` int(1) DEFAULT NULL,
  `Jasa` int(1) DEFAULT NULL,
  `Penyewaan` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pengguna`
--

INSERT INTO `tbl_pengguna` (`ID_Pengguna`, `Username`, `Password`, `Tipe`, `Pengguna`, `Kategori`, `Fasilitas`, `Jasa`, `Penyewaan`) VALUES
('1113', 'anjas', 'anjas', 'Administrator', 1, 1, 1, 1, 1),
('1114', 'anjas', 'anjas', 'Administrator', 1, 1, 1, 1, 1),
('12345678', 'admin', 'admin', 'Administrator', 1, 1, 1, 1, 1),
('123456789', 'users', 'users', 'Administrator', 0, 1, 1, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penyewaan`
--

CREATE TABLE `tbl_penyewaan` (
  `ID_Penyewaan` char(50) NOT NULL,
  `Pelanggan` varchar(255) DEFAULT NULL,
  `ID_Pelanggan` char(50) DEFAULT NULL,
  `Tgl_Penyewaan` date DEFAULT NULL,
  `ID_Pengguna` char(50) DEFAULT NULL,
  `Total_Item` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penyewaan`
--

INSERT INTO `tbl_penyewaan` (`ID_Penyewaan`, `Pelanggan`, `ID_Pelanggan`, `Tgl_Penyewaan`, `ID_Pengguna`, `Total_Item`) VALUES
('PJ-200131 110449', 'Anjas Mara', '111', '2020-01-31', '-', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penyewaan_dtl`
--

CREATE TABLE `tbl_penyewaan_dtl` (
  `ID_Penyewaan` char(255) NOT NULL,
  `ID_Jasa` char(255) DEFAULT NULL,
  `Nama_Jasa` varchar(255) DEFAULT NULL,
  `Harga_Sewa` double(255,0) DEFAULT NULL,
  `Jumlah_Sewa` int(255) DEFAULT NULL,
  `Diskon` double(255,0) DEFAULT NULL,
  `Sub_Total` double(255,0) DEFAULT NULL,
  `ID_Pelanggan` char(255) DEFAULT NULL,
  `Status` enum('Tunai','Hutang') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penyewaan_dtl`
--

INSERT INTO `tbl_penyewaan_dtl` (`ID_Penyewaan`, `ID_Jasa`, `Nama_Jasa`, `Harga_Sewa`, `Jumlah_Sewa`, `Diskon`, `Sub_Total`, `ID_Pelanggan`, `Status`) VALUES
('PJ-200131 040416', '1010', 'Paket A', 5000, 1, 0, 5000, '111', 'Tunai');

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_sewa`
-- (See below for the actual view)
--
CREATE TABLE `view_sewa` (
`ID_Penyewaan` char(50)
,`Pelanggan` varchar(255)
,`ID_Pelanggan` char(50)
,`Tgl_Penyewaan` date
,`ID_Jasa` char(255)
,`Nama_Jasa` varchar(255)
,`Harga_Sewa` double(255,0)
,`Jumlah_Sewa` int(255)
,`Sub_Total` double(255,0)
);

-- --------------------------------------------------------

--
-- Structure for view `view_sewa`
--
DROP TABLE IF EXISTS `view_sewa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_sewa`  AS  select `tbl_penyewaan`.`ID_Penyewaan` AS `ID_Penyewaan`,`tbl_penyewaan`.`Pelanggan` AS `Pelanggan`,`tbl_penyewaan`.`ID_Pelanggan` AS `ID_Pelanggan`,`tbl_penyewaan`.`Tgl_Penyewaan` AS `Tgl_Penyewaan`,`tbl_penyewaan_dtl`.`ID_Jasa` AS `ID_Jasa`,`tbl_penyewaan_dtl`.`Nama_Jasa` AS `Nama_Jasa`,`tbl_penyewaan_dtl`.`Harga_Sewa` AS `Harga_Sewa`,`tbl_penyewaan_dtl`.`Jumlah_Sewa` AS `Jumlah_Sewa`,`tbl_penyewaan_dtl`.`Sub_Total` AS `Sub_Total` from (`tbl_penyewaan` join `tbl_penyewaan_dtl`) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_fasilitas`
--
ALTER TABLE `tbl_fasilitas`
  ADD PRIMARY KEY (`ID_Fasilitas`);

--
-- Indexes for table `tbl_jasa`
--
ALTER TABLE `tbl_jasa`
  ADD PRIMARY KEY (`ID_Jasa`),
  ADD KEY `id_kategori` (`ID_Kategori`),
  ADD KEY `id_fasilitas` (`ID_Fasilitas`);

--
-- Indexes for table `tbl_kategori`
--
ALTER TABLE `tbl_kategori`
  ADD PRIMARY KEY (`ID_Kategori`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indexes for table `tbl_pengguna`
--
ALTER TABLE `tbl_pengguna`
  ADD PRIMARY KEY (`ID_Pengguna`);

--
-- Indexes for table `tbl_penyewaan`
--
ALTER TABLE `tbl_penyewaan`
  ADD PRIMARY KEY (`ID_Penyewaan`) USING BTREE;

--
-- Indexes for table `tbl_penyewaan_dtl`
--
ALTER TABLE `tbl_penyewaan_dtl`
  ADD PRIMARY KEY (`ID_Penyewaan`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_jasa`
--
ALTER TABLE `tbl_jasa`
  ADD CONSTRAINT `id_fasilitas` FOREIGN KEY (`ID_Fasilitas`) REFERENCES `tbl_fasilitas` (`ID_Fasilitas`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `id_kategori` FOREIGN KEY (`ID_Kategori`) REFERENCES `tbl_kategori` (`ID_Kategori`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
