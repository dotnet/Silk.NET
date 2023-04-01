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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_provoking_vertex")]
    public unsafe partial class ExtProvokingVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_provoking_vertex";
        [NativeApi(EntryPoint = "glProvokingVertexEXT", Convention = CallingConvention.Winapi)]
        public partial void ProvokingVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glProvokingVertexEXT", Convention = CallingConvention.Winapi)]
        public partial void ProvokingVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexProvokingMode mode);

        public ExtProvokingVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

