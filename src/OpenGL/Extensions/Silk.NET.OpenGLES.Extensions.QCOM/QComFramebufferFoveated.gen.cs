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
    [Extension("QCOM_framebuffer_foveated")]
    public unsafe partial class QComFramebufferFoveated : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_framebuffer_foveated";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numLayers">
        /// To be added.
        /// </param>
        /// <param name="focalPointsPerLayer">
        /// To be added.
        /// </param>
        /// <param name="requestedFeatures">
        /// To be added.
        /// </param>
        /// <param name="providedFeatures">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] uint* providedFeatures)
            => ImplFramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numLayers">
        /// To be added.
        /// </param>
        /// <param name="focalPointsPerLayer">
        /// To be added.
        /// </param>
        /// <param name="requestedFeatures">
        /// To be added.
        /// </param>
        /// <param name="providedFeatures">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] out uint providedFeatures)
            => ImplFramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
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
        [NativeApi(EntryPoint = "glFramebufferFoveationParametersQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferFoveationParameters([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint layer, [Flow(FlowDirection.In)] uint focalPoint, [Flow(FlowDirection.In)] float focalX, [Flow(FlowDirection.In)] float focalY, [Flow(FlowDirection.In)] float gainX, [Flow(FlowDirection.In)] float gainY, [Flow(FlowDirection.In)] float foveaArea)
            => ImplFramebufferFoveationParameters(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);

        public QComFramebufferFoveated(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

