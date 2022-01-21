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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_storage_compression")]
    public unsafe partial class ExtTextureStorageCompression : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_storage_compression";
        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] TexStorageAttribs* attrib_list);

        [NativeApi(EntryPoint = "TexStorageAttribs3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageAttribs3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] in TexStorageAttribs attrib_list);

        public ExtTextureStorageCompression(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

