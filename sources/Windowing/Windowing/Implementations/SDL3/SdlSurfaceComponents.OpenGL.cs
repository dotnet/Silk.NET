// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceOpenGL
{
    void IDisposable.Dispose() => throw new NotImplementedException();

    unsafe void* INativeContext.LoadFunction(string functionName, string libraryNameHint) =>
        throw new NotImplementedException();

    bool IGLContext.IsCurrent
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    int IGLContext.SwapInterval
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    void IGLContext.SwapBuffers() => throw new NotImplementedException();

    int? ISurfaceOpenGL.PreferredDepthBufferBits
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    int? ISurfaceOpenGL.PreferredStencilBufferBits
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    Vector4D<int>? ISurfaceOpenGL.PreferredBitDepth
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    int? ISurfaceOpenGL.PreferredSampleCount
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    Version32? ISurfaceOpenGL.Version
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    OpenGLContextFlags ISurfaceOpenGL.Flags
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    OpenGLContextProfile ISurfaceOpenGL.Profile
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    bool ISurfaceOpenGL.IsSupported => throw new NotImplementedException();

    bool ISurfaceOpenGL.ShouldSwapAutomatically
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IGLContext? ISurfaceOpenGL.SharedContext
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}
