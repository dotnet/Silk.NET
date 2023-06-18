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
    [Extension("EXT_semaphore_win32")]
    public unsafe partial class ExtSemaphoreWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_win32";
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportSemaphoreWin32Handle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT handleType, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* handle);

        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImportSemaphoreWin32Name([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT handleType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* name);

        public ExtSemaphoreWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

