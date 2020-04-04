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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_reference_plane")]
    public abstract unsafe partial class SgixReferencePlane : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        public abstract unsafe void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] double* equation);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        public abstract void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] Span<double> equation);

        public SgixReferencePlane(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

