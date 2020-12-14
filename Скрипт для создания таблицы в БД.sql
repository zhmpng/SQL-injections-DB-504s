CREATE TABLE dbo.Users
( Id uniqueidentifier NOT NULL,
  [Login] varchar(64) NOT NULL,
  [Password] varchar(64) NOT NULL
  CONSTRAINT users_pk PRIMARY KEY (Id),
  CONSTRAINT AK_Login UNIQUE([Login])
);