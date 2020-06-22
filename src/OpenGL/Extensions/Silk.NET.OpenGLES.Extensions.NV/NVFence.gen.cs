// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_fence")]
    public abstract unsafe partial class NVFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fence";
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public abstract unsafe void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public abstract void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences);

        [NativeApi(EntryPoint = "glFinishFenceNV")]
        public abstract void FinishFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public abstract unsafe void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public abstract void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFenceNV")]
        public abstract bool IsFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public abstract void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV condition);

        [NativeApi(EntryPoint = "glTestFenceNV")]
        public abstract bool TestFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public abstract void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceConditionNV condition);

        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        public unsafe uint GenFence()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFences(n, &ret);
            return ret;
        }

        public NVFence(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

