// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.SDL;

partial class Sdl(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : ISdl.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : ISdl.Static
    {
        public static ThreadLocal<ISdl> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(ISdl ctx) => Underlying.Value = ctx;
    }

    private readonly unsafe void*[] _slots = new void*[1156];
    public static ISdl Instance { get; } = new StaticWrapper<DllImport>();

    public static ISdl Create() => Instance;

    public static ISdl Create(INativeContext ctx) => new Sdl(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
