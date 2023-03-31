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
        public partial void ImportMemoryF([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT handleType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int fd);

        [NativeApi(EntryPoint = "glImportMemoryFdEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportMemoryF([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalHandleType handleType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int fd);

        public ExtMemoryObjectFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

