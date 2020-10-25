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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_stencil_two_side")]
    public unsafe partial class ExtStencilTwoSide : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_stencil_two_side";
        [NativeApi(EntryPoint = "glActiveStencilFaceEXT")]
        public partial void ActiveStencilFace([Flow(FlowDirection.In)] EXT face);

        [NativeApi(EntryPoint = "glActiveStencilFaceEXT")]
        public partial void ActiveStencilFace([Flow(FlowDirection.In)] StencilFaceDirection face);

        public ExtStencilTwoSide(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

