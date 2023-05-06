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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.POCL
{
    [Extension("POCL_content_size")]
    public unsafe partial class PoclContentSize : NativeExtension<CL>
    {
        public const string ExtensionName = "POCL_content_size";
        [NativeApi(EntryPoint = "clSetContentSizeBufferPoCL", Convention = CallingConvention.Winapi)]
        public partial int SetContentSizeBufferPoCL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint content_size_buffer);

        public PoclContentSize(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

