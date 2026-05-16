# Quản Lý Bán Hàng Điện Tử — Hướng dẫn cài đặt môi trường

Hướng dẫn này giúp bạn dựng môi trường SQL Server bằng Docker và nạp dữ liệu mẫu vào database `quanlybanhangdientu` để chạy ứng dụng WinForms.

---

## Yêu cầu

| Phần mềm | Ghi chú |
|---|---|
| [Docker Desktop](https://www.docker.com/products/docker-desktop) | Windows / macOS / Linux |
| [Azure Data Studio](https://aka.ms/azuredatastudio) hoặc SSMS | Để chạy script SQL |
| RAM tối thiểu | 4 GB (SQL Server container cần ≥ 2 GB) |

> **Windows:** Bật WSL 2 trong Docker Desktop → Settings → Resources → WSL Integration

---

## 🚀 Các bước thực hiện

### Bước 1 — Pull image SQL Server 2022

Mở Terminal (PowerShell / CMD / bash) và chạy:

```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
```

Chờ đến khi thấy: `Status: Downloaded newer image`

---

### Bước 2 — Tạo và chạy container

**Windows (PowerShell / CMD):**

```powershell
docker run -e "ACCEPT_EULA=Y" `
  -e "MSSQL_SA_PASSWORD=Mssql123456" `
  -p 1433:1433 `
  --name sqlserver_quanlybanhang `
  -d mcr.microsoft.com/mssql/server:2022-latest
```

---

### Bước 3 — Kiểm tra container đang chạy

```bash
docker ps
```

Kết quả mong đợi: thấy dòng có `sqlserver_quanlybanhang` với status `Up`.

Nếu container bị exit, xem log để tìm lỗi:

```bash
docker logs sqlserver_quanlybanhang
```

---

### Bước 4 — Kết nối vào SQL Server

Mở **Sql Service Management System**, tạo kết nối mới với thông tin sau:

| Trường | Giá trị |
|---|---|
| Server / Host | `localhost` |
| Port | `1433` |
| Authentication | `SQL Server Authentication` |
| Username | `sa` |
| Password | `Mssql123456` |
| Trust server certificate | ✅ Tích vào |

---

### Bước 5 — Chạy script SQL

Mở file **`DDL.sql`** trong Azure Data Studio / SSMS và nhấn **Run** (F5).

Script sẽ tự động thực hiện theo thứ tự:
1. Tạo database `quanlybanhangdientu`
2. Tạo 11 bảng với khóa chính và khóa ngoại
3. Insert dữ liệu mẫu (≥ 20 bản ghi mỗi bảng)
4. Thêm cột `MaHangSX` vào bảng `SanPham` và tạo FK

> ⚠️ **Quan trọng:** Chạy **toàn bộ file một lần** — không chạy từng đoạn riêng lẻ để tránh lỗi FK.

---

## Cấu hình ứng dụng WinForms

Mở file `App.config` trong project và đảm bảo connection string như sau:

```xml
<connectionStrings>
	<add name="MyDB"
        connectionString="Server=localhost;Database=quanlybanhangdientu;User Id=sa;Password=Mssql123456;"
        providerName="System.Data.SqlClient"/>
</connectionStrings>
```
Chuột phải vào Project → Add Reference → tìm System.Configuration → nhấn tick