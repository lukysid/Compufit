CREATE TABLE Clientes (
    Matricula INT IDENTITY(662000,1) PRIMARY KEY,     -- Matricula: Identificador único e auto-incrementado para cada cliente, começando de 662000.
    Nome VARCHAR(100) NOT NULL,                       -- Nome: Nome completo do cliente (campo obrigatório).
    RG VARCHAR(20),                                   -- RG: Número do Registro Geral (documento de identificação) do cliente.
    CPF VARCHAR(20) NOT NULL,                         -- CPF: Cadastro de Pessoa Física, número único do cliente (campo obrigatório).
    DataNascimento VARCHAR(10),                       -- DataNascimento: Data de nascimento do cliente no formato 'DD/MM/YYYY'.
    Email VARCHAR(100),                               -- Email: Endereço de e-mail do cliente.
    Telefone VARCHAR(15),                             -- Telefone: Número de telefone fixo do cliente.
    Celular VARCHAR(15),                              -- Celular: Número de telefone celular do cliente.
    CEP VARCHAR(10),                                  -- CEP: Código de Endereçamento Postal, utilizado para o endereço do cliente.
    Endereco VARCHAR(150),                            -- Endereco: Endereço completo do cliente.
    Numero VARCHAR(8),                                -- Numero: Número da residência do cliente.
    Cidade VARCHAR(100),                              -- Cidade: Cidade onde o cliente reside.
    Estado VARCHAR(5)                                 -- Estado: Sigla do estado onde o cliente reside (ex: SP, RJ, MG).
);