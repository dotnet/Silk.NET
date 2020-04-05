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
    [Extension("ARB_draw_indirect")]
    public abstract unsafe partial class ArbDrawIndirect : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        public ArbDrawIndirect(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

