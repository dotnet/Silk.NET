// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_sample_shading")]
    public abstract unsafe partial class OesSampleShading : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_sample_shading";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinSampleShadingOES")]
        public abstract void MinSampleShading([Flow(FlowDirection.In)] float value);

        public OesSampleShading(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

