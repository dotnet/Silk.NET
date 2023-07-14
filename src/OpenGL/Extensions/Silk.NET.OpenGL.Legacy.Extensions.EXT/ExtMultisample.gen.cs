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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multisample")]
    public unsafe partial class ExtMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multisample";
        [NativeApi(EntryPoint = "glSampleMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void SampleMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] float value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glSamplePatternEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplePattern([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pattern);

        [NativeApi(EntryPoint = "glSamplePatternEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplePattern([Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplePatternEXT pattern);

        public ExtMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

