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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_compiled_vertex_array")]
    public unsafe partial class ExtCompiledVertexArray : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_compiled_vertex_array";
        [NativeApi(EntryPoint = "glLockArraysEXT")]
        public partial void LockArrays([Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glUnlockArraysEXT")]
        public partial void UnlockArrays();

        public ExtCompiledVertexArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

