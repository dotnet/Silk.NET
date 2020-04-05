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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_framebuffer_foveated")]
    public abstract unsafe partial class QComFramebufferFoveated : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        public abstract unsafe void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] uint* providedFeatures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        public abstract void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] out uint providedFeatures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferFoveationParametersQCOM")]
        public abstract void FramebufferFoveationParameters([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint layer, [Flow(FlowDirection.In)] uint focalPoint, [Flow(FlowDirection.In)] float focalX, [Flow(FlowDirection.In)] float focalY, [Flow(FlowDirection.In)] float gainX, [Flow(FlowDirection.In)] float gainY, [Flow(FlowDirection.In)] float foveaArea);

        public QComFramebufferFoveated(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

