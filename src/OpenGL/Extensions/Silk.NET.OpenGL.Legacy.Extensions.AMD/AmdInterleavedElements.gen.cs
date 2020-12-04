// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_interleaved_elements")]
    public unsafe partial class AmdInterleavedElements : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_interleaved_elements";
        [NativeApi(EntryPoint = "glVertexAttribParameteriAMD")]
        public partial void VertexAttribParameter([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] int param);

        public AmdInterleavedElements(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

