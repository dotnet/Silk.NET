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
    [Extension("AMD_interleaved_elements")]
    public abstract unsafe partial class AmdInterleavedElements : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribParameteriAMD")]
        public abstract void VertexAttribParameter([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] int param);

        public AmdInterleavedElements(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

