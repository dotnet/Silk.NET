// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;

namespace Silk.NET.Windowing.WPF;

internal abstract class BaseWGLContext : IGLContext
{
    public WGL.WGL WGL { get; }
    public virtual void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public nint GetProcAddress(string proc, int? slot = default)
    {
        throw new System.NotImplementedException();
    }

    public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
    {
        throw new System.NotImplementedException();
    }

    public nint Handle { get; }
    public IGLContextSource Source { get; }
    public bool IsCurrent { get; }
    public void SwapInterval(int interval)
    {
        throw new System.NotImplementedException();
    }

    public void SwapBuffers()
    {
        throw new System.NotImplementedException();
    }

    public void MakeCurrent()
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }
}
