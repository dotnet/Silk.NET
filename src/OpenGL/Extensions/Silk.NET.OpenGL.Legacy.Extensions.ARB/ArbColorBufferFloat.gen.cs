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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_color_buffer_float")]
    public abstract unsafe partial class ArbColorBufferFloat : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClampColorARB")]
        public abstract void ClampColor([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB clamp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClampColorARB")]
        public abstract void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        public ArbColorBufferFloat(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

