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
    [Extension("NV_scissor_exclusive")]
    public unsafe partial class NVScissorExclusive : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_scissor_exclusive";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glScissorExclusiveNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ScissorExclusive([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplScissorExclusive(x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v)
            => ImplScissorExclusiveArray(first, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v)
            => ImplScissorExclusiveArray(first, count, v);

        public NVScissorExclusive(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

