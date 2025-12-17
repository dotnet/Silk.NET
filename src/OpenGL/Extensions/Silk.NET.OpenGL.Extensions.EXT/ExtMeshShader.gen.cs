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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_mesh_shader")]
    public unsafe partial class ExtMeshShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_mesh_shader";
        [NativeApi(EntryPoint = "glDrawMeshTasksEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawMeshTask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDrawMeshTasksIndirectEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawMeshTasksIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint indirect);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawMeshTasksIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawMeshTasksIndirectCountEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawMeshTasksIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        public ExtMeshShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

