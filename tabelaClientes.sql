CREATE TABLE Clientes (
    Matricula INT IDENTITY(662000,1) PRIMARY KEY,     -- Matricula: Identificador �nico e auto-incrementado para cada cliente, come�ando de 662000.
    Nome VARCHAR(100) NOT NULL,                       -- Nome: Nome completo do cliente (campo obrigat�rio).
    RG VARCHAR(20),                                   -- RG: N�mero do Registro Geral (documento de identifica��o) do cliente.
    CPF VARCHAR(20) NOT NULL,                         -- CPF: Cadastro de Pessoa F�sica, n�mero �nico do cliente (campo obrigat�rio).
    DataNascimento VARCHAR(10),                       -- DataNascimento: Data de nascimento do cliente no formato 'DD/MM/YYYY'.
    Email VARCHAR(100),                               -- Email: Endere�o de e-mail do cliente.
    Telefone VARCHAR(15),                             -- Telefone: N�mero de telefone fixo do cliente.
    Celular VARCHAR(15),                              -- Celular: N�mero de telefone celular do cliente.
    CEP VARCHAR(10),                                  -- CEP: C�digo de Endere�amento Postal, utilizado para o endere�o do cliente.
    Endereco VARCHAR(150),                            -- Endereco: Endere�o completo do cliente.
    Numero VARCHAR(8),                                -- Numero: N�mero da resid�ncia do cliente.
    Cidade VARCHAR(100),                              -- Cidade: Cidade onde o cliente reside.
    Estado VARCHAR(5)                                 -- Estado: Sigla do estado onde o cliente reside (ex: SP, RJ, MG).
);