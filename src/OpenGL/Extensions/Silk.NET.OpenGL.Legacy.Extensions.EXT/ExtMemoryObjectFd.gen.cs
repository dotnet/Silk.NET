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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_memory_object_fd")]
    public unsafe partial class ExtMemoryObjectFd : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object_fd";
        [NativeApi(EntryPoint = "glImportMemoryFdEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd);

        [NativeApi(EntryPoint = "glImportMemoryFdEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd);

        public ExtMemoryObjectFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

