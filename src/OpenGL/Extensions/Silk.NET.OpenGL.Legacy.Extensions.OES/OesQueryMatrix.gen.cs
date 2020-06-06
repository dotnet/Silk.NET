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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_query_matrix")]
    public unsafe partial class OesQueryMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_query_matrix";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mantissa">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <param name="exponent">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] int* exponent)
            => ImplQueryMatrixx(mantissa, exponent);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mantissa">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <param name="exponent">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] Span<int> mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> exponent)
            => ImplQueryMatrixx(mantissa, exponent);

        public OesQueryMatrix(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

