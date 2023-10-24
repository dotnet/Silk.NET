// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static class NameGenerator
    {
        private static int _c = 1;
        private static ConcurrentDictionary<string, string> _names = new();
        private const int ColumnBase = 26;
        private const int MaxLength = 7 + 1; // 7 characters can contain zero through int.MaxValue, +1 for underscore
        private const string Digits = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string ToAlphabetString(int i)
        {
            if (i <= ColumnBase)
            {
                Span<char> theResult = stackalloc char[]{'_', Digits[i - 1]};
                return theResult.ToString();
            }

            Span<char> result = stackalloc char[MaxLength];
            var offset = MaxLength;
            while (i > 0)
            {
                result[--offset] = Digits[--i % ColumnBase];
                i /= ColumnBase;
            }
            
            // Make all identifiers start with _. Otherwise, eventually we will end up generating stuff like "GL" and
            // "SDL" out of sheer luck for example, which could conflict.
            result[--offset] = '_';

            return result.Slice(offset, MaxLength - offset).ToString();
        }

#if true
        public static string Name(string suggestion) => suggestion;
#else
        public static string Name(string suggestion)
            => _names.GetOrAdd(suggestion, static _ => ToAlphabetString(Interlocked.Increment(ref _c)));
#endif

        public static IdentifierNameSyntax IdentifierSilk(string hint) => IdentifierName(Name(hint));
    }
}
