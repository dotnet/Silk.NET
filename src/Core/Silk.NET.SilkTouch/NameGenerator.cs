// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;

namespace Silk.NET.SilkTouch
{
    public static class NameGenerator
    {
        private static int _c = 1;

        private static char ToAlphabet(int i)
        {
            return (char) (i + 65);
        }

        private static string ToAlphabetString(int i)
        {
            const int maxChar = 26;
            var s = "";
            while (i > 0)
            {
                var x = (i - 1) % maxChar;
                s = ToAlphabet(x) + s;
                i = (i - x) / 24;
            }

            return s;
        }

        public static string Name(string suggestion)
        {
            // BUG the name shortener for some reason is causing duplicate member bugs. such as:
            // GL.3491994.gen.cs(107452,35): Error CS0111 : Type 'GL.TXDY' already defines a member called 'VNWU' with
            //                                              the same parameter types
            // return ToAlphabetString(_c++);
            return suggestion;
        }
    }
}
