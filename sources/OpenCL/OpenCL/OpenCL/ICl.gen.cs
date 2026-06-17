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
        static abstract _cl_context* CreateContEXT(
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
        static abstract Ptr<_cl_context> CreateContEXT(
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
            ClImageFormat* image_format,
            ClImageDesc* image_desc,
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
            Ref<ClImageFormat> image_format,
            Ref<ClImageDesc> image_desc,
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
            ClImageFormat* image_format,
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
            Ref<ClImageFormat> image_format,
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
            ClImageFormat* image_format,
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
            Ref<ClImageFormat> image_format,
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
            ClImageFormat* image_format,
            ClImageDesc* image_desc,
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
            Ref<ClImageFormat> image_format,
            Ref<ClImageDesc> image_desc,
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
            ClImageFormat* image_formats,
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
            Ref<ClImageFormat> image_formats,
            Ref<uint> num_image_formats
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
        static abstract int ReleaseContEXT(_cl_context* context);

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
        static abstract int ReleaseContEXT(Ref<_cl_context> context);

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
        static abstract int RetainContEXT(_cl_context* context);

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
        static abstract int RetainContEXT(Ref<_cl_context> context);

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
    _cl_context* CreateContEXT(
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
    Ptr<_cl_context> CreateContEXT(
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
        ClImageFormat* image_format,
        ClImageDesc* image_desc,
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
        Ref<ClImageFormat> image_format,
        Ref<ClImageDesc> image_desc,
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
        ClImageFormat* image_format,
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
        Ref<ClImageFormat> image_format,
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
        ClImageFormat* image_format,
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
        Ref<ClImageFormat> image_format,
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
        ClImageFormat* image_format,
        ClImageDesc* image_desc,
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
        Ref<ClImageFormat> image_format,
        Ref<ClImageDesc> image_desc,
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
        ClImageFormat* image_formats,
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
        Ref<ClImageFormat> image_formats,
        Ref<uint> num_image_formats
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
    int ReleaseContEXT(_cl_context* context);

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
    int ReleaseContEXT(Ref<_cl_context> context);

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
    int RetainContEXT(_cl_context* context);

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
    int RetainContEXT(Ref<_cl_context> context);

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
