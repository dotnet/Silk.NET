// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_window_pos")]
    public unsafe partial class ArbWindowPos : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_window_pos";
        [NativeApi(EntryPoint = "glWindowPos2dARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glWindowPos2dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos2dvARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glWindowPos2fARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glWindowPos2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos2fvARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glWindowPos2iARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glWindowPos2ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos2ivARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glWindowPos2sARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glWindowPos2svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos2svARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glWindowPos3dARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glWindowPos3dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos3dvARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glWindowPos3fARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glWindowPos3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos3fvARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glWindowPos3iARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glWindowPos3ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos3ivARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glWindowPos3sARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glWindowPos3svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos3svARB", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        public ArbWindowPos(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

