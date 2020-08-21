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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sample_positions")]
    public unsafe partial class AmdSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sample_positions";
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public unsafe partial void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* val);

        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public partial void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in float val);

        public AmdSamplePositions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

