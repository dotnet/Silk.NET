// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

public unsafe partial interface ICl
{
    public partial interface Static
    {
        [NativeName("clBuildProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clBuildProgram")]
        static abstract int BuildProgram(
            ProgramHandle program,
            uint num_devices,
            DeviceIdHandle* device_list,
            sbyte* options,
            BuildProgramPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clBuildProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clBuildProgram")]
        static abstract int BuildProgram(
            ProgramHandle program,
            uint num_devices,
            Ref<DeviceIdHandle> device_list,
            Ref<sbyte> options,
            BuildProgramPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(EventHandle* event_list, nuint num_events_in_list);

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(
            Ref<EventHandle> event_list,
            nuint num_events_in_list
        );

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract KernelHandle CloneKernel(KernelHandle source_kernel, int* errcode_ret);

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract KernelHandle CloneKernel(KernelHandle source_kernel, Ref<int> errcode_ret);

        [NativeName("clCompileProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCompileProgram")]
        static abstract int CompileProgram(
            ProgramHandle program,
            uint num_devices,
            DeviceIdHandle* device_list,
            sbyte* options,
            uint num_input_headers,
            ProgramHandle* input_headers,
            sbyte** header_include_names,
            CompileProgramPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clCompileProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCompileProgram")]
        static abstract int CompileProgram(
            ProgramHandle program,
            uint num_devices,
            Ref<DeviceIdHandle> device_list,
            Ref<sbyte> options,
            uint num_input_headers,
            Ref<ProgramHandle> input_headers,
            Ref2D<sbyte> header_include_names,
            CompileProgramPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract AcceleratorHandleINTEL CreateAcceleratorINTEL(
            ContextHandle context,
            uint accelerator_type,
            nuint descriptor_size,
            void* descriptor,
            int* errcode_ret
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract AcceleratorHandleINTEL CreateAcceleratorINTEL(
            ContextHandle context,
            uint accelerator_type,
            nuint descriptor_size,
            Ref descriptor,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateBuffer")]
        static abstract MemHandle CreateBuffer(
            ContextHandle context,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateBuffer")]
        static abstract MemHandle CreateBuffer(
            ContextHandle context,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract MemHandle CreateBufferWithProperties(
            ContextHandle context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract MemHandle CreateBufferWithProperties(
            ContextHandle context,
            Ref<ulong> properties,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract MemHandle CreateBufferWithPropertiesINTEL(
            ContextHandle context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract MemHandle CreateBufferWithPropertiesINTEL(
            ContextHandle context,
            Ref<ulong> properties,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateCommandQueue")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueue")]
        static abstract CommandQueueHandle CreateCommandQueue(
            ContextHandle context,
            DeviceIdHandle device,
            ulong properties,
            int* errcode_ret
        );

        [NativeName("clCreateCommandQueue")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueue")]
        static abstract CommandQueueHandle CreateCommandQueue(
            ContextHandle context,
            DeviceIdHandle device,
            ulong properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateCommandQueueWithProperties")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithProperties")]
        static abstract CommandQueueHandle CreateCommandQueueWithProperties(
            ContextHandle context,
            DeviceIdHandle device,
            ulong* properties,
            int* errcode_ret
        );

        [NativeName("clCreateCommandQueueWithProperties")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithProperties")]
        static abstract CommandQueueHandle CreateCommandQueueWithProperties(
            ContextHandle context,
            DeviceIdHandle device,
            Ref<ulong> properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract CommandQueueHandle CreateCommandQueueWithPropertiesKHR(
            ContextHandle context,
            DeviceIdHandle device,
            ulong* properties,
            int* errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract CommandQueueHandle CreateCommandQueueWithPropertiesKHR(
            ContextHandle context,
            DeviceIdHandle device,
            Ref<ulong> properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateContext")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateContext")]
        static abstract ContextHandle CreateContext(
            nint* properties,
            uint num_devices,
            DeviceIdHandle* devices,
            CreateContextPfnNotify pfn_notify,
            void* user_data,
            int* errcode_ret
        );

        [NativeName("clCreateContext")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateContext")]
        static abstract ContextHandle CreateContext(
            Ref<nint> properties,
            uint num_devices,
            Ref<DeviceIdHandle> devices,
            CreateContextPfnNotify pfn_notify,
            Ref user_data,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateContextFromType")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateContextFromType")]
        static abstract ContextHandle CreateContextFromType(
            nint* properties,
            ulong device_type,
            CreateContextFromTypePfnNotify pfn_notify,
            void* user_data,
            int* errcode_ret
        );

        [NativeName("clCreateContextFromType")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateContextFromType")]
        static abstract ContextHandle CreateContextFromType(
            Ref<nint> properties,
            ulong device_type,
            CreateContextFromTypePfnNotify pfn_notify,
            Ref user_data,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage")]
        static abstract MemHandle CreateImage(
            ContextHandle context,
            ulong flags,
            ImageFormat* image_format,
            ImageDesc* image_desc,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage")]
        static abstract MemHandle CreateImage(
            ContextHandle context,
            ulong flags,
            Ref<ImageFormat> image_format,
            Ref<ImageDesc> image_desc,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateImage2D")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage2D")]
        static abstract MemHandle CreateImage2D(
            ContextHandle context,
            ulong flags,
            ImageFormat* image_format,
            nuint image_width,
            nuint image_height,
            nuint image_row_pitch,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateImage2D")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage2D")]
        static abstract MemHandle CreateImage2D(
            ContextHandle context,
            ulong flags,
            Ref<ImageFormat> image_format,
            nuint image_width,
            nuint image_height,
            nuint image_row_pitch,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateImage3D")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage3D")]
        static abstract MemHandle CreateImage3D(
            ContextHandle context,
            ulong flags,
            ImageFormat* image_format,
            nuint image_width,
            nuint image_height,
            nuint image_depth,
            nuint image_row_pitch,
            nuint image_slice_pitch,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateImage3D")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateImage3D")]
        static abstract MemHandle CreateImage3D(
            ContextHandle context,
            ulong flags,
            Ref<ImageFormat> image_format,
            nuint image_width,
            nuint image_height,
            nuint image_depth,
            nuint image_row_pitch,
            nuint image_slice_pitch,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateImageWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateImageWithProperties")]
        static abstract MemHandle CreateImageWithProperties(
            ContextHandle context,
            ulong* properties,
            ulong flags,
            ImageFormat* image_format,
            ImageDesc* image_desc,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateImageWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateImageWithProperties")]
        static abstract MemHandle CreateImageWithProperties(
            ContextHandle context,
            Ref<ulong> properties,
            ulong flags,
            Ref<ImageFormat> image_format,
            Ref<ImageDesc> image_desc,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateKernel")]
        static abstract KernelHandle CreateKernel(
            ProgramHandle program,
            sbyte* kernel_name,
            int* errcode_ret
        );

        [NativeName("clCreateKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateKernel")]
        static abstract KernelHandle CreateKernel(
            ProgramHandle program,
            Ref<sbyte> kernel_name,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateKernelsInProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateKernelsInProgram")]
        static abstract int CreateKernelsInProgram(
            ProgramHandle program,
            uint num_kernels,
            KernelHandle* kernels,
            uint* num_kernels_ret
        );

        [NativeName("clCreateKernelsInProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateKernelsInProgram")]
        static abstract int CreateKernelsInProgram(
            ProgramHandle program,
            uint num_kernels,
            Ref<KernelHandle> kernels,
            Ref<uint> num_kernels_ret
        );

        [NativeName("clCreatePipe")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
        static abstract MemHandle CreatePipe(
            ContextHandle context,
            ulong flags,
            uint pipe_packet_size,
            uint pipe_max_packets,
            nint* properties,
            int* errcode_ret
        );

        [NativeName("clCreatePipe")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
        static abstract MemHandle CreatePipe(
            ContextHandle context,
            ulong flags,
            uint pipe_packet_size,
            uint pipe_max_packets,
            Ref<nint> properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithBinary")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBinary")]
        static abstract ProgramHandle CreateProgramWithBinary(
            ContextHandle context,
            uint num_devices,
            DeviceIdHandle* device_list,
            nuint* lengths,
            byte** binaries,
            int* binary_status,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithBinary")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBinary")]
        static abstract ProgramHandle CreateProgramWithBinary(
            ContextHandle context,
            uint num_devices,
            Ref<DeviceIdHandle> device_list,
            Ref<nuint> lengths,
            Ref2D<byte> binaries,
            Ref<int> binary_status,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithBuiltInKernels")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBuiltInKernels")]
        static abstract ProgramHandle CreateProgramWithBuiltInKernels(
            ContextHandle context,
            uint num_devices,
            DeviceIdHandle* device_list,
            sbyte* kernel_names,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithBuiltInKernels")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBuiltInKernels")]
        static abstract ProgramHandle CreateProgramWithBuiltInKernels(
            ContextHandle context,
            uint num_devices,
            Ref<DeviceIdHandle> device_list,
            Ref<sbyte> kernel_names,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithIL")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithIL")]
        static abstract ProgramHandle CreateProgramWithIL(
            ContextHandle context,
            void* il,
            nuint length,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithIL")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithIL")]
        static abstract ProgramHandle CreateProgramWithIL(
            ContextHandle context,
            Ref il,
            nuint length,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract ProgramHandle CreateProgramWithILKHR(
            ContextHandle context,
            void* il,
            nuint length,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract ProgramHandle CreateProgramWithILKHR(
            ContextHandle context,
            Ref il,
            nuint length,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithSource")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithSource")]
        static abstract ProgramHandle CreateProgramWithSource(
            ContextHandle context,
            uint count,
            sbyte** strings,
            nuint* lengths,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithSource")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithSource")]
        static abstract ProgramHandle CreateProgramWithSource(
            ContextHandle context,
            uint count,
            Ref2D<sbyte> strings,
            Ref<nuint> lengths,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSampler")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSampler")]
        static abstract SamplerHandle CreateSampler(
            ContextHandle context,
            uint normalized_coords,
            uint addressing_mode,
            uint filter_mode,
            int* errcode_ret
        );

        [NativeName("clCreateSampler")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSampler")]
        static abstract SamplerHandle CreateSampler(
            ContextHandle context,
            MaybeBool<uint> normalized_coords,
            uint addressing_mode,
            uint filter_mode,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSamplerWithProperties")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSamplerWithProperties")]
        static abstract SamplerHandle CreateSamplerWithProperties(
            ContextHandle context,
            ulong* sampler_properties,
            int* errcode_ret
        );

        [NativeName("clCreateSamplerWithProperties")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSamplerWithProperties")]
        static abstract SamplerHandle CreateSamplerWithProperties(
            ContextHandle context,
            Ref<ulong> sampler_properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract SemaphoreHandleKHR CreateSemaphoreWithPropertiesKHR(
            ContextHandle context,
            ulong* sema_props,
            int* errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract SemaphoreHandleKHR CreateSemaphoreWithPropertiesKHR(
            ContextHandle context,
            Ref<ulong> sema_props,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSubBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSubBuffer")]
        static abstract MemHandle CreateSubBuffer(
            MemHandle buffer,
            ulong flags,
            uint buffer_create_type,
            void* buffer_create_info,
            int* errcode_ret
        );

        [NativeName("clCreateSubBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSubBuffer")]
        static abstract MemHandle CreateSubBuffer(
            MemHandle buffer,
            ulong flags,
            uint buffer_create_type,
            Ref buffer_create_info,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSubDevices")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevices")]
        static abstract int CreateSubDevices(
            DeviceIdHandle in_device,
            nint* properties,
            uint num_devices,
            DeviceIdHandle* out_devices,
            uint* num_devices_ret
        );

        [NativeName("clCreateSubDevices")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevices")]
        static abstract int CreateSubDevices(
            DeviceIdHandle in_device,
            Ref<nint> properties,
            uint num_devices,
            Ref<DeviceIdHandle> out_devices,
            Ref<uint> num_devices_ret
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            DeviceIdHandle in_device,
            ulong* properties,
            uint num_entries,
            DeviceIdHandle* out_devices,
            uint* num_devices
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            DeviceIdHandle in_device,
            Ref<ulong> properties,
            uint num_entries,
            Ref<DeviceIdHandle> out_devices,
            Ref<uint> num_devices
        );

        [NativeName("clCreateUserEvent")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateUserEvent")]
        static abstract EventHandle CreateUserEvent(ContextHandle context, int* errcode_ret);

        [NativeName("clCreateUserEvent")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCreateUserEvent")]
        static abstract EventHandle CreateUserEvent(ContextHandle context, Ref<int> errcode_ret);

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract void* DeviceMemAllocINTEL(
            ContextHandle context,
            DeviceIdHandle device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract Ptr DeviceMemAllocINTEL(
            ContextHandle context,
            DeviceIdHandle device,
            Ref<ulong> properties,
            nuint size,
            uint alignment,
            Ref<int> errcode_ret
        );

        [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
        static abstract int EnqueueAcquireExternalMemObjectsKHR(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            MemHandle* mem_objects,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
        static abstract int EnqueueAcquireExternalMemObjectsKHR(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            Ref<MemHandle> mem_objects,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            CommandQueueHandle command_queue,
            uint num_objects,
            MemHandle* mem_objects,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            CommandQueueHandle command_queue,
            uint num_objects,
            Ref<MemHandle> mem_objects,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueBarrier")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueBarrier")]
        static abstract int EnqueueBarrier(CommandQueueHandle command_queue);

        [NativeName("clEnqueueBarrierWithWaitList")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueBarrierWithWaitList")]
        static abstract int EnqueueBarrierWithWaitList(
            CommandQueueHandle command_queue,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueBarrierWithWaitList")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueBarrierWithWaitList")]
        static abstract int EnqueueBarrierWithWaitList(
            CommandQueueHandle command_queue,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueCopyBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBuffer")]
        static abstract int EnqueueCopyBuffer(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueCopyBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBuffer")]
        static abstract int EnqueueCopyBuffer(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueCopyBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferRect")]
        static abstract int EnqueueCopyBufferRect(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_buffer,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueCopyBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferRect")]
        static abstract int EnqueueCopyBufferRect(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueCopyBufferToImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferToImage")]
        static abstract int EnqueueCopyBufferToImage(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_image,
            nuint src_offset,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueCopyBufferToImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferToImage")]
        static abstract int EnqueueCopyBufferToImage(
            CommandQueueHandle command_queue,
            MemHandle src_buffer,
            MemHandle dst_image,
            nuint src_offset,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueCopyImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImage")]
        static abstract int EnqueueCopyImage(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_image,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueCopyImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImage")]
        static abstract int EnqueueCopyImage(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_image,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueCopyImageToBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImageToBuffer")]
        static abstract int EnqueueCopyImageToBuffer(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_buffer,
            nuint* src_origin,
            nuint* region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueCopyImageToBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImageToBuffer")]
        static abstract int EnqueueCopyImageToBuffer(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueFillBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueFillBuffer")]
        static abstract int EnqueueFillBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            void* pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueFillBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueFillBuffer")]
        static abstract int EnqueueFillBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            Ref pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueFillImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueFillImage")]
        static abstract int EnqueueFillImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            void* fill_color,
            nuint* origin,
            nuint* region,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueFillImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueFillImage")]
        static abstract int EnqueueFillImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            Ref fill_color,
            Ref<nuint> origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_image,
            uint mipmap_filter_mode,
            nuint* array_region,
            nuint* mip_region,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            CommandQueueHandle command_queue,
            MemHandle src_image,
            MemHandle dst_image,
            uint mipmap_filter_mode,
            Ref<nuint> array_region,
            Ref<nuint> mip_region,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMapBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMapBuffer")]
        static abstract void* EnqueueMapBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            uint blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event,
            int* errcode_ret
        );

        [NativeName("clEnqueueMapBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMapBuffer")]
        static abstract Ptr EnqueueMapBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event,
            Ref<int> errcode_ret
        );

        [NativeName("clEnqueueMapImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMapImage")]
        static abstract void* EnqueueMapImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            uint blocking_map,
            ulong map_flags,
            nuint* origin,
            nuint* region,
            nuint* image_row_pitch,
            nuint* image_slice_pitch,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event,
            int* errcode_ret
        );

        [NativeName("clEnqueueMapImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMapImage")]
        static abstract Ptr EnqueueMapImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            Ref<nuint> origin,
            Ref<nuint> region,
            Ref<nuint> image_row_pitch,
            Ref<nuint> image_slice_pitch,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event,
            Ref<int> errcode_ret
        );

        [NativeName("clEnqueueMarker")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMarker")]
        static abstract int EnqueueMarker(CommandQueueHandle command_queue, EventHandle* @event);

        [NativeName("clEnqueueMarker")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMarker")]
        static abstract int EnqueueMarker(
            CommandQueueHandle command_queue,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMarkerWithWaitList")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMarkerWithWaitList")]
        static abstract int EnqueueMarkerWithWaitList(
            CommandQueueHandle command_queue,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMarkerWithWaitList")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMarkerWithWaitList")]
        static abstract int EnqueueMarkerWithWaitList(
            CommandQueueHandle command_queue,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            CommandQueueHandle command_queue,
            void* ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            CommandQueueHandle command_queue,
            Ref ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            CommandQueueHandle command_queue,
            uint blocking,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            CommandQueueHandle command_queue,
            MaybeBool<uint> blocking,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            CommandQueueHandle command_queue,
            void* dst_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            CommandQueueHandle command_queue,
            Ref dst_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            CommandQueueHandle command_queue,
            void* dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            CommandQueueHandle command_queue,
            Ref dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            CommandQueueHandle command_queue,
            void* ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            CommandQueueHandle command_queue,
            Ref ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            MemHandle* mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            Ref<MemHandle> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueMigrateMemObjects")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjects")]
        static abstract int EnqueueMigrateMemObjects(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            MemHandle* mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueMigrateMemObjects")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjects")]
        static abstract int EnqueueMigrateMemObjects(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            Ref<MemHandle> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueNativeKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueNativeKernel")]
        static abstract int EnqueueNativeKernel(
            CommandQueueHandle command_queue,
            EnqueueNativeKernelUserFunc user_func,
            void* args,
            nuint cb_args,
            uint num_mem_objects,
            MemHandle* mem_list,
            void** args_mem_loc,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueNativeKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueNativeKernel")]
        static abstract int EnqueueNativeKernel(
            CommandQueueHandle command_queue,
            EnqueueNativeKernelUserFunc user_func,
            Ref args,
            nuint cb_args,
            uint num_mem_objects,
            Ref<MemHandle> mem_list,
            Ref2D args_mem_loc,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueNDRangeKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueNDRangeKernel")]
        static abstract int EnqueueNDRangeKernel(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* local_work_size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueNDRangeKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueNDRangeKernel")]
        static abstract int EnqueueNDRangeKernel(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> local_work_size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReadBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadBuffer")]
        static abstract int EnqueueReadBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            uint blocking_read,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReadBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadBuffer")]
        static abstract int EnqueueReadBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            MaybeBool<uint> blocking_read,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReadBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadBufferRect")]
        static abstract int EnqueueReadBufferRect(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            uint blocking_read,
            nuint* buffer_origin,
            nuint* host_origin,
            nuint* region,
            nuint buffer_row_pitch,
            nuint buffer_slice_pitch,
            nuint host_row_pitch,
            nuint host_slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReadBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadBufferRect")]
        static abstract int EnqueueReadBufferRect(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            MaybeBool<uint> blocking_read,
            Ref<nuint> buffer_origin,
            Ref<nuint> host_origin,
            Ref<nuint> region,
            nuint buffer_row_pitch,
            nuint buffer_slice_pitch,
            nuint host_row_pitch,
            nuint host_slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            CommandQueueHandle command_queue,
            ProgramHandle program,
            sbyte* pipe_symbol,
            uint blocking_read,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            CommandQueueHandle command_queue,
            ProgramHandle program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_read,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReadImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadImage")]
        static abstract int EnqueueReadImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            uint blocking_read,
            nuint* origin,
            nuint* region,
            nuint row_pitch,
            nuint slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReadImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadImage")]
        static abstract int EnqueueReadImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            MaybeBool<uint> blocking_read,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint row_pitch,
            nuint slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            MemHandle* mem_objects,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            CommandQueueHandle command_queue,
            uint num_mem_objects,
            Ref<MemHandle> mem_objects,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            CommandQueueHandle command_queue,
            uint num_objects,
            MemHandle* mem_objects,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            CommandQueueHandle command_queue,
            uint num_objects,
            Ref<MemHandle> mem_objects,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            CommandQueueHandle command_queue,
            uint num_sema_objects,
            SemaphoreHandleKHR* sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            CommandQueueHandle command_queue,
            uint num_sema_objects,
            Ref<SemaphoreHandleKHR> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMFree")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
        static abstract int EnqueueSvmFree(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            EnqueueSvmFreePfnFreeFunc pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMFree")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
        static abstract int EnqueueSvmFree(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            EnqueueSvmFreePfnFreeFunc pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            EnqueueSvmFreeArmPfnFreeFunc pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            EnqueueSvmFreeArmPfnFreeFunc pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMap")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
        static abstract int EnqueueSvmMap(
            CommandQueueHandle command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMap")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
        static abstract int EnqueueSvmMap(
            CommandQueueHandle command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            CommandQueueHandle command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            CommandQueueHandle command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMemcpy")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
        static abstract int EnqueueSvmMemcpy(
            CommandQueueHandle command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMemcpy")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
        static abstract int EnqueueSvmMemcpy(
            CommandQueueHandle command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            CommandQueueHandle command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            CommandQueueHandle command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMemFill")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
        static abstract int EnqueueSvmMemFill(
            CommandQueueHandle command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMemFill")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
        static abstract int EnqueueSvmMemFill(
            CommandQueueHandle command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            CommandQueueHandle command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            CommandQueueHandle command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            nuint* sizes,
            ulong flags,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            CommandQueueHandle command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            Ref<nuint> sizes,
            ulong flags,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMUnmap")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
        static abstract int EnqueueSvmUnmap(
            CommandQueueHandle command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMUnmap")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
        static abstract int EnqueueSvmUnmap(
            CommandQueueHandle command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            CommandQueueHandle command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            CommandQueueHandle command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueTask")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueTask")]
        static abstract int EnqueueTask(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueTask")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueTask")]
        static abstract int EnqueueTask(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueUnmapMemObject")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueUnmapMemObject")]
        static abstract int EnqueueUnmapMemObject(
            CommandQueueHandle command_queue,
            MemHandle memobj,
            void* mapped_ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueUnmapMemObject")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueUnmapMemObject")]
        static abstract int EnqueueUnmapMemObject(
            CommandQueueHandle command_queue,
            MemHandle memobj,
            Ref mapped_ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueWaitForEvents")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitForEvents")]
        static abstract int EnqueueWaitForEvents(
            CommandQueueHandle command_queue,
            uint num_events,
            EventHandle* event_list
        );

        [NativeName("clEnqueueWaitForEvents")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitForEvents")]
        static abstract int EnqueueWaitForEvents(
            CommandQueueHandle command_queue,
            uint num_events,
            Ref<EventHandle> event_list
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            CommandQueueHandle command_queue,
            uint num_sema_objects,
            SemaphoreHandleKHR* sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            CommandQueueHandle command_queue,
            uint num_sema_objects,
            Ref<SemaphoreHandleKHR> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueWriteBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBuffer")]
        static abstract int EnqueueWriteBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            uint blocking_write,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueWriteBuffer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBuffer")]
        static abstract int EnqueueWriteBuffer(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            MaybeBool<uint> blocking_write,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueWriteBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBufferRect")]
        static abstract int EnqueueWriteBufferRect(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            uint blocking_write,
            nuint* buffer_origin,
            nuint* host_origin,
            nuint* region,
            nuint buffer_row_pitch,
            nuint buffer_slice_pitch,
            nuint host_row_pitch,
            nuint host_slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueWriteBufferRect")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBufferRect")]
        static abstract int EnqueueWriteBufferRect(
            CommandQueueHandle command_queue,
            MemHandle buffer,
            MaybeBool<uint> blocking_write,
            Ref<nuint> buffer_origin,
            Ref<nuint> host_origin,
            Ref<nuint> region,
            nuint buffer_row_pitch,
            nuint buffer_slice_pitch,
            nuint host_row_pitch,
            nuint host_slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            CommandQueueHandle command_queue,
            ProgramHandle program,
            sbyte* pipe_symbol,
            uint blocking_write,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            CommandQueueHandle command_queue,
            ProgramHandle program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_write,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clEnqueueWriteImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteImage")]
        static abstract int EnqueueWriteImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            uint blocking_write,
            nuint* origin,
            nuint* region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            EventHandle* event_wait_list,
            EventHandle* @event
        );

        [NativeName("clEnqueueWriteImage")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteImage")]
        static abstract int EnqueueWriteImage(
            CommandQueueHandle command_queue,
            MemHandle image,
            MaybeBool<uint> blocking_write,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref<EventHandle> event_wait_list,
            Ref<EventHandle> @event
        );

        [NativeName("clFinish")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clFinish")]
        static abstract int Finish(CommandQueueHandle command_queue);

        [NativeName("clFlush")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clFlush")]
        static abstract int Flush(CommandQueueHandle command_queue);

        [NativeName("clGetAcceleratorInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
        static abstract int GetAcceleratorInfoINTEL(
            AcceleratorHandleINTEL accelerator,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetAcceleratorInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
        static abstract int GetAcceleratorInfoINTEL(
            AcceleratorHandleINTEL accelerator,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetCommandQueueInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetCommandQueueInfo")]
        static abstract int GetCommandQueueInfo(
            CommandQueueHandle command_queue,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetCommandQueueInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetCommandQueueInfo")]
        static abstract int GetCommandQueueInfo(
            CommandQueueHandle command_queue,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetContextInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetContextInfo")]
        static abstract int GetContextInfo(
            ContextHandle context,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetContextInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetContextInfo")]
        static abstract int GetContextInfo(
            ContextHandle context,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetDeviceAndHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceAndHostTimer")]
        static abstract int GetDeviceAndHostTimer(
            DeviceIdHandle device,
            ulong* device_timestamp,
            ulong* host_timestamp
        );

        [NativeName("clGetDeviceAndHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceAndHostTimer")]
        static abstract int GetDeviceAndHostTimer(
            DeviceIdHandle device,
            Ref<ulong> device_timestamp,
            Ref<ulong> host_timestamp
        );

        [NativeName("clGetDeviceIDs")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceIDs")]
        static abstract int GetDeviceIDs(
            PlatformIdHandle platform,
            ulong device_type,
            uint num_entries,
            DeviceIdHandle* devices,
            uint* num_devices
        );

        [NativeName("clGetDeviceIDs")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceIDs")]
        static abstract int GetDeviceIDs(
            PlatformIdHandle platform,
            ulong device_type,
            uint num_entries,
            Ref<DeviceIdHandle> devices,
            Ref<uint> num_devices
        );

        [NativeName("clGetDeviceImageInfoQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
        static abstract int GetDeviceImageInfoQCOM(
            DeviceIdHandle device,
            nuint image_width,
            nuint image_height,
            ImageFormat* image_format,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetDeviceImageInfoQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
        static abstract int GetDeviceImageInfoQCOM(
            DeviceIdHandle device,
            nuint image_width,
            nuint image_height,
            Ref<ImageFormat> image_format,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetDeviceInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceInfo")]
        static abstract int GetDeviceInfo(
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetDeviceInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceInfo")]
        static abstract int GetDeviceInfo(
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetEventInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetEventInfo")]
        static abstract int GetEventInfo(
            EventHandle @event,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetEventInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetEventInfo")]
        static abstract int GetEventInfo(
            EventHandle @event,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetEventProfilingInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetEventProfilingInfo")]
        static abstract int GetEventProfilingInfo(
            EventHandle @event,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetEventProfilingInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetEventProfilingInfo")]
        static abstract int GetEventProfilingInfo(
            EventHandle @event,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetExtensionFunctionAddress")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddress")]
        static abstract void* GetExtensionFunctionAddress(sbyte* func_name);

        [NativeName("clGetExtensionFunctionAddress")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddress")]
        static abstract Ptr GetExtensionFunctionAddress(Ref<sbyte> func_name);

        [NativeName("clGetExtensionFunctionAddressForPlatform")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        static abstract void* GetExtensionFunctionAddressForPlatform(
            PlatformIdHandle platform,
            sbyte* func_name
        );

        [NativeName("clGetExtensionFunctionAddressForPlatform")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        static abstract Ptr GetExtensionFunctionAddressForPlatform(
            PlatformIdHandle platform,
            Ref<sbyte> func_name
        );

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(DeviceIdHandle device, ulong* host_timestamp);

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(DeviceIdHandle device, Ref<ulong> host_timestamp);

        [NativeName("clGetICDLoaderInfoOCLICD")]
        [SupportedApiProfile("opencl", ["cl_loader_info"])]
        [NativeFunction("opencl", EntryPoint = "clGetICDLoaderInfoOCLICD")]
        static abstract int GetIcdLoaderInfoOclicd(
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetICDLoaderInfoOCLICD")]
        [SupportedApiProfile("opencl", ["cl_loader_info"])]
        [NativeFunction("opencl", EntryPoint = "clGetICDLoaderInfoOCLICD")]
        static abstract int GetIcdLoaderInfoOclicd(
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetImageInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetImageInfo")]
        static abstract int GetImageInfo(
            MemHandle image,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetImageInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetImageInfo")]
        static abstract int GetImageInfo(
            MemHandle image,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetImageRequirementsInfoEXT")]
        [SupportedApiProfile(
            "opencl",
            ["cl_ext_image_requirements_info"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clGetImageRequirementsInfoEXT")]
        static abstract int GetImageRequirementsInfoEXT(
            ContextHandle context,
            ulong* properties,
            ulong flags,
            ImageFormat* image_format,
            ImageDesc* image_desc,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetImageRequirementsInfoEXT")]
        [SupportedApiProfile(
            "opencl",
            ["cl_ext_image_requirements_info"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clGetImageRequirementsInfoEXT")]
        static abstract int GetImageRequirementsInfoEXT(
            ContextHandle context,
            Ref<ulong> properties,
            ulong flags,
            Ref<ImageFormat> image_format,
            Ref<ImageDesc> image_desc,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetKernelArgInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelArgInfo")]
        static abstract int GetKernelArgInfo(
            KernelHandle kernel,
            uint arg_indx,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetKernelArgInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelArgInfo")]
        static abstract int GetKernelArgInfo(
            KernelHandle kernel,
            uint arg_indx,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetKernelInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelInfo")]
        static abstract int GetKernelInfo(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetKernelInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelInfo")]
        static abstract int GetKernelInfo(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetKernelSubGroupInfo")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfo")]
        static abstract int GetKernelSubGroupInfo(
            KernelHandle kernel,
            DeviceIdHandle device,
            uint param_name,
            nuint input_value_size,
            void* input_value,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetKernelSubGroupInfo")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfo")]
        static abstract int GetKernelSubGroupInfo(
            KernelHandle kernel,
            DeviceIdHandle device,
            uint param_name,
            nuint input_value_size,
            Ref input_value,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetKernelSubGroupInfoKHR")]
        [Obsolete]
        [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfoKHR")]
        static abstract int GetKernelSubGroupInfoKHR(
            KernelHandle in_kernel,
            DeviceIdHandle in_device,
            uint param_name,
            nuint input_value_size,
            void* input_value,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetKernelSubGroupInfoKHR")]
        [Obsolete]
        [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfoKHR")]
        static abstract int GetKernelSubGroupInfoKHR(
            KernelHandle in_kernel,
            DeviceIdHandle in_device,
            uint param_name,
            nuint input_value_size,
            Ref input_value,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetKernelSuggestedLocalWorkSize")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
        static abstract int GetKernelSuggestedLocalWorkSize(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSize")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
        static abstract int GetKernelSuggestedLocalWorkSize(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            CommandQueueHandle command_queue,
            KernelHandle kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> suggested_local_work_size
        );

        [NativeName("clGetKernelWorkGroupInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelWorkGroupInfo")]
        static abstract int GetKernelWorkGroupInfo(
            KernelHandle kernel,
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetKernelWorkGroupInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetKernelWorkGroupInfo")]
        static abstract int GetKernelWorkGroupInfo(
            KernelHandle kernel,
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetMemAllocInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
        static abstract int GetMemAllocInfoINTEL(
            ContextHandle context,
            void* ptr,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetMemAllocInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
        static abstract int GetMemAllocInfoINTEL(
            ContextHandle context,
            Ref ptr,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetMemObjectInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetMemObjectInfo")]
        static abstract int GetMemObjectInfo(
            MemHandle memobj,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetMemObjectInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetMemObjectInfo")]
        static abstract int GetMemObjectInfo(
            MemHandle memobj,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetPipeInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPipeInfo")]
        static abstract int GetPipeInfo(
            MemHandle pipe,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetPipeInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPipeInfo")]
        static abstract int GetPipeInfo(
            MemHandle pipe,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetPlatformIDs")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPlatformIDs")]
        static abstract int GetPlatformIDs(
            uint num_entries,
            PlatformIdHandle* platforms,
            uint* num_platforms
        );

        [NativeName("clGetPlatformIDs")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPlatformIDs")]
        static abstract int GetPlatformIDs(
            uint num_entries,
            Ref<PlatformIdHandle> platforms,
            Ref<uint> num_platforms
        );

        [NativeName("clGetPlatformInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPlatformInfo")]
        static abstract int GetPlatformInfo(
            PlatformIdHandle platform,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetPlatformInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetPlatformInfo")]
        static abstract int GetPlatformInfo(
            PlatformIdHandle platform,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetProgramBuildInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetProgramBuildInfo")]
        static abstract int GetProgramBuildInfo(
            ProgramHandle program,
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetProgramBuildInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetProgramBuildInfo")]
        static abstract int GetProgramBuildInfo(
            ProgramHandle program,
            DeviceIdHandle device,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetProgramInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetProgramInfo")]
        static abstract int GetProgramInfo(
            ProgramHandle program,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetProgramInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetProgramInfo")]
        static abstract int GetProgramInfo(
            ProgramHandle program,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetSamplerInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSamplerInfo")]
        static abstract int GetSamplerInfo(
            SamplerHandle sampler,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetSamplerInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSamplerInfo")]
        static abstract int GetSamplerInfo(
            SamplerHandle sampler,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetSemaphoreHandleForTypeKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_semaphore"],
            ImpliesSets = ["cl_khr_semaphore", "CL_VERSION_1_2"]
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreHandleForTypeKHR")]
        static abstract int GetSemaphoreHandleForTypeKHR(
            SemaphoreHandleKHR sema_object,
            DeviceIdHandle device,
            uint handle_type,
            nuint handle_size,
            void* handle_ptr,
            nuint* handle_size_ret
        );

        [NativeName("clGetSemaphoreHandleForTypeKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_semaphore"],
            ImpliesSets = ["cl_khr_semaphore", "CL_VERSION_1_2"]
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreHandleForTypeKHR")]
        static abstract int GetSemaphoreHandleForTypeKHR(
            SemaphoreHandleKHR sema_object,
            DeviceIdHandle device,
            uint handle_type,
            nuint handle_size,
            Ref handle_ptr,
            Ref<nuint> handle_size_ret
        );

        [NativeName("clGetSemaphoreInfoKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
        static abstract int GetSemaphoreInfoKHR(
            SemaphoreHandleKHR sema_object,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetSemaphoreInfoKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
        static abstract int GetSemaphoreInfoKHR(
            SemaphoreHandleKHR sema_object,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetSupportedImageFormats")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSupportedImageFormats")]
        static abstract int GetSupportedImageFormats(
            ContextHandle context,
            ulong flags,
            uint image_type,
            uint num_entries,
            ImageFormat* image_formats,
            uint* num_image_formats
        );

        [NativeName("clGetSupportedImageFormats")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetSupportedImageFormats")]
        static abstract int GetSupportedImageFormats(
            ContextHandle context,
            ulong flags,
            uint image_type,
            uint num_entries,
            Ref<ImageFormat> image_formats,
            Ref<uint> num_image_formats
        );

        [NativeName("clHostMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
        static abstract void* HostMemAllocINTEL(
            ContextHandle context,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clHostMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
        static abstract Ptr HostMemAllocINTEL(
            ContextHandle context,
            Ref<ulong> properties,
            nuint size,
            uint alignment,
            Ref<int> errcode_ret
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract void* IcdGetFunctionAddressForPlatformKHR(
            PlatformIdHandle platform,
            sbyte* func_name
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract Ptr IcdGetFunctionAddressForPlatformKHR(
            PlatformIdHandle platform,
            Ref<sbyte> func_name
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            PlatformIdHandle* platforms,
            uint* num_platforms
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            Ref<PlatformIdHandle> platforms,
            Ref<uint> num_platforms
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            PlatformIdHandle platform,
            void* dispatch_data
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            PlatformIdHandle platform,
            Ref dispatch_data
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract MemHandle ImportMemoryARM(
            ContextHandle context,
            ulong flags,
            nint* properties,
            void* memory,
            nuint size,
            int* errcode_ret
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract MemHandle ImportMemoryARM(
            ContextHandle context,
            ulong flags,
            Ref<nint> properties,
            Ref memory,
            nuint size,
            Ref<int> errcode_ret
        );

        [NativeName("clLinkProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clLinkProgram")]
        static abstract ProgramHandle LinkProgram(
            ContextHandle context,
            uint num_devices,
            DeviceIdHandle* device_list,
            sbyte* options,
            uint num_input_programs,
            ProgramHandle* input_programs,
            LinkProgramPfnNotify pfn_notify,
            void* user_data,
            int* errcode_ret
        );

        [NativeName("clLinkProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clLinkProgram")]
        static abstract ProgramHandle LinkProgram(
            ContextHandle context,
            uint num_devices,
            Ref<DeviceIdHandle> device_list,
            Ref<sbyte> options,
            uint num_input_programs,
            Ref<ProgramHandle> input_programs,
            LinkProgramPfnNotify pfn_notify,
            Ref user_data,
            Ref<int> errcode_ret
        );

        [NativeName("clLogMessagesToStderrAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToStderrAPPLE")]
        static abstract void LogMessagesToStderrAPPLE(
            sbyte* errstr,
            void* private_info,
            nuint cb,
            void* user_data
        );

        [NativeName("clLogMessagesToStderrAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToStderrAPPLE")]
        static abstract void LogMessagesToStderrAPPLE(
            Ref<sbyte> errstr,
            Ref private_info,
            nuint cb,
            Ref user_data
        );

        [NativeName("clLogMessagesToStdoutAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToStdoutAPPLE")]
        static abstract void LogMessagesToStdoutAPPLE(
            sbyte* errstr,
            void* private_info,
            nuint cb,
            void* user_data
        );

        [NativeName("clLogMessagesToStdoutAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToStdoutAPPLE")]
        static abstract void LogMessagesToStdoutAPPLE(
            Ref<sbyte> errstr,
            Ref private_info,
            nuint cb,
            Ref user_data
        );

        [NativeName("clLogMessagesToSystemLogAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        static abstract void LogMessagesToSystemLogAPPLE(
            sbyte* errstr,
            void* private_info,
            nuint cb,
            void* user_data
        );

        [NativeName("clLogMessagesToSystemLogAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
        [NativeFunction("opencl", EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        static abstract void LogMessagesToSystemLogAPPLE(
            Ref<sbyte> errstr,
            Ref private_info,
            nuint cb,
            Ref user_data
        );

        [NativeName("clMemBlockingFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
        static abstract int MemBlockingFreeINTEL(ContextHandle context, void* ptr);

        [NativeName("clMemBlockingFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
        static abstract int MemBlockingFreeINTEL(ContextHandle context, Ref ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(ContextHandle context, void* ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(ContextHandle context, Ref ptr);

        [NativeName("clReImportSemaphoreSyncFdKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_semaphore_sync_fd"],
            ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
        )]
        [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
        static abstract int ReImportSemaphoreSyncFdKHR(
            SemaphoreHandleKHR sema_object,
            ulong* reimport_props,
            int fd
        );

        [NativeName("clReImportSemaphoreSyncFdKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_semaphore_sync_fd"],
            ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
        )]
        [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
        static abstract int ReImportSemaphoreSyncFdKHR(
            SemaphoreHandleKHR sema_object,
            Ref<ulong> reimport_props,
            int fd
        );

        [NativeName("clReleaseAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
        static abstract int ReleaseAcceleratorINTEL(AcceleratorHandleINTEL accelerator);

        [NativeName("clReleaseCommandQueue")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseCommandQueue")]
        static abstract int ReleaseCommandQueue(CommandQueueHandle command_queue);

        [NativeName("clReleaseContext")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseContext")]
        static abstract int ReleaseContext(ContextHandle context);

        [NativeName("clReleaseDevice")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseDevice")]
        static abstract int ReleaseDevice(DeviceIdHandle device);

        [NativeName("clReleaseDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
        static abstract int ReleaseDeviceEXT(DeviceIdHandle device);

        [NativeName("clReleaseEvent")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseEvent")]
        static abstract int ReleaseEvent(EventHandle @event);

        [NativeName("clReleaseKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseKernel")]
        static abstract int ReleaseKernel(KernelHandle kernel);

        [NativeName("clReleaseMemObject")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseMemObject")]
        static abstract int ReleaseMemObject(MemHandle memobj);

        [NativeName("clReleaseProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseProgram")]
        static abstract int ReleaseProgram(ProgramHandle program);

        [NativeName("clReleaseSampler")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clReleaseSampler")]
        static abstract int ReleaseSampler(SamplerHandle sampler);

        [NativeName("clReleaseSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
        static abstract int ReleaseSemaphoreKHR(SemaphoreHandleKHR sema_object);

        [NativeName("clRetainAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
        static abstract int RetainAcceleratorINTEL(AcceleratorHandleINTEL accelerator);

        [NativeName("clRetainCommandQueue")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainCommandQueue")]
        static abstract int RetainCommandQueue(CommandQueueHandle command_queue);

        [NativeName("clRetainContext")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainContext")]
        static abstract int RetainContext(ContextHandle context);

        [NativeName("clRetainDevice")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainDevice")]
        static abstract int RetainDevice(DeviceIdHandle device);

        [NativeName("clRetainDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
        static abstract int RetainDeviceEXT(DeviceIdHandle device);

        [NativeName("clRetainEvent")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainEvent")]
        static abstract int RetainEvent(EventHandle @event);

        [NativeName("clRetainKernel")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainKernel")]
        static abstract int RetainKernel(KernelHandle kernel);

        [NativeName("clRetainMemObject")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainMemObject")]
        static abstract int RetainMemObject(MemHandle memobj);

        [NativeName("clRetainProgram")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainProgram")]
        static abstract int RetainProgram(ProgramHandle program);

        [NativeName("clRetainSampler")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clRetainSampler")]
        static abstract int RetainSampler(SamplerHandle sampler);

        [NativeName("clRetainSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
        static abstract int RetainSemaphoreKHR(SemaphoreHandleKHR sema_object);

        [NativeName("clSetContentSizeBufferPoCL")]
        [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
        [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
        static abstract int SetContentSizeBufferPOCL(
            MemHandle buffer,
            MemHandle content_size_buffer
        );

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            ContextHandle context,
            SetContextDestructorCallbackPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            ContextHandle context,
            SetContextDestructorCallbackPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clSetDefaultDeviceCommandQueue")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
        static abstract int SetDefaultDeviceCommandQueue(
            ContextHandle context,
            DeviceIdHandle device,
            CommandQueueHandle command_queue
        );

        [NativeName("clSetEventCallback")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetEventCallback")]
        static abstract int SetEventCallback(
            EventHandle @event,
            int command_exec_callback_type,
            SetEventCallbackPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clSetEventCallback")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetEventCallback")]
        static abstract int SetEventCallback(
            EventHandle @event,
            int command_exec_callback_type,
            SetEventCallbackPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clSetKernelArg")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArg")]
        static abstract int SetKernelArg(
            KernelHandle kernel,
            uint arg_index,
            nuint arg_size,
            void* arg_value
        );

        [NativeName("clSetKernelArg")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArg")]
        static abstract int SetKernelArg(
            KernelHandle kernel,
            uint arg_index,
            nuint arg_size,
            Ref arg_value
        );

        [NativeName("clSetKernelArgDevicePointerEXT")]
        [SupportedApiProfile(
            "opencl",
            ["cl_ext_buffer_device_address"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
        static abstract int SetKernelArgDevicePointerEXT(
            KernelHandle kernel,
            uint arg_index,
            ulong arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            KernelHandle kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            KernelHandle kernel,
            uint arg_index,
            Ref arg_value
        );

        [NativeName("clSetKernelArgSVMPointer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
        static abstract int SetKernelArgSvmPointer(
            KernelHandle kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgSVMPointer")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
        static abstract int SetKernelArgSvmPointer(
            KernelHandle kernel,
            uint arg_index,
            Ref arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            KernelHandle kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            KernelHandle kernel,
            uint arg_index,
            Ref arg_value
        );

        [NativeName("clSetKernelExecInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
        static abstract int SetKernelExecInfo(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            void* param_value
        );

        [NativeName("clSetKernelExecInfo")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
        static abstract int SetKernelExecInfo(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            void* param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            KernelHandle kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            MemHandle memobj,
            SetMemObjectDestructorApplePfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            MemHandle memobj,
            SetMemObjectDestructorApplePfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clSetMemObjectDestructorCallback")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorCallback")]
        static abstract int SetMemObjectDestructorCallback(
            MemHandle memobj,
            SetMemObjectDestructorCallbackPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clSetMemObjectDestructorCallback")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorCallback")]
        static abstract int SetMemObjectDestructorCallback(
            MemHandle memobj,
            SetMemObjectDestructorCallbackPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clSetPerfHintQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
        [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
        static abstract int SetPerfHintQCOM(ContextHandle context, uint perf_hint);

        [NativeName("clSetProgramReleaseCallback")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
        static abstract int SetProgramReleaseCallback(
            ProgramHandle program,
            SetProgramReleaseCallbackPfnNotify pfn_notify,
            void* user_data
        );

        [NativeName("clSetProgramReleaseCallback")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
        static abstract int SetProgramReleaseCallback(
            ProgramHandle program,
            SetProgramReleaseCallbackPfnNotify pfn_notify,
            Ref user_data
        );

        [NativeName("clSetProgramSpecializationConstant")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramSpecializationConstant")]
        static abstract int SetProgramSpecializationConstant(
            ProgramHandle program,
            uint spec_id,
            nuint spec_size,
            void* spec_value
        );

        [NativeName("clSetProgramSpecializationConstant")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramSpecializationConstant")]
        static abstract int SetProgramSpecializationConstant(
            ProgramHandle program,
            uint spec_id,
            nuint spec_size,
            Ref spec_value
        );

        [NativeName("clSetUserEventStatus")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetUserEventStatus")]
        static abstract int SetUserEventStatus(EventHandle @event, int execution_status);

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract void* SharedMemAllocINTEL(
            ContextHandle context,
            DeviceIdHandle device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract Ptr SharedMemAllocINTEL(
            ContextHandle context,
            DeviceIdHandle device,
            Ref<ulong> properties,
            nuint size,
            uint alignment,
            Ref<int> errcode_ret
        );

        [NativeName("clSVMAlloc")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
        static abstract Ptr SvmAlloc(
            ContextHandle context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract Ptr SvmAllocARM(
            ContextHandle context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract void* SvmAllocRawARM(
            ContextHandle context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAlloc")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
        static abstract void* SvmAllocRaw(
            ContextHandle context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMFree")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSVMFree")]
        static abstract void SvmFree(ContextHandle context, void* svm_pointer);

        [NativeName("clSVMFree")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "2.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clSVMFree")]
        static abstract void SvmFree(ContextHandle context, Ref svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(ContextHandle context, void* svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(ContextHandle context, Ref svm_pointer);

        [NativeName("clTerminateContextKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
        [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
        static abstract int TerminateContextKHR(ContextHandle context);

        [NativeName("clUnloadCompiler")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clUnloadCompiler")]
        static abstract int UnloadCompiler();

        [NativeName("clUnloadPlatformCompiler")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clUnloadPlatformCompiler")]
        static abstract int UnloadPlatformCompiler(PlatformIdHandle platform);

        [NativeName("clWaitForEvents")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clWaitForEvents")]
        static abstract int WaitForEvents(uint num_events, EventHandle* event_list);

        [NativeName("clWaitForEvents")]
        [SupportedApiProfile(
            "opencl",
            [
                "CL_VERSION_1_0",
                "CL_VERSION_1_1",
                "CL_VERSION_1_2",
                "CL_VERSION_2_0",
                "CL_VERSION_2_1",
                "CL_VERSION_2_2",
                "CL_VERSION_3_0",
                "CL_VERSION_3_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("opencl", EntryPoint = "clWaitForEvents")]
        static abstract int WaitForEvents(uint num_events, Ref<EventHandle> event_list);
    }

    [NativeName("clBuildProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clBuildProgram")]
    int BuildProgram(
        ProgramHandle program,
        uint num_devices,
        DeviceIdHandle* device_list,
        sbyte* options,
        BuildProgramPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clBuildProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clBuildProgram")]
    int BuildProgram(
        ProgramHandle program,
        uint num_devices,
        Ref<DeviceIdHandle> device_list,
        Ref<sbyte> options,
        BuildProgramPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(EventHandle* event_list, nuint num_events_in_list);

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(Ref<EventHandle> event_list, nuint num_events_in_list);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    KernelHandle CloneKernel(KernelHandle source_kernel, int* errcode_ret);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    KernelHandle CloneKernel(KernelHandle source_kernel, Ref<int> errcode_ret);

    [NativeName("clCompileProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCompileProgram")]
    int CompileProgram(
        ProgramHandle program,
        uint num_devices,
        DeviceIdHandle* device_list,
        sbyte* options,
        uint num_input_headers,
        ProgramHandle* input_headers,
        sbyte** header_include_names,
        CompileProgramPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clCompileProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCompileProgram")]
    int CompileProgram(
        ProgramHandle program,
        uint num_devices,
        Ref<DeviceIdHandle> device_list,
        Ref<sbyte> options,
        uint num_input_headers,
        Ref<ProgramHandle> input_headers,
        Ref2D<sbyte> header_include_names,
        CompileProgramPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    AcceleratorHandleINTEL CreateAcceleratorINTEL(
        ContextHandle context,
        uint accelerator_type,
        nuint descriptor_size,
        void* descriptor,
        int* errcode_ret
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    AcceleratorHandleINTEL CreateAcceleratorINTEL(
        ContextHandle context,
        uint accelerator_type,
        nuint descriptor_size,
        Ref descriptor,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateBuffer")]
    MemHandle CreateBuffer(
        ContextHandle context,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateBuffer")]
    MemHandle CreateBuffer(
        ContextHandle context,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    MemHandle CreateBufferWithProperties(
        ContextHandle context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    MemHandle CreateBufferWithProperties(
        ContextHandle context,
        Ref<ulong> properties,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    MemHandle CreateBufferWithPropertiesINTEL(
        ContextHandle context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    MemHandle CreateBufferWithPropertiesINTEL(
        ContextHandle context,
        Ref<ulong> properties,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateCommandQueue")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueue")]
    CommandQueueHandle CreateCommandQueue(
        ContextHandle context,
        DeviceIdHandle device,
        ulong properties,
        int* errcode_ret
    );

    [NativeName("clCreateCommandQueue")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueue")]
    CommandQueueHandle CreateCommandQueue(
        ContextHandle context,
        DeviceIdHandle device,
        ulong properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateCommandQueueWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithProperties")]
    CommandQueueHandle CreateCommandQueueWithProperties(
        ContextHandle context,
        DeviceIdHandle device,
        ulong* properties,
        int* errcode_ret
    );

    [NativeName("clCreateCommandQueueWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithProperties")]
    CommandQueueHandle CreateCommandQueueWithProperties(
        ContextHandle context,
        DeviceIdHandle device,
        Ref<ulong> properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    CommandQueueHandle CreateCommandQueueWithPropertiesKHR(
        ContextHandle context,
        DeviceIdHandle device,
        ulong* properties,
        int* errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    CommandQueueHandle CreateCommandQueueWithPropertiesKHR(
        ContextHandle context,
        DeviceIdHandle device,
        Ref<ulong> properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateContext")]
    ContextHandle CreateContext(
        nint* properties,
        uint num_devices,
        DeviceIdHandle* devices,
        CreateContextPfnNotify pfn_notify,
        void* user_data,
        int* errcode_ret
    );

    [NativeName("clCreateContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateContext")]
    ContextHandle CreateContext(
        Ref<nint> properties,
        uint num_devices,
        Ref<DeviceIdHandle> devices,
        CreateContextPfnNotify pfn_notify,
        Ref user_data,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateContextFromType")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateContextFromType")]
    ContextHandle CreateContextFromType(
        nint* properties,
        ulong device_type,
        CreateContextFromTypePfnNotify pfn_notify,
        void* user_data,
        int* errcode_ret
    );

    [NativeName("clCreateContextFromType")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateContextFromType")]
    ContextHandle CreateContextFromType(
        Ref<nint> properties,
        ulong device_type,
        CreateContextFromTypePfnNotify pfn_notify,
        Ref user_data,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage")]
    MemHandle CreateImage(
        ContextHandle context,
        ulong flags,
        ImageFormat* image_format,
        ImageDesc* image_desc,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage")]
    MemHandle CreateImage(
        ContextHandle context,
        ulong flags,
        Ref<ImageFormat> image_format,
        Ref<ImageDesc> image_desc,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateImage2D")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage2D")]
    MemHandle CreateImage2D(
        ContextHandle context,
        ulong flags,
        ImageFormat* image_format,
        nuint image_width,
        nuint image_height,
        nuint image_row_pitch,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateImage2D")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage2D")]
    MemHandle CreateImage2D(
        ContextHandle context,
        ulong flags,
        Ref<ImageFormat> image_format,
        nuint image_width,
        nuint image_height,
        nuint image_row_pitch,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateImage3D")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage3D")]
    MemHandle CreateImage3D(
        ContextHandle context,
        ulong flags,
        ImageFormat* image_format,
        nuint image_width,
        nuint image_height,
        nuint image_depth,
        nuint image_row_pitch,
        nuint image_slice_pitch,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateImage3D")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateImage3D")]
    MemHandle CreateImage3D(
        ContextHandle context,
        ulong flags,
        Ref<ImageFormat> image_format,
        nuint image_width,
        nuint image_height,
        nuint image_depth,
        nuint image_row_pitch,
        nuint image_slice_pitch,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateImageWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateImageWithProperties")]
    MemHandle CreateImageWithProperties(
        ContextHandle context,
        ulong* properties,
        ulong flags,
        ImageFormat* image_format,
        ImageDesc* image_desc,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateImageWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateImageWithProperties")]
    MemHandle CreateImageWithProperties(
        ContextHandle context,
        Ref<ulong> properties,
        ulong flags,
        Ref<ImageFormat> image_format,
        Ref<ImageDesc> image_desc,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateKernel")]
    KernelHandle CreateKernel(ProgramHandle program, sbyte* kernel_name, int* errcode_ret);

    [NativeName("clCreateKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateKernel")]
    KernelHandle CreateKernel(ProgramHandle program, Ref<sbyte> kernel_name, Ref<int> errcode_ret);

    [NativeName("clCreateKernelsInProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateKernelsInProgram")]
    int CreateKernelsInProgram(
        ProgramHandle program,
        uint num_kernels,
        KernelHandle* kernels,
        uint* num_kernels_ret
    );

    [NativeName("clCreateKernelsInProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateKernelsInProgram")]
    int CreateKernelsInProgram(
        ProgramHandle program,
        uint num_kernels,
        Ref<KernelHandle> kernels,
        Ref<uint> num_kernels_ret
    );

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
    MemHandle CreatePipe(
        ContextHandle context,
        ulong flags,
        uint pipe_packet_size,
        uint pipe_max_packets,
        nint* properties,
        int* errcode_ret
    );

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
    MemHandle CreatePipe(
        ContextHandle context,
        ulong flags,
        uint pipe_packet_size,
        uint pipe_max_packets,
        Ref<nint> properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithBinary")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBinary")]
    ProgramHandle CreateProgramWithBinary(
        ContextHandle context,
        uint num_devices,
        DeviceIdHandle* device_list,
        nuint* lengths,
        byte** binaries,
        int* binary_status,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithBinary")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBinary")]
    ProgramHandle CreateProgramWithBinary(
        ContextHandle context,
        uint num_devices,
        Ref<DeviceIdHandle> device_list,
        Ref<nuint> lengths,
        Ref2D<byte> binaries,
        Ref<int> binary_status,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithBuiltInKernels")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBuiltInKernels")]
    ProgramHandle CreateProgramWithBuiltInKernels(
        ContextHandle context,
        uint num_devices,
        DeviceIdHandle* device_list,
        sbyte* kernel_names,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithBuiltInKernels")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithBuiltInKernels")]
    ProgramHandle CreateProgramWithBuiltInKernels(
        ContextHandle context,
        uint num_devices,
        Ref<DeviceIdHandle> device_list,
        Ref<sbyte> kernel_names,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithIL")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithIL")]
    ProgramHandle CreateProgramWithIL(
        ContextHandle context,
        void* il,
        nuint length,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithIL")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithIL")]
    ProgramHandle CreateProgramWithIL(
        ContextHandle context,
        Ref il,
        nuint length,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    ProgramHandle CreateProgramWithILKHR(
        ContextHandle context,
        void* il,
        nuint length,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    ProgramHandle CreateProgramWithILKHR(
        ContextHandle context,
        Ref il,
        nuint length,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithSource")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithSource")]
    ProgramHandle CreateProgramWithSource(
        ContextHandle context,
        uint count,
        sbyte** strings,
        nuint* lengths,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithSource")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithSource")]
    ProgramHandle CreateProgramWithSource(
        ContextHandle context,
        uint count,
        Ref2D<sbyte> strings,
        Ref<nuint> lengths,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSampler")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSampler")]
    SamplerHandle CreateSampler(
        ContextHandle context,
        uint normalized_coords,
        uint addressing_mode,
        uint filter_mode,
        int* errcode_ret
    );

    [NativeName("clCreateSampler")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSampler")]
    SamplerHandle CreateSampler(
        ContextHandle context,
        MaybeBool<uint> normalized_coords,
        uint addressing_mode,
        uint filter_mode,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSamplerWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSamplerWithProperties")]
    SamplerHandle CreateSamplerWithProperties(
        ContextHandle context,
        ulong* sampler_properties,
        int* errcode_ret
    );

    [NativeName("clCreateSamplerWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSamplerWithProperties")]
    SamplerHandle CreateSamplerWithProperties(
        ContextHandle context,
        Ref<ulong> sampler_properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    SemaphoreHandleKHR CreateSemaphoreWithPropertiesKHR(
        ContextHandle context,
        ulong* sema_props,
        int* errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    SemaphoreHandleKHR CreateSemaphoreWithPropertiesKHR(
        ContextHandle context,
        Ref<ulong> sema_props,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSubBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSubBuffer")]
    MemHandle CreateSubBuffer(
        MemHandle buffer,
        ulong flags,
        uint buffer_create_type,
        void* buffer_create_info,
        int* errcode_ret
    );

    [NativeName("clCreateSubBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSubBuffer")]
    MemHandle CreateSubBuffer(
        MemHandle buffer,
        ulong flags,
        uint buffer_create_type,
        Ref buffer_create_info,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSubDevices")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevices")]
    int CreateSubDevices(
        DeviceIdHandle in_device,
        nint* properties,
        uint num_devices,
        DeviceIdHandle* out_devices,
        uint* num_devices_ret
    );

    [NativeName("clCreateSubDevices")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevices")]
    int CreateSubDevices(
        DeviceIdHandle in_device,
        Ref<nint> properties,
        uint num_devices,
        Ref<DeviceIdHandle> out_devices,
        Ref<uint> num_devices_ret
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        DeviceIdHandle in_device,
        ulong* properties,
        uint num_entries,
        DeviceIdHandle* out_devices,
        uint* num_devices
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        DeviceIdHandle in_device,
        Ref<ulong> properties,
        uint num_entries,
        Ref<DeviceIdHandle> out_devices,
        Ref<uint> num_devices
    );

    [NativeName("clCreateUserEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateUserEvent")]
    EventHandle CreateUserEvent(ContextHandle context, int* errcode_ret);

    [NativeName("clCreateUserEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateUserEvent")]
    EventHandle CreateUserEvent(ContextHandle context, Ref<int> errcode_ret);

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    void* DeviceMemAllocINTEL(
        ContextHandle context,
        DeviceIdHandle device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    Ptr DeviceMemAllocINTEL(
        ContextHandle context,
        DeviceIdHandle device,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        MemHandle* mem_objects,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        Ref<MemHandle> mem_objects,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        CommandQueueHandle command_queue,
        uint num_objects,
        MemHandle* mem_objects,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        CommandQueueHandle command_queue,
        uint num_objects,
        Ref<MemHandle> mem_objects,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueBarrier")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueBarrier")]
    int EnqueueBarrier(CommandQueueHandle command_queue);

    [NativeName("clEnqueueBarrierWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueBarrierWithWaitList")]
    int EnqueueBarrierWithWaitList(
        CommandQueueHandle command_queue,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueBarrierWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueBarrierWithWaitList")]
    int EnqueueBarrierWithWaitList(
        CommandQueueHandle command_queue,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueCopyBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBuffer")]
    int EnqueueCopyBuffer(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueCopyBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBuffer")]
    int EnqueueCopyBuffer(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueCopyBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferRect")]
    int EnqueueCopyBufferRect(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_buffer,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueCopyBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferRect")]
    int EnqueueCopyBufferRect(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueCopyBufferToImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferToImage")]
    int EnqueueCopyBufferToImage(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_image,
        nuint src_offset,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueCopyBufferToImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyBufferToImage")]
    int EnqueueCopyBufferToImage(
        CommandQueueHandle command_queue,
        MemHandle src_buffer,
        MemHandle dst_image,
        nuint src_offset,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueCopyImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImage")]
    int EnqueueCopyImage(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_image,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueCopyImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImage")]
    int EnqueueCopyImage(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_image,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueCopyImageToBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImageToBuffer")]
    int EnqueueCopyImageToBuffer(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_buffer,
        nuint* src_origin,
        nuint* region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueCopyImageToBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueCopyImageToBuffer")]
    int EnqueueCopyImageToBuffer(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueFillBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueFillBuffer")]
    int EnqueueFillBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        void* pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueFillBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueFillBuffer")]
    int EnqueueFillBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        Ref pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueFillImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueFillImage")]
    int EnqueueFillImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        void* fill_color,
        nuint* origin,
        nuint* region,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueFillImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueFillImage")]
    int EnqueueFillImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        Ref fill_color,
        Ref<nuint> origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_image,
        uint mipmap_filter_mode,
        nuint* array_region,
        nuint* mip_region,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        CommandQueueHandle command_queue,
        MemHandle src_image,
        MemHandle dst_image,
        uint mipmap_filter_mode,
        Ref<nuint> array_region,
        Ref<nuint> mip_region,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMapBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMapBuffer")]
    void* EnqueueMapBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        uint blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event,
        int* errcode_ret
    );

    [NativeName("clEnqueueMapBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMapBuffer")]
    Ptr EnqueueMapBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event,
        Ref<int> errcode_ret
    );

    [NativeName("clEnqueueMapImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMapImage")]
    void* EnqueueMapImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        uint blocking_map,
        ulong map_flags,
        nuint* origin,
        nuint* region,
        nuint* image_row_pitch,
        nuint* image_slice_pitch,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event,
        int* errcode_ret
    );

    [NativeName("clEnqueueMapImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMapImage")]
    Ptr EnqueueMapImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        Ref<nuint> origin,
        Ref<nuint> region,
        Ref<nuint> image_row_pitch,
        Ref<nuint> image_slice_pitch,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event,
        Ref<int> errcode_ret
    );

    [NativeName("clEnqueueMarker")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMarker")]
    int EnqueueMarker(CommandQueueHandle command_queue, EventHandle* @event);

    [NativeName("clEnqueueMarker")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMarker")]
    int EnqueueMarker(CommandQueueHandle command_queue, Ref<EventHandle> @event);

    [NativeName("clEnqueueMarkerWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMarkerWithWaitList")]
    int EnqueueMarkerWithWaitList(
        CommandQueueHandle command_queue,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMarkerWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMarkerWithWaitList")]
    int EnqueueMarkerWithWaitList(
        CommandQueueHandle command_queue,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        CommandQueueHandle command_queue,
        void* ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        CommandQueueHandle command_queue,
        Ref ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        CommandQueueHandle command_queue,
        uint blocking,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        CommandQueueHandle command_queue,
        MaybeBool<uint> blocking,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        CommandQueueHandle command_queue,
        void* dst_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        CommandQueueHandle command_queue,
        Ref dst_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        CommandQueueHandle command_queue,
        void* dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        CommandQueueHandle command_queue,
        Ref dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        CommandQueueHandle command_queue,
        void* ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        CommandQueueHandle command_queue,
        Ref ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        MemHandle* mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        Ref<MemHandle> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueMigrateMemObjects")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjects")]
    int EnqueueMigrateMemObjects(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        MemHandle* mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueMigrateMemObjects")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjects")]
    int EnqueueMigrateMemObjects(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        Ref<MemHandle> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueNativeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueNativeKernel")]
    int EnqueueNativeKernel(
        CommandQueueHandle command_queue,
        EnqueueNativeKernelUserFunc user_func,
        void* args,
        nuint cb_args,
        uint num_mem_objects,
        MemHandle* mem_list,
        void** args_mem_loc,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueNativeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueNativeKernel")]
    int EnqueueNativeKernel(
        CommandQueueHandle command_queue,
        EnqueueNativeKernelUserFunc user_func,
        Ref args,
        nuint cb_args,
        uint num_mem_objects,
        Ref<MemHandle> mem_list,
        Ref2D args_mem_loc,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueNDRangeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueNDRangeKernel")]
    int EnqueueNDRangeKernel(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* local_work_size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueNDRangeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueNDRangeKernel")]
    int EnqueueNDRangeKernel(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> local_work_size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReadBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadBuffer")]
    int EnqueueReadBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        uint blocking_read,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReadBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadBuffer")]
    int EnqueueReadBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        MaybeBool<uint> blocking_read,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReadBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadBufferRect")]
    int EnqueueReadBufferRect(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        uint blocking_read,
        nuint* buffer_origin,
        nuint* host_origin,
        nuint* region,
        nuint buffer_row_pitch,
        nuint buffer_slice_pitch,
        nuint host_row_pitch,
        nuint host_slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReadBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadBufferRect")]
    int EnqueueReadBufferRect(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        MaybeBool<uint> blocking_read,
        Ref<nuint> buffer_origin,
        Ref<nuint> host_origin,
        Ref<nuint> region,
        nuint buffer_row_pitch,
        nuint buffer_slice_pitch,
        nuint host_row_pitch,
        nuint host_slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        CommandQueueHandle command_queue,
        ProgramHandle program,
        sbyte* pipe_symbol,
        uint blocking_read,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        CommandQueueHandle command_queue,
        ProgramHandle program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_read,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReadImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadImage")]
    int EnqueueReadImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        uint blocking_read,
        nuint* origin,
        nuint* region,
        nuint row_pitch,
        nuint slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReadImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadImage")]
    int EnqueueReadImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        MaybeBool<uint> blocking_read,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint row_pitch,
        nuint slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        MemHandle* mem_objects,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        CommandQueueHandle command_queue,
        uint num_mem_objects,
        Ref<MemHandle> mem_objects,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        CommandQueueHandle command_queue,
        uint num_objects,
        MemHandle* mem_objects,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        CommandQueueHandle command_queue,
        uint num_objects,
        Ref<MemHandle> mem_objects,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        CommandQueueHandle command_queue,
        uint num_sema_objects,
        SemaphoreHandleKHR* sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        CommandQueueHandle command_queue,
        uint num_sema_objects,
        Ref<SemaphoreHandleKHR> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        EnqueueSvmFreePfnFreeFunc pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        EnqueueSvmFreePfnFreeFunc pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        EnqueueSvmFreeArmPfnFreeFunc pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        EnqueueSvmFreeArmPfnFreeFunc pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        CommandQueueHandle command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        CommandQueueHandle command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        CommandQueueHandle command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        CommandQueueHandle command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        CommandQueueHandle command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        CommandQueueHandle command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        CommandQueueHandle command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        CommandQueueHandle command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        CommandQueueHandle command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        CommandQueueHandle command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        CommandQueueHandle command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        CommandQueueHandle command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        nuint* sizes,
        ulong flags,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        CommandQueueHandle command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        Ref<nuint> sizes,
        ulong flags,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        CommandQueueHandle command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        CommandQueueHandle command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        CommandQueueHandle command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        CommandQueueHandle command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueTask")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueTask")]
    int EnqueueTask(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueTask")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueTask")]
    int EnqueueTask(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueUnmapMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueUnmapMemObject")]
    int EnqueueUnmapMemObject(
        CommandQueueHandle command_queue,
        MemHandle memobj,
        void* mapped_ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueUnmapMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueUnmapMemObject")]
    int EnqueueUnmapMemObject(
        CommandQueueHandle command_queue,
        MemHandle memobj,
        Ref mapped_ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueWaitForEvents")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitForEvents")]
    int EnqueueWaitForEvents(
        CommandQueueHandle command_queue,
        uint num_events,
        EventHandle* event_list
    );

    [NativeName("clEnqueueWaitForEvents")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitForEvents")]
    int EnqueueWaitForEvents(
        CommandQueueHandle command_queue,
        uint num_events,
        Ref<EventHandle> event_list
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        CommandQueueHandle command_queue,
        uint num_sema_objects,
        SemaphoreHandleKHR* sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        CommandQueueHandle command_queue,
        uint num_sema_objects,
        Ref<SemaphoreHandleKHR> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueWriteBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBuffer")]
    int EnqueueWriteBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        uint blocking_write,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueWriteBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBuffer")]
    int EnqueueWriteBuffer(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        MaybeBool<uint> blocking_write,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueWriteBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBufferRect")]
    int EnqueueWriteBufferRect(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        uint blocking_write,
        nuint* buffer_origin,
        nuint* host_origin,
        nuint* region,
        nuint buffer_row_pitch,
        nuint buffer_slice_pitch,
        nuint host_row_pitch,
        nuint host_slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueWriteBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteBufferRect")]
    int EnqueueWriteBufferRect(
        CommandQueueHandle command_queue,
        MemHandle buffer,
        MaybeBool<uint> blocking_write,
        Ref<nuint> buffer_origin,
        Ref<nuint> host_origin,
        Ref<nuint> region,
        nuint buffer_row_pitch,
        nuint buffer_slice_pitch,
        nuint host_row_pitch,
        nuint host_slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        CommandQueueHandle command_queue,
        ProgramHandle program,
        sbyte* pipe_symbol,
        uint blocking_write,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        CommandQueueHandle command_queue,
        ProgramHandle program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_write,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clEnqueueWriteImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteImage")]
    int EnqueueWriteImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        uint blocking_write,
        nuint* origin,
        nuint* region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        EventHandle* event_wait_list,
        EventHandle* @event
    );

    [NativeName("clEnqueueWriteImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteImage")]
    int EnqueueWriteImage(
        CommandQueueHandle command_queue,
        MemHandle image,
        MaybeBool<uint> blocking_write,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref<EventHandle> event_wait_list,
        Ref<EventHandle> @event
    );

    [NativeName("clFinish")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clFinish")]
    int Finish(CommandQueueHandle command_queue);

    [NativeName("clFlush")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clFlush")]
    int Flush(CommandQueueHandle command_queue);

    [NativeName("clGetAcceleratorInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
    int GetAcceleratorInfoINTEL(
        AcceleratorHandleINTEL accelerator,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetAcceleratorInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
    int GetAcceleratorInfoINTEL(
        AcceleratorHandleINTEL accelerator,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetCommandQueueInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetCommandQueueInfo")]
    int GetCommandQueueInfo(
        CommandQueueHandle command_queue,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetCommandQueueInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetCommandQueueInfo")]
    int GetCommandQueueInfo(
        CommandQueueHandle command_queue,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetContextInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetContextInfo")]
    int GetContextInfo(
        ContextHandle context,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetContextInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetContextInfo")]
    int GetContextInfo(
        ContextHandle context,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetDeviceAndHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceAndHostTimer")]
    int GetDeviceAndHostTimer(
        DeviceIdHandle device,
        ulong* device_timestamp,
        ulong* host_timestamp
    );

    [NativeName("clGetDeviceAndHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceAndHostTimer")]
    int GetDeviceAndHostTimer(
        DeviceIdHandle device,
        Ref<ulong> device_timestamp,
        Ref<ulong> host_timestamp
    );

    [NativeName("clGetDeviceIDs")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceIDs")]
    int GetDeviceIDs(
        PlatformIdHandle platform,
        ulong device_type,
        uint num_entries,
        DeviceIdHandle* devices,
        uint* num_devices
    );

    [NativeName("clGetDeviceIDs")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceIDs")]
    int GetDeviceIDs(
        PlatformIdHandle platform,
        ulong device_type,
        uint num_entries,
        Ref<DeviceIdHandle> devices,
        Ref<uint> num_devices
    );

    [NativeName("clGetDeviceImageInfoQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
    int GetDeviceImageInfoQCOM(
        DeviceIdHandle device,
        nuint image_width,
        nuint image_height,
        ImageFormat* image_format,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetDeviceImageInfoQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
    int GetDeviceImageInfoQCOM(
        DeviceIdHandle device,
        nuint image_width,
        nuint image_height,
        Ref<ImageFormat> image_format,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetDeviceInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceInfo")]
    int GetDeviceInfo(
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetDeviceInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceInfo")]
    int GetDeviceInfo(
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetEventInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetEventInfo")]
    int GetEventInfo(
        EventHandle @event,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetEventInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetEventInfo")]
    int GetEventInfo(
        EventHandle @event,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetEventProfilingInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetEventProfilingInfo")]
    int GetEventProfilingInfo(
        EventHandle @event,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetEventProfilingInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetEventProfilingInfo")]
    int GetEventProfilingInfo(
        EventHandle @event,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetExtensionFunctionAddress")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddress")]
    void* GetExtensionFunctionAddress(sbyte* func_name);

    [NativeName("clGetExtensionFunctionAddress")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddress")]
    Ptr GetExtensionFunctionAddress(Ref<sbyte> func_name);

    [NativeName("clGetExtensionFunctionAddressForPlatform")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
    void* GetExtensionFunctionAddressForPlatform(PlatformIdHandle platform, sbyte* func_name);

    [NativeName("clGetExtensionFunctionAddressForPlatform")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
    Ptr GetExtensionFunctionAddressForPlatform(PlatformIdHandle platform, Ref<sbyte> func_name);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(DeviceIdHandle device, ulong* host_timestamp);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(DeviceIdHandle device, Ref<ulong> host_timestamp);

    [NativeName("clGetICDLoaderInfoOCLICD")]
    [SupportedApiProfile("opencl", ["cl_loader_info"])]
    [NativeFunction("opencl", EntryPoint = "clGetICDLoaderInfoOCLICD")]
    int GetIcdLoaderInfoOclicd(
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetICDLoaderInfoOCLICD")]
    [SupportedApiProfile("opencl", ["cl_loader_info"])]
    [NativeFunction("opencl", EntryPoint = "clGetICDLoaderInfoOCLICD")]
    int GetIcdLoaderInfoOclicd(
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetImageInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetImageInfo")]
    int GetImageInfo(
        MemHandle image,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetImageInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetImageInfo")]
    int GetImageInfo(
        MemHandle image,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetImageRequirementsInfoEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_image_requirements_info"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clGetImageRequirementsInfoEXT")]
    int GetImageRequirementsInfoEXT(
        ContextHandle context,
        ulong* properties,
        ulong flags,
        ImageFormat* image_format,
        ImageDesc* image_desc,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetImageRequirementsInfoEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_image_requirements_info"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clGetImageRequirementsInfoEXT")]
    int GetImageRequirementsInfoEXT(
        ContextHandle context,
        Ref<ulong> properties,
        ulong flags,
        Ref<ImageFormat> image_format,
        Ref<ImageDesc> image_desc,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetKernelArgInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelArgInfo")]
    int GetKernelArgInfo(
        KernelHandle kernel,
        uint arg_indx,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetKernelArgInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelArgInfo")]
    int GetKernelArgInfo(
        KernelHandle kernel,
        uint arg_indx,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetKernelInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelInfo")]
    int GetKernelInfo(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetKernelInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelInfo")]
    int GetKernelInfo(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetKernelSubGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfo")]
    int GetKernelSubGroupInfo(
        KernelHandle kernel,
        DeviceIdHandle device,
        uint param_name,
        nuint input_value_size,
        void* input_value,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetKernelSubGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfo")]
    int GetKernelSubGroupInfo(
        KernelHandle kernel,
        DeviceIdHandle device,
        uint param_name,
        nuint input_value_size,
        Ref input_value,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetKernelSubGroupInfoKHR")]
    [Obsolete]
    [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfoKHR")]
    int GetKernelSubGroupInfoKHR(
        KernelHandle in_kernel,
        DeviceIdHandle in_device,
        uint param_name,
        nuint input_value_size,
        void* input_value,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetKernelSubGroupInfoKHR")]
    [Obsolete]
    [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSubGroupInfoKHR")]
    int GetKernelSubGroupInfoKHR(
        KernelHandle in_kernel,
        DeviceIdHandle in_device,
        uint param_name,
        nuint input_value_size,
        Ref input_value,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
    int GetKernelSuggestedLocalWorkSize(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
    int GetKernelSuggestedLocalWorkSize(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        CommandQueueHandle command_queue,
        KernelHandle kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> suggested_local_work_size
    );

    [NativeName("clGetKernelWorkGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelWorkGroupInfo")]
    int GetKernelWorkGroupInfo(
        KernelHandle kernel,
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetKernelWorkGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetKernelWorkGroupInfo")]
    int GetKernelWorkGroupInfo(
        KernelHandle kernel,
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetMemAllocInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
    int GetMemAllocInfoINTEL(
        ContextHandle context,
        void* ptr,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetMemAllocInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
    int GetMemAllocInfoINTEL(
        ContextHandle context,
        Ref ptr,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetMemObjectInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetMemObjectInfo")]
    int GetMemObjectInfo(
        MemHandle memobj,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetMemObjectInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetMemObjectInfo")]
    int GetMemObjectInfo(
        MemHandle memobj,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetPipeInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPipeInfo")]
    int GetPipeInfo(
        MemHandle pipe,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetPipeInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPipeInfo")]
    int GetPipeInfo(
        MemHandle pipe,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetPlatformIDs")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPlatformIDs")]
    int GetPlatformIDs(uint num_entries, PlatformIdHandle* platforms, uint* num_platforms);

    [NativeName("clGetPlatformIDs")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPlatformIDs")]
    int GetPlatformIDs(uint num_entries, Ref<PlatformIdHandle> platforms, Ref<uint> num_platforms);

    [NativeName("clGetPlatformInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPlatformInfo")]
    int GetPlatformInfo(
        PlatformIdHandle platform,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetPlatformInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetPlatformInfo")]
    int GetPlatformInfo(
        PlatformIdHandle platform,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetProgramBuildInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetProgramBuildInfo")]
    int GetProgramBuildInfo(
        ProgramHandle program,
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetProgramBuildInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetProgramBuildInfo")]
    int GetProgramBuildInfo(
        ProgramHandle program,
        DeviceIdHandle device,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetProgramInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetProgramInfo")]
    int GetProgramInfo(
        ProgramHandle program,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetProgramInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetProgramInfo")]
    int GetProgramInfo(
        ProgramHandle program,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetSamplerInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSamplerInfo")]
    int GetSamplerInfo(
        SamplerHandle sampler,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetSamplerInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSamplerInfo")]
    int GetSamplerInfo(
        SamplerHandle sampler,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetSemaphoreHandleForTypeKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore"],
        ImpliesSets = ["cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreHandleForTypeKHR")]
    int GetSemaphoreHandleForTypeKHR(
        SemaphoreHandleKHR sema_object,
        DeviceIdHandle device,
        uint handle_type,
        nuint handle_size,
        void* handle_ptr,
        nuint* handle_size_ret
    );

    [NativeName("clGetSemaphoreHandleForTypeKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore"],
        ImpliesSets = ["cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreHandleForTypeKHR")]
    int GetSemaphoreHandleForTypeKHR(
        SemaphoreHandleKHR sema_object,
        DeviceIdHandle device,
        uint handle_type,
        nuint handle_size,
        Ref handle_ptr,
        Ref<nuint> handle_size_ret
    );

    [NativeName("clGetSemaphoreInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
    int GetSemaphoreInfoKHR(
        SemaphoreHandleKHR sema_object,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetSemaphoreInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
    int GetSemaphoreInfoKHR(
        SemaphoreHandleKHR sema_object,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetSupportedImageFormats")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSupportedImageFormats")]
    int GetSupportedImageFormats(
        ContextHandle context,
        ulong flags,
        uint image_type,
        uint num_entries,
        ImageFormat* image_formats,
        uint* num_image_formats
    );

    [NativeName("clGetSupportedImageFormats")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetSupportedImageFormats")]
    int GetSupportedImageFormats(
        ContextHandle context,
        ulong flags,
        uint image_type,
        uint num_entries,
        Ref<ImageFormat> image_formats,
        Ref<uint> num_image_formats
    );

    [NativeName("clHostMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
    void* HostMemAllocINTEL(
        ContextHandle context,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clHostMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
    Ptr HostMemAllocINTEL(
        ContextHandle context,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    void* IcdGetFunctionAddressForPlatformKHR(PlatformIdHandle platform, sbyte* func_name);

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    Ptr IcdGetFunctionAddressForPlatformKHR(PlatformIdHandle platform, Ref<sbyte> func_name);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(uint num_entries, PlatformIdHandle* platforms, uint* num_platforms);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(
        uint num_entries,
        Ref<PlatformIdHandle> platforms,
        Ref<uint> num_platforms
    );

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(PlatformIdHandle platform, void* dispatch_data);

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(PlatformIdHandle platform, Ref dispatch_data);

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    MemHandle ImportMemoryARM(
        ContextHandle context,
        ulong flags,
        nint* properties,
        void* memory,
        nuint size,
        int* errcode_ret
    );

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    MemHandle ImportMemoryARM(
        ContextHandle context,
        ulong flags,
        Ref<nint> properties,
        Ref memory,
        nuint size,
        Ref<int> errcode_ret
    );

    [NativeName("clLinkProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clLinkProgram")]
    ProgramHandle LinkProgram(
        ContextHandle context,
        uint num_devices,
        DeviceIdHandle* device_list,
        sbyte* options,
        uint num_input_programs,
        ProgramHandle* input_programs,
        LinkProgramPfnNotify pfn_notify,
        void* user_data,
        int* errcode_ret
    );

    [NativeName("clLinkProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clLinkProgram")]
    ProgramHandle LinkProgram(
        ContextHandle context,
        uint num_devices,
        Ref<DeviceIdHandle> device_list,
        Ref<sbyte> options,
        uint num_input_programs,
        Ref<ProgramHandle> input_programs,
        LinkProgramPfnNotify pfn_notify,
        Ref user_data,
        Ref<int> errcode_ret
    );

    [NativeName("clLogMessagesToStderrAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToStderrAPPLE")]
    void LogMessagesToStderrAPPLE(sbyte* errstr, void* private_info, nuint cb, void* user_data);

    [NativeName("clLogMessagesToStderrAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToStderrAPPLE")]
    void LogMessagesToStderrAPPLE(Ref<sbyte> errstr, Ref private_info, nuint cb, Ref user_data);

    [NativeName("clLogMessagesToStdoutAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToStdoutAPPLE")]
    void LogMessagesToStdoutAPPLE(sbyte* errstr, void* private_info, nuint cb, void* user_data);

    [NativeName("clLogMessagesToStdoutAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToStdoutAPPLE")]
    void LogMessagesToStdoutAPPLE(Ref<sbyte> errstr, Ref private_info, nuint cb, Ref user_data);

    [NativeName("clLogMessagesToSystemLogAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToSystemLogAPPLE")]
    void LogMessagesToSystemLogAPPLE(sbyte* errstr, void* private_info, nuint cb, void* user_data);

    [NativeName("clLogMessagesToSystemLogAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_ContextLoggingFunctions"])]
    [NativeFunction("opencl", EntryPoint = "clLogMessagesToSystemLogAPPLE")]
    void LogMessagesToSystemLogAPPLE(Ref<sbyte> errstr, Ref private_info, nuint cb, Ref user_data);

    [NativeName("clMemBlockingFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
    int MemBlockingFreeINTEL(ContextHandle context, void* ptr);

    [NativeName("clMemBlockingFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
    int MemBlockingFreeINTEL(ContextHandle context, Ref ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(ContextHandle context, void* ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(ContextHandle context, Ref ptr);

    [NativeName("clReImportSemaphoreSyncFdKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore_sync_fd"],
        ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
    int ReImportSemaphoreSyncFdKHR(SemaphoreHandleKHR sema_object, ulong* reimport_props, int fd);

    [NativeName("clReImportSemaphoreSyncFdKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore_sync_fd"],
        ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
    int ReImportSemaphoreSyncFdKHR(
        SemaphoreHandleKHR sema_object,
        Ref<ulong> reimport_props,
        int fd
    );

    [NativeName("clReleaseAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
    int ReleaseAcceleratorINTEL(AcceleratorHandleINTEL accelerator);

    [NativeName("clReleaseCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseCommandQueue")]
    int ReleaseCommandQueue(CommandQueueHandle command_queue);

    [NativeName("clReleaseContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseContext")]
    int ReleaseContext(ContextHandle context);

    [NativeName("clReleaseDevice")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseDevice")]
    int ReleaseDevice(DeviceIdHandle device);

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
    int ReleaseDeviceEXT(DeviceIdHandle device);

    [NativeName("clReleaseEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseEvent")]
    int ReleaseEvent(EventHandle @event);

    [NativeName("clReleaseKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseKernel")]
    int ReleaseKernel(KernelHandle kernel);

    [NativeName("clReleaseMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseMemObject")]
    int ReleaseMemObject(MemHandle memobj);

    [NativeName("clReleaseProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseProgram")]
    int ReleaseProgram(ProgramHandle program);

    [NativeName("clReleaseSampler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clReleaseSampler")]
    int ReleaseSampler(SamplerHandle sampler);

    [NativeName("clReleaseSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
    int ReleaseSemaphoreKHR(SemaphoreHandleKHR sema_object);

    [NativeName("clRetainAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
    int RetainAcceleratorINTEL(AcceleratorHandleINTEL accelerator);

    [NativeName("clRetainCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainCommandQueue")]
    int RetainCommandQueue(CommandQueueHandle command_queue);

    [NativeName("clRetainContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainContext")]
    int RetainContext(ContextHandle context);

    [NativeName("clRetainDevice")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainDevice")]
    int RetainDevice(DeviceIdHandle device);

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
    int RetainDeviceEXT(DeviceIdHandle device);

    [NativeName("clRetainEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainEvent")]
    int RetainEvent(EventHandle @event);

    [NativeName("clRetainKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainKernel")]
    int RetainKernel(KernelHandle kernel);

    [NativeName("clRetainMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainMemObject")]
    int RetainMemObject(MemHandle memobj);

    [NativeName("clRetainProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainProgram")]
    int RetainProgram(ProgramHandle program);

    [NativeName("clRetainSampler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clRetainSampler")]
    int RetainSampler(SamplerHandle sampler);

    [NativeName("clRetainSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
    int RetainSemaphoreKHR(SemaphoreHandleKHR sema_object);

    [NativeName("clSetContentSizeBufferPoCL")]
    [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
    [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
    int SetContentSizeBufferPOCL(MemHandle buffer, MemHandle content_size_buffer);

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        ContextHandle context,
        SetContextDestructorCallbackPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        ContextHandle context,
        SetContextDestructorCallbackPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clSetDefaultDeviceCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
    int SetDefaultDeviceCommandQueue(
        ContextHandle context,
        DeviceIdHandle device,
        CommandQueueHandle command_queue
    );

    [NativeName("clSetEventCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetEventCallback")]
    int SetEventCallback(
        EventHandle @event,
        int command_exec_callback_type,
        SetEventCallbackPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clSetEventCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetEventCallback")]
    int SetEventCallback(
        EventHandle @event,
        int command_exec_callback_type,
        SetEventCallbackPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clSetKernelArg")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArg")]
    int SetKernelArg(KernelHandle kernel, uint arg_index, nuint arg_size, void* arg_value);

    [NativeName("clSetKernelArg")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArg")]
    int SetKernelArg(KernelHandle kernel, uint arg_index, nuint arg_size, Ref arg_value);

    [NativeName("clSetKernelArgDevicePointerEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_buffer_device_address"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
    int SetKernelArgDevicePointerEXT(KernelHandle kernel, uint arg_index, ulong arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(KernelHandle kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(KernelHandle kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(KernelHandle kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(KernelHandle kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(KernelHandle kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(KernelHandle kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
    int SetKernelExecInfo(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        void* param_value
    );

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
    int SetKernelExecInfo(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        void* param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        KernelHandle kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        MemHandle memobj,
        SetMemObjectDestructorApplePfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        MemHandle memobj,
        SetMemObjectDestructorApplePfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clSetMemObjectDestructorCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorCallback")]
    int SetMemObjectDestructorCallback(
        MemHandle memobj,
        SetMemObjectDestructorCallbackPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clSetMemObjectDestructorCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorCallback")]
    int SetMemObjectDestructorCallback(
        MemHandle memobj,
        SetMemObjectDestructorCallbackPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clSetPerfHintQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
    [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
    int SetPerfHintQCOM(ContextHandle context, uint perf_hint);

    [NativeName("clSetProgramReleaseCallback")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
    int SetProgramReleaseCallback(
        ProgramHandle program,
        SetProgramReleaseCallbackPfnNotify pfn_notify,
        void* user_data
    );

    [NativeName("clSetProgramReleaseCallback")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
    int SetProgramReleaseCallback(
        ProgramHandle program,
        SetProgramReleaseCallbackPfnNotify pfn_notify,
        Ref user_data
    );

    [NativeName("clSetProgramSpecializationConstant")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramSpecializationConstant")]
    int SetProgramSpecializationConstant(
        ProgramHandle program,
        uint spec_id,
        nuint spec_size,
        void* spec_value
    );

    [NativeName("clSetProgramSpecializationConstant")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramSpecializationConstant")]
    int SetProgramSpecializationConstant(
        ProgramHandle program,
        uint spec_id,
        nuint spec_size,
        Ref spec_value
    );

    [NativeName("clSetUserEventStatus")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetUserEventStatus")]
    int SetUserEventStatus(EventHandle @event, int execution_status);

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    void* SharedMemAllocINTEL(
        ContextHandle context,
        DeviceIdHandle device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    Ptr SharedMemAllocINTEL(
        ContextHandle context,
        DeviceIdHandle device,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
    Ptr SvmAlloc(ContextHandle context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    Ptr SvmAllocARM(ContextHandle context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    void* SvmAllocRawARM(ContextHandle context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
    void* SvmAllocRaw(ContextHandle context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(ContextHandle context, void* svm_pointer);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(ContextHandle context, Ref svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(ContextHandle context, void* svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(ContextHandle context, Ref svm_pointer);

    [NativeName("clTerminateContextKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
    [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
    int TerminateContextKHR(ContextHandle context);

    [NativeName("clUnloadCompiler")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clUnloadCompiler")]
    int UnloadCompiler();

    [NativeName("clUnloadPlatformCompiler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clUnloadPlatformCompiler")]
    int UnloadPlatformCompiler(PlatformIdHandle platform);

    [NativeName("clWaitForEvents")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clWaitForEvents")]
    int WaitForEvents(uint num_events, EventHandle* event_list);

    [NativeName("clWaitForEvents")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clWaitForEvents")]
    int WaitForEvents(uint num_events, Ref<EventHandle> event_list);
}
