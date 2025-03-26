{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 03. Crie um programa que ir\'e1 simular um caixa de supermercado. O usu\'e1rio ir\'e1\
informar a quantidade e o valor do item. O sistema ir\'e1 imprimir o valor total da\
compra. */\
\
using System;\
\
public class ex03 \{\
    \
    public static void Main()\{\
        \
        int qndProduct = 0;\
        double valueProd = 0, soma = 0;\
        string continuar = "";\
        \
        do\{\
        Console.WriteLine("Qual a quantidade desse item inserido ?");\
        qndProduct = Convert.ToInt32(Console.ReadLine());\
        \
        Console.WriteLine("Qual o valor do produto inserido?");\
        valueProd = Convert.ToDouble(Console.ReadLine());\
        \
        soma += + (qndProduct * valueProd);\
        \
        Console.WriteLine("Gostaria de inserir um item?");\
        continuar = Console.ReadLine();\
        \}  while(continuar == "sim");\
        \
        Console.WriteLine($"o total da sua compra deu \{soma\} ");\
        \
        \}\
        \
    \}\
    \
}