// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_accelerator")]
    public unsafe partial class IntelAccelerator : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_accelerator";
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL")]
        public unsafe partial IntPtr CreateAccelerator([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] UIntPtr descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL")]
        public partial IntPtr CreateAccelerator<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] UIntPtr descriptor_size, [Flow(FlowDirection.In)] Span<T0> descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL")]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] IntPtr accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL")]
        public partial int GetAcceleratorInfo<T0>([Flow(FlowDirection.In)] IntPtr accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseAcceleratorINTEL")]
        public partial int ReleaseAccelerator([Flow(FlowDirection.In)] IntPtr accelerator);

        [NativeApi(EntryPoint = "clRetainAcceleratorINTEL")]
        public partial int RetainAccelerator([Flow(FlowDirection.In)] IntPtr accelerator);

        public unsafe IntPtr CreateAccelerator([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] uint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateAccelerator(new IntPtr(context), accelerator_type, new UIntPtr(descriptor_size), descriptor, errcode_ret);
        }

        public unsafe IntPtr CreateAccelerator<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] uint descriptor_size, [Flow(FlowDirection.In)] Span<T0> descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateAccelerator(new IntPtr(context), accelerator_type, new UIntPtr(descriptor_size), descriptor, errcode_ret);
        }

        public unsafe int GetAcceleratorInfo([Flow(FlowDirection.In)] int accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetAcceleratorInfo(new IntPtr(accelerator), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetAcceleratorInfo<T0>([Flow(FlowDirection.In)] int accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetAcceleratorInfo(new IntPtr(accelerator), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int ReleaseAccelerator([Flow(FlowDirection.In)] int accelerator)
        {
            // IntPtrOverloader
            return ReleaseAccelerator(new IntPtr(accelerator));
        }

        public unsafe int RetainAccelerator([Flow(FlowDirection.In)] int accelerator)
        {
            // IntPtrOverloader
            return RetainAccelerator(new IntPtr(accelerator));
        }

        public IntelAccelerator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

