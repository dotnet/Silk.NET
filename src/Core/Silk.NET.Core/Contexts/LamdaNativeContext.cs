// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    public struct LamdaNativeContext : INativeContext
    {
        private readonly Func<string, nint> _getProcAddress;

        public LamdaNativeContext(Func<string, nint> getProcAddress)
        {
            _getProcAddress = getProcAddress;
        }

        public nint GetProcAddress(string proc, int? slot = default)
        {
            return _getProcAddress(proc);
        }

        public void Dispose()
        {
        }
    }
}
