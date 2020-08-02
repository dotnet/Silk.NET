// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_fence")]
    public unsafe partial class NVFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fence";
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public unsafe partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences);

        [NativeApi(EntryPoint = "glFinishFenceNV")]
        public partial void FinishFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public unsafe partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesNV")]
        public partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public unsafe partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFenceNV")]
        public partial bool IsFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV condition);

        [NativeApi(EntryPoint = "glTestFenceNV")]
        public partial bool TestFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public unsafe partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public partial void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glSetFenceNV")]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceConditionNV condition);

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

        public NVFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

