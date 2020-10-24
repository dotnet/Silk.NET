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

namespace Silk.NET.OpenGL.Legacy.Extensions.PGI
{
    [Extension("PGI_misc_hints")]
    public unsafe partial class PgiMiscHints : NativeExtension<GL>
    {
        public const string ExtensionName = "PGI_misc_hints";
        [NativeApi(EntryPoint = "glHintPGI")]
        public partial void Hint([Flow(FlowDirection.In)] PGI target, [Flow(FlowDirection.In)] int mode);

        [NativeApi(EntryPoint = "glHintPGI")]
        public partial void Hint([Flow(FlowDirection.In)] HintTargetPGI target, [Flow(FlowDirection.In)] int mode);

        public PgiMiscHints(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

