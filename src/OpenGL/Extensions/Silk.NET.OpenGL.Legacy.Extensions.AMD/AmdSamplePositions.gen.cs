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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_sample_positions")]
    public abstract unsafe partial class AmdSamplePositions : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public abstract unsafe void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD")]
        public abstract void SetMultisample([Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> val);

        public AmdSamplePositions(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

