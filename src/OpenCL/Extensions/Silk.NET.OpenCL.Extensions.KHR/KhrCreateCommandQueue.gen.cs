// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KHR* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] KHR* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in KHR properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in KHR properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        public KhrCreateCommandQueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

