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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_copy_buffer")]
    public unsafe partial class NVCopyBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_copy_buffer";
        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] NV readTarget, [Flow(FlowDirection.In)] NV writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] NV readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] NV writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubDataNV")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        public NVCopyBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

