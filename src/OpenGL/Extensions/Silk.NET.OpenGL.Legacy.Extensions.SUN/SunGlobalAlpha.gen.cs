// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public abstract unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] sbyte factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] int factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] float factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] double factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] byte factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] ushort factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] uint factor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN")]
        public abstract void ObalAlphaFactors([Flow(FlowDirection.In)] short factor);

        public SunGlobalAlpha(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

