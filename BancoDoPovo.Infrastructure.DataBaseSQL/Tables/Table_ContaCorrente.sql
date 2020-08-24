CREATE TABLE [dbo].[ContaCorrente](
	[Id] [int] NOT NULL,
	[NomeCorrentista] [nvarchar](50) NULL,
	[Agencia] [int] NULL,
	[NumeroContaCorrente] [int] NULL,
	[Digito] [int] NULL,
	[Saldo] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Conta_Corrente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]