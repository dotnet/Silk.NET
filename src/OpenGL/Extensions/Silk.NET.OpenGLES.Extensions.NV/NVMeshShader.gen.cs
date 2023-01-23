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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_mesh_shader")]
    public unsafe partial class NVMeshShader : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_mesh_shader";
        [NativeApi(EntryPoint = "glDrawMeshTasksNV", Convention = CallingConvention.Winapi)]
        public partial void DrawMeshTask([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawMeshTasksIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void DrawMeshTasksIndirect([Flow(FlowDirection.In)] nint indirect);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawMeshTasksIndirect([Flow(FlowDirection.In)] nint indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectCountNV", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawMeshTasksIndirectCount([Flow(FlowDirection.In)] nint indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        public NVMeshShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

