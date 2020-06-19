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
    [Extension("QCOM_framebuffer_foveated")]
    public abstract unsafe partial class QComFramebufferFoveated : NativeExtension<GL>
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
        public abstract unsafe void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] uint* providedFeatures);

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
        public abstract void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] out uint providedFeatures);

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
        public abstract void FramebufferFoveationParameters([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint layer, [Flow(FlowDirection.In)] uint focalPoint, [Flow(FlowDirection.In)] float focalX, [Flow(FlowDirection.In)] float focalY, [Flow(FlowDirection.In)] float gainX, [Flow(FlowDirection.In)] float gainY, [Flow(FlowDirection.In)] float foveaArea);

        public QComFramebufferFoveated(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

