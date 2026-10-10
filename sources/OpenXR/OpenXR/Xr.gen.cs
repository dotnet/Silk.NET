// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenXR;

partial class Xr(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : IXr.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IXr.Static
    {
        public static ThreadLocal<IXr> Underlying { get; } = new(ContextFactory);

        public static void MakeCurrent(IXr ctx) => Underlying.Value = ctx;

        private static partial IXr ContextFactory();
    }

    private readonly unsafe void*[] _slots = new void*[56];

    public static IXr Create(INativeContext ctx) => new Xr(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
