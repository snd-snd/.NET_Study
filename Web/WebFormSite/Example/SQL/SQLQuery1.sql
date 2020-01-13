CREATE TABLE Board(
Bno BIGINT IDENTITY(1,1),
Title VARCHAR(100) not null,
Writer VARCHAR(100) not null,
Content VARCHAR(2000) not null,
Regdate DATE DEFAULT getdate(),
Hit INT DEFAULT 0,
CONSTRAINT PK_Board PRIMARY KEY (Bno));

