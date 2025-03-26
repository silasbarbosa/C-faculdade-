{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 07. Desenvolva um programa em C# que leia a largura e a altura de um ret\'e2ngulo e calcule o per\'edmetro. A f\'f3rmula \'e9 Per\'edmetro = 2 * (largura + altura). O programa deve exibir o valor do per\'edmetro.*/\
\
using System;\
    \
    public class Ex07\{\
        \
        public static void Main()\{\
        \
        double largura, altura, perimeter;\
        \
        Console.WriteLine("insira a largura do retangulo");\
        largura = Convert.ToDouble(Console.ReadLine());\
        \
        Console.WriteLine("insira a largura do altura");\
        altura = Convert.ToDouble(Console.ReadLine());\
        \
        \
        perimeter = (altura + largura) * 2;\
        Console.WriteLine($"o perimetro e \{perimeter\}");\
        \
        \}\
    \}}