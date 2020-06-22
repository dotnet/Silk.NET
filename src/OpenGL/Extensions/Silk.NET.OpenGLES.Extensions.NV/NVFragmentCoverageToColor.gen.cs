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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_fragment_coverage_to_color")]
    public abstract unsafe partial class NVFragmentCoverageToColor : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_coverage_to_color";
        [NativeApi(EntryPoint = "glFragmentCoverageColorNV")]
        public abstract void FragmentCoverageColor([Flow(FlowDirection.In)] uint color);

        public NVFragmentCoverageToColor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

