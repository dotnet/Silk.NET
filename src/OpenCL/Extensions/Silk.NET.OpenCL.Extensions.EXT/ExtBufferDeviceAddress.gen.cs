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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_buffer_device_address")]
    public unsafe partial class ExtBufferDeviceAddress : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_buffer_device_address";
        [NativeApi(EntryPoint = "clSetKernelArgDevicePointerEXT", Convention = CallingConvention.Winapi)]
        public partial int SetKernelArgDevicePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong arg_value);

        public ExtBufferDeviceAddress(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

