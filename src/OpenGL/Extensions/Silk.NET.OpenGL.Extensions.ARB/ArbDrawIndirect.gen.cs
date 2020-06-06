// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_draw_indirect")]
    public unsafe partial class ArbDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_indirect";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawArraysIndirect(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawArraysIndirect<T0>(mode, indirect);

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
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawElementsIndirect(mode, type, indirect);

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
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawElementsIndirect<T0>(mode, type, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawArraysIndirect(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawArraysIndirect<T0>(mode, indirect);

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
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawElementsIndirect(mode, type, indirect);

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
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawElementsIndirect<T0>(mode, type, indirect);

        public ArbDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

