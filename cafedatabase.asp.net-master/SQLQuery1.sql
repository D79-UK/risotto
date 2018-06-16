CREATE TABLE [dbo].[cevents] (
    [id]      INT IDENTITY(1,1) PRIMARY KEY ,    
	[title] NVARCHAR (61) NOT NULL,
    [description] NVARCHAR (1023) NOT NULL,
	[scheduled_on] DATETIME NULL
);
INSERT INTO cevents(title, description, scheduled_on) VALUES (N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018'),
(N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018'),
(N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018'),
(N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018');