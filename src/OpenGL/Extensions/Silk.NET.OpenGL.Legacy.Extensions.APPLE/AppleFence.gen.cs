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
        public unsafe partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glDeleteFencesAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint fences);

        [NativeApi(EntryPoint = "glFinishFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FinishFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glFinishObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FinishObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "glFinishObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial void FinishObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "glGenFencesAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint fences);

        [NativeApi(EntryPoint = "glIsFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestFenceAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool TestFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool TestObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] uint name);

        [NativeApi(EntryPoint = "glTestObjectAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool TestObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] uint name);

        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        public unsafe void DeleteFences([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fences)
        {
            // ImplicitCountSpanOverloader
            DeleteFences((uint) fences.Length, in fences.GetPinnableReference());
        }

        public unsafe uint GenFence()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFences(n, &ret);
            return ret;
        }

        public unsafe void GenFences([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences)
        {
            // ImplicitCountSpanOverloader
            GenFences((uint) fences.Length, out fences.GetPinnableReference());
        }

        public AppleFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

