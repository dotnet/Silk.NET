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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_pn_triangles")]
    public unsafe partial class AtiPnTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_pn_triangles";
        [NativeApi(EntryPoint = "glPNTrianglesiATI", Convention = CallingConvention.Winapi)]
        public partial void Pntriangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPNTrianglesiATI", Convention = CallingConvention.Winapi)]
        public partial void Pntriangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPNTrianglesfATI", Convention = CallingConvention.Winapi)]
        public partial void Pntriangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPNTrianglesfATI", Convention = CallingConvention.Winapi)]
        public partial void Pntriangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] PNTrianglesPNameATI pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        public AtiPnTriangles(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

