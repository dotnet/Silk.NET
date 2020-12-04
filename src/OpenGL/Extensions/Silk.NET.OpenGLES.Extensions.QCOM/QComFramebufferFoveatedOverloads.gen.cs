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

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    public static class QComFramebufferFoveatedOverloads
    {
        public static unsafe void FramebufferFoveationConfig(this QComFramebufferFoveated thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint focalPointsPerLayer, [Flow(FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> providedFeatures)
        {
            // SpanOverloader
            thisApi.FramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, out providedFeatures.GetPinnableReference());
        }

    }
}

