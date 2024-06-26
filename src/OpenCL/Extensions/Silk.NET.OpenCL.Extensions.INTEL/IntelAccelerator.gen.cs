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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_accelerator")]
    public unsafe partial class IntelAccelerator : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_accelerator";
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateAccelerator<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateAccelerator<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetAcceleratorInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetAcceleratorInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int ReleaseAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator);

        [NativeApi(EntryPoint = "clRetainAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int RetainAccelerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator);

        public IntelAccelerator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

