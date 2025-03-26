{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 05. Escreva um programa em C# que pe\'e7a ao usu\'e1rio dois n\'fameros e uma opera\'e7\'e3o matem\'e1tica (+, -,*,/) e exiba o resultado da opera\'e7\'e3o escolhida. */\
 \
 using System;\
 \
 public class EX05 \{\
     public static void Main()\{\
      \
      double num1 = 0, num2 = 0, calc = 0; \
      string operador= "";\
      \
      Console.WriteLine("Insira um valor para o calculo");\
      num1 = Convert.ToDouble(Console.ReadLine());\
      \
      Console.WriteLine("Insira o operador que deseja fazer o calculo (+,-,*,/)");\
      operador = Console.ReadLine();\
      \
      Console.WriteLine("Insira o segundo valor para o calculo");\
      num2 = Convert.ToDouble(Console.ReadLine());\
     \
      if (operador == "+")\{\
         calc = num1 + num2;\
         Console.WriteLine($"\{num1\}\{operador\}\{num2\} e igual \{calc\}");\
      \}\
     \
      else if (operador == "-")\{\
         calc = num1 - num2;\
         Console.WriteLine($"\{num1\}\{operador\}\{num2\} e igual \{calc\}");\
        \
      \}\
      \
      else if (operador == "*")\{\
         calc = num1 * num2;\
         Console.WriteLine($"\{num1\}\{operador\}\{num2\} e igual \{calc\}");\
      \}  \
     \
      else if( operador == "/")\{\
         calc = num1 / num2;\
         Console.WriteLine($"\{num1\}\{operador\}\{num2\} e igual \{calc\}");\
      \}  \
         \
      else \{\
         Console.WriteLine("O operador inserido e invalido");\
      \}\
     \}\
 \}\
}