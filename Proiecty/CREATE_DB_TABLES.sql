
CREATE TABLE AUTOMOBIL
(
	 automobil_id int NOT NULL PRIMARY KEY
	,producator varchar(100)
	,model varchar(100)
	,an_incepere_fabricatie int NOT NULL
	,an_incetare_fabricatie int 
	,tip varchar(100)

	,CONSTRAINT CHK_AN_FABR CHECK(an_incepere_fabricatie<an_incetare_fabricatie)
)


CREATE TABLE FURNIZOR
(
	 furnizor_id int NOT NULL PRIMARY KEY
	,nume_furnizor varchar(100) NOT NULL UNIQUE
	,tara varchar(100)
	,oras varchar(100)
)

CREATE TABLE CATEGORIE
(
	 categorie_id int NOT NULL PRIMARY KEY
	,nume varchar(100) NOT NULL
	,descriere varchar(300)
)

CREATE TABLE PRODUS
(
	 cod_produs int NOT NULL PRIMARY KEY
	,categorie_id int NOT NULL 
	,furnizor_id int NOT NULL 
	,nume_produs varchar(100) NOT NULL
	,pret numeric(10,2) NOT NULL
	,descriere varchar(300)
	,CONSTRAINT FK_PRODUS_CATEGORIE_ID FOREIGN KEY (categorie_id) REFERENCES CATEGORIE(categorie_id) 
	,CONSTRAINT FK_PRODUS_FURNIZOR_ID FOREIGN KEY (furnizor_id) REFERENCES FURNIZOR(furnizor_id)
)

CREATE TABLE AUTOMOBIL_COMPATIBIL
(
	 automobil_id int NOT NULL 
	,cod_produs int NOT NULL 
	,producator varchar(100)
	,model varchar(100)
	,an_fabricatie int 
	,cod_motor varchar(200)
	,CONSTRAINT FK_AUTO_COMP_AUTOMOBIL_ID FOREIGN KEY (automobil_id) REFERENCES AUTOMOBIL(automobil_id)
	,CONSTRAINT FK_AUTO_COMP_COD_PRODUS FOREIGN KEY (cod_produs) REFERENCES PRODUS(cod_produs)
	,CONSTRAINT PK_AUTOMOBIL_COMPATIBIL PRIMARY KEY NONCLUSTERED([automobil_id],[cod_produs])
)


CREATE TABLE CLIENT
(
	 client_id int NOT NULL IDENTITY(1,1) PRIMARY KEY
	,nume varchar(100) NOT NULL
	,prenume varchar(100)
	,contact varchar(100) NOT NULL UNIQUE
)

CREATE TABLE ADRESA
(
	 adresa_id int NOT NULL IDENTITY(1,1) PRIMARY KEY
	,client_id int NOT NULL 
	,oras varchar(100) NOT NULL
	,strada varchar(100) NOT NULL
	,numar int NOT NULL
	,bloc varchar(10)
	,scara varchar(10)
	,etaj int
	,apartament int
	,CONSTRAINT FK_ADRESA_CLIENT FOREIGN KEY (client_id) REFERENCES CLIENT(client_id)
)

CREATE TABLE COMANDA
(
	 comanda_id int NOT NULL IDENTITY(1,1) PRIMARY KEY
	,adresa_id int NOT NULL 
	,data_comanda date NOT NULL
	,data_expediere date
	,stare varchar(20)
	,CONSTRAINT FK_COMANDA_ADRESA FOREIGN KEY (adresa_id) REFERENCES ADRESA(adresa_id)
)

CREATE TABLE PRODUSE_COMANDATE
(
	 comanda_id int NOT NULL 
	,cod_produs int NOT NULL 
	,cantitate int	NOT NULL 
	,CONSTRAINT FK_PROD_COM_PRODUS FOREIGN KEY (cod_produs) REFERENCES PRODUS(cod_produs)
	,CONSTRAINT FK_PROD_COM_COMANDA FOREIGN KEY (comanda_id) REFERENCES COMANDA(comanda_id)
	,CONSTRAINT PK_PRODUSE_COMANDATE PRIMARY KEY NONCLUSTERED ([comanda_id],[cod_produs])
)

