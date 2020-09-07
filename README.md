# ATBM
Đồ án An toàn bảo mật Hệ thống thông tin

Ngôn ngữ sử dụng: Oracle + Winform C#
Quy mô thành viên: 2 thành viên.
Nội dung:
    PHÂN HỆ 1: DÀNH CHO NGƯỜI QUẢN TRỊ NGƯỜI DÙNG VÀ ĐIỀU KHIỂN TRUY
    CẬP
    Sinh viên hãy xây dựng ứng dụng cho phép các người dùng có quyền quản trị thực hiện công việc
    sau:
    - Xem danh sách người dùng trong hệ thống.
    - Thông tin về quyền (privileges) của mỗi user/ role trên các đối tượng dữ liệu.
    - Cho phép tạo mới, xóa, sửa (hiệu chỉnh) user hoặc role.
    - Cho phép thực hiện việc cấp quyền: cấp quyền cho user, cấp quyền cho role, cấp role
    cho user. Quá trình cấp quyền có tùy chọn là có cho phép người được cấp quyền có thể
    cấp quyền đó cho user/ role khác hay không (có chỉ định WITH GRANT OPTION hay
    không). Quyền, select, update thì cho phép phân quyền tinh đến mức cột; quyền insert,
    delete thì không.
    - Cho phép thu hồi quyền từ người dùng/ role.
    - Cho phép kiểm tra quyền của các chủ thể vừa được cấp quyền.
    - Cho phép chỉnh sửa quyền của user/ role.
    Sinh viên hãy thực hiện chức năng ghi nhật ký hệ thống (chỉ yêu cầu thực hiện mức HQT CSDL
    Oracle):
    - Admin có quyền enable/ disable việc ghi nhật ký toàn hệ thống.
    - Admin được chỉ định ghi nhật ký của những hành động thực hiện bởi những user nào
    trên những đối tượng cụ thể. Các hành động đó là: đăng nhập, thay đổi thông tin user
    account, select, insert, update, delete, execute.; các đối tượng là table, view, stored
    procedure, function. Admin cũng được quyền chọn ghi nhật ký hành động được thực
    hiện thành công hay không thành công.
    - Kiểm tra dữ liệu nhật ký hệ thống. Sinh viên nên đề ra một số kịch bản theo dõi hệ thống
    để phân tích dữ liệu nhật ký.
   
    PHÂN HỆ 2: ỨNG DỤNG QUẢN LÝ QUÁ TRÌNH BÌNH BẦU TÍN NHIỆM
    Để quản lý quá trính bình bầu tín nhiệm trong một tổ chức ABC, người ta xây dựng ứng dụng gồm
    có các vai trò sau: ban tổ chức bình bầu, người đi bầu, tổ lập danh sách người đi bầu, tổ theo dõi
    kết quả bình bầu và tổ giám sát.
    Trưởng ban tổ chức bình bầu nhập vào danh sách ứng cử viên. Danh sách những người bình bầu
    được lập ra bởi những người thuộc tổ lập danh sách người đi bầu, là kết quả của việc lọc từ danh
    sách các thành viên của tổ chức ABC thỏa điều kiện là những người hiện tại đang công tác để loại
    trừ những người vắng mặt vì lý do đang đi công tác xa hoặc tạm nghỉ việc vì lý do nào đó. Dữ liệu
    về các thành viên trong tổ chức ABC đã được lưu trữ gồm họ tên, phái, quê quán, ngày sinh, quốc
    tịch, địa chỉ thường trú, địa chỉ tạm trú. Mỗi người đi bầu phải chọn 3 trong 5 người ứng viên. Nếu
    vi phạm nguyên tắc này thì lần bình bầu của người đó được xem là không hợp lệ và không được
    tính trong kết quả. Một người có thể bình bầu nhiểu lần nhưng kết quả chỉ dựa trên lần bình bầu
    cuối cùng của người đó. Sau đây là các chính sách về quyền trong ứng dụng trên:
     Người thuộc ban tổ chức bình bầu chỉ có thể xem, xóa, sửa thông tin trong danh sách ứng
    cử viên, những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám
    sát.
     Mỗi người thuộc tổ lập danh sách người đi bầu chỉ có thể lọc ra danh sách những người đi
    bầu mà không nhìn thấy thông tin liên quan đến một thành viên nào đó đang công tác ở
    đâu, tạm nghỉ việc vì lý do gì. Mỗi người trong tổ này chỉ chịu trách nhiệm lập danh sách
    người đi bầu của 1 đơn vị mà người đó phụ trách.
     Tổ theo dõi kết quả được xem danh sách tất cả những người đi bầu thuộc tất cả các đơn vị
    và chỉ có thể biết được ai trong danh sách những người đi bầu đã hoặc chưa đi bầu, tuy
    nhiên họ không biết được mỗi người đã bình bầu cho những ứng viên nào. Những người
    này có thể theo dõi số lần bình bầu cho từng ứng cử viên.
     Bộ phận giám sát được toàn quyền xem thông tin trên ứng dụng, nhưng không được thay
    đổi bất cứ thông tin gì. 
