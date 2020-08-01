// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_global_alpha";
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] sbyte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] int factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] double factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] byte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] ushort factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] uint factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN")]
        public partial void ObalAlphaFactors([Flow(FlowDirection.In)] short factor);

        public SunGlobalAlpha(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

