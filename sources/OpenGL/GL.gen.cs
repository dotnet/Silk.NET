// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;
using System.Reflection;

namespace Silk.NET.OpenGL;

[NativeMemberContainer(typeof(IGL))]
[NativeMemberContainer(typeof(IGL.Static<>), Static = true)]
partial class GL(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IGL.Static<ThisThread>
    {
        public static ThreadLocal<IGL> Underlying { get; } = new();

        public static partial void MakeCurrent(IGL ctx);
    }

    public static IGL Create(INativeContext ctx) => new GL(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
