{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 02. Crie um programa em java que solicite ao usu\'e1rio que insira as notas de tr\'eas provas (P1, P2 e P3) e calcule a m\'e9dia aritm\'e9tica dessas notas. */\
\
using System;\
\
public class ex02\{\
    \
    public static void Main()\{\
        \
        float p1, p2, p3;\
    \
        Console.WriteLine("Insira o valor da nota da P1");\
        p1 = Convert.ToSingle(Console.ReadLine());\
        Console.WriteLine("Insira o valor da nota da P2");\
        p2 = Convert.ToSingle(Console.ReadLine());\
        Console.WriteLine("Insira o valor da nota da P3");\
        p3 = Convert.ToSingle(Console.ReadLine());\
    \
    Console.WriteLine($"\{(p1+p2+p3)/3\}");\
        \
    \}\
    \
    \
\}}