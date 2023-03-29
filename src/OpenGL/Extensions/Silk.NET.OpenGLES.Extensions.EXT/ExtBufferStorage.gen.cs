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
    [Extension("EXT_buffer_storage")]
    public unsafe partial class ExtBufferStorage : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_buffer_storage";
        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferStorageMask flags);

        public ExtBufferStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

