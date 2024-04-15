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

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_window_pos")]
    public unsafe partial class MesaWindowPos : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_window_pos";
        [NativeApi(EntryPoint = "glWindowPos2dMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glWindowPos2dvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos2dvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glWindowPos2fMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glWindowPos2fvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos2fvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glWindowPos2iMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glWindowPos2ivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos2ivMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glWindowPos2sMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glWindowPos2svMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos2svMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos2([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glWindowPos3dMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glWindowPos3dvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos3dvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glWindowPos3fMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glWindowPos3fvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos3fvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glWindowPos3iMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glWindowPos3ivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos3ivMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glWindowPos3sMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glWindowPos3svMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos3svMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glWindowPos4dMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glWindowPos4dvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos4dvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glWindowPos4fMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glWindowPos4fvMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos4fvMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glWindowPos4iMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glWindowPos4ivMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos4ivMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glWindowPos4sMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glWindowPos4svMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos4svMESA", Convention = CallingConvention.Winapi)]
        public partial void WindowPos4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        public MesaWindowPos(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

