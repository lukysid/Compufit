CREATE TABLE RegistroAcesso (
    Id INT IDENTITY(1,1) PRIMARY KEY,						 -- Identificador �nico para cada registro (auto incremento)
    Matricula INT NOT NULL,									 -- Matricula do cliente
    Tipo VARCHAR(15) NOT NULL,								 -- Tipo de movimenta��o
    DataHora DATETIME NOT NULL,							     -- Data e hor�rio da movimenta��o
    FOREIGN KEY (Matricula) REFERENCES clientes(matricula)   -- Chave estrangeira sem a cl�usula ON DELETE CASCADE
);