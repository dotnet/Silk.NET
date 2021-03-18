// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
