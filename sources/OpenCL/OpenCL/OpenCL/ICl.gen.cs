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
            _cl_program* program,
            uint num_devices,
            _cl_device_id** device_list,
            sbyte* options,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
            Ref<_cl_program> program,
            uint num_devices,
            Ref2D<_cl_device_id> device_list,
            Ref<sbyte> options,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(_cl_event** event_list, nuint num_events_in_list);

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(
            Ref2D<_cl_event> event_list,
            nuint num_events_in_list
        );

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract _cl_kernel* CloneKernel(_cl_kernel* source_kernel, int* errcode_ret);

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract Ptr<_cl_kernel> CloneKernel(
            Ref<_cl_kernel> source_kernel,
            Ref<int> errcode_ret
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
            _cl_program* program,
            uint num_devices,
            _cl_device_id** device_list,
            sbyte* options,
            uint num_input_headers,
            _cl_program** input_headers,
            sbyte** header_include_names,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
            Ref<_cl_program> program,
            uint num_devices,
            Ref2D<_cl_device_id> device_list,
            Ref<sbyte> options,
            uint num_input_headers,
            Ref2D<_cl_program> input_headers,
            Ref2D<sbyte> header_include_names,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract _cl_accelerator_intel* CreateAcceleratorINTEL(
            _cl_context* context,
            uint accelerator_type,
            nuint descriptor_size,
            void* descriptor,
            int* errcode_ret
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract Ptr<_cl_accelerator_intel> CreateAcceleratorINTEL(
            Ref<_cl_context> context,
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
        static abstract _cl_mem* CreateBuffer(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreateBuffer(
            Ref<_cl_context> context,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract _cl_mem* CreateBufferWithProperties(
            _cl_context* context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract Ptr<_cl_mem> CreateBufferWithProperties(
            Ref<_cl_context> context,
            Ref<ulong> properties,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract _cl_mem* CreateBufferWithPropertiesINTEL(
            _cl_context* context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract Ptr<_cl_mem> CreateBufferWithPropertiesINTEL(
            Ref<_cl_context> context,
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
        static abstract _cl_command_queue* CreateCommandQueue(
            _cl_context* context,
            _cl_device_id* device,
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
        static abstract Ptr<_cl_command_queue> CreateCommandQueue(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
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
        static abstract _cl_command_queue* CreateCommandQueueWithProperties(
            _cl_context* context,
            _cl_device_id* device,
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
        static abstract Ptr<_cl_command_queue> CreateCommandQueueWithProperties(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
            Ref<ulong> properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract _cl_command_queue* CreateCommandQueueWithPropertiesKHR(
            _cl_context* context,
            _cl_device_id* device,
            ulong* properties,
            int* errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract Ptr<_cl_command_queue> CreateCommandQueueWithPropertiesKHR(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
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
        static abstract _cl_context* CreateContext(
            nint* properties,
            uint num_devices,
            _cl_device_id** devices,
            delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
        static abstract Ptr<_cl_context> CreateContext(
            Ref<nint> properties,
            uint num_devices,
            Ref2D<_cl_device_id> devices,
            delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
        static abstract _cl_context* CreateContextFromType(
            nint* properties,
            ulong device_type,
            delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
        static abstract Ptr<_cl_context> CreateContextFromType(
            Ref<nint> properties,
            ulong device_type,
            delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
        static abstract _cl_mem* CreateImage(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreateImage(
            Ref<_cl_context> context,
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
        static abstract _cl_mem* CreateImage2D(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreateImage2D(
            Ref<_cl_context> context,
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
        static abstract _cl_mem* CreateImage3D(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreateImage3D(
            Ref<_cl_context> context,
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
        static abstract _cl_mem* CreateImageWithProperties(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreateImageWithProperties(
            Ref<_cl_context> context,
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
        static abstract _cl_kernel* CreateKernel(
            _cl_program* program,
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
        static abstract Ptr<_cl_kernel> CreateKernel(
            Ref<_cl_program> program,
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
            _cl_program* program,
            uint num_kernels,
            _cl_kernel** kernels,
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
            Ref<_cl_program> program,
            uint num_kernels,
            Ref2D<_cl_kernel> kernels,
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
        static abstract _cl_mem* CreatePipe(
            _cl_context* context,
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
        static abstract Ptr<_cl_mem> CreatePipe(
            Ref<_cl_context> context,
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
        static abstract _cl_program* CreateProgramWithBinary(
            _cl_context* context,
            uint num_devices,
            _cl_device_id** device_list,
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
        static abstract Ptr<_cl_program> CreateProgramWithBinary(
            Ref<_cl_context> context,
            uint num_devices,
            Ref2D<_cl_device_id> device_list,
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
        static abstract _cl_program* CreateProgramWithBuiltInKernels(
            _cl_context* context,
            uint num_devices,
            _cl_device_id** device_list,
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
        static abstract Ptr<_cl_program> CreateProgramWithBuiltInKernels(
            Ref<_cl_context> context,
            uint num_devices,
            Ref2D<_cl_device_id> device_list,
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
        static abstract _cl_program* CreateProgramWithIL(
            _cl_context* context,
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
        static abstract Ptr<_cl_program> CreateProgramWithIL(
            Ref<_cl_context> context,
            Ref il,
            nuint length,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract _cl_program* CreateProgramWithILKHR(
            _cl_context* context,
            void* il,
            nuint length,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract Ptr<_cl_program> CreateProgramWithILKHR(
            Ref<_cl_context> context,
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
        static abstract _cl_program* CreateProgramWithSource(
            _cl_context* context,
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
        static abstract Ptr<_cl_program> CreateProgramWithSource(
            Ref<_cl_context> context,
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
        static abstract _cl_sampler* CreateSampler(
            _cl_context* context,
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
        static abstract Ptr<_cl_sampler> CreateSampler(
            Ref<_cl_context> context,
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
        static abstract _cl_sampler* CreateSamplerWithProperties(
            _cl_context* context,
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
        static abstract Ptr<_cl_sampler> CreateSamplerWithProperties(
            Ref<_cl_context> context,
            Ref<ulong> sampler_properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract _cl_semaphore_khr* CreateSemaphoreWithPropertiesKHR(
            _cl_context* context,
            ulong* sema_props,
            int* errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract Ptr<_cl_semaphore_khr> CreateSemaphoreWithPropertiesKHR(
            Ref<_cl_context> context,
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
        static abstract _cl_mem* CreateSubBuffer(
            _cl_mem* buffer,
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
        static abstract Ptr<_cl_mem> CreateSubBuffer(
            Ref<_cl_mem> buffer,
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
            _cl_device_id* in_device,
            nint* properties,
            uint num_devices,
            _cl_device_id** out_devices,
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
            Ref<_cl_device_id> in_device,
            Ref<nint> properties,
            uint num_devices,
            Ref2D<_cl_device_id> out_devices,
            Ref<uint> num_devices_ret
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            _cl_device_id* in_device,
            ulong* properties,
            uint num_entries,
            _cl_device_id** out_devices,
            uint* num_devices
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            Ref<_cl_device_id> in_device,
            Ref<ulong> properties,
            uint num_entries,
            Ref2D<_cl_device_id> out_devices,
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
        static abstract _cl_event* CreateUserEvent(_cl_context* context, int* errcode_ret);

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
        static abstract Ptr<_cl_event> CreateUserEvent(
            Ref<_cl_context> context,
            Ref<int> errcode_ret
        );

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract void* DeviceMemAllocINTEL(
            _cl_context* context,
            _cl_device_id* device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract Ptr DeviceMemAllocINTEL(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
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
            _cl_command_queue* command_queue,
            uint num_mem_objects,
            _cl_mem** mem_objects,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
        static abstract int EnqueueAcquireExternalMemObjectsKHR(
            Ref<_cl_command_queue> command_queue,
            uint num_mem_objects,
            Ref2D<_cl_mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            _cl_command_queue* command_queue,
            uint num_objects,
            _cl_mem** mem_objects,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            Ref<_cl_command_queue> command_queue,
            uint num_objects,
            Ref2D<_cl_mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
        static abstract int EnqueueBarrier(_cl_command_queue* command_queue);

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
        static abstract int EnqueueBarrier(Ref<_cl_command_queue> command_queue);

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
            _cl_command_queue* command_queue,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* src_buffer,
            _cl_mem* dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_buffer,
            Ref<_cl_mem> dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* src_buffer,
            _cl_mem* dst_buffer,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_buffer,
            Ref<_cl_mem> dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* src_buffer,
            _cl_mem* dst_image,
            nuint src_offset,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_buffer,
            Ref<_cl_mem> dst_image,
            nuint src_offset,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* src_image,
            _cl_mem* dst_image,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_image,
            Ref<_cl_mem> dst_image,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* src_image,
            _cl_mem* dst_buffer,
            nuint* src_origin,
            nuint* region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_image,
            Ref<_cl_mem> dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
            void* pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
            Ref pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* image,
            void* fill_color,
            nuint* origin,
            nuint* region,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> image,
            Ref fill_color,
            Ref<nuint> origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            _cl_command_queue* command_queue,
            _cl_mem* src_image,
            _cl_mem* dst_image,
            uint mipmap_filter_mode,
            nuint* array_region,
            nuint* mip_region,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> src_image,
            Ref<_cl_mem> dst_image,
            uint mipmap_filter_mode,
            Ref<nuint> array_region,
            Ref<nuint> mip_region,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
            uint blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event,
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event,
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
            _cl_command_queue* command_queue,
            _cl_mem* image,
            uint blocking_map,
            ulong map_flags,
            nuint* origin,
            nuint* region,
            nuint* image_row_pitch,
            nuint* image_slice_pitch,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event,
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> image,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            Ref<nuint> origin,
            Ref<nuint> region,
            Ref<nuint> image_row_pitch,
            Ref<nuint> image_slice_pitch,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event,
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
        static abstract int EnqueueMarker(_cl_command_queue* command_queue, _cl_event** @event);

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
            Ref<_cl_command_queue> command_queue,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            _cl_command_queue* command_queue,
            void* ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            _cl_command_queue* command_queue,
            uint blocking,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            Ref<_cl_command_queue> command_queue,
            MaybeBool<uint> blocking,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            _cl_command_queue* command_queue,
            void* dst_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref dst_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            _cl_command_queue* command_queue,
            void* dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            _cl_command_queue* command_queue,
            void* ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            _cl_command_queue* command_queue,
            uint num_mem_objects,
            _cl_mem** mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            Ref<_cl_command_queue> command_queue,
            uint num_mem_objects,
            Ref2D<_cl_mem> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint num_mem_objects,
            _cl_mem** mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            uint num_mem_objects,
            Ref2D<_cl_mem> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            delegate* unmanaged<void*, void> user_func,
            void* args,
            nuint cb_args,
            uint num_mem_objects,
            _cl_mem** mem_list,
            void** args_mem_loc,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            delegate* unmanaged<void*, void> user_func,
            Ref args,
            nuint cb_args,
            uint num_mem_objects,
            Ref2D<_cl_mem> mem_list,
            Ref2D args_mem_loc,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* local_work_size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_kernel> kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> local_work_size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
            uint blocking_read,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
            MaybeBool<uint> blocking_read,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
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
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
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
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            _cl_command_queue* command_queue,
            _cl_program* program,
            sbyte* pipe_symbol,
            uint blocking_read,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_program> program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_read,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* image,
            uint blocking_read,
            nuint* origin,
            nuint* region,
            nuint row_pitch,
            nuint slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> image,
            MaybeBool<uint> blocking_read,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint row_pitch,
            nuint slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            _cl_command_queue* command_queue,
            uint num_mem_objects,
            _cl_mem** mem_objects,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            Ref<_cl_command_queue> command_queue,
            uint num_mem_objects,
            Ref2D<_cl_mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            _cl_command_queue* command_queue,
            uint num_objects,
            _cl_mem** mem_objects,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            Ref<_cl_command_queue> command_queue,
            uint num_objects,
            Ref2D<_cl_mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            _cl_command_queue* command_queue,
            uint num_sema_objects,
            _cl_semaphore_khr** sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            Ref<_cl_command_queue> command_queue,
            uint num_sema_objects,
            Ref2D<_cl_semaphore_khr> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            _cl_command_queue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            Ref<_cl_command_queue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            _cl_command_queue* command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            Ref<_cl_command_queue> command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            _cl_command_queue* command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            Ref<_cl_command_queue> command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            _cl_command_queue* command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            Ref<_cl_command_queue> command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            _cl_command_queue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            nuint* sizes,
            ulong flags,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            Ref<_cl_command_queue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            Ref<nuint> sizes,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            _cl_command_queue* command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            Ref<_cl_command_queue> command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_kernel* kernel,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_kernel> kernel,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* memobj,
            void* mapped_ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> memobj,
            Ref mapped_ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            uint num_events,
            _cl_event** event_list
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
            Ref<_cl_command_queue> command_queue,
            uint num_events,
            Ref2D<_cl_event> event_list
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            _cl_command_queue* command_queue,
            uint num_sema_objects,
            _cl_semaphore_khr** sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            Ref<_cl_command_queue> command_queue,
            uint num_sema_objects,
            Ref2D<_cl_semaphore_khr> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
            uint blocking_write,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
            MaybeBool<uint> blocking_write,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* buffer,
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
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> buffer,
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
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            _cl_command_queue* command_queue,
            _cl_program* program,
            sbyte* pipe_symbol,
            uint blocking_write,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_program> program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_write,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
            _cl_command_queue* command_queue,
            _cl_mem* image,
            uint blocking_write,
            nuint* origin,
            nuint* region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            _cl_event** event_wait_list,
            _cl_event** @event
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
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_mem> image,
            MaybeBool<uint> blocking_write,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<_cl_event> event_wait_list,
            Ref2D<_cl_event> @event
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
        static abstract int Finish(_cl_command_queue* command_queue);

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
        static abstract int Finish(Ref<_cl_command_queue> command_queue);

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
        static abstract int Flush(_cl_command_queue* command_queue);

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
        static abstract int Flush(Ref<_cl_command_queue> command_queue);

        [NativeName("clGetAcceleratorInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
        static abstract int GetAcceleratorInfoINTEL(
            _cl_accelerator_intel* accelerator,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetAcceleratorInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
        static abstract int GetAcceleratorInfoINTEL(
            Ref<_cl_accelerator_intel> accelerator,
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
            _cl_command_queue* command_queue,
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
            Ref<_cl_command_queue> command_queue,
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
            _cl_context* context,
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
            Ref<_cl_context> context,
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
            _cl_device_id* device,
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
            Ref<_cl_device_id> device,
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
            _cl_platform_id* platform,
            ulong device_type,
            uint num_entries,
            _cl_device_id** devices,
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
            Ref<_cl_platform_id> platform,
            ulong device_type,
            uint num_entries,
            Ref2D<_cl_device_id> devices,
            Ref<uint> num_devices
        );

        [NativeName("clGetDeviceImageInfoQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
        static abstract int GetDeviceImageInfoQCOM(
            _cl_device_id* device,
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
            Ref<_cl_device_id> device,
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
            _cl_device_id* device,
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
            Ref<_cl_device_id> device,
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
            _cl_event* @event,
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
            Ref<_cl_event> @event,
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
            _cl_event* @event,
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
            Ref<_cl_event> @event,
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
            _cl_platform_id* platform,
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
            Ref<_cl_platform_id> platform,
            Ref<sbyte> func_name
        );

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(_cl_device_id* device, ulong* host_timestamp);

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(Ref<_cl_device_id> device, Ref<ulong> host_timestamp);

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
            _cl_mem* image,
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
            Ref<_cl_mem> image,
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
            _cl_context* context,
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
            Ref<_cl_context> context,
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
            _cl_kernel* kernel,
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
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
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
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
            _cl_device_id* device,
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
            Ref<_cl_kernel> kernel,
            Ref<_cl_device_id> device,
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
            _cl_kernel* in_kernel,
            _cl_device_id* in_device,
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
            Ref<_cl_kernel> in_kernel,
            Ref<_cl_device_id> in_device,
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
            _cl_command_queue* command_queue,
            _cl_kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSize")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
        static abstract int GetKernelSuggestedLocalWorkSize(
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_kernel> kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            _cl_command_queue* command_queue,
            _cl_kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            Ref<_cl_command_queue> command_queue,
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
            _cl_device_id* device,
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
            Ref<_cl_kernel> kernel,
            Ref<_cl_device_id> device,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetMemAllocInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
        static abstract int GetMemAllocInfoINTEL(
            _cl_context* context,
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
            Ref<_cl_context> context,
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
            _cl_mem* memobj,
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
            Ref<_cl_mem> memobj,
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
            _cl_mem* pipe,
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
            Ref<_cl_mem> pipe,
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
            _cl_platform_id** platforms,
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
            Ref2D<_cl_platform_id> platforms,
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
            _cl_platform_id* platform,
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
            Ref<_cl_platform_id> platform,
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
            _cl_program* program,
            _cl_device_id* device,
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
            Ref<_cl_program> program,
            Ref<_cl_device_id> device,
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
            _cl_program* program,
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
            Ref<_cl_program> program,
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
            _cl_sampler* sampler,
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
            Ref<_cl_sampler> sampler,
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
            _cl_semaphore_khr* sema_object,
            _cl_device_id* device,
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
            Ref<_cl_semaphore_khr> sema_object,
            Ref<_cl_device_id> device,
            uint handle_type,
            nuint handle_size,
            Ref handle_ptr,
            Ref<nuint> handle_size_ret
        );

        [NativeName("clGetSemaphoreInfoKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
        static abstract int GetSemaphoreInfoKHR(
            _cl_semaphore_khr* sema_object,
            uint param_name,
            nuint param_value_size,
            void* param_value,
            nuint* param_value_size_ret
        );

        [NativeName("clGetSemaphoreInfoKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
        static abstract int GetSemaphoreInfoKHR(
            Ref<_cl_semaphore_khr> sema_object,
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
            _cl_context* context,
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
            Ref<_cl_context> context,
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
            _cl_context* context,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clHostMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
        static abstract Ptr HostMemAllocINTEL(
            Ref<_cl_context> context,
            Ref<ulong> properties,
            nuint size,
            uint alignment,
            Ref<int> errcode_ret
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract void* IcdGetFunctionAddressForPlatformKHR(
            _cl_platform_id* platform,
            sbyte* func_name
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract Ptr IcdGetFunctionAddressForPlatformKHR(
            Ref<_cl_platform_id> platform,
            Ref<sbyte> func_name
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            _cl_platform_id** platforms,
            uint* num_platforms
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            Ref2D<_cl_platform_id> platforms,
            Ref<uint> num_platforms
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            _cl_platform_id* platform,
            void* dispatch_data
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            Ref<_cl_platform_id> platform,
            Ref dispatch_data
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract _cl_mem* ImportMemoryARM(
            _cl_context* context,
            ulong flags,
            nint* properties,
            void* memory,
            nuint size,
            int* errcode_ret
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract Ptr<_cl_mem> ImportMemoryARM(
            Ref<_cl_context> context,
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
        static abstract _cl_program* LinkProgram(
            _cl_context* context,
            uint num_devices,
            _cl_device_id** device_list,
            sbyte* options,
            uint num_input_programs,
            _cl_program** input_programs,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        static abstract Ptr<_cl_program> LinkProgram(
            Ref<_cl_context> context,
            uint num_devices,
            Ref2D<_cl_device_id> device_list,
            Ref<sbyte> options,
            uint num_input_programs,
            Ref2D<_cl_program> input_programs,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        static abstract int MemBlockingFreeINTEL(_cl_context* context, void* ptr);

        [NativeName("clMemBlockingFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
        static abstract int MemBlockingFreeINTEL(Ref<_cl_context> context, Ref ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(_cl_context* context, void* ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(Ref<_cl_context> context, Ref ptr);

        [NativeName("clReImportSemaphoreSyncFdKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_semaphore_sync_fd"],
            ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
        )]
        [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
        static abstract int ReImportSemaphoreSyncFdKHR(
            _cl_semaphore_khr* sema_object,
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
            Ref<_cl_semaphore_khr> sema_object,
            Ref<ulong> reimport_props,
            int fd
        );

        [NativeName("clReleaseAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
        static abstract int ReleaseAcceleratorINTEL(_cl_accelerator_intel* accelerator);

        [NativeName("clReleaseAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
        static abstract int ReleaseAcceleratorINTEL(Ref<_cl_accelerator_intel> accelerator);

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
        static abstract int ReleaseCommandQueue(_cl_command_queue* command_queue);

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
        static abstract int ReleaseCommandQueue(Ref<_cl_command_queue> command_queue);

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
        static abstract int ReleaseContext(_cl_context* context);

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
        static abstract int ReleaseContext(Ref<_cl_context> context);

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
        static abstract int ReleaseDevice(_cl_device_id* device);

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
        static abstract int ReleaseDevice(Ref<_cl_device_id> device);

        [NativeName("clReleaseDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
        static abstract int ReleaseDeviceEXT(_cl_device_id* device);

        [NativeName("clReleaseDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
        static abstract int ReleaseDeviceEXT(Ref<_cl_device_id> device);

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
        static abstract int ReleaseEvent(_cl_event* @event);

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
        static abstract int ReleaseEvent(Ref<_cl_event> @event);

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
        static abstract int ReleaseKernel(_cl_kernel* kernel);

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
        static abstract int ReleaseKernel(Ref<_cl_kernel> kernel);

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
        static abstract int ReleaseMemObject(_cl_mem* memobj);

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
        static abstract int ReleaseMemObject(Ref<_cl_mem> memobj);

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
        static abstract int ReleaseProgram(_cl_program* program);

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
        static abstract int ReleaseProgram(Ref<_cl_program> program);

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
        static abstract int ReleaseSampler(_cl_sampler* sampler);

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
        static abstract int ReleaseSampler(Ref<_cl_sampler> sampler);

        [NativeName("clReleaseSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
        static abstract int ReleaseSemaphoreKHR(_cl_semaphore_khr* sema_object);

        [NativeName("clReleaseSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
        static abstract int ReleaseSemaphoreKHR(Ref<_cl_semaphore_khr> sema_object);

        [NativeName("clRetainAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
        static abstract int RetainAcceleratorINTEL(_cl_accelerator_intel* accelerator);

        [NativeName("clRetainAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
        static abstract int RetainAcceleratorINTEL(Ref<_cl_accelerator_intel> accelerator);

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
        static abstract int RetainCommandQueue(_cl_command_queue* command_queue);

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
        static abstract int RetainCommandQueue(Ref<_cl_command_queue> command_queue);

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
        static abstract int RetainContext(_cl_context* context);

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
        static abstract int RetainContext(Ref<_cl_context> context);

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
        static abstract int RetainDevice(_cl_device_id* device);

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
        static abstract int RetainDevice(Ref<_cl_device_id> device);

        [NativeName("clRetainDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
        static abstract int RetainDeviceEXT(_cl_device_id* device);

        [NativeName("clRetainDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
        static abstract int RetainDeviceEXT(Ref<_cl_device_id> device);

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
        static abstract int RetainEvent(_cl_event* @event);

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
        static abstract int RetainEvent(Ref<_cl_event> @event);

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
        static abstract int RetainKernel(_cl_kernel* kernel);

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
        static abstract int RetainKernel(Ref<_cl_kernel> kernel);

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
        static abstract int RetainMemObject(_cl_mem* memobj);

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
        static abstract int RetainMemObject(Ref<_cl_mem> memobj);

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
        static abstract int RetainProgram(_cl_program* program);

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
        static abstract int RetainProgram(Ref<_cl_program> program);

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
        static abstract int RetainSampler(_cl_sampler* sampler);

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
        static abstract int RetainSampler(Ref<_cl_sampler> sampler);

        [NativeName("clRetainSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
        static abstract int RetainSemaphoreKHR(_cl_semaphore_khr* sema_object);

        [NativeName("clRetainSemaphoreKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
        static abstract int RetainSemaphoreKHR(Ref<_cl_semaphore_khr> sema_object);

        [NativeName("clSetContentSizeBufferPoCL")]
        [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
        [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
        static abstract int SetContentSizeBufferPOCL(_cl_mem* buffer, _cl_mem* content_size_buffer);

        [NativeName("clSetContentSizeBufferPoCL")]
        [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
        [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
        static abstract int SetContentSizeBufferPOCL(
            Ref<_cl_mem> buffer,
            Ref<_cl_mem> content_size_buffer
        );

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            _cl_context* context,
            delegate* unmanaged<_cl_context*, void*, void> pfn_notify,
            void* user_data
        );

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            Ref<_cl_context> context,
            delegate* unmanaged<_cl_context*, void*, void> pfn_notify,
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
            _cl_context* context,
            _cl_device_id* device,
            _cl_command_queue* command_queue
        );

        [NativeName("clSetDefaultDeviceCommandQueue")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
        static abstract int SetDefaultDeviceCommandQueue(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
            Ref<_cl_command_queue> command_queue
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
            _cl_event* @event,
            int command_exec_callback_type,
            delegate* unmanaged<_cl_event*, int, void*, void> pfn_notify,
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
            Ref<_cl_event> @event,
            int command_exec_callback_type,
            delegate* unmanaged<_cl_event*, int, void*, void> pfn_notify,
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
            _cl_kernel* kernel,
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
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
            uint arg_index,
            ulong arg_value
        );

        [NativeName("clSetKernelArgDevicePointerEXT")]
        [SupportedApiProfile(
            "opencl",
            ["cl_ext_buffer_device_address"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
        static abstract int SetKernelArgDevicePointerEXT(
            Ref<_cl_kernel> kernel,
            uint arg_index,
            ulong arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            _cl_kernel* kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
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
            Ref<_cl_kernel> kernel,
            uint arg_index,
            Ref arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            _cl_kernel* kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            Ref<_cl_kernel> kernel,
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
            _cl_kernel* kernel,
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
            Ref<_cl_kernel> kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            _cl_kernel* kernel,
            uint param_name,
            nuint param_value_size,
            void* param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            Ref<_cl_kernel> kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            _cl_mem* memobj,
            delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
            void* user_data
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            Ref<_cl_mem> memobj,
            delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
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
            _cl_mem* memobj,
            delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
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
            Ref<_cl_mem> memobj,
            delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clSetPerfHintQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
        [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
        static abstract int SetPerfHintQCOM(_cl_context* context, uint perf_hint);

        [NativeName("clSetPerfHintQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
        [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
        static abstract int SetPerfHintQCOM(Ref<_cl_context> context, uint perf_hint);

        [NativeName("clSetProgramReleaseCallback")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
        static abstract int SetProgramReleaseCallback(
            _cl_program* program,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
            Ref<_cl_program> program,
            delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
            _cl_program* program,
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
            Ref<_cl_program> program,
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
        static abstract int SetUserEventStatus(_cl_event* @event, int execution_status);

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
        static abstract int SetUserEventStatus(Ref<_cl_event> @event, int execution_status);

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract void* SharedMemAllocINTEL(
            _cl_context* context,
            _cl_device_id* device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract Ptr SharedMemAllocINTEL(
            Ref<_cl_context> context,
            Ref<_cl_device_id> device,
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
        static abstract void* SvmAlloc(
            _cl_context* context,
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
        static abstract Ptr SvmAlloc(
            Ref<_cl_context> context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract void* SvmAllocARM(
            _cl_context* context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract Ptr SvmAllocARM(
            Ref<_cl_context> context,
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
        static abstract void SvmFree(_cl_context* context, void* svm_pointer);

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
        static abstract void SvmFree(Ref<_cl_context> context, Ref svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(_cl_context* context, void* svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(Ref<_cl_context> context, Ref svm_pointer);

        [NativeName("clTerminateContextKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
        [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
        static abstract int TerminateContextKHR(_cl_context* context);

        [NativeName("clTerminateContextKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
        [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
        static abstract int TerminateContextKHR(Ref<_cl_context> context);

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
        static abstract int UnloadPlatformCompiler(_cl_platform_id* platform);

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
        static abstract int UnloadPlatformCompiler(Ref<_cl_platform_id> platform);

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
        static abstract int WaitForEvents(uint num_events, _cl_event** event_list);

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
        static abstract int WaitForEvents(uint num_events, Ref2D<_cl_event> event_list);
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
        _cl_program* program,
        uint num_devices,
        _cl_device_id** device_list,
        sbyte* options,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        Ref<_cl_program> program,
        uint num_devices,
        Ref2D<_cl_device_id> device_list,
        Ref<sbyte> options,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(_cl_event** event_list, nuint num_events_in_list);

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(Ref2D<_cl_event> event_list, nuint num_events_in_list);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    _cl_kernel* CloneKernel(_cl_kernel* source_kernel, int* errcode_ret);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    Ptr<_cl_kernel> CloneKernel(Ref<_cl_kernel> source_kernel, Ref<int> errcode_ret);

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
        _cl_program* program,
        uint num_devices,
        _cl_device_id** device_list,
        sbyte* options,
        uint num_input_headers,
        _cl_program** input_headers,
        sbyte** header_include_names,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        Ref<_cl_program> program,
        uint num_devices,
        Ref2D<_cl_device_id> device_list,
        Ref<sbyte> options,
        uint num_input_headers,
        Ref2D<_cl_program> input_headers,
        Ref2D<sbyte> header_include_names,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    _cl_accelerator_intel* CreateAcceleratorINTEL(
        _cl_context* context,
        uint accelerator_type,
        nuint descriptor_size,
        void* descriptor,
        int* errcode_ret
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    Ptr<_cl_accelerator_intel> CreateAcceleratorINTEL(
        Ref<_cl_context> context,
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
    _cl_mem* CreateBuffer(
        _cl_context* context,
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
    Ptr<_cl_mem> CreateBuffer(
        Ref<_cl_context> context,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    _cl_mem* CreateBufferWithProperties(
        _cl_context* context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    Ptr<_cl_mem> CreateBufferWithProperties(
        Ref<_cl_context> context,
        Ref<ulong> properties,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    _cl_mem* CreateBufferWithPropertiesINTEL(
        _cl_context* context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    Ptr<_cl_mem> CreateBufferWithPropertiesINTEL(
        Ref<_cl_context> context,
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
    _cl_command_queue* CreateCommandQueue(
        _cl_context* context,
        _cl_device_id* device,
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
    Ptr<_cl_command_queue> CreateCommandQueue(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
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
    _cl_command_queue* CreateCommandQueueWithProperties(
        _cl_context* context,
        _cl_device_id* device,
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
    Ptr<_cl_command_queue> CreateCommandQueueWithProperties(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
        Ref<ulong> properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    _cl_command_queue* CreateCommandQueueWithPropertiesKHR(
        _cl_context* context,
        _cl_device_id* device,
        ulong* properties,
        int* errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    Ptr<_cl_command_queue> CreateCommandQueueWithPropertiesKHR(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
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
    _cl_context* CreateContext(
        nint* properties,
        uint num_devices,
        _cl_device_id** devices,
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
    Ptr<_cl_context> CreateContext(
        Ref<nint> properties,
        uint num_devices,
        Ref2D<_cl_device_id> devices,
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
    _cl_context* CreateContextFromType(
        nint* properties,
        ulong device_type,
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
    Ptr<_cl_context> CreateContextFromType(
        Ref<nint> properties,
        ulong device_type,
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn_notify,
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
    _cl_mem* CreateImage(
        _cl_context* context,
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
    Ptr<_cl_mem> CreateImage(
        Ref<_cl_context> context,
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
    _cl_mem* CreateImage2D(
        _cl_context* context,
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
    Ptr<_cl_mem> CreateImage2D(
        Ref<_cl_context> context,
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
    _cl_mem* CreateImage3D(
        _cl_context* context,
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
    Ptr<_cl_mem> CreateImage3D(
        Ref<_cl_context> context,
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
    _cl_mem* CreateImageWithProperties(
        _cl_context* context,
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
    Ptr<_cl_mem> CreateImageWithProperties(
        Ref<_cl_context> context,
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
    _cl_kernel* CreateKernel(_cl_program* program, sbyte* kernel_name, int* errcode_ret);

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
    Ptr<_cl_kernel> CreateKernel(
        Ref<_cl_program> program,
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
    int CreateKernelsInProgram(
        _cl_program* program,
        uint num_kernels,
        _cl_kernel** kernels,
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
        Ref<_cl_program> program,
        uint num_kernels,
        Ref2D<_cl_kernel> kernels,
        Ref<uint> num_kernels_ret
    );

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
    _cl_mem* CreatePipe(
        _cl_context* context,
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
    Ptr<_cl_mem> CreatePipe(
        Ref<_cl_context> context,
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
    _cl_program* CreateProgramWithBinary(
        _cl_context* context,
        uint num_devices,
        _cl_device_id** device_list,
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
    Ptr<_cl_program> CreateProgramWithBinary(
        Ref<_cl_context> context,
        uint num_devices,
        Ref2D<_cl_device_id> device_list,
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
    _cl_program* CreateProgramWithBuiltInKernels(
        _cl_context* context,
        uint num_devices,
        _cl_device_id** device_list,
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
    Ptr<_cl_program> CreateProgramWithBuiltInKernels(
        Ref<_cl_context> context,
        uint num_devices,
        Ref2D<_cl_device_id> device_list,
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
    _cl_program* CreateProgramWithIL(
        _cl_context* context,
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
    Ptr<_cl_program> CreateProgramWithIL(
        Ref<_cl_context> context,
        Ref il,
        nuint length,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    _cl_program* CreateProgramWithILKHR(
        _cl_context* context,
        void* il,
        nuint length,
        int* errcode_ret
    );

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    Ptr<_cl_program> CreateProgramWithILKHR(
        Ref<_cl_context> context,
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
    _cl_program* CreateProgramWithSource(
        _cl_context* context,
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
    Ptr<_cl_program> CreateProgramWithSource(
        Ref<_cl_context> context,
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
    _cl_sampler* CreateSampler(
        _cl_context* context,
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
    Ptr<_cl_sampler> CreateSampler(
        Ref<_cl_context> context,
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
    _cl_sampler* CreateSamplerWithProperties(
        _cl_context* context,
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
    Ptr<_cl_sampler> CreateSamplerWithProperties(
        Ref<_cl_context> context,
        Ref<ulong> sampler_properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    _cl_semaphore_khr* CreateSemaphoreWithPropertiesKHR(
        _cl_context* context,
        ulong* sema_props,
        int* errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    Ptr<_cl_semaphore_khr> CreateSemaphoreWithPropertiesKHR(
        Ref<_cl_context> context,
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
    _cl_mem* CreateSubBuffer(
        _cl_mem* buffer,
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
    Ptr<_cl_mem> CreateSubBuffer(
        Ref<_cl_mem> buffer,
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
        _cl_device_id* in_device,
        nint* properties,
        uint num_devices,
        _cl_device_id** out_devices,
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
        Ref<_cl_device_id> in_device,
        Ref<nint> properties,
        uint num_devices,
        Ref2D<_cl_device_id> out_devices,
        Ref<uint> num_devices_ret
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        _cl_device_id* in_device,
        ulong* properties,
        uint num_entries,
        _cl_device_id** out_devices,
        uint* num_devices
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        Ref<_cl_device_id> in_device,
        Ref<ulong> properties,
        uint num_entries,
        Ref2D<_cl_device_id> out_devices,
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
    _cl_event* CreateUserEvent(_cl_context* context, int* errcode_ret);

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
    Ptr<_cl_event> CreateUserEvent(Ref<_cl_context> context, Ref<int> errcode_ret);

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    void* DeviceMemAllocINTEL(
        _cl_context* context,
        _cl_device_id* device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    Ptr DeviceMemAllocINTEL(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        _cl_command_queue* command_queue,
        uint num_mem_objects,
        _cl_mem** mem_objects,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        Ref<_cl_command_queue> command_queue,
        uint num_mem_objects,
        Ref2D<_cl_mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        _cl_command_queue* command_queue,
        uint num_objects,
        _cl_mem** mem_objects,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        Ref<_cl_command_queue> command_queue,
        uint num_objects,
        Ref2D<_cl_mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
    int EnqueueBarrier(_cl_command_queue* command_queue);

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
    int EnqueueBarrier(Ref<_cl_command_queue> command_queue);

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
        _cl_command_queue* command_queue,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* src_buffer,
        _cl_mem* dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_buffer,
        Ref<_cl_mem> dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* src_buffer,
        _cl_mem* dst_buffer,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_buffer,
        Ref<_cl_mem> dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* src_buffer,
        _cl_mem* dst_image,
        nuint src_offset,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_buffer,
        Ref<_cl_mem> dst_image,
        nuint src_offset,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* src_image,
        _cl_mem* dst_image,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_image,
        Ref<_cl_mem> dst_image,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* src_image,
        _cl_mem* dst_buffer,
        nuint* src_origin,
        nuint* region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_image,
        Ref<_cl_mem> dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
        void* pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
        Ref pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* image,
        void* fill_color,
        nuint* origin,
        nuint* region,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> image,
        Ref fill_color,
        Ref<nuint> origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        _cl_command_queue* command_queue,
        _cl_mem* src_image,
        _cl_mem* dst_image,
        uint mipmap_filter_mode,
        nuint* array_region,
        nuint* mip_region,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> src_image,
        Ref<_cl_mem> dst_image,
        uint mipmap_filter_mode,
        Ref<nuint> array_region,
        Ref<nuint> mip_region,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
        uint blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event,
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event,
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
        _cl_command_queue* command_queue,
        _cl_mem* image,
        uint blocking_map,
        ulong map_flags,
        nuint* origin,
        nuint* region,
        nuint* image_row_pitch,
        nuint* image_slice_pitch,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event,
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> image,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        Ref<nuint> origin,
        Ref<nuint> region,
        Ref<nuint> image_row_pitch,
        Ref<nuint> image_slice_pitch,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event,
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
    int EnqueueMarker(_cl_command_queue* command_queue, _cl_event** @event);

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
    int EnqueueMarker(Ref<_cl_command_queue> command_queue, Ref2D<_cl_event> @event);

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
        _cl_command_queue* command_queue,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        _cl_command_queue* command_queue,
        void* ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        _cl_command_queue* command_queue,
        uint blocking,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        Ref<_cl_command_queue> command_queue,
        MaybeBool<uint> blocking,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        _cl_command_queue* command_queue,
        void* dst_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref dst_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        _cl_command_queue* command_queue,
        void* dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        _cl_command_queue* command_queue,
        void* ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        _cl_command_queue* command_queue,
        uint num_mem_objects,
        _cl_mem** mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        Ref<_cl_command_queue> command_queue,
        uint num_mem_objects,
        Ref2D<_cl_mem> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        uint num_mem_objects,
        _cl_mem** mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        uint num_mem_objects,
        Ref2D<_cl_mem> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        delegate* unmanaged<void*, void> user_func,
        void* args,
        nuint cb_args,
        uint num_mem_objects,
        _cl_mem** mem_list,
        void** args_mem_loc,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        delegate* unmanaged<void*, void> user_func,
        Ref args,
        nuint cb_args,
        uint num_mem_objects,
        Ref2D<_cl_mem> mem_list,
        Ref2D args_mem_loc,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* local_work_size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_kernel> kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> local_work_size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
        uint blocking_read,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
        MaybeBool<uint> blocking_read,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
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
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
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
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        _cl_command_queue* command_queue,
        _cl_program* program,
        sbyte* pipe_symbol,
        uint blocking_read,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_program> program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_read,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* image,
        uint blocking_read,
        nuint* origin,
        nuint* region,
        nuint row_pitch,
        nuint slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> image,
        MaybeBool<uint> blocking_read,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint row_pitch,
        nuint slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        _cl_command_queue* command_queue,
        uint num_mem_objects,
        _cl_mem** mem_objects,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        Ref<_cl_command_queue> command_queue,
        uint num_mem_objects,
        Ref2D<_cl_mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        _cl_command_queue* command_queue,
        uint num_objects,
        _cl_mem** mem_objects,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        Ref<_cl_command_queue> command_queue,
        uint num_objects,
        Ref2D<_cl_mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        _cl_command_queue* command_queue,
        uint num_sema_objects,
        _cl_semaphore_khr** sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        Ref<_cl_command_queue> command_queue,
        uint num_sema_objects,
        Ref2D<_cl_semaphore_khr> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        _cl_command_queue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        Ref<_cl_command_queue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        _cl_command_queue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        Ref<_cl_command_queue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        delegate* unmanaged<_cl_command_queue*, uint, void**, void*, void> pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        _cl_command_queue* command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        Ref<_cl_command_queue> command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        _cl_command_queue* command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        Ref<_cl_command_queue> command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        _cl_command_queue* command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        Ref<_cl_command_queue> command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        _cl_command_queue* command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        Ref<_cl_command_queue> command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        _cl_command_queue* command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        Ref<_cl_command_queue> command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        _cl_command_queue* command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        Ref<_cl_command_queue> command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        _cl_command_queue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        nuint* sizes,
        ulong flags,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        Ref<_cl_command_queue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        Ref<nuint> sizes,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        _cl_command_queue* command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        Ref<_cl_command_queue> command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        _cl_command_queue* command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        Ref<_cl_command_queue> command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_kernel* kernel,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_kernel> kernel,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* memobj,
        void* mapped_ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> memobj,
        Ref mapped_ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        uint num_events,
        _cl_event** event_list
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
        Ref<_cl_command_queue> command_queue,
        uint num_events,
        Ref2D<_cl_event> event_list
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        _cl_command_queue* command_queue,
        uint num_sema_objects,
        _cl_semaphore_khr** sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        Ref<_cl_command_queue> command_queue,
        uint num_sema_objects,
        Ref2D<_cl_semaphore_khr> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
        uint blocking_write,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
        MaybeBool<uint> blocking_write,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* buffer,
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
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> buffer,
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
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        _cl_command_queue* command_queue,
        _cl_program* program,
        sbyte* pipe_symbol,
        uint blocking_write,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_program> program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_write,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
        _cl_command_queue* command_queue,
        _cl_mem* image,
        uint blocking_write,
        nuint* origin,
        nuint* region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        _cl_event** event_wait_list,
        _cl_event** @event
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
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_mem> image,
        MaybeBool<uint> blocking_write,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<_cl_event> event_wait_list,
        Ref2D<_cl_event> @event
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
    int Finish(_cl_command_queue* command_queue);

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
    int Finish(Ref<_cl_command_queue> command_queue);

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
    int Flush(_cl_command_queue* command_queue);

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
    int Flush(Ref<_cl_command_queue> command_queue);

    [NativeName("clGetAcceleratorInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
    int GetAcceleratorInfoINTEL(
        _cl_accelerator_intel* accelerator,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetAcceleratorInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clGetAcceleratorInfoINTEL")]
    int GetAcceleratorInfoINTEL(
        Ref<_cl_accelerator_intel> accelerator,
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
        _cl_command_queue* command_queue,
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
        Ref<_cl_command_queue> command_queue,
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
        _cl_context* context,
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
        Ref<_cl_context> context,
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
        _cl_device_id* device,
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
        Ref<_cl_device_id> device,
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
        _cl_platform_id* platform,
        ulong device_type,
        uint num_entries,
        _cl_device_id** devices,
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
        Ref<_cl_platform_id> platform,
        ulong device_type,
        uint num_entries,
        Ref2D<_cl_device_id> devices,
        Ref<uint> num_devices
    );

    [NativeName("clGetDeviceImageInfoQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
    int GetDeviceImageInfoQCOM(
        _cl_device_id* device,
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
        Ref<_cl_device_id> device,
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
        _cl_device_id* device,
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
        Ref<_cl_device_id> device,
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
        _cl_event* @event,
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
        Ref<_cl_event> @event,
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
        _cl_event* @event,
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
        Ref<_cl_event> @event,
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
    void* GetExtensionFunctionAddressForPlatform(_cl_platform_id* platform, sbyte* func_name);

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
    Ptr GetExtensionFunctionAddressForPlatform(Ref<_cl_platform_id> platform, Ref<sbyte> func_name);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(_cl_device_id* device, ulong* host_timestamp);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(Ref<_cl_device_id> device, Ref<ulong> host_timestamp);

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
        _cl_mem* image,
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
        Ref<_cl_mem> image,
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
        _cl_context* context,
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
        Ref<_cl_context> context,
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
        _cl_kernel* kernel,
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
        Ref<_cl_kernel> kernel,
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
        _cl_kernel* kernel,
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
        Ref<_cl_kernel> kernel,
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
        _cl_kernel* kernel,
        _cl_device_id* device,
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
        Ref<_cl_kernel> kernel,
        Ref<_cl_device_id> device,
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
        _cl_kernel* in_kernel,
        _cl_device_id* in_device,
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
        Ref<_cl_kernel> in_kernel,
        Ref<_cl_device_id> in_device,
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
        _cl_command_queue* command_queue,
        _cl_kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
    int GetKernelSuggestedLocalWorkSize(
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_kernel> kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        _cl_command_queue* command_queue,
        _cl_kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        Ref<_cl_command_queue> command_queue,
        Ref<_cl_kernel> kernel,
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
        _cl_kernel* kernel,
        _cl_device_id* device,
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
        Ref<_cl_kernel> kernel,
        Ref<_cl_device_id> device,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetMemAllocInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
    int GetMemAllocInfoINTEL(
        _cl_context* context,
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
        Ref<_cl_context> context,
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
        _cl_mem* memobj,
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
        Ref<_cl_mem> memobj,
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
        _cl_mem* pipe,
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
        Ref<_cl_mem> pipe,
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
    int GetPlatformIDs(uint num_entries, _cl_platform_id** platforms, uint* num_platforms);

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
    int GetPlatformIDs(uint num_entries, Ref2D<_cl_platform_id> platforms, Ref<uint> num_platforms);

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
        _cl_platform_id* platform,
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
        Ref<_cl_platform_id> platform,
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
        _cl_program* program,
        _cl_device_id* device,
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
        Ref<_cl_program> program,
        Ref<_cl_device_id> device,
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
        _cl_program* program,
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
        Ref<_cl_program> program,
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
        _cl_sampler* sampler,
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
        Ref<_cl_sampler> sampler,
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
        _cl_semaphore_khr* sema_object,
        _cl_device_id* device,
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
        Ref<_cl_semaphore_khr> sema_object,
        Ref<_cl_device_id> device,
        uint handle_type,
        nuint handle_size,
        Ref handle_ptr,
        Ref<nuint> handle_size_ret
    );

    [NativeName("clGetSemaphoreInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
    int GetSemaphoreInfoKHR(
        _cl_semaphore_khr* sema_object,
        uint param_name,
        nuint param_value_size,
        void* param_value,
        nuint* param_value_size_ret
    );

    [NativeName("clGetSemaphoreInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clGetSemaphoreInfoKHR")]
    int GetSemaphoreInfoKHR(
        Ref<_cl_semaphore_khr> sema_object,
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
        _cl_context* context,
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
        Ref<_cl_context> context,
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
        _cl_context* context,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clHostMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
    Ptr HostMemAllocINTEL(
        Ref<_cl_context> context,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    void* IcdGetFunctionAddressForPlatformKHR(_cl_platform_id* platform, sbyte* func_name);

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    Ptr IcdGetFunctionAddressForPlatformKHR(Ref<_cl_platform_id> platform, Ref<sbyte> func_name);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(uint num_entries, _cl_platform_id** platforms, uint* num_platforms);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(
        uint num_entries,
        Ref2D<_cl_platform_id> platforms,
        Ref<uint> num_platforms
    );

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(_cl_platform_id* platform, void* dispatch_data);

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(Ref<_cl_platform_id> platform, Ref dispatch_data);

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    _cl_mem* ImportMemoryARM(
        _cl_context* context,
        ulong flags,
        nint* properties,
        void* memory,
        nuint size,
        int* errcode_ret
    );

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    Ptr<_cl_mem> ImportMemoryARM(
        Ref<_cl_context> context,
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
    _cl_program* LinkProgram(
        _cl_context* context,
        uint num_devices,
        _cl_device_id** device_list,
        sbyte* options,
        uint num_input_programs,
        _cl_program** input_programs,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
    Ptr<_cl_program> LinkProgram(
        Ref<_cl_context> context,
        uint num_devices,
        Ref2D<_cl_device_id> device_list,
        Ref<sbyte> options,
        uint num_input_programs,
        Ref2D<_cl_program> input_programs,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
    int MemBlockingFreeINTEL(_cl_context* context, void* ptr);

    [NativeName("clMemBlockingFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
    int MemBlockingFreeINTEL(Ref<_cl_context> context, Ref ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(_cl_context* context, void* ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(Ref<_cl_context> context, Ref ptr);

    [NativeName("clReImportSemaphoreSyncFdKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore_sync_fd"],
        ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
    int ReImportSemaphoreSyncFdKHR(_cl_semaphore_khr* sema_object, ulong* reimport_props, int fd);

    [NativeName("clReImportSemaphoreSyncFdKHR")]
    [SupportedApiProfile(
        "opencl",
        ["cl_khr_external_semaphore_sync_fd"],
        ImpliesSets = ["cl_khr_external_semaphore", "cl_khr_semaphore", "CL_VERSION_1_2"]
    )]
    [NativeFunction("opencl", EntryPoint = "clReImportSemaphoreSyncFdKHR")]
    int ReImportSemaphoreSyncFdKHR(
        Ref<_cl_semaphore_khr> sema_object,
        Ref<ulong> reimport_props,
        int fd
    );

    [NativeName("clReleaseAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
    int ReleaseAcceleratorINTEL(_cl_accelerator_intel* accelerator);

    [NativeName("clReleaseAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseAcceleratorINTEL")]
    int ReleaseAcceleratorINTEL(Ref<_cl_accelerator_intel> accelerator);

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
    int ReleaseCommandQueue(_cl_command_queue* command_queue);

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
    int ReleaseCommandQueue(Ref<_cl_command_queue> command_queue);

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
    int ReleaseContext(_cl_context* context);

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
    int ReleaseContext(Ref<_cl_context> context);

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
    int ReleaseDevice(_cl_device_id* device);

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
    int ReleaseDevice(Ref<_cl_device_id> device);

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
    int ReleaseDeviceEXT(_cl_device_id* device);

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
    int ReleaseDeviceEXT(Ref<_cl_device_id> device);

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
    int ReleaseEvent(_cl_event* @event);

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
    int ReleaseEvent(Ref<_cl_event> @event);

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
    int ReleaseKernel(_cl_kernel* kernel);

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
    int ReleaseKernel(Ref<_cl_kernel> kernel);

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
    int ReleaseMemObject(_cl_mem* memobj);

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
    int ReleaseMemObject(Ref<_cl_mem> memobj);

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
    int ReleaseProgram(_cl_program* program);

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
    int ReleaseProgram(Ref<_cl_program> program);

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
    int ReleaseSampler(_cl_sampler* sampler);

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
    int ReleaseSampler(Ref<_cl_sampler> sampler);

    [NativeName("clReleaseSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
    int ReleaseSemaphoreKHR(_cl_semaphore_khr* sema_object);

    [NativeName("clReleaseSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseSemaphoreKHR")]
    int ReleaseSemaphoreKHR(Ref<_cl_semaphore_khr> sema_object);

    [NativeName("clRetainAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
    int RetainAcceleratorINTEL(_cl_accelerator_intel* accelerator);

    [NativeName("clRetainAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clRetainAcceleratorINTEL")]
    int RetainAcceleratorINTEL(Ref<_cl_accelerator_intel> accelerator);

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
    int RetainCommandQueue(_cl_command_queue* command_queue);

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
    int RetainCommandQueue(Ref<_cl_command_queue> command_queue);

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
    int RetainContext(_cl_context* context);

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
    int RetainContext(Ref<_cl_context> context);

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
    int RetainDevice(_cl_device_id* device);

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
    int RetainDevice(Ref<_cl_device_id> device);

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
    int RetainDeviceEXT(_cl_device_id* device);

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
    int RetainDeviceEXT(Ref<_cl_device_id> device);

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
    int RetainEvent(_cl_event* @event);

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
    int RetainEvent(Ref<_cl_event> @event);

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
    int RetainKernel(_cl_kernel* kernel);

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
    int RetainKernel(Ref<_cl_kernel> kernel);

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
    int RetainMemObject(_cl_mem* memobj);

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
    int RetainMemObject(Ref<_cl_mem> memobj);

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
    int RetainProgram(_cl_program* program);

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
    int RetainProgram(Ref<_cl_program> program);

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
    int RetainSampler(_cl_sampler* sampler);

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
    int RetainSampler(Ref<_cl_sampler> sampler);

    [NativeName("clRetainSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
    int RetainSemaphoreKHR(_cl_semaphore_khr* sema_object);

    [NativeName("clRetainSemaphoreKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clRetainSemaphoreKHR")]
    int RetainSemaphoreKHR(Ref<_cl_semaphore_khr> sema_object);

    [NativeName("clSetContentSizeBufferPoCL")]
    [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
    [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
    int SetContentSizeBufferPOCL(_cl_mem* buffer, _cl_mem* content_size_buffer);

    [NativeName("clSetContentSizeBufferPoCL")]
    [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
    [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
    int SetContentSizeBufferPOCL(Ref<_cl_mem> buffer, Ref<_cl_mem> content_size_buffer);

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        _cl_context* context,
        delegate* unmanaged<_cl_context*, void*, void> pfn_notify,
        void* user_data
    );

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        Ref<_cl_context> context,
        delegate* unmanaged<_cl_context*, void*, void> pfn_notify,
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
        _cl_context* context,
        _cl_device_id* device,
        _cl_command_queue* command_queue
    );

    [NativeName("clSetDefaultDeviceCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
    int SetDefaultDeviceCommandQueue(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
        Ref<_cl_command_queue> command_queue
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
        _cl_event* @event,
        int command_exec_callback_type,
        delegate* unmanaged<_cl_event*, int, void*, void> pfn_notify,
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
        Ref<_cl_event> @event,
        int command_exec_callback_type,
        delegate* unmanaged<_cl_event*, int, void*, void> pfn_notify,
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
    int SetKernelArg(_cl_kernel* kernel, uint arg_index, nuint arg_size, void* arg_value);

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
    int SetKernelArg(Ref<_cl_kernel> kernel, uint arg_index, nuint arg_size, Ref arg_value);

    [NativeName("clSetKernelArgDevicePointerEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_buffer_device_address"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
    int SetKernelArgDevicePointerEXT(_cl_kernel* kernel, uint arg_index, ulong arg_value);

    [NativeName("clSetKernelArgDevicePointerEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_buffer_device_address"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
    int SetKernelArgDevicePointerEXT(Ref<_cl_kernel> kernel, uint arg_index, ulong arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(_cl_kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(Ref<_cl_kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(_cl_kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(Ref<_cl_kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(_cl_kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(Ref<_cl_kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
    int SetKernelExecInfo(
        _cl_kernel* kernel,
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
        Ref<_cl_kernel> kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        _cl_kernel* kernel,
        uint param_name,
        nuint param_value_size,
        void* param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        Ref<_cl_kernel> kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        _cl_mem* memobj,
        delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
        void* user_data
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        Ref<_cl_mem> memobj,
        delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
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
        _cl_mem* memobj,
        delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
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
        Ref<_cl_mem> memobj,
        delegate* unmanaged<_cl_mem*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clSetPerfHintQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
    [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
    int SetPerfHintQCOM(_cl_context* context, uint perf_hint);

    [NativeName("clSetPerfHintQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
    [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
    int SetPerfHintQCOM(Ref<_cl_context> context, uint perf_hint);

    [NativeName("clSetProgramReleaseCallback")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
    int SetProgramReleaseCallback(
        _cl_program* program,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        Ref<_cl_program> program,
        delegate* unmanaged<_cl_program*, void*, void> pfn_notify,
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
        _cl_program* program,
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
        Ref<_cl_program> program,
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
    int SetUserEventStatus(_cl_event* @event, int execution_status);

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
    int SetUserEventStatus(Ref<_cl_event> @event, int execution_status);

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    void* SharedMemAllocINTEL(
        _cl_context* context,
        _cl_device_id* device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    Ptr SharedMemAllocINTEL(
        Ref<_cl_context> context,
        Ref<_cl_device_id> device,
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
    void* SvmAlloc(_cl_context* context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
    Ptr SvmAlloc(Ref<_cl_context> context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    void* SvmAllocARM(_cl_context* context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    Ptr SvmAllocARM(Ref<_cl_context> context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(_cl_context* context, void* svm_pointer);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(Ref<_cl_context> context, Ref svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(_cl_context* context, void* svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(Ref<_cl_context> context, Ref svm_pointer);

    [NativeName("clTerminateContextKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
    [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
    int TerminateContextKHR(_cl_context* context);

    [NativeName("clTerminateContextKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
    [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
    int TerminateContextKHR(Ref<_cl_context> context);

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
    int UnloadPlatformCompiler(_cl_platform_id* platform);

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
    int UnloadPlatformCompiler(Ref<_cl_platform_id> platform);

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
    int WaitForEvents(uint num_events, _cl_event** event_list);

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
    int WaitForEvents(uint num_events, Ref2D<_cl_event> event_list);
}
