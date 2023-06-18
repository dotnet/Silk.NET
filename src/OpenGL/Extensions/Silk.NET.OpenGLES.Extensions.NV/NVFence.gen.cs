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
    [Extension("NV_fence")]
    public unsafe partial class NVFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fence";
        [NativeApi(EntryPoint = "glDeleteFencesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glFinishFenceNV", Convention = CallingConvention.Winapi)]
        public partial void FinishFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGenFencesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGetFenceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glIsFenceNV", Convention = CallingConvention.Winapi)]
        public partial bool IsFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceNV", Convention = CallingConvention.Winapi)]
        public partial void SetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV condition);

        [NativeApi(EntryPoint = "glTestFenceNV", Convention = CallingConvention.Winapi)]
        public partial bool TestFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        public NVFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

