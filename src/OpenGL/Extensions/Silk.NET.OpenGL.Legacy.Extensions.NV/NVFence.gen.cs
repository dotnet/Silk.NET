// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_fence")]
    public abstract unsafe partial class NVFence : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public abstract unsafe void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        public abstract void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishFenceNV")]
        public abstract void FinishFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFencesNV")]
        public abstract unsafe void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFencesNV")]
        public abstract void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsFenceNV")]
        public abstract bool IsFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetFenceNV")]
        public abstract void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV condition);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTestFenceNV")]
        public abstract bool TestFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        public abstract void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetFenceNV")]
        public abstract void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceConditionNV condition);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="fences">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="fences">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
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

