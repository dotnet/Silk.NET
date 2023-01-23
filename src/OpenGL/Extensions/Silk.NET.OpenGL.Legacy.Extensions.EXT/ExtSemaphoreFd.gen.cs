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
    [Extension("EXT_semaphore_fd")]
    public unsafe partial class ExtSemaphoreFd : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_fd";
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd);

        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT", Convention = CallingConvention.Winapi)]
        public partial void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd);

        public ExtSemaphoreFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

