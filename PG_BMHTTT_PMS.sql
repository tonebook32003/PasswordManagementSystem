-- Tạo bảng Users để lưu thông tin người dùng
CREATE TABLE Users (
    user_id NUMBER PRIMARY KEY,
    username VARCHAR2(50) UNIQUE NOT NULL,
    email VARCHAR2(100) UNIQUE NOT NULL,
    master_password VARCHAR2(256) NOT NULL, -- Mật khẩu chính được mã hóa
    salt VARCHAR2(64) NOT NULL, -- Salt cho việc mã hóa
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_login TIMESTAMP
);

ALTER TABLE Users
ADD CONSTRAINT chk_email_format CHECK (REGEXP_LIKE(email, '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$'));

ALTER TABLE Users
ADD CONSTRAINT chk_last_login CHECK (last_login IS NULL OR last_login >= created_date);

-- Tạo sequence cho user_id
CREATE SEQUENCE users_seq START WITH 1 INCREMENT BY 1;

-- Tạo bảng Password_Entries để lưu các mật khẩu của người dùng
CREATE TABLE Password_Entries (
    entry_id NUMBER PRIMARY KEY,
    user_id NUMBER,
    website_name VARCHAR2(100) NOT NULL,
    website_url VARCHAR2(255),
    username_for_site VARCHAR2(100),
    encrypted_password VARCHAR2(512) NOT NULL, -- Mật khẩu được mã hóa
    notes CLOB,
    category VARCHAR2(50),
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_modified TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
);
ALTER TABLE Password_Entries
ADD CONSTRAINT chk_last_modified CHECK (last_modified IS NULL OR last_modified >= created_date);

-- Tạo sequence cho entry_id
CREATE SEQUENCE password_entries_seq START WITH 1 INCREMENT BY 1;

-- Tạo bảng Categories để quản lý các danh mục
CREATE TABLE Categories (
    category_id NUMBER PRIMARY KEY,
    user_id NUMBER,
    category_name VARCHAR2(50) NOT NULL,
    description VARCHAR2(255),
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
);
ALTER TABLE Categories
ADD CONSTRAINT chk_category_name_length CHECK (LENGTH(TRIM(category_name)) BETWEEN 1 AND 100);

-- Tạo sequence cho category_id
CREATE SEQUENCE categories_seq START WITH 1 INCREMENT BY 1;

-- Tạo bảng Login_History để theo dõi lịch sử đăng nhập
CREATE TABLE Login_History (
    history_id NUMBER PRIMARY KEY,
    user_id NUMBER,
    login_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ip_address VARCHAR2(45),
    login_status VARCHAR2(20),
    device_info VARCHAR2(255),
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
);

--=========Xem xét cần thiêt hay không hãy thêm vào ràng buộc

--ALTER TABLE Login_History
--ADD CONSTRAINT chk_login_status CHECK (login_status IN ('SUCCESS', 'FAILURE'));
--
--ALTER TABLE Login_History
--ADD CONSTRAINT chk_ip_address_format CHECK (
--    REGEXP_LIKE(ip_address, '^([0-9]{1,3}\.){3}[0-9]{1,3}$') OR -- IPv4
--    REGEXP_LIKE(ip_address, '^([A-Fa-f0-9]{0,4}:){2,7}[A-Fa-f0-9]{1,4}$') -- IPv6
--);

-- Tạo sequence cho history_id
CREATE SEQUENCE login_history_seq START WITH 1 INCREMENT BY 1;

--=======================================================================================================================
-- Thêm dữ liệu vào bảng Users
INSERT INTO Users (user_id, username, email, master_password, salt) VALUES (users_seq.NEXTVAL, 'thevinh', 'vinh@gmail.com', '123', 'random_salt');
INSERT INTO Users (user_id, username, email, master_password, salt) VALUES (users_seq.NEXTVAL, 'tonsach', 'tonsach@gmail.com', '2209', 'random_salt');

-- Thêm dữ liệu vào bảng Password_Entries
INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category)
VALUES (password_entries_seq.NEXTVAL, 1, 'Facebook', 'https://www.facebook.com', 'vinh_fb', 'encrypted_fb_password', 'My Facebook account', 'Social Media');

INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category)
VALUES (password_entries_seq.NEXTVAL, 2, 'Instagram', 'https://www.instagram.com', 'sachfacbook', 'encrypted_fb_password', 'My Instagram account', 'Social Media');

-- Thêm dữ liệu vào bảng Categories
INSERT INTO Categories (category_id, user_id, category_name, description)
VALUES (categories_seq.NEXTVAL, 1, 'Social Media', 'Các trang mạng xã hội');

-- Thêm dữ liệu vào bảng Login_History
INSERT INTO Login_History (history_id, user_id, ip_address, login_status, device_info)
VALUES (login_history_seq.NEXTVAL, 1, '192.168.1.1', 'Success', 'Chrome on Windows');
--=========================================================================================================================

--================INSERT User ============================
INSERT INTO Users (user_id, username, email, master_password, salt, last_login) 
VALUES (users_seq.NEXTVAL, 'john_doe', 'john.doe@example.com', 'hashed_password_1', 'random_salt_1', NULL);

INSERT INTO Users (user_id, username, email, master_password, salt, last_login) 
VALUES (users_seq.NEXTVAL, 'jane_smith', 'jane.smith@example.com', 'hashed_password_2', 'random_salt_2', NULL);

INSERT INTO Users (user_id, username, email, master_password, salt, last_login) 
VALUES (users_seq.NEXTVAL, 'alice_walker', 'alice.walker@example.com', 'hashed_password_3', 'random_salt_3', SYSTIMESTAMP);

INSERT INTO Users (user_id, username, email, master_password, salt, last_login) 
VALUES (users_seq.NEXTVAL, 'bob_builder', 'bob.builder@example.com', 'hashed_password_4', 'random_salt_4', SYSTIMESTAMP);

INSERT INTO Users (user_id, username, email, master_password, salt, last_login) 
VALUES (users_seq.NEXTVAL, 'charlie_brown', 'charlie.brown@example.com', 'hashed_password_5', 'random_salt_5', NULL);

--================INSERT Password_Entries ====================Xem chỉnh lại khóa ngoại vì gennarate ID ngẫu nhiên
INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category, last_modified) 
VALUES (password_entries_seq.NEXTVAL, 21, 'Google', 'https://accounts.google.com', 'john.doe', 'encrypted_pwd_1', 'Main email account', 'Email', NULL);

INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category, last_modified) 
VALUES (password_entries_seq.NEXTVAL, 22, 'Facebook', 'https://facebook.com', 'jane.smith', 'encrypted_pwd_2', 'Personal account', 'Social Media', NULL);

INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category, last_modified) 
VALUES (password_entries_seq.NEXTVAL, 23, 'GitHub', 'https://github.com', 'alice_walker', 'encrypted_pwd_3', NULL, 'Development', SYSTIMESTAMP);

INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category, last_modified) 
VALUES (password_entries_seq.NEXTVAL, 24, 'LinkedIn', 'https://linkedin.com', 'bob_builder', 'encrypted_pwd_4', 'Professional profile', 'Networking', NULL);

INSERT INTO Password_Entries (entry_id, user_id, website_name, website_url, username_for_site, encrypted_password, notes, category, last_modified) 
VALUES (password_entries_seq.NEXTVAL, 25, 'Amazon', 'https://amazon.com', 'charlie.brown', 'encrypted_pwd_5', 'Shopping account', 'E-commerce', NULL);

--================INSERT Categories ============================Xem chỉnh lại khóa ngoại vì gennarate ID ngẫu nhiên
INSERT INTO Categories (category_id, user_id, category_name, description) 
VALUES (categories_seq.NEXTVAL, 21, 'Email', 'Email accounts for work and personal use');

INSERT INTO Categories (category_id, user_id, category_name, description) 
VALUES (categories_seq.NEXTVAL, 22, 'Social Media', 'Facebook, Instagram, etc.');

INSERT INTO Categories (category_id, user_id, category_name, description) 
VALUES (categories_seq.NEXTVAL, 23, 'Development', 'Tools and platforms for coding');

INSERT INTO Categories (category_id, user_id, category_name, description) 
VALUES (categories_seq.NEXTVAL, 24, 'Networking', 'Professional platforms like LinkedIn');

INSERT INTO Categories (category_id, user_id, category_name, description) 
VALUES (categories_seq.NEXTVAL, 25, 'E-commerce', 'Shopping websites and services');

--================INSERT Login_History ============================
INSERT INTO Login_History (history_id, user_id, login_timestamp, ip_address, login_status, device_info) 
VALUES (login_history_seq.NEXTVAL, 21, SYSTIMESTAMP, '192.168.1.1', 'SUCCESS', 'Chrome on Windows');

INSERT INTO Login_History (history_id, user_id, login_timestamp, ip_address, login_status, device_info) 
VALUES (login_history_seq.NEXTVAL, 22, SYSTIMESTAMP, '192.168.1.2', 'FAILURE', 'Safari on macOS');

INSERT INTO Login_History (history_id, user_id, login_timestamp, ip_address, login_status, device_info) 
VALUES (login_history_seq.NEXTVAL, 23, SYSTIMESTAMP, '192.168.1.3', 'SUCCESS', 'Firefox on Linux');

INSERT INTO Login_History (history_id, user_id, login_timestamp, ip_address, login_status, device_info) 
VALUES (login_history_seq.NEXTVAL, 24, SYSTIMESTAMP, '192.168.1.4', 'SUCCESS', 'Edge on Windows');

INSERT INTO Login_History (history_id, user_id, login_timestamp, ip_address, login_status, device_info) 
VALUES (login_history_seq.NEXTVAL, 25, SYSTIMESTAMP, '192.168.1.5', 'FAILURE', 'Chrome on Android');



SELECT * FROM users;
SELECT * FROM password_entries where user_id = 1;
SELECT * FROM login_history;
SELECT * FROM categories;
SELECT website_name, username_for_site, encrypted_password, category FROM Password_Entries