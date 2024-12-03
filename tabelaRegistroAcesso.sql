CREATE TABLE RegistroAcesso (
    Id INT IDENTITY(1,1) PRIMARY KEY,						 -- Identificador único para cada registro (auto incremento)
    Matricula INT NOT NULL,									 -- Matricula do cliente
    Tipo VARCHAR(15) NOT NULL,								 -- Tipo de movimentação
    DataHora DATETIME NOT NULL,							     -- Data e horário da movimentação
    FOREIGN KEY (Matricula) REFERENCES clientes(matricula)   -- Chave estrangeira sem a cláusula ON DELETE CASCADE
);