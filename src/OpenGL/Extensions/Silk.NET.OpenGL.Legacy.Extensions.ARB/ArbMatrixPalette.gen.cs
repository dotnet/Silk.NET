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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_matrix_palette")]
    public unsafe partial class ArbMatrixPalette : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_matrix_palette";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCurrentPaletteMatrixARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CurrentPaletteMatrix([Flow(FlowDirection.In)] int index)
            => ImplCurrentPaletteMatrix(index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] byte* indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<byte> indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ushort* indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<ushort> indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] uint* indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<uint> indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplMatrixIndexPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplMatrixIndexPointer<T0>(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndex([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] string indices)
            => ImplMatrixIndex(size, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplMatrixIndexPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixIndexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplMatrixIndexPointer<T0>(size, type, stride, pointer);

        public ArbMatrixPalette(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

