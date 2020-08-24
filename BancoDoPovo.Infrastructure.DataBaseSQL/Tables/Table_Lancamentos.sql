CREATE TABLE [dbo].[Lancamentos](
	[Id] [int] NOT NULL,
	[ContaOrigem] [int] NULL,
	[ContaDestino] [int] NULL,
	[Operacao] [nvarchar](50) NULL,
	[Valor] [decimal](18, 2) NULL,
        [DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_Lancamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]