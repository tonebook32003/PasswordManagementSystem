CREATE TABLE USERS(
    USERNAME VARCHAR2(10) PRIMARY KEY,
    PASSWORD VARCHAR2(30),
    LOAITAIKHOAN VARCHAR2(20) NOT NULL
)

INSERT INTO USERS VALUES('admin', '123', 'ADMIN');
INSERT INTO USERS VALUES('user1', '123', 'USER');


SELECT * FROM USERS
DROP TABLE USERS