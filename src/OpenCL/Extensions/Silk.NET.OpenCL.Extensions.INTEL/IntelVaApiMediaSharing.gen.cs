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
    [Extension("INTEL_va_api_media_sharing")]
    public unsafe partial class IntelVaApiMediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_va_api_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromVAApimediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] nint surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromVAApimediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] nint surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromVAApimediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] nint surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromVAApimediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] nint surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] VaApiDeviceSource media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] VaApiDeviceSet media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (VaApiDeviceSource, VaApiDeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        public IntelVaApiMediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

