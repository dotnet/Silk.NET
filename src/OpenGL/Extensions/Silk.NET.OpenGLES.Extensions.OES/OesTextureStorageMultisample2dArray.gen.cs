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
    [Extension("OES_texture_storage_multisample_2d_array")]
    public unsafe partial class OesTextureStorageMultisample2dArray : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_storage_multisample_2d_array";
        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES", Convention = CallingConvention.Winapi)]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        public OesTextureStorageMultisample2dArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

