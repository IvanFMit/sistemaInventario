CREATE TABLE [dbo].[Renta] (
    [Id]                    INT             IDENTITY (1, 1) NOT NULL,
    [CodigoProductoConsola] INT             NOT NULL,
    [Fecha]                 DATETIME        NOT NULL,
    [CodigoTipoRenta]       INT             NOT NULL,
    [PrecioRenta]           DECIMAL (18, 2) NOT NULL,
    [Documento]             VARCHAR (50)    NOT NULL,
    [TipoDocumento]         VARCHAR (10)    NOT NULL,
    [CodigoCliente] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Renta_ToTable_1] FOREIGN KEY ([CodigoTipoRenta]) REFERENCES [dbo].[TipoRenta] ([Id]),
    CONSTRAINT [FK_Renta_ToTable] FOREIGN KEY ([CodigoProductoConsola]) REFERENCES [dbo].[ProductoConsola] ([Id])
);

