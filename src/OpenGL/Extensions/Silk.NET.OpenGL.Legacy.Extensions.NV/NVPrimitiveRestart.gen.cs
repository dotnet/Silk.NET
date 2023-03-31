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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_primitive_restart")]
    public unsafe partial class NVPrimitiveRestart : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_primitive_restart";
        [NativeApi(EntryPoint = "glPrimitiveRestartNV", Convention = CallingConvention.Winapi)]
        public partial void PrimitiveRestart();

        [NativeApi(EntryPoint = "glPrimitiveRestartIndexNV", Convention = CallingConvention.Winapi)]
        public partial void PrimitiveRestartIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        public NVPrimitiveRestart(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

