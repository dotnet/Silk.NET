// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_memory_object_fd")]
    public unsafe partial class ExtMemoryObjectFd : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object_fd";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="fd">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryFdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd)
            => ImplImportMemoryF(memory, size, handleType, fd);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="fd">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportMemoryFdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd)
            => ImplImportMemoryF(memory, size, handleType, fd);

        public ExtMemoryObjectFd(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

