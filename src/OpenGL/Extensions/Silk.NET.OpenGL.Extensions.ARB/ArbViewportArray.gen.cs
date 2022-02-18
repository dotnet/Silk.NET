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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_viewport_array")]
    public unsafe partial class ArbViewportArray : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_viewport_array";
        [NativeApi(EntryPoint = "glDepthRangeArrayv", Convention = CallingConvention.Winapi)]
        public unsafe partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayv", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glDepthRangeIndexed", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glScissorArrayv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayv", Convention = CallingConvention.Winapi)]
        public partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glScissorIndexed", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedv", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glViewportArrayv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayv", Convention = CallingConvention.Winapi)]
        public partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glViewportIndexedf", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfv", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        public ArbViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

