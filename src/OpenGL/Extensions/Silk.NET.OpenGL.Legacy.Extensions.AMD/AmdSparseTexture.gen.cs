// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sparse_texture")]
    public unsafe partial class AmdSparseTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sparse_texture";
        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD")]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD")]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        public AmdSparseTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

