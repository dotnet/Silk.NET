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
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] AcceleratorType accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] AcceleratorType accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clCreateAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAccelerator([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] AcceleratorInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] AcceleratorInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetAcceleratorInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAcceleratorInfo([Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clReleaseAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int ReleaseAccelerator([Flow(FlowDirection.In)] nint accelerator);

        [NativeApi(EntryPoint = "clRetainAcceleratorINTEL", Convention = CallingConvention.Winapi)]
        public partial int RetainAccelerator([Flow(FlowDirection.In)] nint accelerator);

        public IntelAccelerator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

