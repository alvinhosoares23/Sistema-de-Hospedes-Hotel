﻿using System.Text;
using sistema_de_Hospedagem_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
 List<Pessoa> hospedes = new List<Pessoa>();

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        Pessoa p1 = new Pessoa(nome: "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // Cria a suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        bool sair = false;

        do
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Ver quantidade de hóspedes");
            Console.WriteLine("2. Ver valor da diária");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    break;
                case "2":
                    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
                    break;
                case "3":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
        } while (!sair);