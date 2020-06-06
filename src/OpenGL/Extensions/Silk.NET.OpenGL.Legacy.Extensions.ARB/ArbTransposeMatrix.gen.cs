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
    [Extension("ARB_transpose_matrix")]
    public unsafe partial class ArbTransposeMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transpose_matrix";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplLoadTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplLoadTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplLoadTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplLoadTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMultTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMultTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMultTransposeMatrix(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMultTransposeMatrix(m);

        public ArbTransposeMatrix(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

