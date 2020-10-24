// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_alpha_to_coverage_dither_control")]
    public unsafe partial class NVAlphaToCoverageDitherControl : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_alpha_to_coverage_dither_control";
        [NativeApi(EntryPoint = "glAlphaToCoverageDitherControlNV")]
        public partial void AlphaToCoverageDitherControl([Flow(FlowDirection.In)] NV mode);

        public NVAlphaToCoverageDitherControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

