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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_compute_shader")]
    public unsafe partial class ArbComputeShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_shader";
        [NativeApi(EntryPoint = "glDispatchCompute", Convention = CallingConvention.Winapi)]
        public partial void DispatchCompute([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect", Convention = CallingConvention.Winapi)]
        public partial void DispatchComputeIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint indirect);

        public ArbComputeShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

