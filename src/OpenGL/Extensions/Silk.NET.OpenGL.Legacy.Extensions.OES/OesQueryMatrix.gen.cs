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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_query_matrix")]
    public unsafe partial class OesQueryMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_query_matrix";
        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        public unsafe partial uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] int* exponent);

        [NativeApi(EntryPoint = "glQueryMatrixxOES")]
        public partial uint QueryMatrixx([Count(Count = 16), Flow(FlowDirection.Out)] Span<int> mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> exponent);

        public OesQueryMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

