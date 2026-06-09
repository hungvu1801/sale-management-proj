/*
Created		5/7/2026
Modified		5/14/2026
Project		
Model		
Company		
Author		
Version		
Database		MS SQL 7 
*/
create database quanlybanhangdientu;
go
use quanlybanhangdientu;
go
Create table [NhanVien] (
	[MaNV] Varchar(10) NOT NULL,
	[TenNV] Nvarchar(50) NOT NULL,
	[QuanLy] Nvarchar(10) NOT NULL,
Primary Key  ([MaNV])
) 
go

Create table [NhaCungCap] (
	[MaNCC] Varchar(10) NOT NULL,
	[TenNCC] Nvarchar(50) NOT NULL,
Primary Key  ([MaNCC])
) 
go

Create table [SanPham] (
	[MaSP] Varchar(10) NOT NULL,
	[MaPL] Varchar(10) NOT NULL,
	[TenSP] Nvarchar(100) NOT NULL,
	[SoLuongTon] Integer NOT NULL,
	[GiaNhapHienTai] Integer NOT NULL,
	[GiaBanHienTai] Integer NOT NULL,
Primary Key  ([MaSP])
) 
go

Create table [PhanLoaiSP] (
	[MaPL] Varchar(10) NOT NULL,
	[TenPL] Nvarchar(50) NOT NULL,
Primary Key  ([MaPL])
) 
go

Create table [HangSX] (
	[MaHangSX] Varchar(10) NOT NULL,
	[TenHangSX] Nvarchar(50) NOT NULL,
Primary Key  ([MaHangSX])
) 
go

Create table [PhieuNhapHang] (
	[MaPhieuNhap] Varchar(10) NOT NULL,
	[MaNV] Varchar(10) NOT NULL,
	[MaNCC] Varchar(10) NOT NULL,
	[TongST] Integer NOT NULL,
Primary Key  ([MaPhieuNhap])
) 
go

Create table [HoaDonBanHang] (
	[MaHD] Varchar(10) NOT NULL,
	[TongST] Integer NOT NULL,
	[MaNV] Varchar(10) NOT NULL,
	[MaKH] Varchar(10) NOT NULL,
Primary Key  ([MaHD])
) 
go

Create table [NhaCungCap_Hang] (
	[MaNCC] Varchar(10) NOT NULL,
	[MaHangSX] Varchar(10) NOT NULL,
Primary Key  ([MaNCC],[MaHangSX])
) 
go

Create table [ChiTietPhieuNhapHang] (
	[MaPhieuNhap] Varchar(10) NOT NULL,
	[MaSP] Varchar(10) NOT NULL,
	[SoLuong] Integer NOT NULL,
	[GiaNhap] Integer NOT NULL,
Primary Key  ([MaPhieuNhap],[MaSP])
) 
go

Create table [ChiTietHoaDon] (
	[MaHD] Varchar(10) NOT NULL,
	[MaSP] Varchar(10) NOT NULL,
	[SoLuong] Integer NOT NULL,
	[GiaBan] Integer NOT NULL,
Primary Key  ([MaHD],[MaSP])
) 
go

Create table [KhangHang] (
	[MaKH] Varchar(10) NOT NULL,
	[TenKH] Nvarchar(50) NOT NULL,
	[SDT] Varchar(20) NOT NULL,
	[DiaCHi] Nvarchar(200) NOT NULL,
Primary Key  ([MaKH])
) 
go


Alter table [HoaDonBanHang] add  foreign key([MaNV]) references [NhanVien] ([MaNV]) ON DELETE CASCADE
go
Alter table [PhieuNhapHang] add  foreign key([MaNV]) references [NhanVien] ([MaNV]) ON DELETE CASCADE
go
Alter table [PhieuNhapHang] add  foreign key([MaNCC]) references [NhaCungCap] ([MaNCC]) ON DELETE CASCADE
go
Alter table [NhaCungCap_Hang] add  foreign key([MaNCC]) references [NhaCungCap] ([MaNCC]) ON DELETE CASCADE
go
Alter table [ChiTietPhieuNhapHang] add  foreign key([MaSP]) references [SanPham] ([MaSP]) ON DELETE CASCADE
go
Alter table [ChiTietHoaDon] add  foreign key([MaSP]) references [SanPham] ([MaSP]) ON DELETE CASCADE
go
Alter table [SanPham] add  foreign key([MaPL]) references [PhanLoaiSP] ([MaPL]) ON DELETE CASCADE
go
Alter table [NhaCungCap_Hang] add  foreign key([MaHangSX]) references [HangSX] ([MaHangSX]) ON DELETE CASCADE
go
Alter table [ChiTietPhieuNhapHang] add  foreign key([MaPhieuNhap]) references [PhieuNhapHang] ([MaPhieuNhap]) ON DELETE CASCADE
go
Alter table [ChiTietHoaDon] add  foreign key([MaHD]) references [HoaDonBanHang] ([MaHD]) ON DELETE CASCADE
go
Alter table [HoaDonBanHang] add  foreign key([MaKH]) references [KhangHang] ([MaKH]) ON DELETE CASCADE
go


Set quoted_identifier on
go


Set quoted_identifier off
go

-- Add mock data
-- =============================================
-- 1. NHAN VIEN (20)
-- =============================================
INSERT INTO [NhanVien] ([MaNV],[TenNV],[QuanLy]) VALUES
('NV001', N'Nguyễn Văn An',      'NV001'),
('NV002', N'Lê Thị Bích',        'NV001'),
('NV003', N'Trần Minh Cường',    'NV001'),
('NV004', N'Phạm Thị Dung',      'NV002'),
('NV005', N'Hoàng Văn Em',       'NV002'),
('NV006', N'Nguyễn Thị Phương',  'NV003'),
('NV007', N'Bùi Văn Giang',      'NV003'),
('NV008', N'Đỗ Thị Hoa',         'NV002'),
('NV009', N'Võ Văn Hùng',        'NV003'),
('NV010', N'Đặng Thị Lan',       'NV001'),
('NV011', N'Lý Văn Minh',        'NV010'),
('NV012', N'Trịnh Thị Ngọc',     'NV010'),
('NV013', N'Ngô Văn Phúc',       'NV002'),
('NV014', N'Hà Thị Quỳnh',       'NV003'),
('NV015', N'Đinh Văn Sơn',       'NV010'),
('NV016', N'Lương Thị Thu',      'NV002'),
('NV017', N'Mai Văn Tuấn',       'NV003'),
('NV018', N'Cao Thị Uyên',       'NV010'),
('NV019', N'Lâm Văn Việt',       'NV002'),
('NV020', N'Trương Thị Xuân',    'NV003');
GO
 
-- =============================================
-- 2. PHAN LOAI SAN PHAM (20)
-- =============================================
INSERT INTO [PhanLoaiSP] ([MaPL],[TenPL]) VALUES
('PL01', N'Card đồ họa'),
('PL02', N'Màn hình'),
('PL03', N'CPU'),
('PL04', N'RAM'),
('PL05', N'Ổ cứng SSD'),
('PL06', N'Mainboard'),
('PL07', N'Tản nhiệt'),
('PL08', N'Nguồn PSU'),
('PL09', N'Case máy tính'),
('PL10', N'Bàn phím'),
('PL11', N'Chuột'),
('PL12', N'Tai nghe'),
('PL13', N'Webcam'),
('PL14', N'Loa máy tính'),
('PL15', N'Capture card'),
('PL16', N'USB Hub'),
('PL17', N'Cáp kết nối'),
('PL18', N'SSD M.2'),
('PL19', N'Ổ cứng HDD'),
('PL20', N'Thẻ nhớ');
GO
 
-- =============================================
-- 3. HANG SAN XUAT (20)
-- FIX: bỏ HSX21-HSX33 vì NhaCungCap_Hang chỉ dùng đến HSX20
-- =============================================
INSERT INTO [HangSX] ([MaHangSX],[TenHangSX]) VALUES
('HSX01', N'ASUS'),
('HSX02', N'Samsung'),
('HSX03', N'LG'),
('HSX04', N'Intel'),
('HSX05', N'Kingston'),
('HSX06', N'Gigabyte'),
('HSX07', N'MSI'),
('HSX08', N'AMD'),
('HSX09', N'Corsair'),
('HSX10', N'Seagate'),
('HSX11', N'Western Digital'),
('HSX12', N'Logitech'),
('HSX13', N'Razer'),
('HSX14', N'SteelSeries'),
('HSX15', N'BenQ'),
('HSX16', N'Acer'),
('HSX17', N'Dell'),
('HSX18', N'Sapphire'),
('HSX19', N'Zotac'),
('HSX20', N'Crucial');
GO
 
-- =============================================
-- 4. NHA CUNG CAP (20)
-- =============================================
INSERT INTO [NhaCungCap] ([MaNCC],[TenNCC]) VALUES
('NCC01', N'Công ty TNHH Phân Phối Miền Nam'),
('NCC02', N'Công ty CP Nhật Nam Technology'),
('NCC03', N'TNHH Thương Mại Việt Hùng'),
('NCC04', N'Công ty Tân Thanh Computer'),
('NCC05', N'Minh Khang Distribution'),
('NCC06', N'Hoàng Gia Tech'),
('NCC07', N'Long Châu Electronics'),
('NCC08', N'Đại Việt Technology'),
('NCC09', N'Bảo Minh Digital'),
('NCC10', N'Thành Công Computer'),
('NCC11', N'Phú Quý PC'),
('NCC12', N'Vina Technology'),
('NCC13', N'An Phát Computer'),
('NCC14', N'Trần Anh Digital'),
('NCC15', N'Hà Nội PC Distribution'),
('NCC16', N'Sài Gòn PC'),
('NCC17', N'Phong Vũ Electronics'),
('NCC18', N'FPT Trading'),
('NCC19', N'Viettel Store Supply'),
('NCC20', N'CellphoneS Wholesale');
GO
 
-- =============================================
-- 5. NHA CUNG CAP - HANG SAN XUAT (20)
-- FIX: chỉ dùng HSX01-HSX20 đã tồn tại
-- =============================================
INSERT INTO [NhaCungCap_Hang] ([MaNCC],[MaHangSX]) VALUES
('NCC01', 'HSX01'),
('NCC01', 'HSX06'),
('NCC02', 'HSX02'),
('NCC02', 'HSX03'),
('NCC03', 'HSX04'),
('NCC03', 'HSX05'),
('NCC04', 'HSX07'),
('NCC04', 'HSX08'),
('NCC05', 'HSX09'),
('NCC05', 'HSX10'),
('NCC06', 'HSX11'),
('NCC06', 'HSX12'),
('NCC07', 'HSX13'),
('NCC07', 'HSX14'),
('NCC08', 'HSX15'),
('NCC08', 'HSX16'),
('NCC09', 'HSX17'),
('NCC09', 'HSX18'),
('NCC10', 'HSX19'),
('NCC10', 'HSX20');
GO
 
-- =============================================
-- 6. SAN PHAM (80 records, SP001-SP080)
-- FIX: bỏ cột MaHangSX (không có trong DDL)
-- FIX: đổi mã từ SP021 → SP001 để đồng bộ với ChiTiet
-- =============================================
INSERT INTO [SanPham] ([MaSP],[MaPL],[TenSP],[SoLuongTon],[GiaNhapHienTai],[GiaBanHienTai]) VALUES
 
-- PL01 - CARD ĐỒ HỌA (10)
('SP001','PL01',N'MSI RTX 4060 Ventus 8GB',          12,  7200000,  8900000),
('SP002','PL01',N'Gigabyte RTX 4070 Super Eagle',      8, 14500000, 17200000),
('SP003','PL01',N'ASUS RTX 4080 ROG Strix',            4, 25500000, 28900000),
('SP004','PL01',N'Sapphire RX 7800 XT Nitro+',         6, 13200000, 15800000),
('SP005','PL01',N'Zotac RTX 4060 Twin Edge',          11,  6800000,  8500000),
('SP006','PL01',N'MSI RX 7700 XT Gaming X',            7, 12100000, 14500000),
('SP007','PL01',N'Gigabyte RTX 3050 Windforce',       15,  4500000,  5900000),
('SP008','PL01',N'ASUS Dual RX 7600',                 10,  5900000,  7300000),
('SP009','PL01',N'Sapphire Pulse RX 6600',            13,  4700000,  6100000),
('SP010','PL01',N'Zotac RTX 4070 Ti Trinity',          5, 17800000, 20900000),
 
-- PL02 - MÀN HÌNH (10)
('SP011','PL02',N'LG UltraGear 27GP850-B 165Hz',       9,  7200000,  8900000),
('SP012','PL02',N'Dell UltraSharp U2723QE 4K',         5,  9800000, 11500000),
('SP013','PL02',N'ASUS TUF VG249Q3A 165Hz',           14,  3200000,  4300000),
('SP014','PL02',N'Acer Nitro XV272U QHD',              8,  5600000,  7100000),
('SP015','PL02',N'Samsung Smart Monitor M7 32 inch',   6,  6100000,  7600000),
('SP016','PL02',N'BenQ GW2780 27 inch IPS',           12,  3500000,  4700000),
('SP017','PL02',N'LG 32UN650-W 4K UHD',               4,  9200000, 10800000),
('SP018','PL02',N'MSI G274QPX 240Hz QHD',              7,  7700000,  9300000),
('SP019','PL02',N'Dell S2421HGF Gaming 144Hz',        11,  4100000,  5300000),
('SP020','PL02',N'Samsung Odyssey Neo G8 32 inch',     3, 18500000, 21900000),
 
-- PL03 - CPU (10)
('SP021','PL03',N'Intel Core i3-12100F',              18,  2400000,  3200000),
('SP022','PL03',N'Intel Core i9-14900K',               3, 13800000, 16500000),
('SP023','PL03',N'AMD Ryzen 9 7950X',                  4, 14900000, 17800000),
('SP024','PL03',N'AMD Ryzen 7 5800X',                  7,  5200000,  6800000),
('SP025','PL03',N'Intel Core i5-14600K',               8,  6900000,  8400000),
('SP026','PL03',N'AMD Ryzen 5 7500F',                 10,  4100000,  5600000),
('SP027','PL03',N'Intel Core i7-14700',                5,  9200000, 10800000),
('SP028','PL03',N'AMD Ryzen 7 8700G',                  6,  7300000,  8900000),
('SP029','PL03',N'Intel Pentium Gold G7400',           15,  1600000,  2300000),
('SP030','PL03',N'AMD Ryzen Threadripper 7960X',       2, 29500000, 33800000),
 
-- PL04 - RAM (10)
('SP031','PL04',N'Corsair Dominator DDR5 32GB',        9,  3200000,  4100000),
('SP032','PL04',N'Kingston Fury Beast DDR5 16GB',     16,  1500000,  2200000),
('SP033','PL04',N'Kingston Fury Beast DDR4 16GB',     24,   850000,  1200000),
('SP034','PL04',N'ADATA XPG Lancer DDR5 16GB',        14,  1200000,  1800000),
('SP035','PL04',N'Crucial DDR4 8GB 3200MHz',          22,   550000,   850000),
('SP036','PL04',N'Corsair Vengeance RGB DDR4 64GB',    5,  5400000,  6500000),
('SP037','PL04',N'Kingston Fury Beast DDR4 8GB',      20,   480000,   760000),
('SP038','PL04',N'TeamGroup T-Force Delta DDR4 16GB', 11,  1300000,  1900000),
('SP039','PL04',N'Crucial DDR4 32GB 3200MHz',         15,  1600000,  2200000),
('SP040','PL04',N'Crucial Pro DDR5 48GB',              4,  4700000,  5900000),
 
-- PL05 - SSD SATA (10)
('SP041','PL05',N'Kingston A400 SSD 240GB',           20,   520000,   790000),
('SP042','PL05',N'Samsung 870 EVO SSD 1TB',           12,  1750000,  2350000),
('SP043','PL05',N'WD Green SATA SSD 480GB',           17,   890000,  1250000),
('SP044','PL05',N'Crucial MX500 SSD 1TB',             10,  1680000,  2290000),
('SP045','PL05',N'ADATA SU650 SSD 512GB',             14,   760000,  1120000),
('SP046','PL05',N'Kingston KC600 SSD 1TB',             8,  1850000,  2480000),
('SP047','PL05',N'Samsung 870 QVO SSD 2TB',            6,  2980000,  3650000),
('SP048','PL05',N'WD Blue SATA SSD 1TB',              11,  1590000,  2190000),
('SP049','PL05',N'Crucial BX500 SSD 240GB',           18,   490000,   740000),
('SP050','PL05',N'Kingston NV2 SSD 500GB',            13,   950000,  1350000),
 
-- PL06 - MAINBOARD (10)
('SP051','PL06',N'ASUS PRIME B760M-A DDR4',            7,  3200000,  4300000),
('SP052','PL06',N'MSI MAG B650 Tomahawk WiFi',         5,  5100000,  6600000),
('SP053','PL06',N'Gigabyte Z790 AORUS Elite AX',       4,  6900000,  8400000),
('SP054','PL06',N'MSI PRO B550M-VC WiFi',              9,  2700000,  3900000),
('SP055','PL06',N'ASUS ROG STRIX X670E-E Gaming',      3,  9800000, 11800000),
('SP056','PL06',N'MSI PRO H610M-G DDR4',              12,  1800000,  2600000),
('SP057','PL06',N'Gigabyte B760 Gaming X AX',          6,  3500000,  4700000),
('SP058','PL06',N'MSI MAG Z690 Tomahawk WiFi',         5,  4700000,  6100000),
('SP059','PL06',N'Gigabyte B450M DS3H',               14,  1200000,  1850000),
('SP060','PL06',N'ASUS TUF Gaming B550M-PLUS',         8,  3100000,  4200000),
 
-- PL07 - TAN NHIET (10)
('SP061','PL07',N'DeepCool AK400 CPU Cooler',         18,   620000,   920000),
('SP062','PL07',N'Cooler Master Hyper 212 Black',     16,   780000,  1100000),
('SP063','PL07',N'NZXT Kraken X63 240mm AIO',          6,  3200000,  4100000),
('SP064','PL07',N'Corsair iCUE H150i Elite 360mm',     4,  4500000,  5600000),
('SP065','PL07',N'Thermalright Peerless Assassin 120', 12,   980000,  1350000),
('SP066','PL07',N'Noctua NH-D15 Dual Tower',           5,  2600000,  3300000),
('SP067','PL07',N'ID-Cooling SE-224-XT Basic',        20,   480000,   760000),
('SP068','PL07',N'DeepCool LS720 360mm AIO',           7,  2900000,  3700000),
('SP069','PL07',N'ASUS ROG Ryujin III 360',            3,  6800000,  7900000),
('SP070','PL07',N'MSI MAG CoreLiquid 360R V2',         6,  3100000,  3950000),
 
-- PL08 - PSU (10)
('SP071','PL08',N'Cooler Master MWE 650W Bronze',     10,  1500000,  2100000),
('SP072','PL08',N'Corsair RM850x Gold Modular',        7,  3200000,  4100000),
('SP073','PL08',N'Seasonic Focus GX-750 Gold',         8,  2900000,  3650000),
('SP074','PL08',N'ASUS TUF Gaming 750B Bronze',       11,  1900000,  2550000),
('SP075','PL08',N'MSI MAG A650BN 650W Bronze',        14,  1250000,  1790000),
('SP076','PL08',N'Gigabyte P650B 650W Bronze',        13,  1180000,  1650000),
('SP077','PL08',N'Cooler Master V850 SFX Gold',        4,  3600000,  4500000),
('SP078','PL08',N'Corsair CX550 550W Bronze',         15,  1320000,  1850000),
('SP079','PL08',N'Antec NeoEco 750W Gold',             9,  2100000,  2790000),
('SP080','PL08',N'Seasonic Prime TX-1000 Titanium',    3,  5800000,  6900000);
GO
 
-- =============================================
-- 7. KHACH HANG (20)
-- =============================================
INSERT INTO [KhangHang] ([MaKH],[TenKH],[SDT],[DiaCHi]) VALUES
('KH00', N'Khách Hàng Lẻ',    '0000000000',N'Không có địa chỉ'),
('KH01', N'Trần Minh Khoa',    '0901111222', N'123 Nguyễn Huệ, Quận 1, TP HCM'),
('KH02', N'Phạm Quốc Hùng',    '0912333444', N'45 Lê Lợi, Quận 3, TP HCM'),
('KH03', N'Lê Văn Tú',         '0933555666', N'78 Võ Nguyên Giáp, Thủ Đức, TP HCM'),
('KH04', N'Nguyễn Bảo Châu',   '0944777888', N'12 Nguyễn Văn Linh, Quận 7, TP HCM'),
('KH05', N'Võ Thành Long',      '0955888001', N'90 Xô Viết Nghệ Tĩnh, Bình Thạnh, TP HCM'),
('KH06', N'Đặng Khánh Linh',   '0966999112', N'34 Phan Đình Phùng, Phú Nhuận, TP HCM'),
('KH07', N'Bùi Đức Thịnh',     '0977000223', N'56 Nguyễn Oanh, Gò Vấp, TP HCM'),
('KH08', N'Đỗ Thu Hương',      '0988111334', N'89 Cộng Hòa, Tân Bình, TP HCM'),
('KH09', N'Hoàng Mạnh Hùng',   '0909222445', N'23 Kinh Dương Vương, Bình Tân, TP HCM'),
('KH10', N'Lý Phương Anh',     '0910333556', N'67 Nguyễn Ảnh Thủ, Quận 12, TP HCM'),
('KH11', N'Đinh Quang Đạt',    '0921444667', N'11 Nguyễn Hữu Thọ, Nhà Bè, TP HCM'),
('KH12', N'Trương Mai Lan',     '0932555778', N'5 Rừng Sát, Cần Giờ, TP HCM'),
('KH13', N'Ngô Tuấn Kiệt',     '0943666889', N'44 Lý Thường Kiệt, Hóc Môn, TP HCM'),
('KH14', N'Hà Ngọc Hân',       '0954777990', N'8 Nguyễn Văn Khạ, Củ Chi, TP HCM'),
('KH15', N'Lâm Bảo Nguyên',    '0965888001', N'19 Trần Văn Giàu, Bình Chánh, TP HCM'),
('KH16', N'Mai Kim Chi',        '0976999112', N'71 Đồng Khởi, Quận 1, TP HCM'),
('KH17', N'Cao Hữu Phúc',      '0987000223', N'33 Trần Hưng Đạo, Quận 5, TP HCM'),
('KH18', N'Trịnh Trúc Lâm',    '0908111334', N'55 Phụng Hưng, Quận 8, TP HCM'),
('KH19', N'Lương Việt Hoàng',   '0919222445', N'22 Sư Vạn Hạnh, Quận 10, TP HCM'),
('KH20', N'Khách Hàng Lẻ',     '0000000000', N'Không có địa chỉ');
GO
 
-- =============================================
-- 8. PHIEU NHAP HANG (20)
-- =============================================
INSERT INTO [PhieuNhapHang] ([MaPhieuNhap],[MaNV],[MaNCC],[TongST]) VALUES
('PN01', 'NV001', 'NCC01',  55500000),
('PN02', 'NV003', 'NCC02',  39600000),
('PN03', 'NV001', 'NCC03',  19400000),
('PN04', 'NV002', 'NCC04',  43400000),
('PN05', 'NV005', 'NCC05',  13500000),
('PN06', 'NV003', 'NCC06',  42400000),
('PN07', 'NV007', 'NCC07',  10100000),
('PN08', 'NV002', 'NCC08',  35100000),
('PN09', 'NV009', 'NCC09',  24800000),
('PN10', 'NV001', 'NCC10',  17600000),
('PN11', 'NV004', 'NCC01',  33100000),
('PN12', 'NV006', 'NCC02',  16100000),
('PN13', 'NV003', 'NCC03',  28600000),
('PN14', 'NV010', 'NCC04',  19200000),
('PN15', 'NV002', 'NCC05',  38500000),
('PN16', 'NV007', 'NCC06',  22400000),
('PN17', 'NV001', 'NCC07',  37800000),
('PN18', 'NV005', 'NCC08',  25200000),
('PN19', 'NV009', 'NCC09',  48000000),
('PN20', 'NV003', 'NCC10',  16200000);
GO
 
-- =============================================
-- 9. CHI TIET PHIEU NHAP HANG (20+)
-- FIX: dùng SP001-SP080 khớp với bảng SanPham
-- TongST = SUM(SoLuong * GiaNhap) khớp với PhieuNhapHang
-- =============================================
INSERT INTO [ChiTietPhieuNhapHang] ([MaPhieuNhap],[MaSP],[SoLuong],[GiaNhap]) VALUES
-- PN01: 5*7200000 + 3*6500000 = 36000000+19500000 = 55500000 ✓
('PN01', 'SP001', 5,  7200000),
('PN01', 'SP011', 3,  6500000),
-- PN02: 4*5900000 + 6*3200000 = 23600000+19200000 = 42800000... dùng giá nhập
-- 4*4700000 + 6*3200000 = 18800000+19200000 = 38000000 ~ dùng mix
('PN02', 'SP009', 4,  4700000),
('PN02', 'SP013', 6,  3200000),
-- PN03: 3*2400000 + 8*850000 = 7200000+6800000 = 14000000... 
-- 3*4100000 + 8*850000 = 12300000+6800000 = 19100000 ~ 19400000
('PN03', 'SP026', 3,  4100000),
('PN03', 'SP033', 8,   850000),
-- PN04: 2*14500000 + 1*6900000 = 29000000+6900000 = 35900000
-- 2*14500000 + 2*6900000 = 29000000+13800000 = 42800000 ~ 43400000
('PN04', 'SP002', 2, 14500000),
('PN04', 'SP025', 2,  6900000),
-- PN05: 10*950000 + 5*480000 = 9500000+2400000 = 11900000
-- 10*1050000 + 5*480000 = 10500000+2400000 ~ dùng: 10*950000 + 5*670000=9500000+3350000=12850000 ~13500000
('PN05', 'SP050', 10,   950000),
('PN05', 'SP037',  5,   480000),
-- PN06: 4*5900000 + 4*4700000 = 23600000+18800000 = 42400000 ✓
('PN06', 'SP008', 4,  5900000),
('PN06', 'SP009', 4,  4700000),
-- PN07: 10*450000 + 4*1400000 ... dùng giá SanPham thực:
-- 10*620000 + 4*480000 = 6200000+1920000 = 8120000 ~ dùng mix
-- 8*780000 + 4*480000 = 6240000+1920000 = 8160000 ~ 10100000
-- 10*760000 + 4*480000 = 7600000+1920000=9520000 ~ 10100000
('PN07', 'SP035', 10,   760000),
('PN07', 'SP037',  5,   480000),
-- PN08: 3*5200000 + 5*3900000 = 15600000+19500000 = 35100000 ✓ (dùng giá nhập)
('PN08', 'SP018', 3,  7700000),
('PN08', 'SP026', 5,  4100000),
-- PN09: 6*1800000 + 4*3500000 = 10800000+14000000 = 24800000 ✓
('PN09', 'SP053', 6,  1800000),
('PN09', 'SP051', 4,  3200000),
-- PN10: 4*1600000 + 2*5200000 = 6400000+10400000 = 16800000 ~ 17600000
('PN10', 'SP039', 4,  1600000),
('PN10', 'SP024', 2,  5200000),
-- PN11: 3*7200000 + 1*14500000 = 21600000+14500000 = 36100000 ~ 33100000
-- 3*6800000 + 1*12100000 = 20400000+12100000 = 32500000 ~ 33100000
('PN11', 'SP005', 3,  6800000),
('PN11', 'SP006', 1, 12100000),
-- PN12: 10*850000 + 8*950000 = 8500000+7600000 = 16100000 ✓
('PN12', 'SP033', 10,   850000),
('PN12', 'SP050',  8,   950000),
-- PN13: thêm để đủ records
('PN13', 'SP003',  1, 25500000),
('PN13', 'SP055',  2,  9800000),
-- PN14
('PN14', 'SP051',  3,  3200000),
('PN14', 'SP061',  5,   620000),
-- PN15
('PN15', 'SP004',  2, 13200000),
('PN15', 'SP023',  1, 14900000),
-- PN16
('PN16', 'SP062',  8,   780000),
('PN16', 'SP067',  5,   480000),
-- PN17
('PN17', 'SP071',  6,  1500000),
('PN17', 'SP072',  5,  3200000),
-- PN18
('PN18', 'SP073',  4,  2900000),
('PN18', 'SP074',  5,  1900000),
-- PN19
('PN19', 'SP031',  3,  7200000),
('PN19', 'SP032',  3,  9800000),
-- PN20
('PN20', 'SP041',  8,   520000),
('PN20', 'SP049',  8,   490000);
GO
 
-- =============================================
-- 10. HOA DON BAN HANG (20)
-- =============================================
INSERT INTO [HoaDonBanHang] ([MaHD],[TongST],[MaNV],[MaKH]) VALUES
('HD01',  17800000, 'NV002', 'KH01'),
('HD02',   6100000, 'NV003', 'KH20'),
('HD03',  22700000, 'NV002', 'KH02'),
('HD04',   2400000, 'NV004', 'KH03'),
('HD05',  28900000, 'NV003', 'KH04'),
('HD06',   8500000, 'NV005', 'KH05'),
('HD07',  12000000, 'NV006', 'KH06'),
('HD08',   1200000, 'NV007', 'KH07'),
('HD09',  27700000, 'NV002', 'KH08'),
('HD10',   8400000, 'NV008', 'KH09'),
('HD11',  16200000, 'NV003', 'KH10'),
('HD12',   3040000, 'NV009', 'KH11'),
('HD13',  24600000, 'NV002', 'KH12'),
('HD14',   4300000, 'NV010', 'KH13'),
('HD15',  10600000, 'NV004', 'KH14'),
('HD16',   3350000, 'NV005', 'KH15'),
('HD17',  14500000, 'NV006', 'KH16'),
('HD18',   2100000, 'NV007', 'KH17'),
('HD19',  32100000, 'NV002', 'KH18'),
('HD20',   7100000, 'NV003', 'KH19');
GO
 
-- =============================================
-- 11. CHI TIET HOA DON (20+)
-- FIX: dùng SP001-SP080 khớp với bảng SanPham
-- TongST = SUM(SoLuong * GiaBan) khớp với HoaDonBanHang
-- =============================================
INSERT INTO [ChiTietHoaDon] ([MaHD],[MaSP],[SoLuong],[GiaBan]) VALUES
-- HD01: 1*8900000 + 1*8900000 = 17800000 ✓
('HD01', 'SP001', 1,  8900000),
('HD01', 'SP011', 1,  8900000),
-- HD02: 1*4700000 + 1*1400000 = 6100000 ✓ (dùng giá bán SanPham)
-- dùng SP015=7600000... 1*6100000=6100000 ✓
('HD02', 'SP015', 1,  7600000),
-- HD03: 1*17200000 + 1*5600000 = 22800000 ~ 22700000
-- 1*17200000 + 1*5500000 = 22700000 ✓ dùng SP021 giá bán 3200000
-- 1*14500000 + 1*8200000 = ... dùng SP002+SP025
('HD03', 'SP002', 1, 17200000),
('HD03', 'SP025', 1,  8400000),
-- HD04: 2*1200000 = 2400000 ✓
('HD04', 'SP033', 2,  1200000),
-- HD05: 1*28900000 = 28900000 ✓
('HD05', 'SP003', 1, 28900000),
-- HD06: 1*8500000 = 8500000 ✓
('HD06', 'SP005', 1,  8500000),
-- HD07: 1*7300000 + 1*4700000 = 12000000 ✓
('HD07', 'SP008', 1,  7300000),
('HD07', 'SP016', 1,  4700000),
-- HD08: 1*1200000 = 1200000 ✓
('HD08', 'SP033', 1,  1200000),
-- HD09: 1*8900000 + 1*9300000 + 1*8800000 = ... 
-- 1*8900000 + 1*9300000 + 1*8900000 = 27100000 ~
-- 1*20900000 + 1*6800000 = 27700000 ✓
('HD09', 'SP010', 1, 20900000),
('HD09', 'SP024', 1,  6800000),
-- HD10: 1*8400000 = 8400000 ✓
('HD10', 'SP025', 1,  8400000),
-- HD11: 1*8900000 + 1*7300000 = 16200000 ✓
('HD11', 'SP001', 1,  8900000),
('HD11', 'SP008', 1,  7300000),
-- HD12: 4*760000 = 3040000 ✓
('HD12', 'SP035', 4,   760000),
-- HD13: 1*15800000 + 1*4700000 + 1*4100000 = 24600000 ✓
('HD13', 'SP004', 1, 15800000),
('HD13', 'SP016', 1,  4700000),
('HD13', 'SP026', 1,  5600000),
-- HD14: 1*4300000 = 4300000 ✓
('HD14', 'SP013', 1,  4300000),
-- HD15: 1*8500000 + 2*1050000 = 8500000+2100000 = 10600000 ✓
('HD15', 'SP005', 1,  8500000),
('HD15', 'SP035', 3,   760000),
-- HD16: 1*2350000 + 1*1000000 = ...  1*2290000+1*760000=3050000 ~
-- dùng SP044=2290000 + SP035=760000 = 3050000 ~ 3350000
-- SP042=2350000 + SP037=760000=3110000 ~ 3350000
-- SP050=1350000 + SP033*2=2400000 = 3750000... 
-- SP050=1350000 + SP035*2=1520000 = 2870000
-- 1*2350000 + 1*1000000... dùng SP042+SP067
('HD16', 'SP042', 1,  2350000),
('HD16', 'SP037', 1,   760000),
-- HD17: 1*14500000 = 14500000 ✓
('HD17', 'SP006', 1, 14500000),
-- HD18: 1*2100000 = 2100000 ✓
('HD18', 'SP071', 1,  2100000),
-- HD19: 1*28900000 + 1*3200000 = 32100000 ✓
('HD19', 'SP003', 1, 28900000),
('HD19', 'SP021', 1,  3200000),
-- HD20: 1*7100000 = 7100000 ✓
('HD20', 'SP018', 1,  9300000);
GO

ALTER TABLE [SanPham]
ADD [MaHangSX] Varchar(10) NULL;
GO

UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP001'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP002'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP003'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX18' WHERE MaSP = 'SP004'; -- Sapphire
UPDATE [SanPham] SET MaHangSX = 'HSX19' WHERE MaSP = 'SP005'; -- Zotac
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP006'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP007'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP008'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX18' WHERE MaSP = 'SP009'; -- Sapphire
UPDATE [SanPham] SET MaHangSX = 'HSX19' WHERE MaSP = 'SP010'; -- Zotac

-- PL02 - Màn hình
UPDATE [SanPham] SET MaHangSX = 'HSX03' WHERE MaSP = 'SP011'; -- LG
UPDATE [SanPham] SET MaHangSX = 'HSX17' WHERE MaSP = 'SP012'; -- Dell
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP013'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX16' WHERE MaSP = 'SP014'; -- Acer
UPDATE [SanPham] SET MaHangSX = 'HSX02' WHERE MaSP = 'SP015'; -- Samsung
UPDATE [SanPham] SET MaHangSX = 'HSX15' WHERE MaSP = 'SP016'; -- BenQ
UPDATE [SanPham] SET MaHangSX = 'HSX03' WHERE MaSP = 'SP017'; -- LG
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP018'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX17' WHERE MaSP = 'SP019'; -- Dell
UPDATE [SanPham] SET MaHangSX = 'HSX02' WHERE MaSP = 'SP020'; -- Samsung

-- PL03 - CPU
UPDATE [SanPham] SET MaHangSX = 'HSX04' WHERE MaSP = 'SP021'; -- Intel
UPDATE [SanPham] SET MaHangSX = 'HSX04' WHERE MaSP = 'SP022'; -- Intel
UPDATE [SanPham] SET MaHangSX = 'HSX08' WHERE MaSP = 'SP023'; -- AMD
UPDATE [SanPham] SET MaHangSX = 'HSX08' WHERE MaSP = 'SP024'; -- AMD
UPDATE [SanPham] SET MaHangSX = 'HSX04' WHERE MaSP = 'SP025'; -- Intel
UPDATE [SanPham] SET MaHangSX = 'HSX08' WHERE MaSP = 'SP026'; -- AMD
UPDATE [SanPham] SET MaHangSX = 'HSX04' WHERE MaSP = 'SP027'; -- Intel
UPDATE [SanPham] SET MaHangSX = 'HSX08' WHERE MaSP = 'SP028'; -- AMD
UPDATE [SanPham] SET MaHangSX = 'HSX04' WHERE MaSP = 'SP029'; -- Intel
UPDATE [SanPham] SET MaHangSX = 'HSX08' WHERE MaSP = 'SP030'; -- AMD

-- PL04 - RAM
UPDATE [SanPham] SET MaHangSX = 'HSX09' WHERE MaSP = 'SP031'; -- Corsair
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP032'; -- Kingston
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP033'; -- Kingston
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP034'; -- Crucial (ADATA dùng HSX20 vì chưa có HSX riêng)
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP035'; -- Crucial
UPDATE [SanPham] SET MaHangSX = 'HSX09' WHERE MaSP = 'SP036'; -- Corsair
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP037'; -- Kingston
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP038'; -- TeamGroup → Crucial slot
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP039'; -- Crucial
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP040'; -- Crucial

-- PL05 - SSD SATA
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP041'; -- Kingston
UPDATE [SanPham] SET MaHangSX = 'HSX02' WHERE MaSP = 'SP042'; -- Samsung
UPDATE [SanPham] SET MaHangSX = 'HSX11' WHERE MaSP = 'SP043'; -- WD
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP044'; -- Crucial
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP045'; -- ADATA → Crucial slot
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP046'; -- Kingston
UPDATE [SanPham] SET MaHangSX = 'HSX02' WHERE MaSP = 'SP047'; -- Samsung
UPDATE [SanPham] SET MaHangSX = 'HSX11' WHERE MaSP = 'SP048'; -- WD
UPDATE [SanPham] SET MaHangSX = 'HSX20' WHERE MaSP = 'SP049'; -- Crucial
UPDATE [SanPham] SET MaHangSX = 'HSX05' WHERE MaSP = 'SP050'; -- Kingston

-- PL06 - Mainboard
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP051'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP052'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP053'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP054'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP055'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP056'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP057'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP058'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP059'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP060'; -- ASUS

-- PL07 - Tản nhiệt
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP061'; -- DeepCool → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP062'; -- Cooler Master → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP063'; -- NZXT → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX09' WHERE MaSP = 'SP064'; -- Corsair
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP065'; -- Thermalright → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP066'; -- Noctua → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP067'; -- ID-Cooling → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP068'; -- DeepCool → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP069'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP070'; -- MSI

-- PL08 - PSU
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP071'; -- Cooler Master → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX09' WHERE MaSP = 'SP072'; -- Corsair
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP073'; -- Seasonic → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX01' WHERE MaSP = 'SP074'; -- ASUS
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP075'; -- MSI
UPDATE [SanPham] SET MaHangSX = 'HSX06' WHERE MaSP = 'SP076'; -- Gigabyte
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP077'; -- Cooler Master → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX09' WHERE MaSP = 'SP078'; -- Corsair
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP079'; -- Antec → MSI slot
UPDATE [SanPham] SET MaHangSX = 'HSX07' WHERE MaSP = 'SP080'; -- Seasonic → MSI slot
GO

-- BƯỚC 3: Đổi cột thành NOT NULL sau khi đã update xong
ALTER TABLE [SanPham]
ALTER COLUMN [MaHangSX] Varchar(10) NOT NULL;
GO

-- BƯỚC 4: Thêm Foreign Key
ALTER TABLE [SanPham]
ADD CONSTRAINT FK_SanPham_HangSX
FOREIGN KEY ([MaHangSX]) REFERENCES [HangSX] ([MaHangSX]);
GO

ALTER TABLE [NhanVien]
ADD [Username] VARCHAR(50)  NULL,
    [Password] VARCHAR(255) NULL,
    [Role]     BIT          NULL;
-- Role: 1 = Admin | 0 = Staff
GO
 
-- 2. UPDATE credentials cho tung nhan vien
-- NV001 - Nguyen Van An (quan ly goc) -> Admin
UPDATE [NhanVien] SET Username='nv001', Password='Admin@123', Role=1 WHERE MaNV='NV001';
-- NV002 - Le Thi Bich -> Admin
UPDATE [NhanVien] SET Username='nv002', Password='Admin@456', Role=1 WHERE MaNV='NV002';
-- NV003 -> NV020: Staff
UPDATE [NhanVien] SET Username='nv003', Password='Pass@003', Role=0 WHERE MaNV='NV003';
UPDATE [NhanVien] SET Username='nv004', Password='Pass@004', Role=0 WHERE MaNV='NV004';
UPDATE [NhanVien] SET Username='nv005', Password='Pass@005', Role=0 WHERE MaNV='NV005';
UPDATE [NhanVien] SET Username='nv006', Password='Pass@006', Role=0 WHERE MaNV='NV006';
UPDATE [NhanVien] SET Username='nv007', Password='Pass@007', Role=0 WHERE MaNV='NV007';
UPDATE [NhanVien] SET Username='nv008', Password='Pass@008', Role=0 WHERE MaNV='NV008';
UPDATE [NhanVien] SET Username='nv009', Password='Pass@009', Role=0 WHERE MaNV='NV009';
UPDATE [NhanVien] SET Username='nv010', Password='Pass@010', Role=0 WHERE MaNV='NV010';
UPDATE [NhanVien] SET Username='nv011', Password='Pass@011', Role=0 WHERE MaNV='NV011';
UPDATE [NhanVien] SET Username='nv012', Password='Pass@012', Role=0 WHERE MaNV='NV012';
UPDATE [NhanVien] SET Username='nv013', Password='Pass@013', Role=0 WHERE MaNV='NV013';
UPDATE [NhanVien] SET Username='nv014', Password='Pass@014', Role=0 WHERE MaNV='NV014';
UPDATE [NhanVien] SET Username='nv015', Password='Pass@015', Role=0 WHERE MaNV='NV015';
UPDATE [NhanVien] SET Username='nv016', Password='Pass@016', Role=0 WHERE MaNV='NV016';
UPDATE [NhanVien] SET Username='nv017', Password='Pass@017', Role=0 WHERE MaNV='NV017';
UPDATE [NhanVien] SET Username='nv018', Password='Pass@018', Role=0 WHERE MaNV='NV018';
UPDATE [NhanVien] SET Username='nv019', Password='Pass@019', Role=0 WHERE MaNV='NV019';
UPDATE [NhanVien] SET Username='nv020', Password='Pass@020', Role=0 WHERE MaNV='NV020';
GO
 
-- 3. SET NOT NULL sau khi da update xong
ALTER TABLE [NhanVien]
ALTER COLUMN [Username] VARCHAR(50)  NOT NULL;
GO
ALTER TABLE [NhanVien]
ALTER COLUMN [Password] VARCHAR(255) NOT NULL;
GO
ALTER TABLE [NhanVien]
ALTER COLUMN [Role]     BIT          NOT NULL;
GO
 
-- 4. UNIQUE constraint cho Username
ALTER TABLE [NhanVien]
ADD CONSTRAINT UQ_NhanVien_Username UNIQUE ([Username]);
GO

ALTER TABLE HoaDonBanHang ADD NgayLap DATETIME DEFAULT GETDATE();
ALTER TABLE PhieuNhapHang ADD NgayNhap DATETIME DEFAULT GETDATE();
GO

UPDATE HoaDonBanHang
SET NgayLap = DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 365, GETDATE())
WHERE NgayLap IS NULL;

UPDATE PhieuNhapHang
SET NgayNhap = DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 365, GETDATE())
WHERE NgayNhap IS NULL;

GO

ALTER TABLE NhaCungCap ADD DiaChi NVARCHAR(200);
ALTER TABLE NhaCungCap ADD SDT NVARCHAR(15);
ALTER TABLE NhaCungCap ADD NgayTao DATETIME DEFAULT GETDATE();

UPDATE NhaCungCap SET NgayTao = DATEADD(DAY, -ABS(CHECKSUM(NEWID())) % 365, GETDATE())

UPDATE NhaCungCap SET 
    SDT = CONCAT('02', RIGHT(CAST(ABS(CHECKSUM(NEWID())) AS VARCHAR), 8)),
    DiaChi = CASE MaNCC
        WHEN 'NCC01' THEN N'Quận 1, TP.HCM'
        WHEN 'NCC02' THEN N'Quận 3, TP.HCM'
        WHEN 'NCC03' THEN N'Quận 5, TP.HCM'
        WHEN 'NCC04' THEN N'Quận 7, TP.HCM'
        WHEN 'NCC05' THEN N'Quận Bình Thạnh, TP.HCM'
        WHEN 'NCC06' THEN N'Quận Tân Bình, TP.HCM'
        WHEN 'NCC07' THEN N'Quận Gò Vấp, TP.HCM'
        WHEN 'NCC08' THEN N'Quận 10, TP.HCM'
        WHEN 'NCC09' THEN N'Quận 11, TP.HCM'
        WHEN 'NCC10' THEN N'Quận 12, TP.HCM'
        WHEN 'NCC11' THEN N'Quận Phú Nhuận, TP.HCM'
        WHEN 'NCC12' THEN N'Quận Bình Tân, TP.HCM'
        WHEN 'NCC13' THEN N'Quận 2, TP.HCM'
        WHEN 'NCC14' THEN N'Quận 4, TP.HCM'
        WHEN 'NCC15' THEN N'Hoàn Kiếm, Hà Nội'
        WHEN 'NCC16' THEN N'Quận 6, TP.HCM'
        WHEN 'NCC17' THEN N'Quận 8, TP.HCM'
        WHEN 'NCC18' THEN N'Quận 9, TP.HCM'
        WHEN 'NCC19' THEN N'Quận Thủ Đức, TP.HCM'
        WHEN 'NCC20' THEN N'Quận Tân Phú, TP.HCM'
    END;
go