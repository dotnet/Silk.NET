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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_texture_storage_multisample")]
    public unsafe partial class ArbTextureStorageMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_storage_multisample";
        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        public ArbTextureStorageMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

