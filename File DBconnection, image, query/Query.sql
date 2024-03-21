
CREATE TABLE FWorkerTable (
    id INT PRIMARY KEY ,
    name VARCHAR(255),
    gender VARCHAR(20),
    birth DATE,
    field VARCHAR(255),
    phoneNumber VARCHAR(20),
    email VARCHAR(255),
    address VARCHAR(255),
    citizenID VARCHAR(20),
    rating DECIMAL(3,2),
    description TEXT,
    qualifications TEXT,
    pricePerHour DECIMAL(10,2),
    currentPosition VARCHAR(255),
    imageLink VARCHAR(255)
);
INSERT INTO FWorkerTable (id, name, gender, birth, field, phoneNumber, email, address, citizenID, rating, description, qualifications, pricePerHour, currentPosition, imageLink) 
VALUES 
(1, 'John Doe', 'Male', '1990-05-15', 'Air conditioner repairman', '123456789', 'john.doe@example.com', '123 Main St, Anytown, USA', '1234567890', 4.5, 'Experienced air conditioner repairman with expertise in HVAC systems.', 'HVAC Certification', 50.00, 'Senior Technician', NULL),
(2, 'Jane Smith', 'Female', '1985-09-20', 'TV repairman', '987654321', 'jane.smith@example.com', '456 Elm St, Othertown, USA', '0987654321', 4.8, 'Professional TV repairman specializing in electronic troubleshooting and component replacement.', 'Electronics Technician Certification', 60.00, 'Lead Technician', NULL),
(3, 'Michael Johnson', 'Male', '1982-07-10', 'Washing machine repairman', '456123789', 'michael.johnson@example.com', '789 Oak St, Anycity, USA', '4561237890', 4.2, 'Experienced washing machine repairman with proficiency in diagnosing and fixing mechanical issues.', 'Appliance Repair Certification', 45.00, 'Repair Specialist', NULL),
(4, 'Emily Brown', 'Female', '1993-03-25', 'House painter', '789456123', 'emily.brown@example.com', '321 Pine St, Othercity, USA', '7894561230', 4.6, 'Professional house painter with expertise in interior and exterior painting.', 'Painter Certification', 55.00, 'Lead Painter', NULL),
(5, 'David Wilson', 'Male', '1988-11-12', 'Air conditioner repairman', '321789654', 'david.wilson@example.com', '654 Birch St, Anothertown, USA', '3217896540', 4.4, 'Experienced air conditioner repairman with expertise in HVAC systems.', 'HVAC Certification', 65.00, 'Senior Technician', NULL);

SELECT * FROM FWorkerTable;
