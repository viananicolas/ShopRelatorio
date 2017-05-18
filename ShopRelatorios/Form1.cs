using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ShopRelatorios.DAL;
using ShopRelatorios.DAL.Models;
using ShopRelatorios.DAL.ViewModels;

namespace ShopRelatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new ShopModel())
            {
                var classes = await context.Classes.ToListAsync();
                var todasClasses = new Classes
                {
                    Codigo = 99999,
                    Data_Alteracao = DateTime.Now,
                    Inativo = false,
                    Nao_Envia_Web = false,
                    Nome = "Todos",
                    Ordem = 99999,
                    Ordem_Funcionario_Alteracao = 0,
                    Validacao = ""
                };
                classes.Add(todasClasses);
                cmbClasse.DataSource = classes;
                cmbClasse.DisplayMember = nameof(Classes.Nome);
                cmbClasse.ValueMember = nameof(Classes.Ordem);
                cmbClasse.SelectedItem = todasClasses;

                var subclasses = await context.Subclasses.ToListAsync();
                var todasSubclasses = new Subclasses
                {
                    Codigo = 99999,
                    Data_Alteracao = DateTime.Now,
                    Inativo = false,
                    Nao_Envia_Web = false,
                    Nome = "Todos",
                    Ordem = 99999,
                    Ordem_Funcionario_Alteracao = 0,
                    Validacao = ""
                };
                subclasses.Add(todasSubclasses);
                cmbSubClasse.DataSource = subclasses;
                cmbSubClasse.DisplayMember = nameof(Subclasses.Nome);
                cmbSubClasse.ValueMember = nameof(Subclasses.Ordem);
                cmbSubClasse.SelectedItem = todasSubclasses;



                var fabricantes = await context.Fabricantes.ToListAsync();
                var todosFabricantes = new ShopRelatorios.DAL.Models.Fabricantes
                {
                    Codigo = 99999,
                    Data_Alteracao = DateTime.Now,
                    Inativo = false,
                    Nao_Envia_Web = false,
                    Nome = "Todos",
                    Ordem = 0,
                    Ordem_Funcionario_Alteracao = 0,
                    Validacao = ""
                };
                fabricantes.Add(todosFabricantes);
                cmbFabricantes.DataSource = fabricantes;
                cmbFabricantes.DisplayMember = nameof(Fabricantes.Nome);
                cmbFabricantes.ValueMember = nameof(Fabricantes.Nome);
                cmbFabricantes.SelectedItem = todosFabricantes;

                var filiais = await context.Filiais.ToListAsync();
                var todasFiliais = new ShopRelatorios.DAL.Models.Filiais()
                {
                    Codigo = 99999,
                    Data_Alteracao = DateTime.Now,
                    Inativo = false,
                    Nome = "Todos",
                    Ordem = 0,
                    Ordem_Funcionario_Alteracao = 0,
                    Validacao = ""
                };
                filiais.Add(todasFiliais);
                cmbFiliais.DataSource = filiais;
                cmbFiliais.DisplayMember = nameof(Filiais.Nome);
                cmbFiliais.ValueMember = nameof(Filiais.Codigo);
                cmbFiliais.SelectedItem = todasFiliais;
            }
            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month-3,DateTime.Now.Day,0,0,0);
            dtpFinal.Value= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 0);
            this.reportViewer1.RefreshReport();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var sql = $"With Vendas as (SELECT DISTINCT [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo, " +
                          $"[S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].[Prod_Serv_Nome], " +
                          $"sum([Movimento_Prod_Serv_Qtde]) AS sales ,[Filiais_Codigo] " +
                          $"FROM [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio] " +
                          $"join [S9_Real].[dbo].Prod_Serv on [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo = [S9_Real].[dbo].Prod_Serv.Codigo " +
                          $"join [S9_Real].[dbo].Fabricantes on [S9_Real].[dbo].Prod_Serv.Ordem_Fabricante = [S9_Real].[dbo].Fabricantes.Ordem " +
                          $"WHERE Movimento_Tipo_Operacao='vnd' " +
                          $"AND Movimento_Data >= cast('{dtpInicio.Value:yyyy-MM-dd HH:mm:ss}' as datetime) " +
                          $"AND Movimento_Data <=cast ('{dtpFinal.Value:yyyy-MM-dd HH:mm:ss}' as datetime) " +
                          $"AND [S9_Real].[dbo].Fabricantes.Nome='{cmbFabricantes.SelectedValue}' " +
                          $"and 1=1 " +
                          $"GROUP BY [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_nome, Filiais_Codigo, Prod_Serv_Codigo), " +
                          $"Vendo as ( SELECT * FROM Vendas pivot(max(sales) FOR Filiais_Codigo IN ([1], [2], [3], [4])) AS pivoto ), " +
                          $"VendasRealizadas as ( SELECT *, (ISNULL(Vendo.[1],0) + ISNULL(Vendo.[2],0) + ISNULL(Vendo.[3],0)+ ISNULL(Vendo.[4],0))" +
                          $" AS Total FROM Vendo ), " +
                          $"ProdEstoque as ( SELECT Codigo_Prod_Serv as Prod_Serv_Codigo, max(Qtde_Estoque_Atual) " +
                          $"AS QuantidadeEstoque, [S9_Real].[dbo].Filiais.Codigo, Prod_Serv.Codigo as codprod " +
                          $"FROM [S9_Real].[dbo].[View_Estoque_Atual_Filial_Prod_Serv] " +
                      $"JOIN [S9_Real].[dbo].Filiais ON [S9_Real].[dbo].[View_Estoque_Atual_Filial_Prod_Serv].Codigo_Filial = [S9_Real].[dbo].Filiais.Codigo " +
                      $"join [S9_Real].[dbo].Prod_Serv ON View_Estoque_Atual_Filial_Prod_Serv.Codigo_Prod_Serv= Prod_Serv.Codigo " +
                      $"WHERE Filiais.Nome!='Não Cadastrada' AND Prod_Serv.Ordem_Subclasse={(int)cmbSubClasse.SelectedValue} " +
                      $"GROUP BY Codigo_Prod_Serv, Filiais.Codigo, Prod_Serv.Codigo, Qtde_Estoque_Atual), " +
                          $"Estocado as ( SELECT * FROM ProdEstoque pivot(max(QuantidadeEstoque) " +
                          $"FOR Codigo IN ([1], [2], [3], [4])) AS pivoto), " +
                          $"Estocamento as (SELECT VendasRealizadas.Prod_Serv_Nome as [Produto], isnull(VendasRealizadas.[1], 0) AS[VendasF1], " +
                          $"isnull(VendasRealizadas.[2], 0) AS[VendasF2], " +
                          $"isnull(VendasRealizadas.[3], 0) AS[VendasF3], " +
                          $"isnull(VendasRealizadas.[4], 0) AS[VendasF4], " +
                          $"isnull(VendasRealizadas.Total, 0) AS[TotalVendas], " +
                          $"isnull((VendasRealizadas.Total) / 3, 0) AS[MediaVendas], " +
                          $"isnull(Estocado.[1], 0) AS[EstoqueF1], " +
                          $"isnull(Estocado.[2], 0) AS[EstoqueF2], " +
                          $"isnull(Estocado.[3], 0) AS[EstoqueF3], " +
                          $"isnull(Estocado.[4], 0) AS[EstoqueF4], " +
                          $"(ISNULL(Estocado.[1], 0) + ISNULL(Estocado.[2], 0) + ISNULL(Estocado.[3], 0) + ISNULL(Estocado.[4], 0)) AS[TotalEstoque], " +
                          $"round(isnull((VendasRealizadas.Total - ((isnull((VendasRealizadas.Total) / 3, 0)))), 0), 0) AS[SG1], " +
                          $"round(isnull((VendasRealizadas.Total - ((ISNULL(Estocado.[1], 0) + ISNULL(Estocado.[2], 0) + ISNULL(Estocado.[3], 0) + ISNULL(Estocado.[4], 0)))), 0), 0) AS[SG3] " +
                          $"FROM Estocado JOIN VendasRealizadas ON VendasRealizadas.Prod_Serv_Codigo = Estocado.Prod_Serv_Codigo " +
                          $"GROUP BY Estocado.Prod_Serv_Codigo, estocado.[1], estocado.[2], Estocado.[3], Estocado.[4], " +
                          $"VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.[1], VendasRealizadas.[2], VendasRealizadas.[3], VendasRealizadas.[4], VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.Prod_Serv_Nome, VendasRealizadas.Total) " +
                          $"select * from estocamento order by produto ";
            var context = new ShopModel();
            var teste = dtpFinal.Value;
            if (cmbFabricantes.SelectedValue.ToString() == "Todos")
            {
                sql = sql.Replace($"AND [S9_Real].[dbo].Fabricantes.Nome='{cmbFabricantes.SelectedValue}' ", " ");
            }
            if ((int)cmbClasse.SelectedValue == 99999)
            {
                sql = sql.Replace($"AND Classes_Codigo ={(int)cmbClasse.SelectedValue} ", " ");
            }
            if ((int)cmbSubClasse.SelectedValue == 99999)
            {
                sql = sql.Replace($"AND Sub_Codigo={(int)cmbSubClasse.SelectedValue} ", " ");
            }
            if (checkBox1.Checked)
            {
                sql = sql.Replace($"select * from estocamento order by produto", $"select * from Estocamento where [SG3]>'0,00' order by Produto");
            }

            if (cmbFiliais.SelectedValue.ToString() == "1")
            {
                if (checkBox1.Checked)
                    sql = sql.Replace($"select * from Estocamento where [SG3]>'0,00' order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF1, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF1 " +
                        $"from Estocamento where [SG3]>'0,00') select * from Tabelas order by Produto");
                else
                {
                    sql = sql.Replace($"select * from Estocamento order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF1, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF1 " +
                        $"from Estocamento) select * from Tabelas order by Produto");
                }
            }
            if (cmbFiliais.SelectedValue.ToString() == "2")
            {
                if (checkBox1.Checked)
                    sql = sql.Replace($"select * from Estocamento where [SG3]>'0,00' order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF2, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF2 " +
                        $"from Estocamento where [SG3]>'0,00') select * from Tabelas order by Produto");
                else
                {
                    sql = sql.Replace($"select * from Estocamento order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF2, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF2 " +
                        $"from Estocamento) select * from Tabelas order by Produto");
                }
            }
            if (cmbFiliais.SelectedValue.ToString() == "3")
            {
                if (checkBox1.Checked)
                    sql = sql.Replace($"select * from Estocamento where [SG3]>'0,00' order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF3, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF3 " +
                        $"from Estocamento where [SG3]>'0,00') select * from Tabelas order by Produto");
                else
                {
                    sql = sql.Replace($"select * from Estocamento order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF3, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF3 " +
                        $"from Estocamento) select * from Tabelas order by Produto");
                }
            }
            if (cmbFiliais.SelectedValue.ToString() == "4")
            {
                if (checkBox1.Checked)
                    sql = sql.Replace($"select * from Estocamento where [SG3]>'0,00' order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF4, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF4 " +
                        $"from Estocamento where [SG3]>'0,00') select * from Tabelas order by Produto");
                else
                {
                    sql = sql.Replace($"select * from Estocamento order by Produto",
                        $",Tabelas as(select Estocamento.EstoqueF4, Estocamento.MediaVendas, Estocamento.Produto, " +
                        $"Estocamento.SG1, Estocamento.SG3,Estocamento.TotalEstoque, estocamento.TotalVendas, estocamento.VendasF4 " +
                        $"from Estocamento) select * from Tabelas order by Produto");
                }
            }


            var adapter = (IObjectContextAdapter)context;
            adapter.ObjectContext.CommandTimeout = 99999999;
            var estoque = adapter.ObjectContext.ExecuteStoreQuery<AnaliseEstoqueViewModel>(sql);
            AnaliseEstoqueViewModelBindingSource.DataSource = estoque;
            var a = new ReportParameter();
            reportViewer1.LocalReport.SetParameters(new List<ReportParameter> {});
            reportViewer1.RefreshReport();
            context.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//var sql = $"WITH Vendas as (SELECT DISTINCT [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo, " +
//          $"[S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].[Prod_Serv_Nome], " +
//          $"sum([Movimento_Prod_Serv_Qtde]) AS sales ,[Filiais_Nome] " +
//          $"FROM [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio] " +
//          $"join [S9_Real].[dbo].Prod_Serv on [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_Codigo = [S9_Real].[dbo].Prod_Serv.Codigo " +
//          $"join [S9_Real].[dbo].Fabricantes on [S9_Real].[dbo].Prod_Serv.Ordem_Fabricante = [S9_Real].[dbo].Fabricantes.Ordem " +
//          $"WHERE Movimento_Tipo_Operacao='vnd' " +
//          $"AND Movimento_Data >= cast('{dtpInicio.Value:yyyy-MM-dd HH:mm:ss}' as datetime) " +
//          $"AND Movimento_Data <=cast ('{dtpFinal.Value:yyyy-MM-dd HH:mm:ss}' as datetime) " +
//          $"AND [S9_Real].[dbo].Fabricantes.Nome='{cmbFabricantes.SelectedValue}' " +
//          $"GROUP BY [S9_Real].[dbo].[View_Movimento_Vendas_Varias_Filiais_Relatorio].Prod_Serv_nome, Filiais_Nome, Prod_Serv_Codigo), " +
//          $"Vendo as ( SELECT * FROM Vendas pivot(max(sales) FOR Filiais_Nome IN ([Ortho VR], [Dental Karisma], [VR Doctor])) AS pivoto), " +
//          $"VendasRealizadas as ( SELECT *, (ISNULL(Vendo.[Ortho VR],0) + ISNULL(Vendo.[Dental Karisma],0) + ISNULL(Vendo.[VR Doctor],0)) " +
//          $"AS Total FROM Vendo ), " +
//          $"ProdEstoque as ( SELECT prod_serv_codigo, sum(Estoque_Qtde_Estoque) AS QuantidadeEstoque, " +
//          $"[S9_Real].[dbo].Filiais.Nome FROM [S9_Real].[dbo].[View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio] " +
//          $"JOIN [S9_Real].[dbo].Filiais ON [S9_Real].[dbo].[View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio].Filiais_Codigo = [S9_Real].[dbo].Filiais.Codigo " +
//          $"WHERE Filiais.Nome!='Não Cadastrada' AND Estoque_Data_Alteracao >=cast ('{dtpInicio.Value:yyyy-MM-dd HH:mm:ss}' as datetime) " +
//          $"AND Estoque_Data_Alteracao <=cast ('{dtpFinal.Value:yyyy-MM-dd HH:mm:ss}' as DATETIME) " +
//          $"AND Classes_Codigo ={(int)cmbClasse.SelectedValue} " +
//          $"AND Sub_Codigo={(int)cmbSubClasse.SelectedValue} " +
//          $"GROUP BY prod_serv_codigo, prod_serv_nome, Filiais.Nome, Estoque_Data_Alteracao ), " +
//          $"Estocado as ( SELECT * FROM ProdEstoque pivot(max(QuantidadeEstoque) " +
//          $"FOR Nome IN ([Ortho VR], [Dental Karisma], [VR Doctor])) AS pivoto)," +
//          $"Estocamento as(SELECT VendasRealizadas.Prod_Serv_Nome as [Produto], isnull(VendasRealizadas.[Ortho VR],0) AS [VendasOrthoVR], " +
//          $"isnull(VendasRealizadas.[VR Doctor],0) AS [VendasVRDoctor], isnull(VendasRealizadas.[Dental Karisma],0) AS [VendasDentalKarisma], " +
//          $"isnull(VendasRealizadas.Total,0) AS [TotalVendas], isnull((VendasRealizadas.Total)/3,0) AS [MediaVendas], " +
//          $"isnull(Estocado.[Ortho VR],0) AS [EstoqueOrthoVR], isnull(Estocado.[VR Doctor],0) AS [EstoqueVRDoctor], " +
//          $"isnull(Estocado.[Dental Karisma],0) AS [EstoqueDentalKarisma], (ISNULL(Estocado.[Ortho VR],0) + " +
//          $"ISNULL(Estocado.[Dental Karisma],0) + ISNULL(Estocado.[VR Doctor],0)) AS [TotalEstoque], " +
//          $"round(isnull((VendasRealizadas.Total - ((isnull((VendasRealizadas.Total)/3,0)))),0),0) AS [SG1], " +
//          $"round(isnull((VendasRealizadas.Total - ((ISNULL(Estocado.[Ortho VR],0) + ISNULL(Estocado.[Dental Karisma],0) + " +
//          $"ISNULL(Estocado.[VR Doctor],0)))),0),0) AS [SG3] " +
//          $"FROM Estocado JOIN VendasRealizadas ON VendasRealizadas.Prod_Serv_Codigo = Estocado.Prod_Serv_Codigo " +
//          $"GROUP BY Estocado.Prod_Serv_Codigo, estocado.[Ortho VR], estocado.[Dental Karisma], " +
//          $"Estocado.[VR Doctor],VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.[Ortho VR], VendasRealizadas.[Dental Karisma], " +
//          $"VendasRealizadas.[VR Doctor], VendasRealizadas.Prod_Serv_Codigo, VendasRealizadas.Prod_Serv_Nome, VendasRealizadas.Total) " +
//          $"select * from Estocamento order by Produto";

