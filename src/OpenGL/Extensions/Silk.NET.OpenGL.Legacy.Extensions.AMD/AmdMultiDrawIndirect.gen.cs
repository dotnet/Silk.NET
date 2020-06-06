// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_multi_draw_indirect")]
    public unsafe partial class AmdMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_multi_draw_indirect";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirect(mode, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirect<T0>(mode, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirect(mode, type, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirect<T0>(mode, type, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirect(mode, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirect<T0>(mode, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirect(mode, type, indirect, primcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirect<T0>(mode, type, indirect, primcount, stride);

        public AmdMultiDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

