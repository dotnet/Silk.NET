// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_query_matrix")]
    public unsafe partial class OesQueryMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_query_matrix";
        [NativeApi(EntryPoint = "glQueryMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* exponent);

        [NativeApi(EntryPoint = "glQueryMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int exponent);

        [NativeApi(EntryPoint = "glQueryMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int mantissa, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* exponent);

        [NativeApi(EntryPoint = "glQueryMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial uint QueryMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int mantissa, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int exponent);

        public OesQueryMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

