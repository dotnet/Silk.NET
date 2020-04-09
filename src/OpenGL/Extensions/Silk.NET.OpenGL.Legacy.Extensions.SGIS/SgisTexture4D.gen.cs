// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture4D")]
    public abstract unsafe partial class SgisTexture4D : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        public abstract unsafe void TexImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        public abstract void TexImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        public abstract unsafe void TexSubImage4D([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        public abstract void TexSubImage4D<T0>([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        public abstract unsafe void TexImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage4DSGIS")]
        public abstract void TexImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        public abstract unsafe void TexSubImage4D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage4DSGIS")]
        public abstract void TexSubImage4D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        public SgisTexture4D(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

