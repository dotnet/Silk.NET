// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Contexts
{
    public interface INativeContext : IDisposable
    {
        nint GetProcAddress(string proc, int? slot = default);
        
        bool TryGetProcAddress(string proc, out nint addr, int? slot = default);
    }
}
