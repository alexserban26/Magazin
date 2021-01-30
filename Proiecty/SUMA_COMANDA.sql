/****** Script for SelectTopNRows command from SSMS  ******/
SELECT PC.comanda_id
      ,CL.nume
	  ,sum(P.pret*cantitate) 'SUMA COMANDA'
  FROM PRODUSE_COMANDATE PC JOIN PRODUS P ON P.cod_produs=PC.cod_produs 
												JOIN COMANDA C ON PC.comanda_id=C.comanda_id 
												JOIN ADRESA A ON A.adresa_id=C.adresa_id
												JOIN CLIENT CL ON A.client_id=CL.client_id
GROUP BY PC.comanda_id, CL.nume
having sum(P.pret*cantitate)>100
SELECT * FROM ADRESA ad JOIN CLIENT cl ON cl.client_id=ad.client_id

