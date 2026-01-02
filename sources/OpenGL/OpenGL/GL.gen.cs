// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL;

partial class GL(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : IGL.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IGL.Static
    {
        public static ThreadLocal<IGL> Underlying { get; } = new();

        public static partial void MakeCurrent(IGL ctx);
    }

    private readonly unsafe void*[] _slots = new void*[3291];

    public static IGL Create(INativeContext ctx) => new GL(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
