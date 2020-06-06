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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_conditional_render")]
    public unsafe partial class NvxConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_conditional_render";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNVX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginConditionalRender([Flow(FlowDirection.In)] uint id)
            => ImplBeginConditionalRender(id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndConditionalRenderNVX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndConditionalRender()
            => ImplEndConditionalRender();

        public NvxConditionalRender(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

