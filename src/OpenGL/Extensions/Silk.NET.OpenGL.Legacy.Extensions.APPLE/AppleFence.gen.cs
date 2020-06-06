// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_fence")]
    public unsafe partial class AppleFence : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_fence";
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
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences)
            => ImplDeleteFences(n, fences);

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
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences)
            => ImplDeleteFences(n, fences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinishFenceAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinishFence([Flow(FlowDirection.In)] uint fence)
            => ImplFinishFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinishObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] int name)
            => ImplFinishObject(@object, name);

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
        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences)
            => ImplGenFences(n, fences);

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
        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences)
            => ImplGenFences(n, fences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsFenceAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsFence([Flow(FlowDirection.In)] uint fence)
            => ImplIsFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSetFenceAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetFence([Flow(FlowDirection.In)] uint fence)
            => ImplSetFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glTestFenceAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool TestFence([Flow(FlowDirection.In)] uint fence)
            => ImplTestFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool TestObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] uint name)
            => ImplTestObject(@object, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinishObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] int name)
            => ImplFinishObject(@object, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool TestObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] uint name)
            => ImplTestObject(@object, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenFence()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFences(n, &ret);
            return ret;
        }

        public AppleFence(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

