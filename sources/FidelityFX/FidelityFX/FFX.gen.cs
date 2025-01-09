// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.FidelityFX;

partial class FFX(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IFFX.Static
    {
        public static ThreadLocal<IFFX> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(IFFX ctx) => Underlying.Value = ctx;
    }

    private readonly unsafe void*[] _slots = new void*[5];
    public static IFFX Instance { get; } = new StaticWrapper<DllImport>();

    public static IFFX Create() => Instance;

    public static IFFX Create(INativeContext ctx) => new FFX(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
