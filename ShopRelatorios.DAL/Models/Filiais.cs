namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Filiais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filiais()
        {
            Movimento = new HashSet<Movimento>();
        }

        [Key]
        public int Ordem { get; set; }

        public int Ordem_Cidade { get; set; }

        public int Ordem_Pais { get; set; }

        public int Ordem_NFe_Parametro { get; set; }

        public int Ordem_Custo { get; set; }

        public int Ordem_Custo_Medio { get; set; }

        public int Ordem_Operacao_Venda_Consumidor { get; set; }

        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Razao_Social { get; set; }

        [Required]
        [StringLength(50)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(30)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(30)]
        public string Fone { get; set; }

        [Required]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [StringLength(9)]
        public string CEP { get; set; }

        [Required]
        [StringLength(18)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(20)]
        public string Inscricao_Estadual { get; set; }

        [Required]
        [StringLength(20)]
        public string Inscricao_Municipal { get; set; }

        [Required]
        [StringLength(9)]
        public string Inscricao_Suframa { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Data { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Arredondamento { get; set; }

        public int Cor_Fundo_Menu { get; set; }

        [Required]
        [StringLength(15)]
        public string Cor_Linhas_Relatorios { get; set; }

        public bool Verifica_Feriado_Bancario { get; set; }

        public bool Verifica_Feriado_Empresa { get; set; }

        public bool Trabalha_Sabado { get; set; }

        public bool Trabalha_Domingo { get; set; }

        public bool Somente_Dias_Abertos { get; set; }

        public bool Utilizo_Modulos_Fiscais { get; set; }

        public bool Nao_Avisar_Saidas_Abertas_Ao_Sair { get; set; }

        public bool Verificar_Conexao_Internet { get; set; }

        public bool Exibe_Liberacao_Data_Anterior { get; set; }

        public bool Gravar_Custo_Medio_Estoque_Todas_Filiais { get; set; }

        public bool Apenas_Permite_Entrar_Data_Servidor { get; set; }

        public byte Tipo_Sequencia_Nota { get; set; }

        public int Ultima_Sequencia { get; set; }

        public int Ultimo_DAV { get; set; }

        public int Ultima_PV { get; set; }

        public bool Gravar_Log { get; set; }

        public bool Gravar_Log_Mais_Detalhado { get; set; }

        public bool Busca_Cidade_SetaBaixo { get; set; }

        [Required]
        [StringLength(30)]
        public string Layout_Nota_Saida { get; set; }

        [Required]
        [StringLength(30)]
        public string Layout_Nota_Entrada { get; set; }

        [Required]
        [StringLength(30)]
        public string Layout_Ticket_Saida { get; set; }

        [Required]
        [StringLength(30)]
        public string Layout_Ticket_Entrada { get; set; }

        public int CRT { get; set; }

        [Column(TypeName = "money")]
        public decimal Optante_Simples_Perc_Aproveitamento { get; set; }

        public bool Inativo { get; set; }

        public DateTime? Data_Criacao { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Venda_Rapida { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Saidas { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Saidas_1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Saidas_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Saidas_3 { get; set; }

        public bool Nao_Exibir_Venda_Rapida { get; set; }

        public bool Nao_Exibir_Saidas { get; set; }

        public bool Nao_Exibir_Saidas_1 { get; set; }

        public bool Nao_Exibir_Saidas_2 { get; set; }

        public bool Nao_Exibir_Saidas_3 { get; set; }

        [Column(TypeName = "money")]
        public decimal Financeiro_Carencia { get; set; }

        [Column(TypeName = "money")]
        public decimal Financeiro_Juros { get; set; }

        [Column(TypeName = "money")]
        public decimal Financeiro_Multa { get; set; }

        [Column(TypeName = "money")]
        public decimal Financeiro_Desconto { get; set; }

        public bool Financeiro_Credito_Cliente { get; set; }

        public bool Financeiro_Nao_Gerar_Conta_Saidas { get; set; }

        public int Financeiro_Qtde_Dias_Cheque { get; set; }

        public bool Financeiro_Nao_Considerar_Cheques_Vencidos { get; set; }

        public bool Nao_Emite_NFe { get; set; }

        public bool Imprimir_Ticket_NF_Sem_Acento { get; set; }

        public bool Preview_Impressao_Ticket_NF { get; set; }

        public int Ordem_Cli_For { get; set; }

        public bool Bloqueado { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }

        [Required]
        [StringLength(15)]
        public string Complemento { get; set; }

        [Required]
        public string Imagem_Fundo_Menu { get; set; }

        [Required]
        public string Logotipo_Pequena { get; set; }

        public bool Utilizar_Atualizacao_Automatica { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Computador_Atualizacao_Automatica { get; set; }

        [Required]
        [StringLength(30)]
        public string Senha_Web_Atualizacao_Automatica { get; set; }

        [Required]
        [StringLength(2)]
        public string UF_Atualizacao_Automatica { get; set; }

        public DateTime Data_Alteracao { get; set; }

        public int Ordem_Funcionario_Alteracao { get; set; }

        [Required]
        [StringLength(32)]
        public string Validacao { get; set; }

        public int Ordem_Layout_Impressao_Ticket_Saida { get; set; }

        public int Ordem_Layout_Impressao_Ticket_Entrada { get; set; }

        public int NFe_Ordem_Filial_Configuracao { get; set; }

        public int NFe_Tipo_Ambiente { get; set; }

        public int NFe_Serie { get; set; }

        public int NFe_Num_Nota { get; set; }

        public bool NFe_Nao_Enviar_Complemento { get; set; }

        public int NFe_Qtde_Danfe { get; set; }

        public int NFe_Danfe_Entrada_Layout { get; set; }

        public bool NFe_Danfe_Entrada_Solicitar_Layout { get; set; }

        public int NFe_Danfe_Saida_Layout { get; set; }

        public bool NFe_Danfe_Saida_Solicitar_Layout { get; set; }

        public int NFe_Danfe_Logotipo_Tipo { get; set; }

        public bool NFe_Produtos_Grade_Utilizar_Nome_Completo { get; set; }

        public bool NFe_Solicitar_Data_Saida { get; set; }

        public bool Programa_Concessao_DF { get; set; }

        public bool Nao_Gravar_Log { get; set; }

        public bool Permitir_Efetivar_PV { get; set; }

        [Required]
        [StringLength(32)]
        public string Valida_U1 { get; set; }

        public int Ordem_Operacao_Estadual { get; set; }

        public bool Invalido { get; set; }

        public bool Nao_Importar_PV_Valor_Maior { get; set; }

        [Column(TypeName = "money")]
        public decimal Nao_Importar_PV_Valor { get; set; }

        [Required]
        [StringLength(100)]
        public string Contabilista_Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Contabilista_CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string Contabilista_CRC { get; set; }

        [Required]
        [StringLength(50)]
        public string Contabilista_CNPJ { get; set; }

        [Required]
        [StringLength(60)]
        public string Contabilista_Endereco { get; set; }

        [Required]
        [StringLength(50)]
        public string Contabilista_Complemento { get; set; }

        [Required]
        [StringLength(50)]
        public string Contabilista_Bairro { get; set; }

        [Required]
        [StringLength(30)]
        public string Contabilista_Cidade { get; set; }

        [Required]
        [StringLength(10)]
        public string Contabilista_Numero { get; set; }

        [Required]
        [StringLength(7)]
        public string Contabilista_Cod_IBGE_Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Contabilista_Cod_IBGE_UF { get; set; }

        [Required]
        [StringLength(2)]
        public string Contabilista_UF { get; set; }

        [Required]
        [StringLength(8)]
        public string Contabilista_CEP { get; set; }

        [Required]
        [StringLength(11)]
        public string Contabilista_Telefone { get; set; }

        [Required]
        [StringLength(11)]
        public string Contabilista_Fax { get; set; }

        [Required]
        [StringLength(250)]
        public string Contabilista_Email { get; set; }

        public int NFCe_Tipo_Ambiente { get; set; }

        public int NFCe_Serie { get; set; }

        public int NFCe_Num_Nota { get; set; }

        public int NFCe_Qtde_Danfe { get; set; }

        public int NFCe_Danfe_Logotipo_Tipo { get; set; }

        public int NFCe_Layout_Danfe { get; set; }

        [Required]
        [StringLength(36)]
        public string NFCe_Token { get; set; }

        [Required]
        [StringLength(6)]
        public string NFCe_IdToken { get; set; }

        public bool NFCe_Nao_Imprimir_Produtos { get; set; }

        public bool NFCe_Pre_Visualizar_Danfe { get; set; }

        public bool NFCe_Imprimir_Danfe_Automaticamente { get; set; }

        public bool NFCe_Enviar_Email_Apos_Autorizar { get; set; }

        public bool NFCe_Nao_Enviar_Complemento { get; set; }

        public int Ultimo_Carne { get; set; }

        public bool NFCe_Nao_enviar_Sem_Identificacao { get; set; }

        [Column(TypeName = "money")]
        public decimal NFCe_Valor_Sem_Identificacao { get; set; }

        [Required]
        [StringLength(30)]
        public string Fax { get; set; }

        [Required]
        public string Email { get; set; }

        public bool Usar_Impostos_Simples_Transferencia { get; set; }

        public bool NFe_Nao_Enviar_Carga_Tributaria_Por_Item { get; set; }

        [Required]
        [StringLength(5)]
        public string Contabilista_Caixa_Postal { get; set; }

        [Required]
        [StringLength(8)]
        public string Contabilista_CEP_Caixa_Postal { get; set; }

        public int Contabilista_Codigo_Assinante { get; set; }

        public int Indicador_IE { get; set; }

        [Required]
        [StringLength(120)]
        public string NFe_Observacao1 { get; set; }

        [Required]
        [StringLength(120)]
        public string NFe_Observacao2 { get; set; }

        [Required]
        [StringLength(120)]
        public string NFe_Observacao3 { get; set; }

        [Required]
        [StringLength(120)]
        public string NFe_Observacao4 { get; set; }

        public bool NFe_Nao_Enviar_Lotes_Prod_Nao_Medicamentos { get; set; }

        public bool SAT_Nao_Imprimir_Produtos { get; set; }

        public bool SAT_Imprimir_Extrato_Automatico { get; set; }

        public bool SAT_Enviar_Email_Automatico { get; set; }

        public bool SAT_Nao_Enviar_Complemento { get; set; }

        public int SAT_Numero_Sessao { get; set; }

        public int SAT_Layout_Extrato { get; set; }

        public int SAT_Extrato_Logotipo_Tipo { get; set; }

        public int SAT_Qtde_Extrato { get; set; }

        [Required]
        [StringLength(344)]
        public string SAT_Assinatura { get; set; }

        public bool SAT_Pre_Visualizar_Extrato { get; set; }

        public int SAT_Regime_Especial_ISS { get; set; }

        [Required]
        [StringLength(5000)]
        public string SAT_Observacao { get; set; }

        public bool Verificar_Estoque_Ideal { get; set; }

        public int Ordem_Funcionario_Estoque_Ideal { get; set; }

        public bool NFe_Enviar_Email_Apos_Autorizar { get; set; }

        public int NFSe_Tipo_Ambiente { get; set; }

        public int NFSe_Num_RPS { get; set; }

        public int NFSe_Num_Nota { get; set; }

        public int NFSe_Num_Lote { get; set; }

        public int NFSe_Serie { get; set; }

        public bool NFCe_Nao_Enviar_Carga_Tributaria_Por_Item { get; set; }

        public string NFCe_Logotipo_Danfe { get; set; }

        public bool NFCe_Enviar_Endereco_Valor_Total_Superior { get; set; }

        [Column(TypeName = "money")]
        public decimal NFCe_Valor_Condicao_Enviar_Endereco { get; set; }

        public bool? Permite_Logar_Somente_Data_Servidor { get; set; }

        public bool NFCe_Enviar_QRCode { get; set; }

        public bool Permitir_Impressao_Notas_Nao_Autorizadas { get; set; }

        public bool Utiliza_Bloco_K { get; set; }

        public bool NFe_Exibir_Numero_Sequencia_Fatura_Duplicata { get; set; }

        public int NFe_Tamanho_Fonte_Observacoes { get; set; }

        public int? Ordem_Funcionario_Msg_Azure { get; set; }

        public bool NFCe_Remover_Codigo_ANP { get; set; }

        public bool Gerar_Conta_Pagar_Icms_Partilha { get; set; }

        public bool NFCe_Enviar_Data_Emissao_Contingencia { get; set; }

        [Required]
        [StringLength(5000)]
        public string NFCe_Observacao { get; set; }

        public bool NFCe_Enviar_Tag_Cartoes { get; set; }

        public bool Nao_Gerar_Prod_Estoque_Fiscal { get; set; }

        public int MDFe_Tipo_Ambiente { get; set; }

        public int MDFe_Serie { get; set; }

        public int MDFe_Numero { get; set; }

        public int MDFe_Qtde_DAMDFE { get; set; }

        public int MDFe_DAMDFE_Logotipo_Tipo { get; set; }

        public bool Adiciona_CEST_NCM_Cupom { get; set; }

        public bool Permite_Label { get; set; }

        public bool Carol_Utilizar_Antecipacao_Financeira { get; set; }

        public int Tipo_Gerar_Conta_Pagar_Partilha_ICMS { get; set; }

        [Required]
        [StringLength(10)]
        public string SAT_Versao_Layout { get; set; }

        public bool Bloquear_Mais_Um_Documento_Fiscal { get; set; }

        [Column(TypeName = "money")]
        public decimal Carol_Perc_Minimo_Antecipacao_Financeira { get; set; }

        public bool SAT_Compartilhado { get; set; }

        public bool NFCe_Somar_Servicos_vProd { get; set; }

        public bool Perguntar_Comprovante_Impresso_TEF { get; set; }

        [Required]
        [StringLength(7)]
        public string CNAE { get; set; }

        public bool NFCe_Enviar_Grupo_Medicamentos { get; set; }

        public bool Carol_Utilizar_Limite_Otica_OS { get; set; }

        [Column(TypeName = "money")]
        public decimal Carol_Perc_Minimo_Saldo_Credito_Otica_OS { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Entradas { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Entradas_1 { get; set; }

        public bool Nao_Exibir_Entradas { get; set; }

        public bool Nao_Exibir_Entradas_1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimento> Movimento { get; set; }
    }
}
