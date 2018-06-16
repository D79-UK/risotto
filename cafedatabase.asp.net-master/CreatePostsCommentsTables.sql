CREATE TABLE [dbo].[posts] (
    [id]      INT IDENTITY(1,1) PRIMARY KEY ,    
	[title] NVARCHAR (61) NOT NULL,
    [body] NVARCHAR (1023) NOT NULL,
	[posted_at] DATETIME NULL
);
CREATE TABLE [dbo].[comments] (
    [id]             INT IDENTITY(1,1) PRIMARY KEY,
    [id_post] INT NULL,
	[title] NVARCHAR (61) NOT NULL,
    [body] NVARCHAR (1023) NOT NULL,
	[commented_at] DATETIME NULL,

	CONSTRAINT fk_posts
    FOREIGN KEY (id_post)
    REFERENCES posts(id)
    ON DELETE CASCADE
);
INSERT INTO posts (title, body, posted_at) VALUES (N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00'),
(N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00');

INSERT INTO comments (id_post, title, body, commented_at) VALUES (1, N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00'),
(2, N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00'),
(1, N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00'),
(2, N'О вкусной и здоровой пище', N'О вкусной и здоровой пище', '12-06-2018 18:15:00');