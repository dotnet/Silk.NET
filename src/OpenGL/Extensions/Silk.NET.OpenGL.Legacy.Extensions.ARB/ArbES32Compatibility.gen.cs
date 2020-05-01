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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_ES3_2_compatibility")]
    public abstract unsafe partial class ArbES32Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES3_2_compatibility";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="minX">
        /// To be added.
        /// </param>
        /// <param name="minY">
        /// To be added.
        /// </param>
        /// <param name="minZ">
        /// To be added.
        /// </param>
        /// <param name="minW">
        /// To be added.
        /// </param>
        /// <param name="maxX">
        /// To be added.
        /// </param>
        /// <param name="maxY">
        /// To be added.
        /// </param>
        /// <param name="maxZ">
        /// To be added.
        /// </param>
        /// <param name="maxW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPrimitiveBoundingBoxARB")]
        public abstract void PrimitiveBoundingBox([Flow(FlowDirection.In)] float minX, [Flow(FlowDirection.In)] float minY, [Flow(FlowDirection.In)] float minZ, [Flow(FlowDirection.In)] float minW, [Flow(FlowDirection.In)] float maxX, [Flow(FlowDirection.In)] float maxY, [Flow(FlowDirection.In)] float maxZ, [Flow(FlowDirection.In)] float maxW);

        public ArbES32Compatibility(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

