// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
