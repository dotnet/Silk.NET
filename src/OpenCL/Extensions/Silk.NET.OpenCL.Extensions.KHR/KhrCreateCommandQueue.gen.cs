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
    [Extension("KHR_create_command_queue")]
    public unsafe partial class KhrCreateCommandQueue : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_create_command_queue";
        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateCommandQueueWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        public KhrCreateCommandQueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

