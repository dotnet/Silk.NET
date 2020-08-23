// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_sample_shading")]
    public unsafe partial class OesSampleShading : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_sample_shading";
        [NativeApi(EntryPoint = "glMinSampleShadingOES")]
        public partial void MinSampleShading([Flow(FlowDirection.In)] float value);

        public OesSampleShading(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

