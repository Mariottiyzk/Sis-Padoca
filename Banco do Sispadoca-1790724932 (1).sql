CREATE TABLE IF NOT EXISTS `tipocliente` (
	`id` int AUTO_INCREMENT NOT NULL,
	`descricao` varchar(100) NOT NULL,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `fornecedores` (
	`id` int AUTO_INCREMENT NOT NULL,
	`nome` varchar(100) NOT NULL,
	`cnpj` varchar(18) NOT NULL,
	`telefone` varchar(20) NOT NULL,
	`email` varchar(100) NOT NULL,
	`endereco` varchar(200) NOT NULL,
	`cidade` varchar(100) NOT NULL,
	`data_cadastro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `funcionarios` (
	`id` int AUTO_INCREMENT NOT NULL,
	`nome` varchar(100) NOT NULL,
	`cpf` varchar(14) NOT NULL,
	`telefone` varchar(20) NOT NULL,
	`cargo` varchar(50) NOT NULL,
	`salario` decimal(10,2) NOT NULL,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `contas` (
	`id` int AUTO_INCREMENT NOT NULL,
	`descricao` varchar(255) NOT NULL,
	`valor` decimal(10,2) NOT NULL,
	`data_vencimento` date NOT NULL,
	`data_pagamento` date,
	`observacao` text NOT NULL,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `clientes` (
	`id` int AUTO_INCREMENT NOT NULL,
	`id_tipocliente` int DEFAULT 'null',
	`nome` varchar(100) NOT NULL,
	`cpf` varchar(14) NOT NULL,
	`telefone` varchar(20) NOT NULL,
	`email` varchar(100) NOT NULL,
	`datanascimento` date DEFAULT 'null',
	`endereco` varchar(200) NOT NULL,
	`cidade` varchar(100) NOT NULL,
	`login` varchar(20) NOT NULL,
	`senha` varchar(50) NOT NULL,
	`datacadastro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	`dataultimoacesso` datetime DEFAULT 'null',
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `produtos` (
	`id` int AUTO_INCREMENT NOT NULL,
	`fornecedor_id` int NOT NULL,
	`ncm` varchar(100) NOT NULL,
	`descricao` varchar(200) NOT NULL,
	`categoria` varchar(50) NOT NULL,
	`preco_custo` decimal(10,2) NOT NULL,
	`preco_venda` decimal(10,2) NOT NULL,
	`lote` int NOT NULL,
	`codigodebarras` int NOT NULL,
	`unidade_medida` varchar(20) NOT NULL DEFAULT 'UN',
	`estoque` int NOT NULL DEFAULT 0,
	`estoque_minimo` int NOT NULL DEFAULT 0,
	`ativo` boolean NOT NULL DEFAULT true,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `estoque` (
	`id` int AUTO_INCREMENT NOT NULL,
	`produto_id` int NOT NULL,
	`quantidade` decimal(10,3) NOT NULL,
	`motivo` varchar(255) NOT NULL,
	`data_movimentacao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `vendas` (
	`id` int AUTO_INCREMENT NOT NULL,
	`cliente_id` int,
	`data_venda` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	`valor_total` decimal(10,2) NOT NULL,
	PRIMARY KEY (`id`)
);
ALTER TABLE `clientes` ADD CONSTRAINT `fk_clientes_id_tipocliente` FOREIGN KEY (id_tipocliente) REFERENCES tipocliente (id);
ALTER TABLE `produtos` ADD CONSTRAINT `fk_produtos_fornecedor_id` FOREIGN KEY (fornecedor_id) REFERENCES fornecedores (id);
ALTER TABLE `estoque` ADD CONSTRAINT `fk_estoque_produto_id` FOREIGN KEY (produto_id) REFERENCES produtos (id);
ALTER TABLE `vendas` ADD CONSTRAINT `fk_vendas_cliente_id` FOREIGN KEY (cliente_id) REFERENCES clientes (id);