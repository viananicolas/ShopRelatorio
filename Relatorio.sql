With Vendas as 
(SELECT [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo, 
[S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].[Prod_Serv_Nome], 
[Movimento_Prod_Serv_Qtde] AS sales ,[Filiais_Codigo] 
FROM [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio] join [S9_Real].[dbo].Prod_Serv 
on [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo = [S9_Real].[dbo].Prod_Serv.Codigo 
join [S9_Real].[dbo].Fabricantes on [S9_Real].[dbo].Prod_Serv.Ordem_Fabricante = [S9_Real].[dbo].Fabricantes.Ordem 
WHERE Movimento_Tipo_Operacao='vnd' AND Movimento_Data >= cast('2016-12-01 00:00:00' as datetime) 
AND Movimento_Data <=cast ('2017-05-07 23:59:00' as datetime)  
and 1=1 
GROUP BY [Movimento_Prod_Serv_Qtde], [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_nome, Filiais_Codigo, Prod_Serv_Codigo), 
Vendo as ( SELECT * FROM Vendas pivot(sum(sales) FOR Filiais_Codigo IN ([1], [2], [3], [4])) AS pivoto ), 
VendasRealizadas as ( SELECT *, (ISNULL(Vendo.[1],0) + ISNULL(Vendo.[2],0) + ISNULL(Vendo.[3],0)+ ISNULL(Vendo.[4],0)) AS Total FROM Vendo ), 
ProdEstoque as ( SELECT Codigo_Prod_Serv as Prod_Serv_Codigo, max(Qtde_Estoque_Atual) AS QuantidadeEstoque, [S9_Real].[dbo].Filiais.Codigo, Prod_Serv.Codigo as codprod
FROM [S9_Real].[dbo].[View_Estoque_Atual_Filial_Prod_Serv] 
JOIN [S9_Real].[dbo].Filiais 
ON [S9_Real].[dbo].[View_Estoque_Atual_Filial_Prod_Serv].Codigo_Filial = [S9_Real].[dbo].Filiais.Codigo 
join [S9_Real].[dbo].Prod_Serv 
ON View_Estoque_Atual_Filial_Prod_Serv.Codigo_Prod_Serv= Prod_Serv.Codigo
WHERE Filiais.Nome!='Não Cadastrada' 
AND Prod_Serv.Ordem_Subclasse=10074
GROUP BY Codigo_Prod_Serv,  Filiais.Codigo, Prod_Serv.Codigo, Qtde_Estoque_Atual), 
Estocado as ( SELECT * FROM ProdEstoque pivot(max(QuantidadeEstoque) 
FOR Codigo IN ([1], [2], [3], [4])) AS pivoto), 
Estocamento as (SELECT VendasRealizadas.Prod_Serv_Nome as [Produto], isnull(VendasRealizadas.[1], 0) 
AS[VendasF1], isnull(VendasRealizadas.[2], 0) AS[VendasF2], isnull(VendasRealizadas.[3], 0) 
AS[VendasF3], isnull(VendasRealizadas.[4], 0) AS[VendasF4], isnull(VendasRealizadas.Total, 0)
AS[TotalVendas], isnull((VendasRealizadas.Total) / 3, 0) AS[MediaVendas], isnull(Estocado.[1], 0) 
AS[EstoqueF1], isnull(Estocado.[2], 0) AS[EstoqueF2], isnull(Estocado.[3], 0) 
AS[EstoqueF3], isnull(Estocado.[4], 0) AS[EstoqueF4], (ISNULL(Estocado.[1], 0) + ISNULL(Estocado.[2], 0) + ISNULL(Estocado.[3], 0) + ISNULL(Estocado.[4], 0)) 
AS[TotalEstoque], round(isnull((VendasRealizadas.Total - ((isnull((VendasRealizadas.Total) / 3, 0)))), 0), 0) 
AS[SG1], round(isnull((VendasRealizadas.Total - ((ISNULL(Estocado.[1], 0) + ISNULL(Estocado.[2], 0) + ISNULL(Estocado.[3], 0) + ISNULL(Estocado.[4], 0)))), 0), 0) AS[SG3]
FROM Estocado JOIN VendasRealizadas ON VendasRealizadas.Prod_Serv_Codigo = Estocado.Prod_Serv_Codigo 
GROUP BY Estocado.Prod_Serv_Codigo, estocado.[1], estocado.[2], Estocado.[3], Estocado.[4], VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.[1], VendasRealizadas.[2], VendasRealizadas.[3], VendasRealizadas.[4], VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.Prod_Serv_Nome, VendasRealizadas.Total) 
select * from estocamento order by produto 
--AND Estoque_Data_Alteracao >= cast('2016-12-01 00:00:00' as datetime) 
--AND Estoque_Data_Alteracao <=cast ('2017-05-07 23:59:00' as datetime)  

--select * from Subclasses where Nome like '%eletrocal%'

--select * from [S9_Real].[dbo].[View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio] where Prod_Serv_Nome like '%cabo%' order by prod_serv_nome

--select top 1000 * from View_Movimento_Vendas_Varias_Filiais_Relatorio WHERE Movimento_Tipo_Operacao='vnd' AND Movimento_Data >= cast('2016-12-01 00:00:00' as datetime) 
--AND Movimento_Data <=cast ('2017-05-07 23:59:00' as datetime)  and
-- Prod_Serv_Nome like '%cabo 750%' order by Prod_Serv_Nome
--With Vendas as
--  (SELECT DISTINCT [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo, [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].[Prod_Serv_Nome] ,sum([Movimento_Prod_Serv_Qtde]) AS sales ,[Filiais_Codigo]
--   FROM [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio]
--   join [S9_Real].[dbo].Prod_Serv on [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo = [S9_Real].[dbo].Prod_Serv.Codigo
--   join [S9_Real].[dbo].Fabricantes on [S9_Real].[dbo].Prod_Serv.Ordem_Fabricante = [S9_Real].[dbo].Fabricantes.Ordem
--   WHERE Movimento_Tipo_Operacao='vnd'
--     AND Movimento_Data >= cast('{dtpInicio.Value:yyyy-MM-dd HH:mm:ss}' as datetime)
--     AND Movimento_Data <=cast ('{dtpFinal.Value:yyyy-MM-dd HH:mm:ss}' as datetime)
--	 AND [S9_Real].[dbo].Fabricantes.Nome='{cmbFabricantes.SelectedValue}'
--	 and 1=1
--   GROUP BY [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_nome, Filiais_Codigo, Prod_Serv_Codigo),
--            Vendo as
--  ( SELECT *
--   FROM Vendas pivot(max(sales) 
--                     FOR Filiais_Codigo IN ([1], [2], [3], [4])) AS pivoto ),
--                  VendasRealizadas as
--  ( SELECT *, (ISNULL(Vendo.[1],0) + ISNULL(Vendo.[2],0) + ISNULL(Vendo.[3],0)+ ISNULL(Vendo.[4],0)) AS Total
--   FROM Vendo ) ,
--                                   ProdEstoque as
--  (
-- SELECT prod_serv_codigo, sum(Estoque_Qtde_Estoque) AS QuantidadeEstoque, [S9_Real].[dbo].Filiais.Codigo
--   FROM [S9_Real].[dbo].[View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio]
--   JOIN [S9_Real].[dbo].Filiais ON [S9_Real].[dbo].[View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio].Filiais_Codigo = [S9_Real].[dbo].Filiais.Codigo
--   WHERE Filiais.Nome!='Não Cadastrada'
--     AND Estoque_Data_Alteracao >= cast('{dtpInicio.Value:yyyy-MM-dd HH:mm:ss}' as datetime)
--     AND Estoque_Data_Alteracao <=cast ('{dtpFinal.Value:yyyy-MM-dd HH:mm:ss}' as datetime)
--	 AND Classes_Codigo ={(int)cmbClasse.SelectedValue}
--	 AND Sub_Codigo={(int)cmbSubClasse.SelectedValue}
--   GROUP BY prod_serv_codigo, prod_serv_nome, Filiais.Codigo, Estoque_Data_Alteracao 
-- ),
--                                               Estocado as
--  ( SELECT *
--   FROM ProdEstoque pivot(max(QuantidadeEstoque)
--                          FOR Codigo IN ([1], [2], [3], [4])) AS pivoto),

--						  Estocamento as(SELECT VendasRealizadas.Prod_Serv_Nome as [Produto],
--       isnull(VendasRealizadas.[1],0) AS [VendasF1],
--       isnull(VendasRealizadas.[2],0) AS [VendasF2],
--       isnull(VendasRealizadas.[3],0) AS [VendasF3],
--	   isnull(VendasRealizadas.[4],0) AS [VendasF4],
--       isnull(VendasRealizadas.Total,0) AS [TotalVendas],
--	   isnull((VendasRealizadas.Total)/3,0) AS [MediaVendas],
--       isnull(Estocado.[1],0) AS [EstoqueF1],
--	   isnull(Estocado.[2],0) AS [EstoqueF2],
--       isnull(Estocado.[3],0) AS [EstoqueF3],
--	   isnull(Estocado.[4],0) AS [EstoqueF4],
--       (ISNULL(Estocado.[1],0) + ISNULL(Estocado.[2],0) + ISNULL(Estocado.[3],0)+ ISNULL(Estocado.[4],0)) AS [TotalEstoque],
--	   round(isnull((VendasRealizadas.Total - ((isnull((VendasRealizadas.Total)/3,0)))),0),0) AS [SG1],
--	   round(isnull((VendasRealizadas.Total - ((ISNULL(Estocado.[1],0) + ISNULL(Estocado.[2],0) + ISNULL(Estocado.[3],0)+ ISNULL(Estocado.[4],0)))),0),0) AS [SG3]
--FROM Estocado
--JOIN VendasRealizadas ON VendasRealizadas.Prod_Serv_Codigo = Estocado.Prod_Serv_Codigo
--GROUP BY Estocado.Prod_Serv_Codigo,
--         estocado.[1],
--         estocado.[2],
--         Estocado.[3],
--		 Estocado.[4],
--         VendasRealizadas.Prod_Serv_Codigo,
--         VendasRealizadas.[1],
--         VendasRealizadas.[2],
--         VendasRealizadas.[3],
--		 VendasRealizadas.[4],
--         VendasRealizadas.Prod_Serv_Codigo,
--         VendasRealizadas.Prod_Serv_Nome,
--         VendasRealizadas.Total)
--		 select * from estocamento order by produto

--		 --		 ,Tabelas as(
--		 --select Estocamento.EstoqueF1, Estocamento.EstoqueF2, Estocamento.EstoqueF3,Estocamento.EstoqueF4, Estocamento.Produto, Estocamento.SG1, Estocamento.SG3, 
--		 --Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF1, estocamento.VendasF2, estocamento.VendasF3, estocamento.VendasF4 from Estocamento)

--		 --select * from Tabelas order by produto

--		  --where [SG3]>'0,00' --filtro