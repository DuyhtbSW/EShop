# Advanced Shop

## Giới thiệu
Advanced Shop là một ứng dụng thương mại điện tử mạnh mẽ được xây dựng bằng .NET và SQL Server. Ứng dụng này cho phép người dùng duyệt sản phẩm, thêm sản phẩm vào giỏ hàng, và thực hiện thanh toán một cách dễ dàng. Dự án được triển khai trên Azure, giúp đảm bảo tính khả dụng và mở rộng.
![image](https://github.com/user-attachments/assets/cbca336b-96a9-47d8-ad0a-d11563275f6e)

## Tính năng
- **Quản lý sản phẩm**: Thêm, sửa, xóa và xem danh sách sản phẩm.
- **Giỏ hàng**: Người dùng có thể thêm sản phẩm vào giỏ và thực hiện thanh toán.
- ![image](https://github.com/user-attachments/assets/8eb4f1a0-cc92-402f-af70-657b7f7fa874)

- **Đăng nhập người dùng**: Hệ thống hỗ trợ đăng ký và đăng nhập cho người dùng.
- **Tìm kiếm sản phẩm**: Tìm kiếm nhanh chóng theo tên sản phẩm hoặc danh mục.
- **Triển khai trên Azure**: Ứng dụng được triển khai trên nền tảng Azure, đảm bảo hiệu suất cao và khả năng mở rộng.

## Công nghệ sử dụng
- **Backend**: .NET (ASP.NET Core)
- **Cơ sở dữ liệu**: SQL Server
- **Triển khai**: Azure App Service
- **Frontend**: HTML, CSS, JavaScript (có thể sử dụng các framework như React hoặc Angular)

## Hướng dẫn cài đặt

### Yêu cầu
- .NET SDK
- SQL Server
- Tài khoản Azure

### Cài đặt
1. **Clone repository**:
   ```bash
   git clone https://github.com/DuyhtbSW/EShop
   ```

2. **Cài đặt các gói NuGet**:
   ```bash
   cd advanced-shop
   dotnet restore
   ```

3. **Cấu hình cơ sở dữ liệu**:
   - Tạo cơ sở dữ liệu SQL Server và cập nhật chuỗi kết nối trong file `appsettings.json`.

4. **Chạy ứng dụng**:
   ```bash
   dotnet run
   ```

## Triển khai trên Azure
1. Đăng nhập vào tài khoản Azure của bạn.
2. Tạo một Azure App Service mới.
3. Triển khai ứng dụng bằng cách sử dụng Azure DevOps hoặc GitHub Actions.

## Đóng góp
Chúng tôi hoan nghênh mọi đóng góp! Vui lòng tạo một pull request hoặc mở issue để thảo luận về các thay đổi bạn muốn thực hiện.

## Liên hệ
Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua email: duyhtbsw@gmail.com

## Giấy phép
Dự án này được cấp phép theo [MIT License](LICENSE).
