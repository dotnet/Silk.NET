// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_framebuffer_foveated")]
    public unsafe partial class QComFramebufferFoveated : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_framebuffer_foveated";
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        public unsafe partial void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] uint* providedFeatures);

        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM")]
        public partial void FramebufferFoveationConfig([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] out uint providedFeatures);

        [NativeApi(EntryPoint = "glFramebufferFoveationParametersQCOM")]
        public partial void FramebufferFoveationParameters([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint layer, [Flow(FlowDirection.In)] uint focalPoint, [Flow(FlowDirection.In)] float focalX, [Flow(FlowDirection.In)] float focalY, [Flow(FlowDirection.In)] float gainX, [Flow(FlowDirection.In)] float gainY, [Flow(FlowDirection.In)] float foveaArea);

        public QComFramebufferFoveated(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

