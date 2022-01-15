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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_viewport_array")]
    public unsafe partial class OesViewportArray : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_viewport_array";
        [NativeApi(EntryPoint = "glDepthRangeArrayfvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayfvOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glDepthRangeIndexedfOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glScissorArrayvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayvOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glScissorIndexedOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedvOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glViewportArrayvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayvOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glViewportIndexedfOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        public OesViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

