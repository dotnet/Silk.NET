// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

partial class Vk(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : IVk.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IVk.Static
    {
        public static ThreadLocal<IVk> Underlying { get; } = new(ContextFactory);

        public static void MakeCurrent(IVk ctx) => Underlying.Value = ctx;

        private static partial IVk ContextFactory();
    }

    private readonly unsafe void*[] _slots = new void*[702];

    public static IVk Create(INativeContext ctx) => new Vk(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
