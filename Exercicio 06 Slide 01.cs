{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 05. 6) Crie um programa em C# que simule as opera\'e7\'f5es b\'e1sicas de um caixa eletr\'f4nico.O programa deve permitir ao usu\'e1rio consultar saldo, realizar saques e dep\'f3sitos. Inicialmente, o saldo deve ser definido pelo usu\'e1rio e o programa deve garantir que saques n\'e3o ultrapassem o valor dispon\'edvel na conta.*/\
\
using System;\
    \
    public class Ex06\{\
        \
        public static void Main()\{\
        \
        double saldo, valor;\
        string entrada;\
        \
        Console.WriteLine("Qual e o saldo atual da sua conta");\
        saldo = Convert.ToDouble(Console.ReadLine());\
       \
        do \{\
        Console.WriteLine("\\nBem Vindo ao Seu Banco. Escolha uma das opcoes:");\
        Console.WriteLine("1.Consultar Saldo");\
        Console.WriteLine("2. Fazer Deposito ");\
        Console.WriteLine("3. Fazer Saque");\
        Console.WriteLine("4. Sair");\
        entrada = Console.ReadLine();\
        \
        switch (entrada)\{\
            case "1":\
            Console.WriteLine($"R$\{saldo\}");\
            break; \
            \
            case "2":\
            Console.WriteLine("Qual o valor que gostaria de depositar?");\
            valor = Convert.ToDouble(Console.ReadLine());\
            saldo += valor;\
            break; \
            case "3":\
            Console.WriteLine("Qual o valor que gostaria de sacar?");\
            valor = Convert.ToDouble(Console.ReadLine());\
            saldo -= valor;\
             break; \
            case "4":\
            Console.WriteLine("Obrigado por usar nosso banco");\
             break; \
            \}\
        \} while(entrada!= "4");\
        \}\
    \}}