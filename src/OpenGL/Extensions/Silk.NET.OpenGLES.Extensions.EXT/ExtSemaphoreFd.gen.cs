// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore_fd")]
    public unsafe partial class ExtSemaphoreFd : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_fd";
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        public partial void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd);

        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        public partial void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd);

        public ExtSemaphoreFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

