/*
Navicat MySQL Data Transfer

Source Server         : MySqlServer 5.5
Source Server Version : 50554
Source Host           : 127.0.0.1:3306
Source Database       : db_penjualan1

Target Server Type    : MYSQL
Target Server Version : 50554
File Encoding         : 65001

Date: 2020-01-15 00:48:03
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tbl_barang
-- ----------------------------
DROP TABLE IF EXISTS `tbl_barang`;
CREATE TABLE `tbl_barang` (
  `ID_Barang` char(20) NOT NULL DEFAULT '',
  `Nama_Barang` varchar(255) DEFAULT NULL,
  `Harga_beli` double(50,0) DEFAULT NULL,
  `Harga_Jual` double(50,0) DEFAULT NULL,
  `Laba` double(50,0) DEFAULT NULL,
  `Stok` int(11) DEFAULT NULL,
  `ID_Jenis` char(12) DEFAULT NULL,
  `ID_Satuan` char(12) DEFAULT NULL,
  `ID_Merek` char(12) DEFAULT NULL,
  `Satuan` varchar(50) DEFAULT NULL,
  `Ukuran` varchar(50) DEFAULT NULL,
  `Diskon` double(50,0) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `Jumlah_Return` int(20) DEFAULT NULL,
  `Sub_Total_Laba` double(50,0) DEFAULT NULL,
  `Foto` blob,
  PRIMARY KEY (`ID_Barang`),
  KEY `fk_satuan` (`ID_Satuan`),
  KEY `fk_jenis` (`ID_Jenis`),
  KEY `fk_merk` (`ID_Merek`),
  KEY `ID_Barang` (`ID_Barang`),
  KEY `ID_Barang_2` (`ID_Barang`),
  CONSTRAINT `fk_jenis` FOREIGN KEY (`ID_Jenis`) REFERENCES `tbl_jenis` (`ID_Jenis`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_merek` FOREIGN KEY (`ID_Merek`) REFERENCES `tbl_merek` (`ID_Merek`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_satuan` FOREIGN KEY (`ID_Satuan`) REFERENCES `tbl_satuan` (`ID_satuan`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_barang
-- ----------------------------
INSERT INTO `tbl_barang` VALUES ('3483894', 'coba', '2000', '4000', '2000', '10', 'JNS-00004', 'STN-00002', 'MRK-00003', 'Botol', '-', '0', '-', '0', '20000', 0x4046696C65);
INSERT INTO `tbl_barang` VALUES ('93090293', 'Mama', '3000', '5000', '2000', '10', 'JNS-00001', 'STN-00001', 'MRK-00002', 'Buah', '-', '0', '-', '0', '20000', 0x40466F746F);
INSERT INTO `tbl_barang` VALUES ('984823984', 'tes', '2000', '12000', '10000', '10', 'JNS-00001', 'STN-00001', 'MRK-00004', 'Buah', '-', '0', '-', '0', '100000', 0x4046696C65);

-- ----------------------------
-- Table structure for tbl_jenis
-- ----------------------------
DROP TABLE IF EXISTS `tbl_jenis`;
CREATE TABLE `tbl_jenis` (
  `ID_Jenis` char(50) NOT NULL,
  `Jenis` varchar(150) DEFAULT NULL,
  `Keterangan` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID_Jenis`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_jenis
-- ----------------------------
INSERT INTO `tbl_jenis` VALUES ('JNS-00001', 'Alat Komputer', '-');
INSERT INTO `tbl_jenis` VALUES ('JNS-00002', 'Alat Kantor', '-');
INSERT INTO `tbl_jenis` VALUES ('JNS-00003', 'Makanan Ringan', '-');
INSERT INTO `tbl_jenis` VALUES ('JNS-00004', 'Minuman Bersoda', '-');

-- ----------------------------
-- Table structure for tbl_merek
-- ----------------------------
DROP TABLE IF EXISTS `tbl_merek`;
CREATE TABLE `tbl_merek` (
  `ID_Merek` char(12) NOT NULL DEFAULT '',
  `Merek` varchar(50) DEFAULT NULL,
  `Keterangan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_Merek`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_merek
-- ----------------------------
INSERT INTO `tbl_merek` VALUES ('MRK-00001', 'TP-Link', '-');
INSERT INTO `tbl_merek` VALUES ('MRK-00002', 'Narmada', '-');
INSERT INTO `tbl_merek` VALUES ('MRK-00003', 'Fruit Tea', '-');
INSERT INTO `tbl_merek` VALUES ('MRK-00004', 'D-Link', '-');

-- ----------------------------
-- Table structure for tbl_pelanggan
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pelanggan`;
CREATE TABLE `tbl_pelanggan` (
  `ID_Pelanggan` char(50) NOT NULL,
  `Nama_Pelanggan` varchar(255) DEFAULT NULL,
  `No_Identitas` char(50) DEFAULT NULL,
  `Alamat` varchar(255) DEFAULT NULL,
  `Kontak` char(13) DEFAULT NULL,
  `Sisa_Hutang` double(255,0) DEFAULT NULL,
  `Terbayar` double(255,0) DEFAULT NULL,
  PRIMARY KEY (`ID_Pelanggan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_pelanggan
-- ----------------------------
INSERT INTO `tbl_pelanggan` VALUES ('0987654', 'Olakk', '1700320011', 'Narmada', '0', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('1600330033', 'Wardiman G.', '252525', 'LOTIM', '12345', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('1700320014', 'eka', '45', 'lotim', '235', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PEL-00005', 'IMAM MUAMAR', '1700310004', 'KOBI', '085', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PELANGGAN-00005', 'Nana', '0987', 'Lembar', '12334', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00001', 'Zahratul Muttaqiin', '12345678', 'CEWE LOTIM', '082340462xxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-000010', 'dwy', '123121', 'masasa', '0826312xxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00002', 'Rizka', '123', 'Puncang', '1234', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00004', 'Eria', '789', 'Mataram', '081923xxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00005', 'Ratna', '12353672', 'Mataram', '098262781', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00006', 'Indah S', '12345678', 'Praya', '081917xxxxxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00006666', 'dwi', 'sfhhs', 'sadf', '2646', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00007', 'gIT gENGS', '12345678', 'Praya', '081917xxxxxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00008', 'Ayu Aprilia Irwandi', '1700320023', 'Geguntur', '085577595577', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLG-00009', 'febi adrian', '0872121', 'asaa', '09712xxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLGN-00002', 'eni febri yanti', '123', 'lotim', '0853xxxx', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLGN-00003', 'Ayu Intan Lestari', '1213', 'sumbawa', '827397', '0', '0');
INSERT INTO `tbl_pelanggan` VALUES ('PLGN-00005', 'feby purnama utami', '13333', 'selagalas', '9088', '0', '0');

-- ----------------------------
-- Table structure for tbl_pembelian
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE `tbl_pembelian` (
  `ID_pembelian` char(25) NOT NULL DEFAULT '',
  `ID_suplier` char(20) DEFAULT NULL,
  `nama_suplier` varchar(50) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `ID_pengguna` char(12) DEFAULT NULL,
  PRIMARY KEY (`ID_pembelian`),
  KEY `fk_suplier` (`ID_suplier`),
  CONSTRAINT `fk_suplier` FOREIGN KEY (`ID_suplier`) REFERENCES `tbl_suplier` (`ID_suplier`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_pembelian
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_pembelian_dtl
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pembelian_dtl`;
CREATE TABLE `tbl_pembelian_dtl` (
  `ID_pembelian` char(25) DEFAULT NULL,
  `ID_barang` char(12) DEFAULT NULL,
  `Nama_Barang` varchar(100) DEFAULT NULL,
  `Diskon` int(5) DEFAULT NULL,
  `harga_beli` double(50,0) DEFAULT NULL,
  `jumlah_beli` double(50,0) DEFAULT NULL,
  `sub_total` double(50,0) DEFAULT NULL,
  KEY `fk_pembelian` (`ID_pembelian`),
  KEY `fk_barang` (`ID_barang`),
  CONSTRAINT `fk_barang` FOREIGN KEY (`ID_barang`) REFERENCES `tbl_barang` (`ID_barang`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_pembelian` FOREIGN KEY (`ID_pembelian`) REFERENCES `tbl_pembelian` (`ID_pembelian`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_pembelian_dtl
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_pengguna
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `ID_pengguna` char(50) NOT NULL DEFAULT '',
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `tipe` char(20) NOT NULL,
  `jenis` int(1) NOT NULL,
  `tipee` int(1) NOT NULL,
  `barang` int(1) NOT NULL,
  `supplier` int(1) NOT NULL,
  `pengguna` int(1) NOT NULL,
  `pembelian` int(1) NOT NULL,
  `penjualan` int(1) NOT NULL,
  `batal_jual` int(1) NOT NULL,
  `return` int(1) NOT NULL,
  `opname` int(1) NOT NULL,
  `hutang` int(1) NOT NULL,
  `laporan` int(1) NOT NULL,
  PRIMARY KEY (`ID_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_pengguna
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_penjualan
-- ----------------------------
DROP TABLE IF EXISTS `tbl_penjualan`;
CREATE TABLE `tbl_penjualan` (
  `ID_Penjualan` char(50) NOT NULL DEFAULT '',
  `Pelanggan` varchar(150) DEFAULT NULL,
  `ID_Pelanggan` char(20) DEFAULT NULL,
  `Tgl_Penjualan` date DEFAULT NULL,
  `ID_Pengguna` char(20) DEFAULT NULL,
  `Total_Item` int(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Penjualan`) USING BTREE,
  KEY `ID_Penjualan` (`ID_Penjualan`),
  KEY `ID_Penjualan_2` (`ID_Penjualan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_penjualan
-- ----------------------------
INSERT INTO `tbl_penjualan` VALUES ('PJ-191208080718', 'IMAM MUAMAR', 'PEL-00005', '2019-12-08', '-', '5');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191209250901', 'Zahratul Muttaqiin', 'PLG-00001', '2019-12-09', '-', '3');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191210051216', 'IMAM MUAMAR', 'PEL-00005', '2019-12-10', '-', '6');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191215170538', 'Nana', 'PELANGGAN-00005', '2019-12-15', '-', '2');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191215350440', 'Olakk', '0987654', '2019-12-15', '-', '2');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191215500548', 'IMAM MUAMAR', 'PEL-00005', '2019-12-15', '-', '4');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191216151113', 'Wardiman G.', '1600330033', '2019-12-16', '-', '6');
INSERT INTO `tbl_penjualan` VALUES ('PJ-191216151132', 'Zahratul Muttaqiin', 'PLG-00001', '2019-12-16', '-', '3');

-- ----------------------------
-- Table structure for tbl_penjualan_dtl
-- ----------------------------
DROP TABLE IF EXISTS `tbl_penjualan_dtl`;
CREATE TABLE `tbl_penjualan_dtl` (
  `ID_Penjualan` char(50) NOT NULL DEFAULT '',
  `ID_Barang` char(20) DEFAULT NULL,
  `Nama_Barang` varchar(150) DEFAULT NULL,
  `Harga_Jual` double(50,0) DEFAULT NULL,
  `Jumlah_Jual` int(50) DEFAULT NULL,
  `Diskon` double(50,0) DEFAULT NULL,
  `Sub_Total` double(50,0) DEFAULT NULL,
  `ID_Pelanggan` char(20) DEFAULT NULL,
  `Status` enum('Tunai','Hutang') DEFAULT NULL,
  KEY `fk_barang_jualdtl` (`ID_Barang`),
  KEY `fk_penjualan_dtl` (`ID_Penjualan`),
  CONSTRAINT `fk_barang_jual` FOREIGN KEY (`ID_Barang`) REFERENCES `tbl_barang` (`ID_Barang`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_penjualan_dtl` FOREIGN KEY (`ID_Penjualan`) REFERENCES `tbl_penjualan` (`ID_Penjualan`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_penjualan_dtl
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_satuan
-- ----------------------------
DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `ID_satuan` char(12) NOT NULL,
  `satuan` varchar(50) DEFAULT NULL,
  `keterangan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_satuan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_satuan
-- ----------------------------
INSERT INTO `tbl_satuan` VALUES ('STN-00001', 'Buah', '-');
INSERT INTO `tbl_satuan` VALUES ('STN-00002', 'Botol', '-');
INSERT INTO `tbl_satuan` VALUES ('STN-00003', 'PCS', '-');

-- ----------------------------
-- Table structure for tbl_suplier
-- ----------------------------
DROP TABLE IF EXISTS `tbl_suplier`;
CREATE TABLE `tbl_suplier` (
  `ID_suplier` char(20) NOT NULL DEFAULT '',
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(100) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Kontak` char(12) DEFAULT NULL,
  PRIMARY KEY (`ID_suplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_suplier
-- ----------------------------

-- ----------------------------
-- View structure for view_jual
-- ----------------------------
DROP VIEW IF EXISTS `view_jual`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_jual` AS select `tbl_penjualan`.`ID_Penjualan` AS `ID_Penjualan`,`tbl_penjualan`.`ID_Pelanggan` AS `ID_Pelanggan`,`tbl_penjualan`.`Pelanggan` AS `Pelanggan`,`tbl_penjualan`.`Tgl_Penjualan` AS `Tgl_Penjualan`,`tbl_penjualan_dtl`.`ID_Barang` AS `ID_Barang`,`tbl_penjualan_dtl`.`Nama_Barang` AS `Nama_Barang`,`tbl_penjualan_dtl`.`Harga_Jual` AS `Harga_Jual`,`tbl_penjualan_dtl`.`Jumlah_Jual` AS `Jumlah_Jual`,`tbl_penjualan_dtl`.`Sub_Total` AS `Sub_Total`,`tbl_penjualan_dtl`.`Diskon` AS `Diskon` from (`tbl_penjualan` join `tbl_penjualan_dtl`) where (`tbl_penjualan`.`ID_Penjualan` = `tbl_penjualan_dtl`.`ID_Penjualan`) ;
DROP TRIGGER IF EXISTS `UbahStok`;
DELIMITER ;;
CREATE TRIGGER `UbahStok` AFTER INSERT ON `tbl_penjualan_dtl` FOR EACH ROW begin
  UPDATE TBL_BARANG SET STOK = STOK - NEW.Jumlah_Jual WHERE ID_Barang = NEW.ID_Barang;
end
;;
DELIMITER ;
