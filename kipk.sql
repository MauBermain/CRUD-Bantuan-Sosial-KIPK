-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Jan 2026 pada 15.17
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kipk`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `fakultas`
--

CREATE TABLE `fakultas` (
  `id_prodi` int(11) NOT NULL,
  `nama_fakultas` varchar(100) NOT NULL,
  `prodi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=swe7 COLLATE=swe7_swedish_ci;

--
-- Dumping data untuk tabel `fakultas`
--

INSERT INTO `fakultas` (`id_prodi`, `nama_fakultas`, `prodi`) VALUES
(1, 'Fakultas Agama Islam', 'Hukum Keluarga'),
(2, 'Fakultas Agama Islam', 'Hukum Ekonomi Syariah'),
(3, 'Fakultas Agama Islam', 'Komunikasi dan Penyiaran Islam'),
(4, 'Fakultas Agama Islam', 'Pendidikan Agama Islam'),
(5, 'Fakultas Agama Islam', 'Pendidikan Guru MI'),
(6, 'Fakultas Teknik', 'Teknik Mesin'),
(7, 'Fakultas Teknik', 'Teknik Sipil'),
(8, 'Fakultas Teknik', 'Teknik Elektro'),
(9, 'Fakultas Teknik', 'Teknik Industri'),
(10, 'Fakultas Teknologi Informasi', 'Teknik Informatika'),
(11, 'Fakultas Teknologi Informasi', 'Sistem Informasi'),
(12, 'Fakultas Teknologi Informasi', 'Teknologi Informasi'),
(13, 'Fakultas Ekonomi', 'Manajemen'),
(14, 'Fakultas Ekonomi', 'Akuntansi'),
(15, 'Fakultas Ilmu Pendidikan', 'Pendidikan Guru SD'),
(16, 'Fakultas Ilmu Pendidikan', 'Pendidikan Bahasa Inggris'),
(17, 'Fakultas Ilmu Pendidikan', 'Pendidikan IPA'),
(18, 'Fakultas Ilmu Pendidikan', 'Pendidikan Bahasa dan Sastra Indonesia');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_bantuan`
--

CREATE TABLE `jenis_bantuan` (
  `id_jenis` int(11) NOT NULL,
  `jenis` enum('KIPK','KIPK Usulan Masyarakat') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=swe7 COLLATE=swe7_swedish_ci;

--
-- Dumping data untuk tabel `jenis_bantuan`
--

INSERT INTO `jenis_bantuan` (`id_jenis`, `jenis`) VALUES
(1, 'KIPK'),
(2, 'KIPK Usulan Masyarakat');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(15) NOT NULL,
  `nama_penerima` varchar(100) NOT NULL,
  `Tahun_Menerima_KIPK` int(11) NOT NULL,
  `id_prodi` int(11) DEFAULT NULL,
  `id_jenis` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=swe7 COLLATE=swe7_swedish_ci;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama_penerima`, `Tahun_Menerima_KIPK`, `id_prodi`, `id_jenis`) VALUES
('2147483647', 'MUHAMMAD ATHI', 2024, 1, 1),
('2491024011', 'TRISALASI', 2024, 2, 1),
('2492034010', 'VIVI NIMAWATI', 2024, 3, 1),
('2493044028', 'SASMITASARI', 2024, 4, 2),
('2493064008', 'RAHMATIA ABDURAHMAN', 2024, 5, 1),
('2494074006', 'TEGAR MAULANA ALAMSYAH', 2024, 6, 1),
('2494094015', 'AHMAD ABDUL KHOIR', 2024, 7, 1),
('2495114004', 'AHMAD BADRUL FURQON', 2024, 10, 1),
('2495114036', 'DIMAS FERDIANSYAH', 2024, 10, 1),
('2495124014', 'SRI AFIFATUL FAJRIYA', 2024, 11, 1),
('2496144039', 'SINTA NUR AZIZAH', 2024, 13, 1),
('2496154006', 'LENTESSA DWI INDRA MAYA', 2024, 14, 1),
('2497174033', 'FANEZA ARIFATUL KARIMAH', 2024, 15, 1),
('2497194001', 'HILYA CAMELIA FATHMA', 2024, 16, 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id_username` int(9) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=swe7 COLLATE=swe7_swedish_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id_username`, `username`, `password`) VALUES
(1000, 'hallo', 'halo'),
(1001, 'aduhgagal', '123'),
(1002, 'adaadaaja', 'duarr'),
(1003, 'aduhhhh', 'qqq'),
(1004, 'bambang', 'udah'),
(1005, 'kudanan', 'payah'),
(1006, 'mamah', 'mamah'),
(1007, 'admin', '123'),
(1008, 'aa', 'bbbb');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `fakultas`
--
ALTER TABLE `fakultas`
  ADD PRIMARY KEY (`id_prodi`);

--
-- Indeks untuk tabel `jenis_bantuan`
--
ALTER TABLE `jenis_bantuan`
  ADD PRIMARY KEY (`id_jenis`);

--
-- Indeks untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`),
  ADD KEY `id_fakultas` (`id_prodi`),
  ADD KEY `id_jenis` (`id_jenis`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_username`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `fakultas`
--
ALTER TABLE `fakultas`
  MODIFY `id_prodi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT untuk tabel `jenis_bantuan`
--
ALTER TABLE `jenis_bantuan`
  MODIFY `id_jenis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD CONSTRAINT `mahasiswa_ibfk_1` FOREIGN KEY (`id_prodi`) REFERENCES `fakultas` (`id_prodi`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `mahasiswa_ibfk_2` FOREIGN KEY (`id_jenis`) REFERENCES `jenis_bantuan` (`id_jenis`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
