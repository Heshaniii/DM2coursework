
--customer schema
CREATE TABLE Customers (
    customerID VARCHAR2(36) PRIMARY KEY,
    cName VARCHAR2(100),
    cEmail VARCHAR2(100) UNIQUE,
    cPassword VARCHAR2(255), 
    cPhone VARCHAR2(20),
    cAddress VARCHAR2(255)
);

--suplier schema
CREATE TABLE Suppliers (
    SupplierID VARCHAR2(36) PRIMARY KEY,
    sName VARCHAR2(100),
    sEmail VARCHAR2(100) UNIQUE,
    sPassword VARCHAR2(255),
    sPhone VARCHAR2(20),
    sAddress VARCHAR2(255)
);

-----------------------------------------------------------
--customer signup function
CREATE OR REPLACE FUNCTION Signup_Customer(
    p_cName IN VARCHAR2,
    p_cEmail IN VARCHAR2,
    p_cHashedPassword IN VARCHAR2,
    p_cPhone IN VARCHAR2,
    p_cAddress IN VARCHAR2
) RETURN VARCHAR2 IS
    vCustomerID VARCHAR2(36);
BEGIN
    SELECT SYS_GUID() INTO vCustomerID FROM dual;

    INSERT INTO Customers (
        CustomerID, 
        cName, 
        cEmail, 
        cPassword, 
        cPhone, 
        cAddress)
    VALUES (
        vCustomerID, 
        p_cName, 
        LOWER(p_cEmail), 
        p_cHashedPassword, 
        p_cPhone, 
        p_cAddress
        );

    RETURN vCustomerID;
EXCEPTION
    WHEN OTHERS THEN
        RETURN NULL;
END Signup_Customer;
/
COMMIT;

--supplier signup function
CREATE OR REPLACE FUNCTION Signup_Supplier(
    p_sName IN VARCHAR2,
    p_sEmail IN VARCHAR2,
    p_sHashedPassword IN VARCHAR2,
    p_sPhone IN VARCHAR2,
    p_sAddress IN VARCHAR2
) RETURN VARCHAR2 IS
    vSupplierID VARCHAR2(36);
BEGIN
    SELECT SYS_GUID() INTO vSupplierID FROM dual;

    INSERT INTO Suppliers (SupplierID, sName, sEmail, sPassword, sPhone, sAddress)
    VALUES (vSupplierID, p_sName, LOWER(p_sEmail), p_sHashedPassword, p_sPhone, p_sAddress);

    RETURN vSupplierID;
EXCEPTION
    WHEN OTHERS THEN
        RETURN NULL;
END Signup_Supplier;
/
COMMIT;
----------------------------------------------------------------
--login function for customer
CREATE OR REPLACE FUNCTION Login_Customer(
    p_cEmail IN VARCHAR2,
    p_cPassword IN VARCHAR2
) RETURN VARCHAR2 IS
    vCustomerID VARCHAR2(36);
BEGIN
    SELECT CustomerID
    INTO vCustomerID
    FROM Customers
    WHERE LOWER(P_CEMAIL) = LOWER(p_cEmail)
      AND CPASSWORD = p_cPassword;

    RETURN vCustomerID;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN NULL;
END Login_Customer;
/

--login function for supplier
CREATE OR REPLACE FUNCTION Login_Supplier(
    p_sEmail IN VARCHAR2,
    p_sPassword IN VARCHAR2
) RETURN VARCHAR2 IS
    vSupplierID VARCHAR2(36);
BEGIN
    SELECT SupplierID
    INTO vSupplierID
    FROM Suppliers
    WHERE LOWER(P_SEMAIL) = LOWER(p_sEmail)
      AND SPASSWORD = p_sPassword;

    RETURN vSupplierID;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RETURN NULL;
END Login_Supplier;
/
------------------------------------------------

