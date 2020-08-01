// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_separate_stencil")]
    public unsafe partial class AtiSeparateStencil : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_separate_stencil";
        [NativeApi(EntryPoint = "glStencilFuncSeparateATI")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] ATI frontfunc, [Flow(FlowDirection.In)] ATI backfunc, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] ATI face, [Flow(FlowDirection.In)] ATI sfail, [Flow(FlowDirection.In)] ATI dpfail, [Flow(FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilFuncSeparateATI")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFunction frontfunc, [Flow(FlowDirection.In)] StencilFunction backfunc, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        public AtiSeparateStencil(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

