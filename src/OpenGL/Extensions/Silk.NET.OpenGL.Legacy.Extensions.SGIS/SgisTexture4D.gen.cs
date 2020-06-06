// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture4D")]
    public unsafe partial class SgisTexture4D : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture4D";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage4D<T0>(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="woffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="woffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage4D<T0>(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage4D<T0>(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="woffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="woffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="size4d">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, depth, and size4d.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage4D<T0>(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);

        public SgisTexture4D(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

