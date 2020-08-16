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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_multi_draw_indirect")]
    public unsafe partial class AmdMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_multi_draw_indirect";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        public AmdMultiDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

