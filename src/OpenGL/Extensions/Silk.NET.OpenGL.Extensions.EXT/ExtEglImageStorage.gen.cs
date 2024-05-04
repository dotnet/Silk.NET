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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_EGL_image_storage")]
    public unsafe partial class ExtEglImageStorage : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_EGL_image_storage";
        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void EglimageTargetTexStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void EglimageTargetTexStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void EglimageTargetTextureStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void EglimageTargetTextureStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attrib_list);

        public ExtEglImageStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

