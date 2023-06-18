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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_fence")]
    public unsafe partial class AppleFence : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_fence";
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glFinishFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FinishFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glFinishObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FinishObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE @object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "glGenFencesAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glIsFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial void SetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool TestFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool TestObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE @object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name);

        public AppleFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

