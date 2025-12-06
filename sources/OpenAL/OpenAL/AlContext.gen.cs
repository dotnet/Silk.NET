// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL;

partial class AlContext(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : IAlContext.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IAlContext.Static
    {
        public static ThreadLocal<IAlContext> Underlying { get; } = new(ContextFactory);

        public static void MakeCurrent(IAlContext ctx) => Underlying.Value = ctx;

        private static partial IAlContext ContextFactory();
    }

    private readonly unsafe void*[] _slots = new void*[35];

    public static IAlContext Create(INativeContext ctx) => new AlContext(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
