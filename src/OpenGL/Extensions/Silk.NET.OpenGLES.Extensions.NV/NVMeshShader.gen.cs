// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_mesh_shader")]
    public unsafe partial class NVMeshShader : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_mesh_shader";
        [NativeApi(EntryPoint = "glDrawMeshTasksNV")]
        public partial void DrawMeshTask([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawMeshTasksIndirectNV")]
        public partial void DrawMeshTasksIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectNV")]
        public partial void MultiDrawMeshTasksIndirect([Flow(FlowDirection.In)] IntPtr indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectCountNV")]
        public partial void MultiDrawMeshTasksIndirectCount([Flow(FlowDirection.In)] IntPtr indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        public NVMeshShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

