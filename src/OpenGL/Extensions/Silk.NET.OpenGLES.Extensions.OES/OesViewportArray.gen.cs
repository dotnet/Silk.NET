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
        public unsafe partial void DepthRangeArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayfvOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glDepthRangeIndexedfOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_vOES", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glScissorArrayvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayvOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glScissorIndexedOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedvOES", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glViewportArrayvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayvOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glViewportIndexedfOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfvOES", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        public unsafe float GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetFloat(target, index, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetFloat(target, index, out float silkRet);
            return silkRet;
        }

        public OesViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

