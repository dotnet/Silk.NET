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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_mesh_array")]
    public unsafe partial class SunMeshArray : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_mesh_array";
        [NativeApi(EntryPoint = "glDrawMeshArraysSUN")]
        public partial void DrawMeshArrays([Flow(FlowDirection.In)] SUN mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glDrawMeshArraysSUN")]
        public partial void DrawMeshArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint width);

        public SunMeshArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

