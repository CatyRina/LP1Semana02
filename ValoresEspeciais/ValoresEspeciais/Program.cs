﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valores máximos e mínimos dos tipos de dados:");
            Console.WriteLine($"sbyte: {sbyte.MinValue} a {sbyte.MaxValue}");
            Console.WriteLine($"byte: {byte.MinValue} a {byte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} a {short.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} a {ushort.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} a {int.MaxValue}");
            Console.WriteLine($"uint: {uint.MinValue} a {uint.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} a {long.MaxValue}");
            Console.WriteLine($"ulong: {ulong.MinValue} a {ulong.MaxValue}");
            Console.WriteLine($"float: {float.MinValue} a {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} a {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} a {decimal.MaxValue}");
            Console.WriteLine($"char: {(int)char.MinValue} a {(int)char.MaxValue}");

            Console.WriteLine();
            Console.WriteLine("Valores especiais para float e double:");
            Console.WriteLine($"Float: -∞ = {float.NegativeInfinity}, +∞ = {float.PositiveInfinity}, NaN = {float.NaN}");
            Console.WriteLine($"Double: -∞ = {double.NegativeInfinity}, +∞ = {double.PositiveInfinity}, NaN = {double.NaN}");
        }
    }
}

