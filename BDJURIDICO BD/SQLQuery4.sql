
CREATE TABLE CIDADE(
  CIDID INT IDENTITY (1,1) PRIMARY KEY,
  CIDDESCRICAO VARCHAR(100) NOT NULL,
  ESTID INT NOT NULL REFERENCES ESTADO(ESTID)
)
GO
SELECT * FROM ESTADO
SELECT * FROM CIDADE
INSERT CIDADE VALUES ('ESTANCIA',1)
