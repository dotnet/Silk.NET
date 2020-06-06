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
    [Extension("NV_conditional_render")]
    public unsafe partial class NVConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conditional_render";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV mode)
            => ImplBeginConditionalRender(id, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndConditionalRenderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndConditionalRender()
            => ImplEndConditionalRender();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode)
            => ImplBeginConditionalRender(id, mode);

        public NVConditionalRender(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

