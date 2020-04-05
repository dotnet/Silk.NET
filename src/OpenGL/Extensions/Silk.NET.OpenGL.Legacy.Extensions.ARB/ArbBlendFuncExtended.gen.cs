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
    [Extension("ARB_blend_func_extended")]
    public abstract unsafe partial class ArbBlendFuncExtended : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        public ArbBlendFuncExtended(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

