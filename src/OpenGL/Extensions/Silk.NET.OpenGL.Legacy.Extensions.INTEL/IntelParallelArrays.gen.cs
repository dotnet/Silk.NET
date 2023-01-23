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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_parallel_arrays")]
    public unsafe partial class IntelParallelArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_parallel_arrays";
        [NativeApi(EntryPoint = "glColorPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glColorPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glColorPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glColorPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glNormalPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glNormalPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glNormalPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glNormalPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glTexCoordPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glTexCoordPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glVertexPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glVertexPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glVertexPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glVertexPointervINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] in void* pointer);

        public IntelParallelArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

