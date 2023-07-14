// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferFoveationConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numLayers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint focalPointsPerLayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* providedFeatures);

        [NativeApi(EntryPoint = "glFramebufferFoveationConfigQCOM", Convention = CallingConvention.Winapi)]
        public partial void FramebufferFoveationConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numLayers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint focalPointsPerLayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint requestedFeatures, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint providedFeatures);

        [NativeApi(EntryPoint = "glFramebufferFoveationParametersQCOM", Convention = CallingConvention.Winapi)]
        public partial void FramebufferFoveationParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint focalPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float focalX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float focalY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float gainX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float gainY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float foveaArea);

        public unsafe uint FramebufferFoveationConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numLayers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint focalPointsPerLayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint requestedFeatures)
        {
            // NonKhrReturnTypeOverloader
            FramebufferFoveationConfig(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, out uint silkRet);
            return silkRet;
        }

        public QComFramebufferFoveated(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

