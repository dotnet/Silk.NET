// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_create_command_queue")]
    public abstract unsafe partial class KhrCreateCommandQueue : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_create_command_queue";
        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public abstract unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] KHR* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        public abstract IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] Span<KHR> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] KHR* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] Span<KHR> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public KhrCreateCommandQueue(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

