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
    [Extension("ARB_get_texture_sub_image")]
    public unsafe partial class ArbGetTextureSubImage : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_get_texture_sub_image";
        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        public unsafe void GetCompressedTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe T0 GetCompressedTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public ArbGetTextureSubImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

