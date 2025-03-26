{\rtf1\ansi\ansicpg1252\cocoartf2821
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 /* 8. Crie um programa em C# que leia um valor em horas e o converta para segundos. O programa deve considerar que cada hora tem 3600 segundos e exibir o valor final convertido*/\
\
using System;\
    \
    public class Ex08\{\
        \
        public static void Main()\{\
        \
        int horas, seg ;\
        \
        Console.WriteLine("insira as horas para conversao");\
        horas = Convert.ToInt32(Console.ReadLine());\
        \
        seg = horas *3600 ;\
        Console.WriteLine($"\{horas\} em segundos e \{seg\} segundos");\
        \
        \}\
    \}}