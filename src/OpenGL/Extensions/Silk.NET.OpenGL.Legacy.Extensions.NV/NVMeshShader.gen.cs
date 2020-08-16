// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
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

        public unsafe void DrawMeshTasksIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DrawMeshTasksIndirect(new IntPtr(indirect));
        }

        public unsafe void MultiDrawMeshTasksIndirect([Flow(FlowDirection.In)] int indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawMeshTasksIndirect(new IntPtr(indirect), drawcount, stride);
        }

        public unsafe void MultiDrawMeshTasksIndirectCount([Flow(FlowDirection.In)] int indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawMeshTasksIndirectCount(new IntPtr(indirect), new IntPtr(drawcount), maxdrawcount, stride);
        }

        public NVMeshShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

