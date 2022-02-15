// See https://aka.ms/new-console-template for more information
 using System;
 using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

/* ################### Conversão INT para DOUBLE ###################

int a, b;
double resultado;

a = 5;
b = 2;
resultado = (double)a / b;

System.Console.WriteLine(resultado.ToString("F2", CI));
*/

/* ################### Conversão de DOUBLE para INT ################### */

double a;
int b;
a = 5.2;
b = (int)a;

System.Console.WriteLine(b.ToString("F2", CI));

/* ################### Estudar Conversões ################### */