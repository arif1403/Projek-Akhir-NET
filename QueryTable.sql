Create TABLE jenis(
kd_jenis CHAR(3) NOT NULL PRIMARY KEY,
nm_jenis VARCHAR(100) NOT NULL,
);

Create TABLE barang(
kd_barang CHAR(4) NOT NULL PRIMARY KEY,
nm_barang VARCHAR(100) NOT NULL,
kd_jenis CHAR(3) NOT NULL,
satuan INT NOT NULL,
harga INT NOT NULL,
CONSTRAINT FK_JENIS FOREIGN KEY (kd_jenis) REFERENCES jenis(kd_jenis),
);

Create TABLE pelanggan(
kd_pelanggan CHAR(4) NOT NULL PRIMARY KEY,
nm_pelanggan VARCHAR(100) NOT NULL,
alamat VARCHAR(100) NOT NULL,
no_telepon VARCHAR(20) NOT NULL,
);

Create TABLE admin(
kd_admin CHAR(3) NOT NULL PRIMARY KEY,
nm_admin VARCHAR(100) NOT NULL,
username VARCHAR(100) NOT NULL,
password VARCHAR(150) NOT NULL,
level VARCHAR(20) NOT NULL,
);

Create TABLE penerimaan(
no_nota CHAR(7) NOT NULL PRIMARY KEY,
tgl_masuk DATE NOT NULL,
tgl_selesai DATE NOT NULL,
kd_pelanggan CHAR(4) NOT NULL,
keterangan VARCHAR(100) NOT NULL,
kd_admin CHAR(3) NOT NULL,
CONSTRAINT FK_PELANGGAN FOREIGN KEY (kd_pelanggan) REFERENCES pelanggan(kd_pelanggan),
CONSTRAINT FK_PENERIMA FOREIGN KEY (kd_admin) REFERENCES admin(kd_admin),
);

Create TABLE penerimaan_item(
no_nota CHAR(7) NOT NULL,
kd_barang CHAR(4) NOT NULL,
harga INT NOT NULL,
jumlah DECIMAL(10,2) NOT NULL,
CONSTRAINT FK_PENERIMAAN FOREIGN KEY (no_nota) REFERENCES penerimaan(no_nota),
CONSTRAINT FK_BARANG FOREIGN KEY (kd_barang) REFERENCES barang(kd_barang),
);

Create TABLE pengambilan(
no_pengambilan CHAR(7) NOT NULL PRIMARY KEY,
no_nota CHAR(7) NOT NULL,
tgl_ambil DATE NOT NULL,
total_bayar INT NOT NULL,
jumlah_bayar INT NOT NULL,
kd_admin CHAR(3) NOT NULL,
CONSTRAINT FK_ADMIN FOREIGN KEY (kd_admin) REFERENCES admin(kd_admin),
CONSTRAINT FK_PENGAMBILAN FOREIGN KEY (no_nota) REFERENCES penerimaan(no_nota),
);
