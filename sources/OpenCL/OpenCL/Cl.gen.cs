// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenCL;

partial class Cl(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : ICl.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : ICl.Static
    {
        public static ThreadLocal<ICl> Underlying { get; } = new();

        public static partial void MakeCurrent(ICl ctx);
    }

    private readonly unsafe void*[] _slots = new void*[179];

    public static ICl Create(INativeContext ctx) => new Cl(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
