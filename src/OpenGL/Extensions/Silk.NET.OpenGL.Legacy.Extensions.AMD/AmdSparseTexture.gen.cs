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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sparse_texture")]
    public unsafe partial class AmdSparseTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sparse_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="layers">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags)
            => ImplTexStorageSparse(target, internalFormat, width, height, depth, layers, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="layers">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageSparseAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags)
            => ImplTextureStorageSparse(texture, target, internalFormat, width, height, depth, layers, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="layers">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageSparseAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags)
            => ImplTexStorageSparse(target, internalFormat, width, height, depth, layers, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
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
        /// <param name="layers">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageSparseAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags)
            => ImplTextureStorageSparse(texture, target, internalFormat, width, height, depth, layers, flags);

        public AmdSparseTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

