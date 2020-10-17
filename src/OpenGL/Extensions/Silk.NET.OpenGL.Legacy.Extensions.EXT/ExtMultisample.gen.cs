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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multisample")]
    public unsafe partial class ExtMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multisample";
        [NativeApi(EntryPoint = "glSampleMaskEXT")]
        public partial void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glSamplePatternEXT")]
        public partial void SamplePattern([Flow(FlowDirection.In)] EXT pattern);

        [NativeApi(EntryPoint = "glSamplePatternEXT")]
        public partial void SamplePattern([Flow(FlowDirection.In)] SamplePatternEXT pattern);

        public ExtMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

