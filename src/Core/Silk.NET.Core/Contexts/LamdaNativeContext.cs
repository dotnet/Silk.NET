// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    public struct LamdaNativeContext : INativeContext
    {
        private readonly Func<string, IntPtr> _getProcAddress;

        public LamdaNativeContext(Func<string, IntPtr> getProcAddress)
        {
            _getProcAddress = getProcAddress;
        }

        public IntPtr GetProcAddress(string proc)
        {
            return _getProcAddress(proc);
        }

        public void Dispose()
        {
        }
    }
}
