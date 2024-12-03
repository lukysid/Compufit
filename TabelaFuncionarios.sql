CREATE TABLE Funcionarios (
    Matricula INT IDENTITY(552000,1) PRIMARY KEY,    -- Matricula: Identificador único e auto-incrementado para cada funcionário, começando de 552000.
    Nome VARCHAR(100) NOT NULL,                      -- Nome: Nome completo do funcionário (campo obrigatório).
    RG VARCHAR(20),                                  -- RG: Número do Registro Geral (documento de identidade) do funcionário.
    CPF VARCHAR(20) NOT NULL,                        -- CPF: Cadastro de Pessoa Física, número único do funcionário (campo obrigatório).
    DataNascimento VARCHAR(10),                      -- DataNascimento: Data de nascimento do funcionário no formato 'DD/MM/YYYY'.
    Cargo VARCHAR(50),                               -- Cargo: Cargo ou função desempenhada pelo funcionário na empresa.
    Email VARCHAR(100),                              -- Email: Endereço de e-mail do funcionário.
    Telefone VARCHAR(15),                            -- Telefone: Número de telefone fixo do funcionário.
    Celular VARCHAR(15),                             -- Celular: Número de telefone celular do funcionário.
    CEP VARCHAR(10),                                 -- CEP: Código de Endereçamento Postal, utilizado para o endereço do funcionário.
    Endereco VARCHAR(150),                           -- Endereco: Endereço completo do funcionário.
    Numero VARCHAR(8),                               -- Numero: Número da residência do funcionário.
    Cidade VARCHAR(100),                             -- Cidade: Cidade onde o funcionário reside.
    Estado VARCHAR(5),                               -- Estado: Sigla do estado onde o funcionário reside (ex: SP, RJ, MG).
    Senha VARCHAR(50) NOT NULL                       -- Senha: Senha de acesso do funcionário, campo obrigatório.
);
