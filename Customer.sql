CREATE TABLE [dbo].[CUSTOMER] (
    [id] VARCHAR(255) NOT NULL,
    [name] VARCHAR(255) NULL,
    [gender] VARCHAR(10) NULL,
    [birth] DATE NULL,
    [phoneNumber] VARCHAR(20) NULL,
    [address] VARCHAR(255) NULL,
    [email] VARCHAR(255) NULL,
    [citizenID] VARCHAR(20) NULL,
    [logo] VARCHAR(255) NULL,
   
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO [dbo].[CUSTOMER] ([id], [name], [gender], [birth], [phoneNumber], [address], [email], [citizenID], [logo])
VALUES
    ('1', 'John Doe', 'Male', '1990-05-15', '123456789', '123 Main Street, City, Country', 'john.doe@example.com', '1234567890', 'Profile\logo1.png'),
    ('2', 'Jane Smith', 'Female', '1985-08-20', '987654321', '456 Elm Street, City, Country', 'jane.smith@example.com', '0987654321', 'Profile\logo2.png'),
    ('3', 'Michael Johnson', 'Male', '1982-03-10', '555123456', '789 Oak Street, City, Country', 'michael.johnson@example.com', '5551234567', 'Profile\logo3.png'),
    ('4', 'Emily Wilson', 'Female', '1995-12-03', '777888999', '321 Pine Street, City, Country', 'emily.wilson@example.com', '7778889990', 'Profile\logo4.png'),
    ('5', 'David Brown', 'Male', '1988-09-25', '444555666', '987 Maple Street, City, Country', 'david.brown@example.com', '4445556667', 'Profile\logo5.png'),
    ('6', 'Jessica Lee', 'Female', '1992-06-18', '666777888', '654 Walnut Street, City, Country', 'jessica.lee@example.com', '6667778889', 'Profile\logo6.png'),
    ('7', 'Daniel Martinez', 'Male', '1980-01-30', '222333444', '852 Cedar Street, City, Country', 'daniel.martinez@example.com', '2223334445', 'Profile\logo7.png'),
    ('8', 'Samantha Taylor', 'Female', '1987-07-12', '999000111', '741 Birch Street, City, Country', 'samantha.taylor@example.com', '9990001112', 'Profile\logo8.png'),
    ('9', 'Christopher Clark', 'Male', '1983-11-08', '333444555', '369 Oakwood Street, City, Country', 'christopher.clark@example.com', '3334445558', 'Profile\logo9.png'),
    ('10', 'Amanda Hall', 'Female', '1998-04-22', '111222333', '159 Cedarwood Street, City, Country', 'amanda.hall@example.com', '1112223334', 'Profile\logo10.png');

INSERT INTO [dbo].[CUSTOMER] ([id], [name], [gender], [birth], [phoneNumber], [address], [email], [citizenID], [logo])
VALUES
    ('11', 'Matthew Turner', 'Male', '1986-10-07', '777888999', '963 Oakwood Street, City, Country', 'matthew.turner@example.com', '7778889991', 'Profile\logo11.png'),
    ('12', 'Olivia Garcia', 'Female', '1991-02-14', '888999000', '258 Elmwood Street, City, Country', 'olivia.garcia@example.com', '8889990005', 'Profile\logo12.png'),
    ('13', 'Ryan Martinez', 'Male', '1984-05-29', '333444555', '741 Pinecrest Street, City, Country', 'ryan.martinez@example.com', '3334445551', 'Profile\logo13.png'),
    ('14', 'Sophia Adams', 'Female', '1990-08-18', '555666777', '852 Maplewood Street, City, Country', 'sophia.adams@example.com', '5556667772', 'Profile\logo14.png'),
    ('15', 'Ethan Hernandez', 'Male', '1982-12-11', '222333444', '369 Birchwood Street, City, Country', 'ethan.hernandez@example.com', '2223334448', 'Profile\logo15.png'),
    ('16', 'Isabella Scott', 'Female', '1987-03-27', '444555666', '159 Cedarcrest Street, City, Country', 'isabella.scott@example.com', '4445556663', 'Profile\logo16.png'),
    ('17', 'Alexander Nguyen', 'Male', '1995-06-05', '666777888', '963 Pinecrest Street, City, Country', 'alexander.nguyen@example.com', '6667778884', 'Profile\logo17.png'),
    ('18', 'Mia Roberts', 'Female', '1989-09-30', '999000111', '258 Elm Street, City, Country', 'mia.roberts@example.com', '9990001115', 'Profile\logo18.png'),
    ('19', 'William Wilson', 'Male', '1981-01-14', '111222333', '741 Birchwood Street, City, Country', 'william.wilson@example.com', '1112223337', 'Profile\logo19.png')