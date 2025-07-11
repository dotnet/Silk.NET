// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

partial class Vk(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    private readonly unsafe void*[] _slots = new void*[678];
    public static IVk Instance { get; } = new StaticWrapper<DllImport>();

    public static IVk Create() => Instance;

    public static IVk Create(INativeContext ctx) => new Vk(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
