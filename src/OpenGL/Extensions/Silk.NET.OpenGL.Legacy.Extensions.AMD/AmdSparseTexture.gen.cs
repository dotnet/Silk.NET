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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sparse_texture")]
    public unsafe partial class AmdSparseTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sparse_texture";
        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTexStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TexStorageSparse([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glTextureStorageSparseAMD", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageSparse([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint layers, [Flow(FlowDirection.In)] TextureStorageMaskAMD flags);

        public AmdSparseTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

