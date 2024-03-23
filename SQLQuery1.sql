CREATE TABLE [dbo].[WORKERS] (
    [id] VARCHAR(255) NOT NULL,
    [name] VARCHAR(255) NULL,
    [gender] VARCHAR(10) NULL,
    [birth] DATE NULL,
    [phoneNumber] VARCHAR(20) NULL,
    [address] VARCHAR(255) NULL,
    [email] VARCHAR(255) NULL,
    [citizenID] VARCHAR(20) NULL,
    [logo] VARCHAR(255) NULL,
    [rating] FLOAT(53) NULL,
    [description] TEXT NULL,
    [qualifications] TEXT NULL,
    [field] NVARCHAR(4000) NULL,
    [pricePerHour] FLOAT(53) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
INSERT INTO [dbo].[WORKERS] ([id], [name], [gender], [birth], [phoneNumber], [address], [email], [citizenID], [logo], [rating], [description], [qualifications], [field], [pricePerHour])
VALUES 
('1', 'John Doe', 'Male', '1990-05-15', '123456789', '123 Main St, Anytown, USA', 'john.doe@example.com', '1234567890', 'Profile\logo1.png', 4.5, 'Experienced air conditioner repairman with expertise in HVAC systems.', 'HVAC Certification', 'Senior Technician', 50.00),
('2', 'Jane Smith', 'Female', '1985-09-20', '987654321', '456 Elm St, Othertown, USA', 'jane.smith@example.com', '0987654321','Profile\logo2.png', 4.8, 'Professional TV repairman specializing in electronic troubleshooting and component replacement.', 'Electronics Technician Certification', 'Lead Technician', 60.00),
('3', 'Michael Johnson', 'Male', '1982-07-10', '456123789', '789 Oak St, Anycity, USA', 'michael.johnson@example.com', '4561237890', 'Profile\logo3.png', 4.2, 'Experienced washing machine repairman with proficiency in diagnosing and fixing mechanical issues.', 'Appliance Repair Certification', 'Repair Specialist', 45.00),
('4', 'Emily Brown', 'Female', '1993-03-25', '789456123', '321 Pine St, Othercity, USA', 'emily.brown@example.com', '7894561230', 'Profile\logo4.png', 4.6, 'Professional house painter with expertise in interior and exterior painting.', 'Painter Certification', 'Lead Painter', 55.00),
('5', 'David Wilson', 'Male', '1988-11-12', '321789654', '654 Birch St, Anothertown, USA', 'david.wilson@example.com', '3217896540', 'Profile\logo5.png', 4.4, 'Experienced air conditioner repairman with expertise in HVAC systems.', 'HVAC Certification', 'Senior Technician', 65.00);

Drop table WORKERS

select * from WORKERS
select *from [dbo].[WORKERS]


SELECT TOP 2 [field] FROM WORKERS