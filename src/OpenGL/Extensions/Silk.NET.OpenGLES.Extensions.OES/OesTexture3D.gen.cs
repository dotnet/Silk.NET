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
    [Extension("OES_texture_3D")]
    public unsafe partial class OesTexture3D : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_3D";
        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CopyTexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES attachment, [Flow(FlowDirection.In)] OES textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] OES textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] OES attachment, [Flow(FlowDirection.In)] OES textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] OES attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] OES textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        public unsafe void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexImage3D(target, level, internalformat, width, height, depth, border, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public OesTexture3D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

