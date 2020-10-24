// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_subgroups")]
    public unsafe partial class KhrSubgroups : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_subgroups";
        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public unsafe partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR")]
        public partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        public KhrSubgroups(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

