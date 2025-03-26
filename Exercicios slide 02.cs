{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /*01. Crie um programa em C# que declare um array de inteiros com 5 elementos definidos pelo utilizador. O programa deve calcular e exibir a soma de todos os elementos do array\
\
using System;\
    \
    public class Ex01\{\
        \
        public static void Main()\{\
        \
        int [] elements = new int [5];\
        int soma=0 ;\
        \
        for (int i = 0; i < 5; i++ )\{\
            Console.WriteLine($"insira um valor para a posicao \{i+1\}");\
            elements[i] = Convert.ToInt32(Console.ReadLine());\
            \
            soma += elements[i];\
        \}\
        \
        Console.WriteLine($"a soma e  \{soma\}");\
        \}\
    \}\
    */\
    \
    \
   /* 02. Crie um programa que pe\'e7a ao utilizador para inserir 4 n\'fameros inteiros em um array. Depois, exiba os n\'fameros na ordem inversa da inser\'e7\'e3o.\
    \
    using System;\
    public class exe02\{\
        \
        public static void Main()\{\
            int[] array = new int [4];\
            \
            for (int i = 0; i< 4; i++)\{\
                Console.WriteLine($"Insira o valor da posicao \{i+1\}");\
                array[i] = Convert.ToInt32(Console.ReadLine());\
            \}\
            \
            for (int i = 3; i>= 0; i--)\{\
                Console.Write($"\{array[i]\}");\
            \}\
        \}\
    \}  */\
    \
   /*03. Crie um programa que permita ao utilizador inserir 5 n\'fameros inteiros num array. O programa deve calcular e exibir a m\'e9dia dos valores inseridos.\
   \
   using System;\
   public class exe03\{\
       public static void Main()\{\
           \
           int[] array = new int [5];\
           float soma = 0, media;\
           \
           for (int i =0; i<5; i++)\{\
               Console.WriteLine($"Insira o valor da poscao \{i+1\}");\
               array[i]= Convert.ToInt32(Console.ReadLine());\
               soma += array[i];\
           \}\
           \
           Console.WriteLine($"A media dos valores do array e \{soma/5\}");\
       \}\
       \
   \}*/\
   \
   \
   \
   /*04. Crie um programa que permita ao utilizador inserir 6 n\'fameros inteiros num array. Em seguida, o programa deve pedir um n\'famero multiplicador e exibir o array resultante com cada elemento multiplicado por esse n\'famero. \
   \
   using System;\
   public class Ex04\{\
       public static void Main()\{\
           int [] array = new int [6];\
           int multiplicador;\
           \
           \
           for (int i = 0 ; i<6; i++)\{\
               Console.WriteLine($"Insira o valor da posicao \{i+1\}");\
               array[i] = Convert.ToInt32(Console.ReadLine());\
           \}\
           \
           Console.WriteLine("Insira um multiplicador");\
           multiplicador = Convert.ToInt32(Console.ReadLine());\
           \
           for (int i = 0 ; i<6; i++)\{\
               array[i] *= multiplicador;\
               \
               Console.WriteLine($"\{array[i]\}");\
           \}\
           \
       \}\
   \}*/ \
   }