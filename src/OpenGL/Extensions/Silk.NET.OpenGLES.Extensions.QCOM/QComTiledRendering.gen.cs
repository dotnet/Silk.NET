// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_tiled_rendering")]
    public unsafe partial class QComTiledRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_tiled_rendering";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="preserveMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndTilingQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndTiling([Flow(FlowDirection.In)] uint preserveMask)
            => ImplEndTiling(preserveMask);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StartTiling([Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint preserveMask)
            => ImplStartTiling(x, y, width, height, preserveMask);

        public QComTiledRendering(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

