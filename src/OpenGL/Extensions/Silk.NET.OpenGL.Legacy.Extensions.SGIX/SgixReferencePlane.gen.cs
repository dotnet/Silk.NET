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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_reference_plane")]
    public unsafe partial class SgixReferencePlane : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_reference_plane";
        [NativeApi(EntryPoint = "glReferencePlaneSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReferencePlane([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* equation);

        [NativeApi(EntryPoint = "glReferencePlaneSGIX", Convention = CallingConvention.Winapi)]
        public partial void ReferencePlane([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double equation);

        public SgixReferencePlane(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

