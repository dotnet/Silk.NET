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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_pn_triangles")]
    public unsafe partial class AtiPnTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_pn_triangles";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param)
            => ImplPntriangles(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Pntriangles([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param)
            => ImplPntriangles(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPNTrianglesiATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] int param)
            => ImplPntriangles(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPNTrianglesfATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Pntriangles([Flow(FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(FlowDirection.In)] float param)
            => ImplPntriangles(pname, param);

        public AtiPnTriangles(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

