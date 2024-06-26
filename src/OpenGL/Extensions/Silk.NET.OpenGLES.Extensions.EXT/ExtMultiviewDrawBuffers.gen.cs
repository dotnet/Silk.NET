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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_multiview_draw_buffers")]
    public unsafe partial class ExtMultiviewDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multiview_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffersIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffersIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffersIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawBuffersIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int indices);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glReadBufferIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadBufferIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int index);

        [NativeApi(EntryPoint = "glReadBufferIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadBufferIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadBufferMode src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int index);

        public unsafe void DrawBuffersIndexed([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices)
        {
            // ImplicitCountSpanOverloader
            DrawBuffersIndexed((int) indices.Length, location, in indices.GetPinnableReference());
        }

        public unsafe void DrawBuffersIndexed([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices)
        {
            // ImplicitCountSpanOverloader
            DrawBuffersIndexed((int) location.Length, in location.GetPinnableReference(), indices);
        }

        public unsafe void DrawBuffersIndexed([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices)
        {
            // ImplicitCountSpanOverloader
            DrawBuffersIndexed((int) indices.Length, in location.GetPinnableReference(), in indices.GetPinnableReference());
        }

        public unsafe int GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetInteger(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetInteger(target, index, out int silkRet);
            return silkRet;
        }

        public ExtMultiviewDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

