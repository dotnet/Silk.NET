// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_tiled_rendering")]
    public abstract unsafe partial class QComTiledRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_tiled_rendering";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="preserveMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndTilingQCOM")]
        public abstract void EndTiling([Flow(FlowDirection.In)] uint preserveMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="preserveMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStartTilingQCOM")]
        public abstract void StartTiling([Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint preserveMask);

        public QComTiledRendering(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

