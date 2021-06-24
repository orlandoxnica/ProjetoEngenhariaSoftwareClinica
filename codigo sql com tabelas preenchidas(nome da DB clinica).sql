-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Jun-2021 às 17:44
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `clinica`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `exercicio`
--

CREATE TABLE `exercicio` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `exercicio`
--

INSERT INTO `exercicio` (`id`, `nome`) VALUES
(1, 'Bicicleta'),
(2, 'Caminhada');

-- --------------------------------------------------------

--
-- Estrutura da tabela `medicamento`
--

CREATE TABLE `medicamento` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `medicamento`
--

INSERT INTO `medicamento` (`id`, `nome`) VALUES
(1, 'Brufen'),
(2, 'Ben-u-Ron');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL,
  `identificacao` int(9) UNSIGNED NOT NULL,
  `dataNascimento` date NOT NULL,
  `telefone` int(9) NOT NULL,
  `sobrenome` varchar(45) NOT NULL,
  `morada` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`id`, `nome`, `identificacao`, `dataNascimento`, `telefone`, `sobrenome`, `morada`) VALUES
(1, 'Silvio', 999999999, '1997-11-16', 930293029, 'Silva', 'Rua do Comboio Nº1'),
(2, 'Raul', 888888888, '1996-06-27', 920392320, 'Gonçalves', 'Rua dos Tanques Nº22'),
(3, 'Filipe', 777777777, '1998-06-24', 910323923, 'Gomes', 'Estrada das Neves Nº2A'),
(4, 'José', 666666666, '1960-06-24', 960123912, 'Alejandro', 'Rua do Comboio Nº12');

-- --------------------------------------------------------

--
-- Estrutura da tabela `planotratamento`
--

CREATE TABLE `planotratamento` (
  `id` int(10) UNSIGNED NOT NULL,
  `idUtente` int(10) UNSIGNED NOT NULL,
  `Terapeuta_id` int(10) UNSIGNED NOT NULL,
  `dataInicioTratamento` date NOT NULL,
  `dataFimTratamento` date NOT NULL,
  `Tratamento` varchar(100) NOT NULL,
  `horarioMedicacao` varchar(100) NOT NULL,
  `medicamentos` varchar(100) NOT NULL,
  `exercicios` varchar(100) NOT NULL,
  `horarioExercicios` varchar(100) NOT NULL,
  `terapeutaNome` varchar(100) NOT NULL,
  `terapeutaSobrenome` varchar(100) NOT NULL,
  `NomeUtenteTratar` varchar(100) NOT NULL,
  `SobrenomeUtenteTratar` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `planotratamento`
--

INSERT INTO `planotratamento` (`id`, `idUtente`, `Terapeuta_id`, `dataInicioTratamento`, `dataFimTratamento`, `Tratamento`, `horarioMedicacao`, `medicamentos`, `exercicios`, `horarioExercicios`, `terapeutaNome`, `terapeutaSobrenome`, `NomeUtenteTratar`, `SobrenomeUtenteTratar`) VALUES
(1, 1, 1, '2021-06-24', '2021-07-24', 'Terapia', 'De 12 em 12 Horas', 'Ben-u-Ron', 'Bicicleta', '30 Minutos por dia', 'Raul', 'Gonçalves', 'Filipe', 'Gomes');

-- --------------------------------------------------------

--
-- Estrutura da tabela `planotratamento_tem_exercicio`
--

CREATE TABLE `planotratamento_tem_exercicio` (
  `idPlanoTratamento` int(10) UNSIGNED NOT NULL,
  `idExercicio` int(10) UNSIGNED NOT NULL,
  `sugestaoHorario` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `planotratamento_tem_medicamento`
--

CREATE TABLE `planotratamento_tem_medicamento` (
  `idPlanoTratamento` int(10) UNSIGNED NOT NULL,
  `idMedicamento` int(10) UNSIGNED NOT NULL,
  `dataFim` date NOT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescricao`
--

CREATE TABLE `prescricao` (
  `id` int(10) UNSIGNED NOT NULL,
  `data` date NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `idAutorTerapeuta` int(10) UNSIGNED NOT NULL,
  `idUtente` int(10) UNSIGNED NOT NULL,
  `nomeUtente` varchar(45) NOT NULL,
  `sobrenomeUtente` varchar(45) NOT NULL,
  `horarioMedicacao` varchar(45) DEFAULT NULL,
  `medicamento` varchar(100) DEFAULT NULL,
  `tratamento` varchar(100) DEFAULT NULL,
  `exercicios` varchar(100) DEFAULT NULL,
  `horarioexercicios` varchar(45) DEFAULT NULL,
  `nomeTerapeuta` varchar(45) NOT NULL,
  `sobrenomeTerapeuta` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `prescricao`
--

INSERT INTO `prescricao` (`id`, `data`, `descricao`, `idAutorTerapeuta`, `idUtente`, `nomeUtente`, `sobrenomeUtente`, `horarioMedicacao`, `medicamento`, `tratamento`, `exercicios`, `horarioexercicios`, `nomeTerapeuta`, `sobrenomeTerapeuta`) VALUES
(1, '2021-06-24', 'Paciente deverá realizar análises.', 1, 1, 'Filipe', 'Gomes', 'De 12 em 12 Horas', 'Ben-u-Ron', 'Terapia', 'Bicicleta', '30 Minutos por dia', 'Raul', 'Gonçalves');

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescricao_tem_exercicio`
--

CREATE TABLE `prescricao_tem_exercicio` (
  `idPrescricao` int(10) UNSIGNED NOT NULL,
  `idExercicio` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescricao_tem_medicamento`
--

CREATE TABLE `prescricao_tem_medicamento` (
  `idPrescricao` int(10) UNSIGNED NOT NULL,
  `idMedicamento` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescricao_tem_tratamento`
--

CREATE TABLE `prescricao_tem_tratamento` (
  `idPrescricao` int(10) UNSIGNED NOT NULL,
  `idTratamento` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `sessaotratamento`
--

CREATE TABLE `sessaotratamento` (
  `id` int(10) UNSIGNED NOT NULL,
  `Terapeuta_id` int(10) UNSIGNED NOT NULL,
  `paciente` varchar(45) NOT NULL,
  `descricao` varchar(45) NOT NULL,
  `dataRealizacao` date NOT NULL,
  `MedicacaoUtilizada` varchar(100) NOT NULL,
  `TipoTratamento` varchar(100) NOT NULL,
  `ExercicioARealizar` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `sessaotratamento`
--

INSERT INTO `sessaotratamento` (`id`, `Terapeuta_id`, `paciente`, `descricao`, `dataRealizacao`, `MedicacaoUtilizada`, `TipoTratamento`, `ExercicioARealizar`) VALUES
(1, 1, 'Filipe Gomes', 'Paciente demonstra sinais de ansiedade alta.', '2021-06-24', 'Ben-u-Ron', 'Terapia', 'Bicicleta');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sessaotratamento_tem_tratamento`
--

CREATE TABLE `sessaotratamento_tem_tratamento` (
  `idSessaoTratamento` int(10) UNSIGNED NOT NULL,
  `idTratamento` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `terapeuta`
--

CREATE TABLE `terapeuta` (
  `id` int(10) UNSIGNED NOT NULL,
  `idUtilizador` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `terapeuta`
--

INSERT INTO `terapeuta` (`id`, `idUtilizador`) VALUES
(1, 2),
(2, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `terapeuta_tem_prescricao`
--

CREATE TABLE `terapeuta_tem_prescricao` (
  `idTerapeuta` int(10) UNSIGNED NOT NULL,
  `idPrescricao` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `terapeuta_tem_prescricao`
--

INSERT INTO `terapeuta_tem_prescricao` (`idTerapeuta`, `idPrescricao`) VALUES
(1, 1),
(2, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tratamento`
--

CREATE TABLE `tratamento` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tratamento`
--

INSERT INTO `tratamento` (`id`, `nome`) VALUES
(1, 'Terapia'),
(2, 'Hemodiálise');

-- --------------------------------------------------------

--
-- Estrutura da tabela `utente`
--

CREATE TABLE `utente` (
  `id` int(10) UNSIGNED NOT NULL,
  `idUtilizador` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `utente`
--

INSERT INTO `utente` (`id`, `idUtilizador`) VALUES
(1, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizador`
--

CREATE TABLE `utilizador` (
  `id` int(10) UNSIGNED NOT NULL,
  `password` varchar(45) NOT NULL,
  `bTerapeuta` int(1) NOT NULL,
  `bUtente` int(1) NOT NULL,
  `bAdmin` int(1) NOT NULL,
  `idPessoa` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `utilizador`
--

INSERT INTO `utilizador` (`id`, `password`, `bTerapeuta`, `bUtente`, `bAdmin`, `idPessoa`) VALUES
(1, '123456', 1, 1, 1, 1),
(2, '123456', 1, 0, 0, 2),
(3, '123456', 0, 1, 0, 3),
(4, '123456', 1, 0, 0, 4);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `exercicio`
--
ALTER TABLE `exercicio`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `medicamento`
--
ALTER TABLE `medicamento`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `identificacao_UNIQUE` (`identificacao`);

--
-- Índices para tabela `planotratamento`
--
ALTER TABLE `planotratamento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_PlanoTratamento_Utente1_idx` (`idUtente`),
  ADD KEY `fk_PlanoTratamento_Terapeuta1_idx` (`Terapeuta_id`);

--
-- Índices para tabela `planotratamento_tem_exercicio`
--
ALTER TABLE `planotratamento_tem_exercicio`
  ADD PRIMARY KEY (`idPlanoTratamento`,`idExercicio`),
  ADD KEY `fk_PlanoTratamento_has_Exercicio_Exercicio1_idx` (`idExercicio`),
  ADD KEY `fk_PlanoTratamento_has_Exercicio_PlanoTratamento1_idx` (`idPlanoTratamento`);

--
-- Índices para tabela `planotratamento_tem_medicamento`
--
ALTER TABLE `planotratamento_tem_medicamento`
  ADD PRIMARY KEY (`idPlanoTratamento`,`idMedicamento`),
  ADD KEY `fk_PlanoTratamento_has_Medicamento_Medicamento1_idx` (`idMedicamento`),
  ADD KEY `fk_PlanoTratamento_has_Medicamento_PlanoTratamento1_idx` (`idPlanoTratamento`);

--
-- Índices para tabela `prescricao`
--
ALTER TABLE `prescricao`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Prescricao_Utente1_idx` (`idUtente`),
  ADD KEY `fk_Prescricao_Terapeuta1_idx` (`idAutorTerapeuta`);

--
-- Índices para tabela `prescricao_tem_exercicio`
--
ALTER TABLE `prescricao_tem_exercicio`
  ADD PRIMARY KEY (`idPrescricao`,`idExercicio`),
  ADD KEY `fk_Prescricao_has_Exercicio_Exercicio1_idx` (`idExercicio`),
  ADD KEY `fk_Prescricao_has_Exercicio_Prescricao1_idx` (`idPrescricao`);

--
-- Índices para tabela `prescricao_tem_medicamento`
--
ALTER TABLE `prescricao_tem_medicamento`
  ADD PRIMARY KEY (`idPrescricao`,`idMedicamento`),
  ADD KEY `fk_Prescricao_has_Medicamento_Medicamento1_idx` (`idMedicamento`),
  ADD KEY `fk_Prescricao_has_Medicamento_Prescricao1_idx` (`idPrescricao`);

--
-- Índices para tabela `prescricao_tem_tratamento`
--
ALTER TABLE `prescricao_tem_tratamento`
  ADD PRIMARY KEY (`idPrescricao`,`idTratamento`),
  ADD KEY `fk_Prescricao_has_Tratamento_Tratamento1_idx` (`idTratamento`),
  ADD KEY `fk_Prescricao_has_Tratamento_Prescricao1_idx` (`idPrescricao`);

--
-- Índices para tabela `sessaotratamento`
--
ALTER TABLE `sessaotratamento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_SessaoTratamento_Terapeuta1_idx` (`Terapeuta_id`);

--
-- Índices para tabela `sessaotratamento_tem_tratamento`
--
ALTER TABLE `sessaotratamento_tem_tratamento`
  ADD PRIMARY KEY (`idSessaoTratamento`,`idTratamento`),
  ADD KEY `fk_SessaoTratamento_has_Tratamento_Tratamento1_idx` (`idTratamento`),
  ADD KEY `fk_SessaoTratamento_has_Tratamento_SessaoTratamento1_idx` (`idSessaoTratamento`);

--
-- Índices para tabela `terapeuta`
--
ALTER TABLE `terapeuta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Terapeuta_utilizador1_idx` (`idUtilizador`);

--
-- Índices para tabela `terapeuta_tem_prescricao`
--
ALTER TABLE `terapeuta_tem_prescricao`
  ADD PRIMARY KEY (`idTerapeuta`,`idPrescricao`),
  ADD KEY `fk_Terapeuta_has_Prescricao_Prescricao1_idx` (`idPrescricao`),
  ADD KEY `fk_Terapeuta_has_Prescricao_Terapeuta1_idx` (`idTerapeuta`);

--
-- Índices para tabela `tratamento`
--
ALTER TABLE `tratamento`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `utente`
--
ALTER TABLE `utente`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Utente_utilizador1_idx` (`idUtilizador`);

--
-- Índices para tabela `utilizador`
--
ALTER TABLE `utilizador`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_utilizador_Pessoa1_idx` (`idPessoa`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `exercicio`
--
ALTER TABLE `exercicio`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `medicamento`
--
ALTER TABLE `medicamento`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `pessoa`
--
ALTER TABLE `pessoa`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `planotratamento`
--
ALTER TABLE `planotratamento`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `prescricao`
--
ALTER TABLE `prescricao`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `sessaotratamento`
--
ALTER TABLE `sessaotratamento`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `terapeuta`
--
ALTER TABLE `terapeuta`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tratamento`
--
ALTER TABLE `tratamento`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `utente`
--
ALTER TABLE `utente`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `utilizador`
--
ALTER TABLE `utilizador`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `planotratamento`
--
ALTER TABLE `planotratamento`
  ADD CONSTRAINT `fk_PlanoTratamento_Terapeuta1` FOREIGN KEY (`Terapeuta_id`) REFERENCES `terapeuta` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_PlanoTratamento_Utente1` FOREIGN KEY (`idUtente`) REFERENCES `utente` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `planotratamento_tem_exercicio`
--
ALTER TABLE `planotratamento_tem_exercicio`
  ADD CONSTRAINT `fk_PlanoTratamento_has_Exercicio_Exercicio1` FOREIGN KEY (`idExercicio`) REFERENCES `exercicio` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_PlanoTratamento_has_Exercicio_PlanoTratamento1` FOREIGN KEY (`idPlanoTratamento`) REFERENCES `planotratamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `planotratamento_tem_medicamento`
--
ALTER TABLE `planotratamento_tem_medicamento`
  ADD CONSTRAINT `fk_PlanoTratamento_has_Medicamento_Medicamento1` FOREIGN KEY (`idMedicamento`) REFERENCES `medicamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_PlanoTratamento_has_Medicamento_PlanoTratamento1` FOREIGN KEY (`idPlanoTratamento`) REFERENCES `planotratamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `prescricao`
--
ALTER TABLE `prescricao`
  ADD CONSTRAINT `fk_Prescricao_Terapeuta1` FOREIGN KEY (`idAutorTerapeuta`) REFERENCES `terapeuta` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Prescricao_Utente1` FOREIGN KEY (`idUtente`) REFERENCES `utente` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `prescricao_tem_exercicio`
--
ALTER TABLE `prescricao_tem_exercicio`
  ADD CONSTRAINT `fk_Prescricao_has_Exercicio_Exercicio1` FOREIGN KEY (`idExercicio`) REFERENCES `exercicio` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Prescricao_has_Exercicio_Prescricao1` FOREIGN KEY (`idPrescricao`) REFERENCES `prescricao` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `prescricao_tem_medicamento`
--
ALTER TABLE `prescricao_tem_medicamento`
  ADD CONSTRAINT `fk_Prescricao_has_Medicamento_Medicamento1` FOREIGN KEY (`idMedicamento`) REFERENCES `medicamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Prescricao_has_Medicamento_Prescricao1` FOREIGN KEY (`idPrescricao`) REFERENCES `prescricao` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `prescricao_tem_tratamento`
--
ALTER TABLE `prescricao_tem_tratamento`
  ADD CONSTRAINT `fk_Prescricao_has_Tratamento_Prescricao1` FOREIGN KEY (`idPrescricao`) REFERENCES `prescricao` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Prescricao_has_Tratamento_Tratamento1` FOREIGN KEY (`idTratamento`) REFERENCES `tratamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `sessaotratamento`
--
ALTER TABLE `sessaotratamento`
  ADD CONSTRAINT `fk_SessaoTratamento_Terapeuta1` FOREIGN KEY (`Terapeuta_id`) REFERENCES `terapeuta` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `sessaotratamento_tem_tratamento`
--
ALTER TABLE `sessaotratamento_tem_tratamento`
  ADD CONSTRAINT `fk_SessaoTratamento_has_Tratamento_SessaoTratamento1` FOREIGN KEY (`idSessaoTratamento`) REFERENCES `sessaotratamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_SessaoTratamento_has_Tratamento_Tratamento1` FOREIGN KEY (`idTratamento`) REFERENCES `tratamento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `terapeuta`
--
ALTER TABLE `terapeuta`
  ADD CONSTRAINT `fk_Terapeuta_utilizador1` FOREIGN KEY (`idUtilizador`) REFERENCES `utilizador` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `terapeuta_tem_prescricao`
--
ALTER TABLE `terapeuta_tem_prescricao`
  ADD CONSTRAINT `fk_Terapeuta_has_Prescricao_Prescricao1` FOREIGN KEY (`idPrescricao`) REFERENCES `prescricao` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Terapeuta_has_Prescricao_Terapeuta1` FOREIGN KEY (`idTerapeuta`) REFERENCES `terapeuta` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `utente`
--
ALTER TABLE `utente`
  ADD CONSTRAINT `fk_Utente_utilizador1` FOREIGN KEY (`idUtilizador`) REFERENCES `utilizador` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `utilizador`
--
ALTER TABLE `utilizador`
  ADD CONSTRAINT `fk_utilizador_Pessoa1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
