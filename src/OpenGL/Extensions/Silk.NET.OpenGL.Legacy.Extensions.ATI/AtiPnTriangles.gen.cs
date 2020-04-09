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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_pn_triangles")]
    public abstract unsafe partial class AtiPnTriangles : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] float param);

        public AtiPnTriangles(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

