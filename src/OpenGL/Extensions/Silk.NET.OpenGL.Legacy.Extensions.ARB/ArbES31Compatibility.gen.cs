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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_ES3_1_compatibility")]
    public abstract unsafe partial class ArbES31Compatibility : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public abstract void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        public ArbES31Compatibility(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

