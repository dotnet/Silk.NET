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
    [Extension("QCOM_texture_foveated")]
    public unsafe partial class QComTextureFoveated : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_texture_foveated";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="focalPoint">
        /// To be added.
        /// </param>
        /// <param name="focalX">
        /// To be added.
        /// </param>
        /// <param name="focalY">
        /// To be added.
        /// </param>
        /// <param name="gainX">
        /// To be added.
        /// </param>
        /// <param name="gainY">
        /// To be added.
        /// </param>
        /// <param name="foveaArea">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureFoveationParametersQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureFoveationParameters([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint layer, [Flow(FlowDirection.In)] uint focalPoint, [Flow(FlowDirection.In)] float focalX, [Flow(FlowDirection.In)] float focalY, [Flow(FlowDirection.In)] float gainX, [Flow(FlowDirection.In)] float gainY, [Flow(FlowDirection.In)] float foveaArea)
            => ImplTextureFoveationParameters(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);

        public QComTextureFoveated(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

