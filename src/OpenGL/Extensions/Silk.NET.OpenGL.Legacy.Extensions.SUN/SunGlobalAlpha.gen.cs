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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_global_alpha";
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] int factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] double factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN", Convention = CallingConvention.Winapi)]
        public partial void ObalAlphaFactors([Flow(Silk.NET.Core.Native.FlowDirection.In)] short factor);

        public SunGlobalAlpha(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

