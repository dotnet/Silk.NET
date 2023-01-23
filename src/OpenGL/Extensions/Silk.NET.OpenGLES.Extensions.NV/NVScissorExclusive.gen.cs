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
    [Extension("NV_scissor_exclusive")]
    public unsafe partial class NVScissorExclusive : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_scissor_exclusive";
        [NativeApi(EntryPoint = "glScissorExclusiveNV", Convention = CallingConvention.Winapi)]
        public partial void ScissorExclusive([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV", Convention = CallingConvention.Winapi)]
        public partial void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] in int v);

        public NVScissorExclusive(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

