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
    [Extension("QCOM_frame_extrapolation")]
    public unsafe partial class QComFrameExtrapolation : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_frame_extrapolation";
        [NativeApi(EntryPoint = "glExtrapolateTex2DQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtrapolateTex2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint src1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint src2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint output, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float scaleFactor);

        public QComFrameExtrapolation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

