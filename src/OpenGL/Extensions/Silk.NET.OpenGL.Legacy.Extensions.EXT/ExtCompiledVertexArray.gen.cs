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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_compiled_vertex_array")]
    public abstract unsafe partial class ExtCompiledVertexArray : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLockArraysEXT")]
        public abstract void LockArrays([Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnlockArraysEXT")]
        public abstract void UnlockArrays();

        public ExtCompiledVertexArray(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

