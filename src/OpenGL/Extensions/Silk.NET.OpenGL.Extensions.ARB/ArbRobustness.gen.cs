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
    [Extension("ARB_robustness")]
    public unsafe partial class ArbRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_robustness";
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusARB", Convention = CallingConvention.Winapi)]
        public partial ARB GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnUniform(program, location, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*8, out @params.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe T0 GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnCompressedTexImage(target, lod, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnCompressedTexImage(target, lod, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnUniform(program, location, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

