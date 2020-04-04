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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_conditional_render")]
    public abstract unsafe partial class NvxConditionalRender : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginConditionalRenderNVX")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndConditionalRenderNVX")]
        public abstract void EndConditionalRender();

        public NvxConditionalRender(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

