CREATE TABLE GiaoVien2 (
 MaGV varchar(10),
 Ten varchar(100),
 Quequan varchar(255),
 Ngaysinh Date,
 Cmnd varchar(13),
 Email varchar (100),
 SDT varchar (11),
);

INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV01','Tran Ngoc A','Ha Noi', '1982-6-8','67890','TrNgocA@gmail.com','0845671234');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV02','Tran Ngoc B','Ho Chi Minh', '1949-12-5','67891','TrNgocB@gmail.com','0823425657');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV03','Tran Ngoc C','Gia Lai', '1987-2-5','67892','TrNgocC@gmail.com','0844586549');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV04','Tran Ngoc D','Khanh Hoa', '1996-3-8','67893','TrNgocD@gmail.com','0834986745');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV05','Tran Ngoc E','An Giang', '1975-9-2','67894','TrNgocE@gmail.com','0982213777');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV06','Tran Ngoc F','Nghe An', '1992-8-18','67895','TrNgocF@gmail.com','0846513447');
INSERT INTO GiaoVien2 (MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('GV07','Tran Ngoc G','Binh Dinh', '1970-6-20','67896','TrNgocG@gmail.com','0982820820');

select * from GiaoVien2

delete from GiaoVien2
