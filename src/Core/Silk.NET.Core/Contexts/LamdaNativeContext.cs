// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Contexts
{
    public struct LamdaNativeContext : INativeContext
    {
        public delegate bool TryLoader(string proc, out nint pfn);
        private readonly Func<string, nint> _getProcAddress;

        public LamdaNativeContext(Func<string, nint> getProcAddress)
        {
            _getProcAddress = getProcAddress;
        }

        public LamdaNativeContext(TryLoader getProcAddress)
        {
            _getProcAddress = Loader;
            nint Loader(string proc)
            {
                if (!getProcAddress(proc, out var pfn))
                {
                    return 0;
                }

                return pfn;
            }
        }

        public nint GetProcAddress(string proc, int? slot = default)
        {
            var pfn = _getProcAddress(proc);
            if (pfn == 0)
            {
                Throw(proc);
            }

            return pfn;
            static void Throw(string proc) => throw new SymbolLoadingException(proc);
        }

        public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
        {
            return (addr = _getProcAddress(proc)) != 0;
        }

        public void Dispose()
        {
        }
    }
}
