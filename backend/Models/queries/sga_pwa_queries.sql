-- Database: sga_teste

-- DROP TABLE IF EXISTS matriculas;

-- CREATE TABLE matriculas(
-- 	id SERIAL PRIMARY KEY,
-- 	estudante_id INTEGER,
-- 	curso_id INTEGER,
-- 	created_at DATE
-- );

-- ALTER TABLE matriculas
-- 	ADD CONSTRAINT estudante_fk
-- 	FOREIGN KEY (estudante_id)
-- 	REFERENCES estudantes(id);

-- ALTER TABLE inscricoes
-- ADD CONSTRAINT estudante_fk
-- FOREIGN KEY (estudante_id)
-- REFERENCES estudantes(id);

-- ALTER TABLE inscricoes
-- ADD CONSTRAINT turma_fk
-- FOREIGN KEY (turma_id)
-- REFERENCES turmas(id);

-- ALTER TABLE notas
-- ADD CONSTRAINT estudante_fk
-- FOREIGN KEY (estudante_id)
-- REFERENCES estudantes(id);

-- ALTER TABLE notas
-- ADD CONSTRAINT disciplina_fk
-- FOREIGN KEY (disciplina_id)
-- REFERENCES disciplinas(id);

-- ALTER TABLE exames
-- ADD CONSTRAINT disciplina_fk
-- FOREIGN KEY (disciplina_id)
-- REFERENCES disciplinas(id);
	
-- ALTER TABLE matriculas
-- DROP CONSTRAINT estudante_fk;

-- ALTER TABLE matriculas
-- ADD COLUMN created_at TIMESTAMP;

-- DELETE FROM cursos
-- WHERE id=2;

-- INSERT INTO cursos (nome, created_at)
-- 	VALUES('Desenvolvimento de Software', '05/11/2023');

-- UPDATE matriculas
-- SET created_at = now()
-- WHERE id=2;

SELECT * FROM matriculas
WHERE estudante_id = 1;

SELECT * FROM cursos
WHERE id = 1;

SELECT * FROM estudantes;

--=========================== ESTUDANTE > CURSOS > DISCIPLINAS ===========================
SELECT * FROM inscricoes;
SELECT * FROM turmas;
SELECT * FROM disciplinas;
SELECT * FROM notas;
SELECT * FROM exames;



-- INSERT INTO notas (teste1, teste2, trabalho1, trabalho2, obs, created_at)
-- 	VALUES (14, 14, 14, 14, 'Admitido', now());

-- INSERT INTO exames (notaFrequencia, normal, recorrencia, obs, created_at)
-- 	VALUES (14, 4, 15, 'Aprovado', now());

-- INSERT INTO turmas (nome, horario, created_at)
-- 	VALUES ('1L1LDS1', 'Depois vejo como faço', now());

-- INSERT INTO disciplinas (nome, created_at)
-- VALUES ('Análise e Desenho de Sistemas', now());


	
create database paypro;
alter database paypro owner to postgres;

create schema master;
alter schema master owner to postgres;

create schema historic;
alter schema historic owner to postgres;








