-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2020 at 08:47 PM
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
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `ID_Barang` char(20) NOT NULL,
  `Nama_Barang` varchar(225) DEFAULT NULL,
  `Harga_Beli` double(50,0) DEFAULT NULL,
  `Harga_Jual` double(50,0) DEFAULT NULL,
  `Laba` double(50,0) DEFAULT NULL,
  `Stok` int(11) DEFAULT NULL,
  `ID_Jenis` char(12) DEFAULT NULL,
  `ID_Merek` char(12) DEFAULT NULL,
  `ID_Satuan` char(12) DEFAULT NULL,
  `Satuan` varchar(50) DEFAULT NULL,
  `Ukuran` varchar(50) DEFAULT NULL,
  `Diskon` varchar(50) DEFAULT NULL,
  `Keterangan` varchar(225) DEFAULT NULL,
  `Jumlah_return` int(20) DEFAULT NULL,
  `Sub_Total_Laba` double(50,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_barang`
--

INSERT INTO `tbl_barang` (`ID_Barang`, `Nama_Barang`, `Harga_Beli`, `Harga_Jual`, `Laba`, `Stok`, `ID_Jenis`, `ID_Merek`, `ID_Satuan`, `Satuan`, `Ukuran`, `Diskon`, `Keterangan`, `Jumlah_return`, `Sub_Total_Laba`) VALUES
('1', '1', 2, 11, 9, 1, 'JNS0001', 'MRK0001', 'STN0001', 'botol', '11', '0', '11', 0, 9),
('111', 'Aqua', 1000, 2000, 1000, 5, 'JNS0001', 'MRK0001', 'STN0001', 'botol', 'L', '0', 'Baru', 0, 5000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jenis`
--

CREATE TABLE `tbl_jenis` (
  `ID_Jenis` char(50) NOT NULL,
  `Jenis` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_jenis`
--

INSERT INTO `tbl_jenis` (`ID_Jenis`, `Jenis`, `Keterangan`) VALUES
('JNS-00002', 's', 's'),
('JNS0001', 'Minuman', 'air');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_merek`
--

CREATE TABLE `tbl_merek` (
  `ID_Merek` char(50) NOT NULL,
  `Merek` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_merek`
--

INSERT INTO `tbl_merek` (`ID_Merek`, `Merek`, `Keterangan`) VALUES
('MRK0001', 'aqua', 'kotak');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `ID_Pelanggan` char(50) NOT NULL,
  `Nama_Pelanggan` varchar(255) DEFAULT NULL,
  `No_Identitas` char(50) DEFAULT NULL,
  `Alamat` varchar(255) DEFAULT NULL,
  `Kontak` char(13) DEFAULT NULL,
  `Sisa_Hutang` double(255,0) DEFAULT NULL,
  `Terbayar` double(255,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`ID_Pelanggan`, `Nama_Pelanggan`, `No_Identitas`, `Alamat`, `Kontak`, `Sisa_Hutang`, `Terbayar`) VALUES
('1012', 'Benjos', '01010', 'Mujur', '081', 1000, 500);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pengguna`
--

CREATE TABLE `tbl_pengguna` (
  `ID_Pengguna` varchar(20) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Tipe` varchar(200) DEFAULT NULL,
  `Pengguna` int(1) DEFAULT NULL,
  `Jenis` int(1) DEFAULT NULL,
  `Satuan` int(1) DEFAULT NULL,
  `Merek` int(1) DEFAULT NULL,
  `Barang` int(1) DEFAULT NULL,
  `Suplier` int(1) DEFAULT NULL,
  `Pembelian` int(1) DEFAULT NULL,
  `Penjualan` int(1) DEFAULT NULL,
  `Batal_Penjualan` int(1) DEFAULT NULL,
  `Return_Barang` int(255) DEFAULT NULL,
  `Opname` int(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pengguna`
--

INSERT INTO `tbl_pengguna` (`ID_Pengguna`, `Username`, `Password`, `Tipe`, `Pengguna`, `Jenis`, `Satuan`, `Merek`, `Barang`, `Suplier`, `Pembelian`, `Penjualan`, `Batal_Penjualan`, `Return_Barang`, `Opname`) VALUES
('12', 'user', 'user', 'User', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `ID_Penjualan` char(50) NOT NULL,
  `Pelanggan` varchar(150) DEFAULT NULL,
  `ID_Pelanggan` char(20) DEFAULT NULL,
  `Tgl_Penjualan` date DEFAULT NULL,
  `ID_Penggunaan` char(20) DEFAULT NULL,
  `Total_Item` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penjualan`
--

INSERT INTO `tbl_penjualan` (`ID_Penjualan`, `Pelanggan`, `ID_Pelanggan`, `Tgl_Penjualan`, `ID_Penggunaan`, `Total_Item`) VALUES
('PJ-191218 510332', 'Benjos', '1012', '2019-12-18', '-', 2),
('PJ-191218 580323', 'Benjos', '1012', '2019-12-18', '-', 1),
('PJ-200108 250401', 'Benjos', '1012', '2020-01-08', '-', 1),
('PJ-200131 320722', 'Benjos', '1012', '2020-01-31', '-', 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan_dtl`
--

CREATE TABLE `tbl_penjualan_dtl` (
  `ID_Penjualan` char(50) NOT NULL,
  `ID_Barang` char(20) DEFAULT NULL,
  `Nama_Barang` varchar(150) DEFAULT NULL,
  `Harga_Jual` double(50,0) DEFAULT NULL,
  `Jumlah_Jual` int(50) DEFAULT NULL,
  `Diskon` double(50,0) DEFAULT NULL,
  `Sub_Total` double(50,0) DEFAULT NULL,
  `ID_Pelanggan` char(20) DEFAULT NULL,
  `Status` enum('Tunai','Hitung') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_penjualan_dtl`
--

INSERT INTO `tbl_penjualan_dtl` (`ID_Penjualan`, `ID_Barang`, `Nama_Barang`, `Harga_Jual`, `Jumlah_Jual`, `Diskon`, `Sub_Total`, `ID_Pelanggan`, `Status`) VALUES
('PJ-191218 580323', '111', 'Aqua', 2000, 1, 0, 2000, '1012', 'Tunai'),
('PJ-200108 250401', '111', 'Aqua', 2000, 1, 0, 2000, '1012', 'Tunai'),
('PJ-200131 320722', '1', '1', 11, 5, 0, 55, '1012', 'Tunai');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_satuan`
--

CREATE TABLE `tbl_satuan` (
  `ID_Satuan` char(50) NOT NULL,
  `Satuan` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_satuan`
--

INSERT INTO `tbl_satuan` (`ID_Satuan`, `Satuan`, `Keterangan`) VALUES
('STN0001', 'botol', 'panjang');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_suplier`
--

CREATE TABLE `tbl_suplier` (
  `ID_Suplier` char(50) NOT NULL,
  `Suplier` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_jual`
-- (See below for the actual view)
--
CREATE TABLE `view_jual` (
`ID_Penjualan` char(50)
,`Pelanggan` varchar(150)
,`ID_Pelanggan` char(20)
,`Tgl_Penjualan` date
,`ID_Barang` char(20)
,`Nama_Barang` varchar(150)
,`Harga_Jual` double(50,0)
,`Jumlah_Jual` int(50)
,`Sub_Total` double(50,0)
);

-- --------------------------------------------------------

--
-- Structure for view `view_jual`
--
DROP TABLE IF EXISTS `view_jual`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_jual`  AS  select `tbl_penjualan`.`ID_Penjualan` AS `ID_Penjualan`,`tbl_penjualan`.`Pelanggan` AS `Pelanggan`,`tbl_penjualan`.`ID_Pelanggan` AS `ID_Pelanggan`,`tbl_penjualan`.`Tgl_Penjualan` AS `Tgl_Penjualan`,`tbl_penjualan_dtl`.`ID_Barang` AS `ID_Barang`,`tbl_penjualan_dtl`.`Nama_Barang` AS `Nama_Barang`,`tbl_penjualan_dtl`.`Harga_Jual` AS `Harga_Jual`,`tbl_penjualan_dtl`.`Jumlah_Jual` AS `Jumlah_Jual`,`tbl_penjualan_dtl`.`Sub_Total` AS `Sub_Total` from (`tbl_penjualan` join `tbl_penjualan_dtl`) where (`tbl_penjualan`.`ID_Penjualan` = `tbl_penjualan_dtl`.`ID_Penjualan`) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`ID_Barang`),
  ADD KEY `fk_id_jenis` (`ID_Jenis`),
  ADD KEY `fk_id_merek` (`ID_Merek`),
  ADD KEY `fk_id_satuan` (`ID_Satuan`);

--
-- Indexes for table `tbl_jenis`
--
ALTER TABLE `tbl_jenis`
  ADD PRIMARY KEY (`ID_Jenis`);

--
-- Indexes for table `tbl_merek`
--
ALTER TABLE `tbl_merek`
  ADD PRIMARY KEY (`ID_Merek`);

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
-- Indexes for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD PRIMARY KEY (`ID_Penjualan`);

--
-- Indexes for table `tbl_penjualan_dtl`
--
ALTER TABLE `tbl_penjualan_dtl`
  ADD KEY `fk_id_barang` (`ID_Barang`),
  ADD KEY `fk_id_jual` (`ID_Penjualan`);

--
-- Indexes for table `tbl_satuan`
--
ALTER TABLE `tbl_satuan`
  ADD PRIMARY KEY (`ID_Satuan`);

--
-- Indexes for table `tbl_suplier`
--
ALTER TABLE `tbl_suplier`
  ADD PRIMARY KEY (`ID_Suplier`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD CONSTRAINT `fk_id_jenis` FOREIGN KEY (`ID_Jenis`) REFERENCES `tbl_jenis` (`ID_Jenis`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_id_merek` FOREIGN KEY (`ID_Merek`) REFERENCES `tbl_merek` (`ID_Merek`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_id_satuan` FOREIGN KEY (`ID_Satuan`) REFERENCES `tbl_satuan` (`ID_Satuan`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
