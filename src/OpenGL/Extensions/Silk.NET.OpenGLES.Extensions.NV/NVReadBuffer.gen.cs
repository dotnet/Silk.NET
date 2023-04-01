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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_read_buffer")]
    public unsafe partial class NVReadBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_read_buffer";
        [NativeApi(EntryPoint = "glReadBufferNV", Convention = CallingConvention.Winapi)]
        public partial void ReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        public NVReadBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

