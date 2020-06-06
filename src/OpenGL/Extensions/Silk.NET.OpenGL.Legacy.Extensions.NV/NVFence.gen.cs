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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_fence")]
    public unsafe partial class NVFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fence";
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
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
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
        [NativeApi(EntryPoint = "glDeleteFencesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> fences)
            => ImplDeleteFences(n, fences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinishFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinishFence([Flow(FlowDirection.In)] uint fence)
            => ImplFinishFence(fence);

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
        [NativeApi(EntryPoint = "glGenFencesNV")]
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
        [NativeApi(EntryPoint = "glGenFencesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences)
            => ImplGenFences(n, fences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFence(fence, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFence(fence, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsFence([Flow(FlowDirection.In)] uint fence)
            => ImplIsFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="condition">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSetFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV condition)
            => ImplSetFence(fence, condition);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glTestFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool TestFence([Flow(FlowDirection.In)] uint fence)
            => ImplTestFence(fence);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFence(fence, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFenceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFence(fence, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fence">
        /// To be added.
        /// </param>
        /// <param name="condition">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSetFenceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetFence([Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceConditionNV condition)
            => ImplSetFence(fence, condition);

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

        public NVFence(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

