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
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        public KhrSubgroups(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

