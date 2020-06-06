// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Contexts
{
    public class DefaultNativeContext : INativeContext
    {
        public UnmanagedLibrary Library { get; }
        public DefaultNativeContext(UnmanagedLibrary library) => Library = library;
        public IntPtr GetProcAddress(string proc) => Library.LoadFunction(proc);
        public void Dispose() => Library?.Dispose();
    }
}
