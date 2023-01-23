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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture4D")]
    public unsafe partial class SgisTexture4D : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture4D";
        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public partial void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        public SgisTexture4D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

