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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multi_draw_arrays")]
    public unsafe partial class ExtMultiDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multi_draw_arrays";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawArrays(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawArrays(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawElements(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplMultiDrawElements<T0>(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawArrays(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawArrays(mode, first, count, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount)
            => ImplMultiDrawElements(mode, count, type, indices, primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
            => ImplMultiDrawElements<T0>(mode, count, type, indices, primcount);

        public ExtMultiDrawArrays(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

