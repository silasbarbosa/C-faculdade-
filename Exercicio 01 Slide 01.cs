{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww29200\viewh18400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 01. Crie um programa que fa\'e7a a entrada de 5 idades de um grupo de pessoas e\
some somente a idade das pessoas com o sexo masculino. */\
\
using System;\
\
public class EX01\{\
    \
    public static void Main ()\{\
        \
        int age = 0, soma = 0; \
        string sex= "";\
        \
        \
        for (int i = 0; i< 5 ; i++ )\{\
            \
            Console.WriteLine($"Insira o sexo do usuario \{i+1\} (M para masculino e F para feminino)");\
            sex = Console.ReadLine();\
            sex = sex.ToLower();\
        \
            if (sex == "m" )\{\
                Console.WriteLine($"Agora insira a idade do usuario \{i+1\}");\
                age = Convert.ToInt32(Console.ReadLine());\
                soma += age;\
        \}\
        \}\
        \
     Console.WriteLine($" A soma das idades de pessoas do sexo masculino e:   \{soma\}");\
    \}\
    \
    \
\}\
\
\
}