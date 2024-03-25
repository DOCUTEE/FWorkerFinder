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
    [field] VARCHAR(255) NULL,
    [pricePerHour] FLOAT(53) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO [dbo].[WORKERS] ([id], [name], [gender], [birth], [phoneNumber], [address], [email], [citizenID], [logo], [rating], [description], [qualifications], [field], [pricePerHour])
VALUES
    ('1', 'John Doe', 'Male', '1990-05-15', '123456789', '123 Main Street, City, Country', 'john.doe@example.com', '1234567890', 'Profile\logo1.png', 4.5, 'Experienced in repairing various types of air conditioners.', 'Certified HVAC technician with 5 years of experience.', 'Air conditioner repairman', 50.00),
    ('2', 'Jane Smith', 'Female', '1985-08-20', '987654321', '456 Elm Street, City, Country', 'jane.smith@example.com', '0987654321', 'Profile\logo2.png', 4.7, 'Specializes in residential and commercial air conditioning repairs.', 'Licensed HVAC technician with excellent customer service skills.', 'Air conditioner repairman', 55.00),
    ('3', 'Michael Johnson', 'Male', '1982-03-10', '555123456', '789 Oak Street, City, Country', 'michael.johnson@example.com', '5551234567', 'Profile\logo3.png', 4.2, 'Skilled in troubleshooting and fixing air conditioner issues efficiently.', '10+ years of experience in the HVAC industry.', 'Air conditioner repairman', 60.00),
    ('4', 'Emily Wilson', 'Female', '1995-12-03', '777888999', '321 Pine Street, City, Country', 'emily.wilson@example.com', '7778889990', 'Profile\logo4.png', 4.9, 'Provides timely and reliable air conditioning repair services.', 'Graduate of an accredited HVAC training program with outstanding reviews.', 'Air conditioner repairman', 65.00),
    ('5', 'David Brown', 'Male', '1988-09-25', '444555666', '987 Maple Street, City, Country', 'david.brown@example.com', '4445556667', 'Profile\logo5.png', 4.6, 'Offers comprehensive air conditioning maintenance and repair solutions.', 'Certified HVAC specialist known for attention to detail.', 'Air conditioner repairman', 70.00),
    ('6', 'Jessica Lee', 'Female', '1992-06-18', '666777888', '654 Walnut Street, City, Country', 'jessica.lee@example.com', '6667778889', 'Profile\logo6.png', 4.8, 'Expert in diagnosing and fixing air conditioner problems effectively.', 'Completed advanced HVAC courses with top grades.', 'Air conditioner repairman', 75.00),
    ('7', 'Daniel Martinez', 'Male', '1980-01-30', '222333444', '852 Cedar Street, City, Country', 'daniel.martinez@example.com', '2223334445', 'Profile\logo7.png', 4.3, 'Known for delivering prompt and professional air conditioning repair services.', 'Trained in the latest HVAC technologies and repair techniques.', 'Air conditioner repairman', 80.00),
    ('8', 'Samantha Taylor', 'Female', '1987-07-12', '999000111', '741 Birch Street, City, Country', 'samantha.taylor@example.com', '9990001112', 'Profile\logo8.png', 4.4, 'Skilled in repairing a wide range of air conditioner models.', 'Extensive experience in both residential and commercial HVAC systems.', 'Air conditioner repairman', 85.00),
    ('9', 'Christopher Clark', 'Male', '1983-11-08', '333444555', '369 Oakwood Street, City, Country', 'christopher.clark@example.com', '3334445558', 'Profile\logo9.png', 4.1, 'Offers reliable air conditioning repair services with a focus on customer satisfaction.', 'Completed apprenticeship under a master HVAC technician.', 'Air conditioner repairman', 90.00),
    ('10', 'Amanda Hall', 'Female', '1998-04-22', '111222333', '159 Cedarwood Street, City, Country', 'amanda.hall@example.com', '1112223334', 'Profile\logo10.png', 4.7, 'Dedicated to providing high-quality air conditioning repair solutions.', 'Trained in the installation, maintenance, and repair of various HVAC systems.', 'Air conditioner repairman', 95.00);

   INSERT INTO [dbo].[WORKERS] ([id], [name], [gender], [birth], [phoneNumber], [address], [email], [citizenID], [logo], [rating], [description], [qualifications], [field], [pricePerHour])
VALUES
    ('11', 'Michael Smith', 'Male', '1985-03-25', '1234567890', '123 Main Street, City, Country', 'michael.smith@example.com', '1234567890123', 'Profile\logo11.png', 4.5, 'Experienced in diagnosing and fixing various TV issues.', 'Certified electronics technician with 7 years of experience.', 'TV repairman', 50.00),
    ('12', 'Jennifer Davis', 'Female', '1980-08-15', '9876543210', '456 Elm Street, City, Country', 'jennifer.davis@example.com', '9876543210987', 'Profile\logo12.png', 4.7, 'Specializes in repairing LED, LCD, and plasma TVs.', 'Trained in TV repair from a reputable technical institute.', 'TV repairman', 55.00),
    ('13', 'Christopher Brown', 'Male', '1978-12-10', '5551234567', '789 Oak Street, City, Country', 'christopher.brown@example.com', '5551234567890', 'Profile\logo13.png', 4.2, 'Known for providing efficient and reliable TV repair services.', '10+ years of experience in the electronics repair industry.', 'TV repairman', 60.00),
    ('14', 'Jessica Wilson', 'Female', '1992-01-03', '7778889990', '321 Pine Street, City, Country', 'jessica.wilson@example.com', '7778889990123', 'Profile\logo14.png', 4.9, 'Expertise in repairing smart TVs with advanced functionalities.', 'Received advanced training in smart TV repair techniques.', 'TV repairman', 65.00),
    ('15', 'Daniel Johnson', 'Male', '1987-09-20', '4445556667', '987 Maple Street, City, Country', 'daniel.johnson@example.com', '4445556667778', 'Profile\logo15.png', 4.6, 'Skilled in troubleshooting and fixing TV display issues.', 'Certified TV repair specialist with extensive knowledge in electronics.', 'TV repairman', 70.00),
    ('16', 'Emily Martinez', 'Female', '1990-06-18', '6667778889', '654 Walnut Street, City, Country', 'emily.martinez@example.com', '6667778889990', 'Profile\logo16.png', 4.8, 'Provides comprehensive TV repair solutions for all brands.', 'Trained in the latest TV technologies and repair methods.', 'TV repairman', 75.00),
    ('17', 'David Taylor', 'Male', '1983-02-05', '2223334445', '852 Cedar Street, City, Country', 'david.taylor@example.com', '2223334445556', 'Profile\logo17.png', 4.3, 'Offers prompt and professional TV repair services.', 'Completed specialized training in TV repair from a renowned institution.', 'TV repairman', 80.00),
    ('18', 'Samantha Clark', 'Female', '1988-07-12', '9990001112', '741 Birch Street, City, Country', 'samantha.clark@example.com', '9990001112223', 'Profile\logo18.png', 4.4, 'Skilled in diagnosing and repairing TV audio and video issues.', 'Extensive experience in TV repair gained through years of practice.', 'TV repairman', 85.00),
    ('19', 'John Hall', 'Male', '1981-11-08', '3334445558', '369 Oakwood Street, City, Country', 'john.hall@example.com', '3334445556667', 'Profile\logo19.png', 4.1, 'Known for delivering high-quality TV repair services.', 'Completed apprenticeship under a master TV repair technician.', 'TV repairman', 90.00),
    ('20', 'Amanda Brown', 'Female', '1995-04-22', '1112223334', '159 Cedarwood Street, City, Country', 'amanda.brown@example.com', '1112223334445', 'Profile\logo20.png', 4.7, 'Dedicated to providing reliable TV repair solutions to customers.', 'Trained in the repair of a wide range of TV models and brands.', 'TV repairman', 95.00);



   drop table WORKERS