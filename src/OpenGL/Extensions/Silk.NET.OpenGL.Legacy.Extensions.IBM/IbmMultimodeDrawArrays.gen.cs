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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_multimode_draw_arrays")]
    public unsafe partial class IbmMultimodeDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_multimode_draw_arrays";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawArrays(mode, first, count, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawArrays(mode, first, count, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawElements(mode, count, type, indices, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawElements<T0>([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride) where T0 : unmanaged
            => ImplMultiModeDrawElements<T0>(mode, count, type, indices, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawArrays(mode, first, count, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawArrays(mode, first, count, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
            => ImplMultiModeDrawElements(mode, count, type, indices, primcount, modestride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// This parameter's element count is computed from primcount.
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
        /// <param name="modestride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiModeDrawElements<T0>([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride) where T0 : unmanaged
            => ImplMultiModeDrawElements<T0>(mode, count, type, indices, primcount, modestride);

        public IbmMultimodeDrawArrays(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

