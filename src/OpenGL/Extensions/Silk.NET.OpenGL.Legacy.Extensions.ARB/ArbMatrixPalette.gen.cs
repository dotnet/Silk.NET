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
    [Extension("ARB_matrix_palette")]
    public abstract unsafe partial class ArbMatrixPalette : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCurrentPaletteMatrixARB")]
        public abstract void CurrentPaletteMatrix([Flow(FlowDirection.In)] int index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        public abstract unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] byte* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        public abstract void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<byte> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexusvARB")]
        public abstract unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ushort* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexusvARB")]
        public abstract void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<ushort> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexuivARB")]
        public abstract unsafe void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] uint* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexuivARB")]
        public abstract void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<uint> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        public abstract unsafe void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        public abstract void MatrixIndexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexubvARB")]
        public abstract void MatrixIndex([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] string indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        public abstract unsafe void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixIndexPointerARB")]
        public abstract void MatrixIndexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ArbMatrixPalette(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

