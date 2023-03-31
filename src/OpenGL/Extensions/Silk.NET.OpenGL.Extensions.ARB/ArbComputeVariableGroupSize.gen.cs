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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_compute_variable_group_size")]
    public unsafe partial class ArbComputeVariableGroupSize : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_variable_group_size";
        [NativeApi(EntryPoint = "glDispatchComputeGroupSizeARB", Convention = CallingConvention.Winapi)]
        public partial void DispatchComputeGroupSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_groups_z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group_size_x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group_size_y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint group_size_z);

        public ArbComputeVariableGroupSize(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

