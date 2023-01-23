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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_multisample")]
    public unsafe partial class SgisMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_multisample";
        [NativeApi(EntryPoint = "glSampleMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glSampleMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] Boolean invert);

        [NativeApi(EntryPoint = "glSamplePatternSGIS", Convention = CallingConvention.Winapi)]
        public partial void SamplePattern([Flow(FlowDirection.In)] SGIS pattern);

        [NativeApi(EntryPoint = "glSamplePatternSGIS", Convention = CallingConvention.Winapi)]
        public partial void SamplePattern([Flow(FlowDirection.In)] SamplePatternSGIS pattern);

        public SgisMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

