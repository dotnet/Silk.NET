// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Loader
{
    public class SymbolLoadingException : Exception
    {
        public SymbolLoadingException(string symbol) : base($"Native symbol not found (Symbol: {symbol})")
        {
        }

        public SymbolLoadingException(string symbol, string msg) : base(msg + $" (Symbol: {symbol})")
        {
        }
    }
}
