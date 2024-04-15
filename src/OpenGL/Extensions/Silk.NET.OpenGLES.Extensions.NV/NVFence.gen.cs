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

        [NativeApi(EntryPoint = "glDeleteFencesNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint fences);

        [NativeApi(EntryPoint = "glFinishFenceNV", Convention = CallingConvention.Winapi)]
        public partial void FinishFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGenFencesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesNV", Convention = CallingConvention.Winapi)]
        public partial void GenFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint fences);

        [NativeApi(EntryPoint = "glGetFenceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFenceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFenceNV", Convention = CallingConvention.Winapi)]
        public partial bool IsFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceNV", Convention = CallingConvention.Winapi)]
        public partial void SetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV condition);

        [NativeApi(EntryPoint = "glSetFenceNV", Convention = CallingConvention.Winapi)]
        public partial void SetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceConditionNV condition);

        [NativeApi(EntryPoint = "glTestFenceNV", Convention = CallingConvention.Winapi)]
        public partial bool TestFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence);

        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        public unsafe void DeleteFences([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fences)
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

        public unsafe void GenFences([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> fences)
        {
            // ImplicitCountSpanOverloader
            GenFences((uint) fences.Length, out fences.GetPinnableReference());
        }

        public unsafe uint GenFences([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenFences(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFence(fence, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFence([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceParameterNameNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFence(fence, pname, out int silkRet);
            return silkRet;
        }

        public NVFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

