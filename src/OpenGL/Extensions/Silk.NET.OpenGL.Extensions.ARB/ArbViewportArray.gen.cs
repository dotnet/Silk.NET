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
        public unsafe partial void DepthRangeArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayv", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glDepthRangeIndexed", Convention = CallingConvention.Winapi)]
        public partial void DepthRangeIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glScissorArrayv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayv", Convention = CallingConvention.Winapi)]
        public partial void ScissorArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glScissorIndexed", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedv", Convention = CallingConvention.Winapi)]
        public partial void ScissorIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glViewportArrayv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayv", Convention = CallingConvention.Winapi)]
        public partial void ViewportArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glViewportIndexedf", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfv", Convention = CallingConvention.Winapi)]
        public partial void ViewportIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        public unsafe double GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetDouble(target, index, out double silkRet);
            return silkRet;
        }

        public unsafe double GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetDouble(target, index, out double silkRet);
            return silkRet;
        }

        public unsafe float GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
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

        public ArbViewportArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

