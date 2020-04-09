// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_storage")]
    public abstract unsafe partial class ExtTextureStorage : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage1DEXT")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2DEXT")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3DEXT")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage1DEXT")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2DEXT")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3DEXT")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        public ExtTextureStorage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

