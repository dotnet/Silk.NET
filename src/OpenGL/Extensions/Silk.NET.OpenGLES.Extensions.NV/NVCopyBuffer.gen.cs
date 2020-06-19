// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_copy_buffer")]
    public abstract unsafe partial class NVCopyBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_copy_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] NV readTarget, [Flow(FlowDirection.In)] NV writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] NV readTarget, [Flow(FlowDirection.In)] NV writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public NVCopyBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

