CREATE TABLE HocSinh2 (
 MaHS varchar(10),
 Ten varchar(100),
 Quequan varchar(255),
 Ngaysinh Date,
 Cmnd varchar(13),
 Email varchar (100),
 SDT varchar (11),
);

INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS01','Nguyen Van A','Ha Noi', '2003-6-8','12345','NgVanA@gmail.com','0845671234');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS02','Nguyen Van B','Ho Chi Minh', '2003-12-5','12346','NgVanB@gmail.com','0823425657');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS03','Nguyen Van C','Dak Lak', '2003-2-5','12347','NgVanC@gmail.com','0844586549');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS04','Nguyen Van D','Dong Thap', '2003-3-8','12348','NgVanD@gmail.com','0834986745');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS05','Nguyen Van E','Can Tho', '2003-9-2','12349','NgVanE@gmail.com','0982213777');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS06','Nguyen Van F','Da Nang', '2003-8-18','12351','NgVanF@gmail.com','0846513447');
INSERT INTO HocSinh2 (MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT)
VALUES ('HS07','Nguyen Van G','Tay Ninh', '2003-6-20','12352','NgVanG@gmail.com','0982820820');

select * from HocSinh2

delete from HocSinh2
