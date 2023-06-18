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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_subgroups")]
    public unsafe partial class KhrSubgroups : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_subgroups";
        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        public KhrSubgroups(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

