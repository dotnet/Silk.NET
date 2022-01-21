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
    [Extension("EXT_robustness")]
    public unsafe partial class ExtRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_robustness";
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnUniformfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsEXT", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public ExtRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

