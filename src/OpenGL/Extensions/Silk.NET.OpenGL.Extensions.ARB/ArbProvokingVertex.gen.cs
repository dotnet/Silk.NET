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
    [Extension("ARB_provoking_vertex")]
    public unsafe partial class ArbProvokingVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_provoking_vertex";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProvokingVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProvokingVertex([Flow(FlowDirection.In)] ARB mode)
            => ImplProvokingVertex(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProvokingVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode)
            => ImplProvokingVertex(mode);

        public ArbProvokingVertex(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

