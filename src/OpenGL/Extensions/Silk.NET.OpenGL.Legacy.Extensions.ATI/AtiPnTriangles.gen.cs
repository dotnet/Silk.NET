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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_pn_triangles")]
    public abstract unsafe partial class AtiPnTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_pn_triangles";
        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        public abstract void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] float param);

        public AtiPnTriangles(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

