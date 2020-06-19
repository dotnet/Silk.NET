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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public abstract unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_global_alpha";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] sbyte factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] int factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] float factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] double factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] byte factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] ushort factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN")]
        public abstract void ObalAlphaFactor([Flow(FlowDirection.In)] uint factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN")]
        public abstract void ObalAlphaFactors([Flow(FlowDirection.In)] short factor);

        public SunGlobalAlpha(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

