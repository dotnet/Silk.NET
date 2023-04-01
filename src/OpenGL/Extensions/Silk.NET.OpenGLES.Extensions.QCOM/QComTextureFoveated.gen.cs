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
    [Extension("QCOM_texture_foveated")]
    public unsafe partial class QComTextureFoveated : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_texture_foveated";
        [NativeApi(EntryPoint = "glTextureFoveationParametersQCOM", Convention = CallingConvention.Winapi)]
        public partial void TextureFoveationParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint focalPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float focalX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float focalY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float gainX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float gainY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float foveaArea);

        public QComTextureFoveated(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

