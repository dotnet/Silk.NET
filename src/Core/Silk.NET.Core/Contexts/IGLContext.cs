// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Contexts
{
    public interface IGLContext : INativeContext, IDisposable
    {
        nint Handle { get; }
        uint DefaultFramebuffer => 0;
        uint DefaultRenderbuffer => 0;
        IGLContextSource? Source { get; }
        bool IsCurrent { get; }
        void SwapInterval(int interval);
        void SwapBuffers();
        void MakeCurrent();
        void Clear();
    }
}
