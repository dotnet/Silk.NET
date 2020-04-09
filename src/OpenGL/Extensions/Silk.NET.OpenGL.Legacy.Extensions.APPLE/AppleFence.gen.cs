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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_fence")]
    public abstract unsafe partial class AppleFence : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        public abstract unsafe void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        public abstract void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishFenceAPPLE")]
        public abstract void FinishFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        public abstract void FinishObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] int name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        public abstract unsafe void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        public abstract void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsFenceAPPLE")]
        public abstract bool IsFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetFenceAPPLE")]
        public abstract void SetFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTestFenceAPPLE")]
        public abstract bool TestFence([Flow(FlowDirection.In)] uint fence);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        public abstract bool TestObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] uint name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        public abstract void FinishObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] int name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        public abstract bool TestObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] uint name);

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

        public AppleFence(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

