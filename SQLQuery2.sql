CREATE DATABASE Optics_DB;
CREATE TABLE Customer (
  CustomerID int NOT NULL PRIMARY KEY IDENTITY, -- Unique auto-generated ID for each customer (uses IDENTITY instead of AUTO_INCREMENT)
  Name nvarchar(255) NOT NULL CHECK (LEN(Name) > 0), -- Customer's full name (not empty, uses nvarchar for Unicode support)
  PhoneNumber nvarchar(20) CHECK (PATINDEX('%[^0-9-]%', PhoneNumber) = 0), -- Phone number (digits and hyphens only, uses PATINDEX for validation)
  DateAdded date NOT NULL DEFAULT CURRENT_TIMESTAMP,  -- Date customer record was created (defaults to current date)
  
  -- Right Eye Prescription
  R_SPH decimal(5,2) CHECK (R_SPH BETWEEN -20.00 AND +20.00),  -- Right eye spherical lens power (-20.00 to +20.00)
  R_CYL decimal(5,2) CHECK (R_CYL BETWEEN -10.00 AND +10.00),  -- Right eye cylindrical lens power (-10.00 to +10.00)
  R_AXIS int CHECK (R_AXIS BETWEEN 0 AND 180),          -- Right eye axis (0 to 180, can be NULL)
  R_ADD decimal(4,2) CHECK (R_ADD >= 0.00),  -- Right eye addition power (for reading glasses, non-negative)

  -- Left Eye Prescription
  L_SPH decimal(5,2) CHECK (L_SPH BETWEEN -20.00 AND +20.00),  -- Left eye spherical lens power (-20.00 to +20.00)
  L_CYL decimal(5,2) CHECK (L_CYL BETWEEN -10.00 AND +10.00),  -- Left eye cylindrical lens power (-10.00 to +10.00)
  L_AXIS int CHECK (L_AXIS BETWEEN 0 AND 180),          -- Left eye axis (0 to 180, can be NULL)
  L_ADD decimal(4,2) CHECK (L_ADD >= 0.00),  -- Left eye addition power (for reading glasses, non-negative)
  
  Distance nvarchar(20) CHECK (Distance IN (N'Single Vision', N'Bifocal', N'Trifocal', N'Progressive',N'')),  -- Type of distance glasses (limited options, uses N' for Unicode literals)
  Reading nvarchar(20) CHECK (Reading IN (N'Single Vision', N'Bifocal', N'Trifocal', N'Progressive',N'')),   -- Type of reading glasses (limited options, uses N' for Unicode literals)
  Delivered bit NOT NULL DEFAULT 0, -- Indicates if glasses were delivered (default: false, uses bit for boolean)
  
  Total decimal(10,2) CHECK (Total >= 0.00),  -- Total cost of the glasses (non-negative)
  Advance decimal(10,2) CHECK (Advance >= 0.00), -- Advance payment received (non-negative)
  Balance decimal(10,2) CHECK  (Balance >= 0.00),
  );
  drop table Customer;
  select * from Customer;