using System;

namespace Silk.NET.Core.Loader
{
    public class SymbolLoadingException : Exception
    {
        public SymbolLoadingException(string symbol) : base($"Native symbol not found (Symbol: {symbol})"){}
        public SymbolLoadingException(string symbol, string msg) : base(msg + $" (Symbol: {symbol})"){}
    }
}