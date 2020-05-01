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
    [Extension("KHR_subgroups")]
    public abstract unsafe partial class KhrSubgroups : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_subgroups";
        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public abstract unsafe int GetKernelSubGroupInfo([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public abstract int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        public unsafe int GetKernelSubGroupInfo([Flow(FlowDirection.In)] int in_kernel, [Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(in_kernel), new IntPtr(in_device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] int in_kernel, [Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(in_kernel), new IntPtr(in_device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public KhrSubgroups(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

