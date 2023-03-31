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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_provoking_vertex")]
    public unsafe partial class ArbProvokingVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_provoking_vertex";
        [NativeApi(EntryPoint = "glProvokingVertex", Convention = CallingConvention.Winapi)]
        public partial void ProvokingVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glProvokingVertex", Convention = CallingConvention.Winapi)]
        public partial void ProvokingVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexProvokingMode mode);

        public ArbProvokingVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

