-- Run this in your LocalDB database to create the missing table
CREATE TABLE Avatars (
    AvatarId INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    AvatarPath NVARCHAR(260) NULL,
    IsActive BIT NOT NULL DEFAULT 0,
    CreatedAt DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Avatars_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);