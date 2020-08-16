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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transpose_matrix")]
    public unsafe partial class ArbTransposeMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transpose_matrix";
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        public unsafe partial void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        public partial void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        public unsafe partial void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        public partial void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        public unsafe partial void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        public partial void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        public unsafe partial void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        public partial void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        public ArbTransposeMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

