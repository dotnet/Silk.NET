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
            Program* program,
            uint num_devices,
            DeviceId** device_list,
            sbyte* options,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
            Ref<Program> program,
            uint num_devices,
            Ref2D<DeviceId> device_list,
            Ref<sbyte> options,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(Event** event_list, nuint num_events_in_list);

        [NativeName("clCancelCommandsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
        [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
        static abstract int CancelCommandsIMG(Ref2D<Event> event_list, nuint num_events_in_list);

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract Kernel* CloneKernel(Kernel* source_kernel, int* errcode_ret);

        [NativeName("clCloneKernel")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
        static abstract Ptr<Kernel> CloneKernel(Ref<Kernel> source_kernel, Ref<int> errcode_ret);

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
            Program* program,
            uint num_devices,
            DeviceId** device_list,
            sbyte* options,
            uint num_input_headers,
            Program** input_headers,
            sbyte** header_include_names,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
            Ref<Program> program,
            uint num_devices,
            Ref2D<DeviceId> device_list,
            Ref<sbyte> options,
            uint num_input_headers,
            Ref2D<Program> input_headers,
            Ref2D<sbyte> header_include_names,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract _cl_accelerator_intel* CreateAcceleratorINTEL(
            Context* context,
            uint accelerator_type,
            nuint descriptor_size,
            void* descriptor,
            int* errcode_ret
        );

        [NativeName("clCreateAcceleratorINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
        [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
        static abstract Ptr<_cl_accelerator_intel> CreateAcceleratorINTEL(
            Ref<Context> context,
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
        static abstract Mem* CreateBuffer(
            Context* context,
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
        static abstract Ptr<Mem> CreateBuffer(
            Ref<Context> context,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract Mem* CreateBufferWithProperties(
            Context* context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithProperties")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
        static abstract Ptr<Mem> CreateBufferWithProperties(
            Ref<Context> context,
            Ref<ulong> properties,
            ulong flags,
            nuint size,
            Ref host_ptr,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract Mem* CreateBufferWithPropertiesINTEL(
            Context* context,
            ulong* properties,
            ulong flags,
            nuint size,
            void* host_ptr,
            int* errcode_ret
        );

        [NativeName("clCreateBufferWithPropertiesINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
        [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        static abstract Ptr<Mem> CreateBufferWithPropertiesINTEL(
            Ref<Context> context,
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
        static abstract CommandQueue* CreateCommandQueue(
            Context* context,
            DeviceId* device,
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
        static abstract Ptr<CommandQueue> CreateCommandQueue(
            Ref<Context> context,
            Ref<DeviceId> device,
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
        static abstract CommandQueue* CreateCommandQueueWithProperties(
            Context* context,
            DeviceId* device,
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
        static abstract Ptr<CommandQueue> CreateCommandQueueWithProperties(
            Ref<Context> context,
            Ref<DeviceId> device,
            Ref<ulong> properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract CommandQueue* CreateCommandQueueWithPropertiesKHR(
            Context* context,
            DeviceId* device,
            ulong* properties,
            int* errcode_ret
        );

        [NativeName("clCreateCommandQueueWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
        [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
        static abstract Ptr<CommandQueue> CreateCommandQueueWithPropertiesKHR(
            Ref<Context> context,
            Ref<DeviceId> device,
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
        static abstract Context* CreateContext(
            nint* properties,
            uint num_devices,
            DeviceId** devices,
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
        static abstract Ptr<Context> CreateContext(
            Ref<nint> properties,
            uint num_devices,
            Ref2D<DeviceId> devices,
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
        static abstract Context* CreateContextFromType(
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
        static abstract Ptr<Context> CreateContextFromType(
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
        static abstract Mem* CreateImage(
            Context* context,
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
        static abstract Ptr<Mem> CreateImage(
            Ref<Context> context,
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
        static abstract Mem* CreateImage2D(
            Context* context,
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
        static abstract Ptr<Mem> CreateImage2D(
            Ref<Context> context,
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
        static abstract Mem* CreateImage3D(
            Context* context,
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
        static abstract Ptr<Mem> CreateImage3D(
            Ref<Context> context,
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
        static abstract Mem* CreateImageWithProperties(
            Context* context,
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
        static abstract Ptr<Mem> CreateImageWithProperties(
            Ref<Context> context,
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
        static abstract Kernel* CreateKernel(
            Program* program,
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
        static abstract Ptr<Kernel> CreateKernel(
            Ref<Program> program,
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
            Program* program,
            uint num_kernels,
            Kernel** kernels,
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
            Ref<Program> program,
            uint num_kernels,
            Ref2D<Kernel> kernels,
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
        static abstract Mem* CreatePipe(
            Context* context,
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
        static abstract Ptr<Mem> CreatePipe(
            Ref<Context> context,
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
        static abstract Program* CreateProgramWithBinary(
            Context* context,
            uint num_devices,
            DeviceId** device_list,
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
        static abstract Ptr<Program> CreateProgramWithBinary(
            Ref<Context> context,
            uint num_devices,
            Ref2D<DeviceId> device_list,
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
        static abstract Program* CreateProgramWithBuiltInKernels(
            Context* context,
            uint num_devices,
            DeviceId** device_list,
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
        static abstract Ptr<Program> CreateProgramWithBuiltInKernels(
            Ref<Context> context,
            uint num_devices,
            Ref2D<DeviceId> device_list,
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
        static abstract Program* CreateProgramWithIL(
            Context* context,
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
        static abstract Ptr<Program> CreateProgramWithIL(
            Ref<Context> context,
            Ref il,
            nuint length,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract Program* CreateProgramWithILKHR(
            Context* context,
            void* il,
            nuint length,
            int* errcode_ret
        );

        [NativeName("clCreateProgramWithILKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
        [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
        static abstract Ptr<Program> CreateProgramWithILKHR(
            Ref<Context> context,
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
        static abstract Program* CreateProgramWithSource(
            Context* context,
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
        static abstract Ptr<Program> CreateProgramWithSource(
            Ref<Context> context,
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
        static abstract Sampler* CreateSampler(
            Context* context,
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
        static abstract Ptr<Sampler> CreateSampler(
            Ref<Context> context,
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
        static abstract Sampler* CreateSamplerWithProperties(
            Context* context,
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
        static abstract Ptr<Sampler> CreateSamplerWithProperties(
            Ref<Context> context,
            Ref<ulong> sampler_properties,
            Ref<int> errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract _cl_semaphore_khr* CreateSemaphoreWithPropertiesKHR(
            Context* context,
            ulong* sema_props,
            int* errcode_ret
        );

        [NativeName("clCreateSemaphoreWithPropertiesKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
        static abstract Ptr<_cl_semaphore_khr> CreateSemaphoreWithPropertiesKHR(
            Ref<Context> context,
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
        static abstract Mem* CreateSubBuffer(
            Mem* buffer,
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
        static abstract Ptr<Mem> CreateSubBuffer(
            Ref<Mem> buffer,
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
            DeviceId* in_device,
            nint* properties,
            uint num_devices,
            DeviceId** out_devices,
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
            Ref<DeviceId> in_device,
            Ref<nint> properties,
            uint num_devices,
            Ref2D<DeviceId> out_devices,
            Ref<uint> num_devices_ret
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            DeviceId* in_device,
            ulong* properties,
            uint num_entries,
            DeviceId** out_devices,
            uint* num_devices
        );

        [NativeName("clCreateSubDevicesEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
        static abstract int CreateSubDevicesEXT(
            Ref<DeviceId> in_device,
            Ref<ulong> properties,
            uint num_entries,
            Ref2D<DeviceId> out_devices,
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
        static abstract Event* CreateUserEvent(Context* context, int* errcode_ret);

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
        static abstract Ptr<Event> CreateUserEvent(Ref<Context> context, Ref<int> errcode_ret);

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract void* DeviceMemAllocINTEL(
            Context* context,
            DeviceId* device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clDeviceMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
        static abstract Ptr DeviceMemAllocINTEL(
            Ref<Context> context,
            Ref<DeviceId> device,
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
            CommandQueue* command_queue,
            uint num_mem_objects,
            Mem** mem_objects,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
        static abstract int EnqueueAcquireExternalMemObjectsKHR(
            Ref<CommandQueue> command_queue,
            uint num_mem_objects,
            Ref2D<Mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            CommandQueue* command_queue,
            uint num_objects,
            Mem** mem_objects,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
        static abstract int EnqueueAcquireGrallocObjectsIMG(
            Ref<CommandQueue> command_queue,
            uint num_objects,
            Ref2D<Mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
        static abstract int EnqueueBarrier(CommandQueue* command_queue);

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
        static abstract int EnqueueBarrier(Ref<CommandQueue> command_queue);

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
            CommandQueue* command_queue,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* src_buffer,
            Mem* dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_buffer,
            Ref<Mem> dst_buffer,
            nuint src_offset,
            nuint dst_offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* src_buffer,
            Mem* dst_buffer,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_buffer,
            Ref<Mem> dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            nuint src_row_pitch,
            nuint src_slice_pitch,
            nuint dst_row_pitch,
            nuint dst_slice_pitch,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* src_buffer,
            Mem* dst_image,
            nuint src_offset,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_buffer,
            Ref<Mem> dst_image,
            nuint src_offset,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* src_image,
            Mem* dst_image,
            nuint* src_origin,
            nuint* dst_origin,
            nuint* region,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_image,
            Ref<Mem> dst_image,
            Ref<nuint> src_origin,
            Ref<nuint> dst_origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* src_image,
            Mem* dst_buffer,
            nuint* src_origin,
            nuint* region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_image,
            Ref<Mem> dst_buffer,
            Ref<nuint> src_origin,
            Ref<nuint> region,
            nuint dst_offset,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
            void* pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
            Ref pattern,
            nuint pattern_size,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* image,
            void* fill_color,
            nuint* origin,
            nuint* region,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> image,
            Ref fill_color,
            Ref<nuint> origin,
            Ref<nuint> region,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            CommandQueue* command_queue,
            Mem* src_image,
            Mem* dst_image,
            uint mipmap_filter_mode,
            nuint* array_region,
            nuint* mip_region,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueGenerateMipmapIMG")]
        [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
        static abstract int EnqueueGenerateMipmapIMG(
            Ref<CommandQueue> command_queue,
            Ref<Mem> src_image,
            Ref<Mem> dst_image,
            uint mipmap_filter_mode,
            Ref<nuint> array_region,
            Ref<nuint> mip_region,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
            uint blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event,
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            nuint offset,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event,
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
            CommandQueue* command_queue,
            Mem* image,
            uint blocking_map,
            ulong map_flags,
            nuint* origin,
            nuint* region,
            nuint* image_row_pitch,
            nuint* image_slice_pitch,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event,
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> image,
            MaybeBool<uint> blocking_map,
            ulong map_flags,
            Ref<nuint> origin,
            Ref<nuint> region,
            Ref<nuint> image_row_pitch,
            Ref<nuint> image_slice_pitch,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event,
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
        static abstract int EnqueueMarker(CommandQueue* command_queue, Event** @event);

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
        static abstract int EnqueueMarker(Ref<CommandQueue> command_queue, Ref2D<Event> @event);

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
            CommandQueue* command_queue,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            CommandQueue* command_queue,
            void* ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMemAdviseINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
        static abstract int EnqueueMemAdviseINTEL(
            Ref<CommandQueue> command_queue,
            Ref ptr,
            nuint size,
            uint advice,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            CommandQueue* command_queue,
            uint blocking,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMemcpyINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
        static abstract int EnqueueMemcpyINTEL(
            Ref<CommandQueue> command_queue,
            MaybeBool<uint> blocking,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            CommandQueue* command_queue,
            void* dst_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMemFillINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
        static abstract int EnqueueMemFillINTEL(
            Ref<CommandQueue> command_queue,
            Ref dst_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            CommandQueue* command_queue,
            void* dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMemsetINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
        static abstract int EnqueueMemsetINTEL(
            Ref<CommandQueue> command_queue,
            Ref dst_ptr,
            int value,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            CommandQueue* command_queue,
            void* ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMigrateMemINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
        static abstract int EnqueueMigrateMemINTEL(
            Ref<CommandQueue> command_queue,
            Ref ptr,
            nuint size,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            CommandQueue* command_queue,
            uint num_mem_objects,
            Mem** mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueMigrateMemObjectEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
        static abstract int EnqueueMigrateMemObjectEXT(
            Ref<CommandQueue> command_queue,
            uint num_mem_objects,
            Ref2D<Mem> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            uint num_mem_objects,
            Mem** mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            uint num_mem_objects,
            Ref2D<Mem> mem_objects,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            delegate* unmanaged<void*, void> user_func,
            void* args,
            nuint cb_args,
            uint num_mem_objects,
            Mem** mem_list,
            void** args_mem_loc,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            delegate* unmanaged<void*, void> user_func,
            Ref args,
            nuint cb_args,
            uint num_mem_objects,
            Ref2D<Mem> mem_list,
            Ref2D args_mem_loc,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* local_work_size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Kernel> kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> local_work_size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
            uint blocking_read,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
            MaybeBool<uint> blocking_read,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
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
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
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
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            CommandQueue* command_queue,
            Program* program,
            sbyte* pipe_symbol,
            uint blocking_read,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueReadHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
        static abstract int EnqueueReadHostPipeINTEL(
            Ref<CommandQueue> command_queue,
            Ref<Program> program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_read,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* image,
            uint blocking_read,
            nuint* origin,
            nuint* region,
            nuint row_pitch,
            nuint slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> image,
            MaybeBool<uint> blocking_read,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint row_pitch,
            nuint slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            CommandQueue* command_queue,
            uint num_mem_objects,
            Mem** mem_objects,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
        [SupportedApiProfile(
            "opencl",
            ["cl_khr_external_memory"],
            ImpliesSets = ["CL_VERSION_3_0"]
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
        static abstract int EnqueueReleaseExternalMemObjectsKHR(
            Ref<CommandQueue> command_queue,
            uint num_mem_objects,
            Ref2D<Mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            CommandQueue* command_queue,
            uint num_objects,
            Mem** mem_objects,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
        [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
        static abstract int EnqueueReleaseGrallocObjectsIMG(
            Ref<CommandQueue> command_queue,
            uint num_objects,
            Ref2D<Mem> mem_objects,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            CommandQueue* command_queue,
            uint num_sema_objects,
            _cl_semaphore_khr** sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSignalSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
        static abstract int EnqueueSignalSemaphoresKHR(
            Ref<CommandQueue> command_queue,
            uint num_sema_objects,
            Ref2D<_cl_semaphore_khr> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            CommandQueue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
            void* user_data,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
        static abstract int EnqueueSvmFreeARM(
            Ref<CommandQueue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
            Ref user_data,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            CommandQueue* command_queue,
            uint blocking_map,
            ulong flags,
            void* svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMMapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
        static abstract int EnqueueSvmMapARM(
            Ref<CommandQueue> command_queue,
            MaybeBool<uint> blocking_map,
            ulong flags,
            Ref svm_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            CommandQueue* command_queue,
            uint blocking_copy,
            void* dst_ptr,
            void* src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMMemcpyARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
        static abstract int EnqueueSvmMemcpyARM(
            Ref<CommandQueue> command_queue,
            MaybeBool<uint> blocking_copy,
            Ref dst_ptr,
            Ref src_ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            CommandQueue* command_queue,
            void* svm_ptr,
            void* pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMMemFillARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
        static abstract int EnqueueSvmMemFillARM(
            Ref<CommandQueue> command_queue,
            Ref svm_ptr,
            Ref pattern,
            nuint pattern_size,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            CommandQueue* command_queue,
            uint num_svm_pointers,
            void** svm_pointers,
            nuint* sizes,
            ulong flags,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMMigrateMem")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
        static abstract int EnqueueSvmMigrateMem(
            Ref<CommandQueue> command_queue,
            uint num_svm_pointers,
            Ref2D svm_pointers,
            Ref<nuint> sizes,
            ulong flags,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            CommandQueue* command_queue,
            void* svm_ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueSVMUnmapARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
        static abstract int EnqueueSvmUnmapARM(
            Ref<CommandQueue> command_queue,
            Ref svm_ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Kernel* kernel,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Kernel> kernel,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* memobj,
            void* mapped_ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> memobj,
            Ref mapped_ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            uint num_events,
            Event** event_list
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
            Ref<CommandQueue> command_queue,
            uint num_events,
            Ref2D<Event> event_list
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            CommandQueue* command_queue,
            uint num_sema_objects,
            _cl_semaphore_khr** sema_objects,
            ulong* sema_payload_list,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueWaitSemaphoresKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
        static abstract int EnqueueWaitSemaphoresKHR(
            Ref<CommandQueue> command_queue,
            uint num_sema_objects,
            Ref2D<_cl_semaphore_khr> sema_objects,
            Ref<ulong> sema_payload_list,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
            uint blocking_write,
            nuint offset,
            nuint size,
            void* ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
            MaybeBool<uint> blocking_write,
            nuint offset,
            nuint size,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* buffer,
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
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> buffer,
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
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            CommandQueue* command_queue,
            Program* program,
            sbyte* pipe_symbol,
            uint blocking_write,
            void* ptr,
            nuint size,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
        );

        [NativeName("clEnqueueWriteHostPipeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
        [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
        static abstract int EnqueueWriteHostPipeINTEL(
            Ref<CommandQueue> command_queue,
            Ref<Program> program,
            Ref<sbyte> pipe_symbol,
            MaybeBool<uint> blocking_write,
            Ref ptr,
            nuint size,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
            CommandQueue* command_queue,
            Mem* image,
            uint blocking_write,
            nuint* origin,
            nuint* region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            void* ptr,
            uint num_events_in_wait_list,
            Event** event_wait_list,
            Event** @event
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
            Ref<CommandQueue> command_queue,
            Ref<Mem> image,
            MaybeBool<uint> blocking_write,
            Ref<nuint> origin,
            Ref<nuint> region,
            nuint input_row_pitch,
            nuint input_slice_pitch,
            Ref ptr,
            uint num_events_in_wait_list,
            Ref2D<Event> event_wait_list,
            Ref2D<Event> @event
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
        static abstract int Finish(CommandQueue* command_queue);

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
        static abstract int Finish(Ref<CommandQueue> command_queue);

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
        static abstract int Flush(CommandQueue* command_queue);

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
        static abstract int Flush(Ref<CommandQueue> command_queue);

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
            CommandQueue* command_queue,
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
            Ref<CommandQueue> command_queue,
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
            Context* context,
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
            Ref<Context> context,
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
            DeviceId* device,
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
            Ref<DeviceId> device,
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
            PlatformId* platform,
            ulong device_type,
            uint num_entries,
            DeviceId** devices,
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
            Ref<PlatformId> platform,
            ulong device_type,
            uint num_entries,
            Ref2D<DeviceId> devices,
            Ref<uint> num_devices
        );

        [NativeName("clGetDeviceImageInfoQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
        [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
        static abstract int GetDeviceImageInfoQCOM(
            DeviceId* device,
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
            Ref<DeviceId> device,
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
            DeviceId* device,
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
            Ref<DeviceId> device,
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
            Event* @event,
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
            Ref<Event> @event,
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
            Event* @event,
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
            Ref<Event> @event,
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
            PlatformId* platform,
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
            Ref<PlatformId> platform,
            Ref<sbyte> func_name
        );

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(DeviceId* device, ulong* host_timestamp);

        [NativeName("clGetHostTimer")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
        static abstract int GetHostTimer(Ref<DeviceId> device, Ref<ulong> host_timestamp);

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
            Mem* image,
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
            Ref<Mem> image,
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
            Context* context,
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
            Ref<Context> context,
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
            Kernel* kernel,
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
            Ref<Kernel> kernel,
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
            Kernel* kernel,
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
            Ref<Kernel> kernel,
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
            Kernel* kernel,
            DeviceId* device,
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
            Ref<Kernel> kernel,
            Ref<DeviceId> device,
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
            Kernel* in_kernel,
            DeviceId* in_device,
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
            Ref<Kernel> in_kernel,
            Ref<DeviceId> in_device,
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
            CommandQueue* command_queue,
            Kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSize")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
        static abstract int GetKernelSuggestedLocalWorkSize(
            Ref<CommandQueue> command_queue,
            Ref<Kernel> kernel,
            uint work_dim,
            Ref<nuint> global_work_offset,
            Ref<nuint> global_work_size,
            Ref<nuint> suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            CommandQueue* command_queue,
            Kernel* kernel,
            uint work_dim,
            nuint* global_work_offset,
            nuint* global_work_size,
            nuint* suggested_local_work_size
        );

        [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
        [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
        static abstract int GetKernelSuggestedLocalWorkSizeKHR(
            Ref<CommandQueue> command_queue,
            Ref<Kernel> kernel,
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
            Kernel* kernel,
            DeviceId* device,
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
            Ref<Kernel> kernel,
            Ref<DeviceId> device,
            uint param_name,
            nuint param_value_size,
            Ref param_value,
            Ref<nuint> param_value_size_ret
        );

        [NativeName("clGetMemAllocInfoINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
        static abstract int GetMemAllocInfoINTEL(
            Context* context,
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
            Ref<Context> context,
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
            Mem* memobj,
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
            Ref<Mem> memobj,
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
            Mem* pipe,
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
            Ref<Mem> pipe,
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
            PlatformId** platforms,
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
            Ref2D<PlatformId> platforms,
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
            PlatformId* platform,
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
            Ref<PlatformId> platform,
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
            Program* program,
            DeviceId* device,
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
            Ref<Program> program,
            Ref<DeviceId> device,
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
            Program* program,
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
            Ref<Program> program,
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
            Sampler* sampler,
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
            Ref<Sampler> sampler,
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
            DeviceId* device,
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
            Ref<DeviceId> device,
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
            Context* context,
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
            Ref<Context> context,
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
            Context* context,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clHostMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
        static abstract Ptr HostMemAllocINTEL(
            Ref<Context> context,
            Ref<ulong> properties,
            nuint size,
            uint alignment,
            Ref<int> errcode_ret
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract void* IcdGetFunctionAddressForPlatformKHR(
            PlatformId* platform,
            sbyte* func_name
        );

        [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
        static abstract Ptr IcdGetFunctionAddressForPlatformKHR(
            Ref<PlatformId> platform,
            Ref<sbyte> func_name
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            PlatformId** platforms,
            uint* num_platforms
        );

        [NativeName("clIcdGetPlatformIDsKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
        static abstract int IcdGetPlatformIDsKHR(
            uint num_entries,
            Ref2D<PlatformId> platforms,
            Ref<uint> num_platforms
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            PlatformId* platform,
            void* dispatch_data
        );

        [NativeName("clIcdSetPlatformDispatchDataKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_icd"])]
        [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
        static abstract int IcdSetPlatformDispatchDataKHR(
            Ref<PlatformId> platform,
            Ref dispatch_data
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract Mem* ImportMemoryARM(
            Context* context,
            ulong flags,
            nint* properties,
            void* memory,
            nuint size,
            int* errcode_ret
        );

        [NativeName("clImportMemoryARM")]
        [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
        [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
        static abstract Ptr<Mem> ImportMemoryARM(
            Ref<Context> context,
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
        static abstract Program* LinkProgram(
            Context* context,
            uint num_devices,
            DeviceId** device_list,
            sbyte* options,
            uint num_input_programs,
            Program** input_programs,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        static abstract Ptr<Program> LinkProgram(
            Ref<Context> context,
            uint num_devices,
            Ref2D<DeviceId> device_list,
            Ref<sbyte> options,
            uint num_input_programs,
            Ref2D<Program> input_programs,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        static abstract int MemBlockingFreeINTEL(Context* context, void* ptr);

        [NativeName("clMemBlockingFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
        static abstract int MemBlockingFreeINTEL(Ref<Context> context, Ref ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(Context* context, void* ptr);

        [NativeName("clMemFreeINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
        static abstract int MemFreeINTEL(Ref<Context> context, Ref ptr);

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
        static abstract int ReleaseCommandQueue(CommandQueue* command_queue);

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
        static abstract int ReleaseCommandQueue(Ref<CommandQueue> command_queue);

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
        static abstract int ReleaseContext(Context* context);

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
        static abstract int ReleaseContext(Ref<Context> context);

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
        static abstract int ReleaseDevice(DeviceId* device);

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
        static abstract int ReleaseDevice(Ref<DeviceId> device);

        [NativeName("clReleaseDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
        static abstract int ReleaseDeviceEXT(DeviceId* device);

        [NativeName("clReleaseDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
        static abstract int ReleaseDeviceEXT(Ref<DeviceId> device);

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
        static abstract int ReleaseEvent(Event* @event);

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
        static abstract int ReleaseEvent(Ref<Event> @event);

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
        static abstract int ReleaseKernel(Kernel* kernel);

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
        static abstract int ReleaseKernel(Ref<Kernel> kernel);

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
        static abstract int ReleaseMemObject(Mem* memobj);

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
        static abstract int ReleaseMemObject(Ref<Mem> memobj);

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
        static abstract int ReleaseProgram(Program* program);

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
        static abstract int ReleaseProgram(Ref<Program> program);

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
        static abstract int ReleaseSampler(Sampler* sampler);

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
        static abstract int ReleaseSampler(Ref<Sampler> sampler);

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
        static abstract int RetainCommandQueue(CommandQueue* command_queue);

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
        static abstract int RetainCommandQueue(Ref<CommandQueue> command_queue);

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
        static abstract int RetainContext(Context* context);

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
        static abstract int RetainContext(Ref<Context> context);

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
        static abstract int RetainDevice(DeviceId* device);

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
        static abstract int RetainDevice(Ref<DeviceId> device);

        [NativeName("clRetainDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
        static abstract int RetainDeviceEXT(DeviceId* device);

        [NativeName("clRetainDeviceEXT")]
        [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
        [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
        static abstract int RetainDeviceEXT(Ref<DeviceId> device);

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
        static abstract int RetainEvent(Event* @event);

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
        static abstract int RetainEvent(Ref<Event> @event);

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
        static abstract int RetainKernel(Kernel* kernel);

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
        static abstract int RetainKernel(Ref<Kernel> kernel);

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
        static abstract int RetainMemObject(Mem* memobj);

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
        static abstract int RetainMemObject(Ref<Mem> memobj);

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
        static abstract int RetainProgram(Program* program);

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
        static abstract int RetainProgram(Ref<Program> program);

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
        static abstract int RetainSampler(Sampler* sampler);

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
        static abstract int RetainSampler(Ref<Sampler> sampler);

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
        static abstract int SetContentSizeBufferPOCL(Mem* buffer, Mem* content_size_buffer);

        [NativeName("clSetContentSizeBufferPoCL")]
        [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
        [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
        static abstract int SetContentSizeBufferPOCL(Ref<Mem> buffer, Ref<Mem> content_size_buffer);

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            Context* context,
            delegate* unmanaged<Context*, void*, void> pfn_notify,
            void* user_data
        );

        [NativeName("clSetContextDestructorCallback")]
        [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
        [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
        static abstract int SetContextDestructorCallback(
            Ref<Context> context,
            delegate* unmanaged<Context*, void*, void> pfn_notify,
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
            Context* context,
            DeviceId* device,
            CommandQueue* command_queue
        );

        [NativeName("clSetDefaultDeviceCommandQueue")]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.1"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
        static abstract int SetDefaultDeviceCommandQueue(
            Ref<Context> context,
            Ref<DeviceId> device,
            Ref<CommandQueue> command_queue
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
            Event* @event,
            int command_exec_callback_type,
            delegate* unmanaged<Event*, int, void*, void> pfn_notify,
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
            Ref<Event> @event,
            int command_exec_callback_type,
            delegate* unmanaged<Event*, int, void*, void> pfn_notify,
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
            Kernel* kernel,
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
            Ref<Kernel> kernel,
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
            Kernel* kernel,
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
            Ref<Kernel> kernel,
            uint arg_index,
            ulong arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            Kernel* kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgMemPointerINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
        static abstract int SetKernelArgMemPointerINTEL(
            Ref<Kernel> kernel,
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
        static abstract int SetKernelArgSvmPointer(Kernel* kernel, uint arg_index, void* arg_value);

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
            Ref<Kernel> kernel,
            uint arg_index,
            Ref arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            Kernel* kernel,
            uint arg_index,
            void* arg_value
        );

        [NativeName("clSetKernelArgSVMPointerARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
        static abstract int SetKernelArgSvmPointerARM(
            Ref<Kernel> kernel,
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
            Kernel* kernel,
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
            Ref<Kernel> kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            Kernel* kernel,
            uint param_name,
            nuint param_value_size,
            void* param_value
        );

        [NativeName("clSetKernelExecInfoARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
        static abstract int SetKernelExecInfoARM(
            Ref<Kernel> kernel,
            uint param_name,
            nuint param_value_size,
            Ref param_value
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            Mem* memobj,
            delegate* unmanaged<Mem*, void*, void> pfn_notify,
            void* user_data
        );

        [NativeName("clSetMemObjectDestructorAPPLE")]
        [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
        [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
        static abstract int SetMemObjectDestructorAPPLE(
            Ref<Mem> memobj,
            delegate* unmanaged<Mem*, void*, void> pfn_notify,
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
            Mem* memobj,
            delegate* unmanaged<Mem*, void*, void> pfn_notify,
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
            Ref<Mem> memobj,
            delegate* unmanaged<Mem*, void*, void> pfn_notify,
            Ref user_data
        );

        [NativeName("clSetPerfHintQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
        [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
        static abstract int SetPerfHintQCOM(Context* context, uint perf_hint);

        [NativeName("clSetPerfHintQCOM")]
        [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
        [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
        static abstract int SetPerfHintQCOM(Ref<Context> context, uint perf_hint);

        [NativeName("clSetProgramReleaseCallback")]
        [Obsolete]
        [SupportedApiProfile(
            "opencl",
            ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
            MinVersion = "2.2"
        )]
        [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
        static abstract int SetProgramReleaseCallback(
            Program* program,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
            Ref<Program> program,
            delegate* unmanaged<Program*, void*, void> pfn_notify,
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
            Program* program,
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
            Ref<Program> program,
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
        static abstract int SetUserEventStatus(Event* @event, int execution_status);

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
        static abstract int SetUserEventStatus(Ref<Event> @event, int execution_status);

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract void* SharedMemAllocINTEL(
            Context* context,
            DeviceId* device,
            ulong* properties,
            nuint size,
            uint alignment,
            int* errcode_ret
        );

        [NativeName("clSharedMemAllocINTEL")]
        [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
        static abstract Ptr SharedMemAllocINTEL(
            Ref<Context> context,
            Ref<DeviceId> device,
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
        static abstract void* SvmAlloc(Context* context, ulong flags, nuint size, uint alignment);

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
        static abstract Ptr SvmAlloc(Ref<Context> context, ulong flags, nuint size, uint alignment);

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract void* SvmAllocARM(
            Context* context,
            ulong flags,
            nuint size,
            uint alignment
        );

        [NativeName("clSVMAllocARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
        static abstract Ptr SvmAllocARM(
            Ref<Context> context,
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
        static abstract void SvmFree(Context* context, void* svm_pointer);

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
        static abstract void SvmFree(Ref<Context> context, Ref svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(Context* context, void* svm_pointer);

        [NativeName("clSVMFreeARM")]
        [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
        [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
        static abstract void SvmFreeARM(Ref<Context> context, Ref svm_pointer);

        [NativeName("clTerminateContextKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
        [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
        static abstract int TerminateContextKHR(Context* context);

        [NativeName("clTerminateContextKHR")]
        [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
        [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
        static abstract int TerminateContextKHR(Ref<Context> context);

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
        static abstract int UnloadPlatformCompiler(PlatformId* platform);

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
        static abstract int UnloadPlatformCompiler(Ref<PlatformId> platform);

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
        static abstract int WaitForEvents(uint num_events, Event** event_list);

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
        static abstract int WaitForEvents(uint num_events, Ref2D<Event> event_list);
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
        Program* program,
        uint num_devices,
        DeviceId** device_list,
        sbyte* options,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        Ref<Program> program,
        uint num_devices,
        Ref2D<DeviceId> device_list,
        Ref<sbyte> options,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(Event** event_list, nuint num_events_in_list);

    [NativeName("clCancelCommandsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_cancel_command"])]
    [NativeFunction("opencl", EntryPoint = "clCancelCommandsIMG")]
    int CancelCommandsIMG(Ref2D<Event> event_list, nuint num_events_in_list);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    Kernel* CloneKernel(Kernel* source_kernel, int* errcode_ret);

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCloneKernel")]
    Ptr<Kernel> CloneKernel(Ref<Kernel> source_kernel, Ref<int> errcode_ret);

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
        Program* program,
        uint num_devices,
        DeviceId** device_list,
        sbyte* options,
        uint num_input_headers,
        Program** input_headers,
        sbyte** header_include_names,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        Ref<Program> program,
        uint num_devices,
        Ref2D<DeviceId> device_list,
        Ref<sbyte> options,
        uint num_input_headers,
        Ref2D<Program> input_headers,
        Ref2D<sbyte> header_include_names,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    _cl_accelerator_intel* CreateAcceleratorINTEL(
        Context* context,
        uint accelerator_type,
        nuint descriptor_size,
        void* descriptor,
        int* errcode_ret
    );

    [NativeName("clCreateAcceleratorINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_accelerator"])]
    [NativeFunction("opencl", EntryPoint = "clCreateAcceleratorINTEL")]
    Ptr<_cl_accelerator_intel> CreateAcceleratorINTEL(
        Ref<Context> context,
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
    Mem* CreateBuffer(Context* context, ulong flags, nuint size, void* host_ptr, int* errcode_ret);

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
    Ptr<Mem> CreateBuffer(
        Ref<Context> context,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    Mem* CreateBufferWithProperties(
        Context* context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithProperties")]
    Ptr<Mem> CreateBufferWithProperties(
        Ref<Context> context,
        Ref<ulong> properties,
        ulong flags,
        nuint size,
        Ref host_ptr,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    Mem* CreateBufferWithPropertiesINTEL(
        Context* context,
        ulong* properties,
        ulong flags,
        nuint size,
        void* host_ptr,
        int* errcode_ret
    );

    [NativeName("clCreateBufferWithPropertiesINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_create_buffer_with_properties"])]
    [NativeFunction("opencl", EntryPoint = "clCreateBufferWithPropertiesINTEL")]
    Ptr<Mem> CreateBufferWithPropertiesINTEL(
        Ref<Context> context,
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
    CommandQueue* CreateCommandQueue(
        Context* context,
        DeviceId* device,
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
    Ptr<CommandQueue> CreateCommandQueue(
        Ref<Context> context,
        Ref<DeviceId> device,
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
    CommandQueue* CreateCommandQueueWithProperties(
        Context* context,
        DeviceId* device,
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
    Ptr<CommandQueue> CreateCommandQueueWithProperties(
        Ref<Context> context,
        Ref<DeviceId> device,
        Ref<ulong> properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    CommandQueue* CreateCommandQueueWithPropertiesKHR(
        Context* context,
        DeviceId* device,
        ulong* properties,
        int* errcode_ret
    );

    [NativeName("clCreateCommandQueueWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_create_command_queue"])]
    [NativeFunction("opencl", EntryPoint = "clCreateCommandQueueWithPropertiesKHR")]
    Ptr<CommandQueue> CreateCommandQueueWithPropertiesKHR(
        Ref<Context> context,
        Ref<DeviceId> device,
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
    Context* CreateContext(
        nint* properties,
        uint num_devices,
        DeviceId** devices,
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
    Ptr<Context> CreateContext(
        Ref<nint> properties,
        uint num_devices,
        Ref2D<DeviceId> devices,
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
    Context* CreateContextFromType(
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
    Ptr<Context> CreateContextFromType(
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
    Mem* CreateImage(
        Context* context,
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
    Ptr<Mem> CreateImage(
        Ref<Context> context,
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
    Mem* CreateImage2D(
        Context* context,
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
    Ptr<Mem> CreateImage2D(
        Ref<Context> context,
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
    Mem* CreateImage3D(
        Context* context,
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
    Ptr<Mem> CreateImage3D(
        Ref<Context> context,
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
    Mem* CreateImageWithProperties(
        Context* context,
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
    Ptr<Mem> CreateImageWithProperties(
        Ref<Context> context,
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
    Kernel* CreateKernel(Program* program, sbyte* kernel_name, int* errcode_ret);

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
    Ptr<Kernel> CreateKernel(Ref<Program> program, Ref<sbyte> kernel_name, Ref<int> errcode_ret);

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
        Program* program,
        uint num_kernels,
        Kernel** kernels,
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
        Ref<Program> program,
        uint num_kernels,
        Ref2D<Kernel> kernels,
        Ref<uint> num_kernels_ret
    );

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreatePipe")]
    Mem* CreatePipe(
        Context* context,
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
    Ptr<Mem> CreatePipe(
        Ref<Context> context,
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
    Program* CreateProgramWithBinary(
        Context* context,
        uint num_devices,
        DeviceId** device_list,
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
    Ptr<Program> CreateProgramWithBinary(
        Ref<Context> context,
        uint num_devices,
        Ref2D<DeviceId> device_list,
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
    Program* CreateProgramWithBuiltInKernels(
        Context* context,
        uint num_devices,
        DeviceId** device_list,
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
    Ptr<Program> CreateProgramWithBuiltInKernels(
        Ref<Context> context,
        uint num_devices,
        Ref2D<DeviceId> device_list,
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
    Program* CreateProgramWithIL(Context* context, void* il, nuint length, int* errcode_ret);

    [NativeName("clCreateProgramWithIL")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithIL")]
    Ptr<Program> CreateProgramWithIL(
        Ref<Context> context,
        Ref il,
        nuint length,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    Program* CreateProgramWithILKHR(Context* context, void* il, nuint length, int* errcode_ret);

    [NativeName("clCreateProgramWithILKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_il_program"])]
    [NativeFunction("opencl", EntryPoint = "clCreateProgramWithILKHR")]
    Ptr<Program> CreateProgramWithILKHR(
        Ref<Context> context,
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
    Program* CreateProgramWithSource(
        Context* context,
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
    Ptr<Program> CreateProgramWithSource(
        Ref<Context> context,
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
    Sampler* CreateSampler(
        Context* context,
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
    Ptr<Sampler> CreateSampler(
        Ref<Context> context,
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
    Sampler* CreateSamplerWithProperties(
        Context* context,
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
    Ptr<Sampler> CreateSamplerWithProperties(
        Ref<Context> context,
        Ref<ulong> sampler_properties,
        Ref<int> errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    _cl_semaphore_khr* CreateSemaphoreWithPropertiesKHR(
        Context* context,
        ulong* sema_props,
        int* errcode_ret
    );

    [NativeName("clCreateSemaphoreWithPropertiesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSemaphoreWithPropertiesKHR")]
    Ptr<_cl_semaphore_khr> CreateSemaphoreWithPropertiesKHR(
        Ref<Context> context,
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
    Mem* CreateSubBuffer(
        Mem* buffer,
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
    Ptr<Mem> CreateSubBuffer(
        Ref<Mem> buffer,
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
        DeviceId* in_device,
        nint* properties,
        uint num_devices,
        DeviceId** out_devices,
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
        Ref<DeviceId> in_device,
        Ref<nint> properties,
        uint num_devices,
        Ref2D<DeviceId> out_devices,
        Ref<uint> num_devices_ret
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        DeviceId* in_device,
        ulong* properties,
        uint num_entries,
        DeviceId** out_devices,
        uint* num_devices
    );

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clCreateSubDevicesEXT")]
    int CreateSubDevicesEXT(
        Ref<DeviceId> in_device,
        Ref<ulong> properties,
        uint num_entries,
        Ref2D<DeviceId> out_devices,
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
    Event* CreateUserEvent(Context* context, int* errcode_ret);

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
    Ptr<Event> CreateUserEvent(Ref<Context> context, Ref<int> errcode_ret);

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    void* DeviceMemAllocINTEL(
        Context* context,
        DeviceId* device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clDeviceMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clDeviceMemAllocINTEL")]
    Ptr DeviceMemAllocINTEL(
        Ref<Context> context,
        Ref<DeviceId> device,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        CommandQueue* command_queue,
        uint num_mem_objects,
        Mem** mem_objects,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueAcquireExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR")]
    int EnqueueAcquireExternalMemObjectsKHR(
        Ref<CommandQueue> command_queue,
        uint num_mem_objects,
        Ref2D<Mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        CommandQueue* command_queue,
        uint num_objects,
        Mem** mem_objects,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueAcquireGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueAcquireGrallocObjectsIMG")]
    int EnqueueAcquireGrallocObjectsIMG(
        Ref<CommandQueue> command_queue,
        uint num_objects,
        Ref2D<Mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
    int EnqueueBarrier(CommandQueue* command_queue);

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
    int EnqueueBarrier(Ref<CommandQueue> command_queue);

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
        CommandQueue* command_queue,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* src_buffer,
        Mem* dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_buffer,
        Ref<Mem> dst_buffer,
        nuint src_offset,
        nuint dst_offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* src_buffer,
        Mem* dst_buffer,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_buffer,
        Ref<Mem> dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        nuint src_row_pitch,
        nuint src_slice_pitch,
        nuint dst_row_pitch,
        nuint dst_slice_pitch,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* src_buffer,
        Mem* dst_image,
        nuint src_offset,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_buffer,
        Ref<Mem> dst_image,
        nuint src_offset,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* src_image,
        Mem* dst_image,
        nuint* src_origin,
        nuint* dst_origin,
        nuint* region,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_image,
        Ref<Mem> dst_image,
        Ref<nuint> src_origin,
        Ref<nuint> dst_origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* src_image,
        Mem* dst_buffer,
        nuint* src_origin,
        nuint* region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_image,
        Ref<Mem> dst_buffer,
        Ref<nuint> src_origin,
        Ref<nuint> region,
        nuint dst_offset,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
        void* pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
        Ref pattern,
        nuint pattern_size,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* image,
        void* fill_color,
        nuint* origin,
        nuint* region,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> image,
        Ref fill_color,
        Ref<nuint> origin,
        Ref<nuint> region,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        CommandQueue* command_queue,
        Mem* src_image,
        Mem* dst_image,
        uint mipmap_filter_mode,
        nuint* array_region,
        nuint* mip_region,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueGenerateMipmapIMG")]
    [SupportedApiProfile("opencl", ["cl_img_generate_mipmap"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueGenerateMipmapIMG")]
    int EnqueueGenerateMipmapIMG(
        Ref<CommandQueue> command_queue,
        Ref<Mem> src_image,
        Ref<Mem> dst_image,
        uint mipmap_filter_mode,
        Ref<nuint> array_region,
        Ref<nuint> mip_region,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
        uint blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event,
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        nuint offset,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event,
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
        CommandQueue* command_queue,
        Mem* image,
        uint blocking_map,
        ulong map_flags,
        nuint* origin,
        nuint* region,
        nuint* image_row_pitch,
        nuint* image_slice_pitch,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event,
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> image,
        MaybeBool<uint> blocking_map,
        ulong map_flags,
        Ref<nuint> origin,
        Ref<nuint> region,
        Ref<nuint> image_row_pitch,
        Ref<nuint> image_slice_pitch,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event,
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
    int EnqueueMarker(CommandQueue* command_queue, Event** @event);

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
    int EnqueueMarker(Ref<CommandQueue> command_queue, Ref2D<Event> @event);

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
        CommandQueue* command_queue,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        CommandQueue* command_queue,
        void* ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMemAdviseINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemAdviseINTEL")]
    int EnqueueMemAdviseINTEL(
        Ref<CommandQueue> command_queue,
        Ref ptr,
        nuint size,
        uint advice,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        CommandQueue* command_queue,
        uint blocking,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMemcpyINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemcpyINTEL")]
    int EnqueueMemcpyINTEL(
        Ref<CommandQueue> command_queue,
        MaybeBool<uint> blocking,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        CommandQueue* command_queue,
        void* dst_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMemFillINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemFillINTEL")]
    int EnqueueMemFillINTEL(
        Ref<CommandQueue> command_queue,
        Ref dst_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        CommandQueue* command_queue,
        void* dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMemsetINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMemsetINTEL")]
    int EnqueueMemsetINTEL(
        Ref<CommandQueue> command_queue,
        Ref dst_ptr,
        int value,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        CommandQueue* command_queue,
        void* ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMigrateMemINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemINTEL")]
    int EnqueueMigrateMemINTEL(
        Ref<CommandQueue> command_queue,
        Ref ptr,
        nuint size,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        CommandQueue* command_queue,
        uint num_mem_objects,
        Mem** mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueMigrateMemObjectEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_migrate_memobject"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueMigrateMemObjectEXT")]
    int EnqueueMigrateMemObjectEXT(
        Ref<CommandQueue> command_queue,
        uint num_mem_objects,
        Ref2D<Mem> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        uint num_mem_objects,
        Mem** mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        uint num_mem_objects,
        Ref2D<Mem> mem_objects,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        delegate* unmanaged<void*, void> user_func,
        void* args,
        nuint cb_args,
        uint num_mem_objects,
        Mem** mem_list,
        void** args_mem_loc,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        delegate* unmanaged<void*, void> user_func,
        Ref args,
        nuint cb_args,
        uint num_mem_objects,
        Ref2D<Mem> mem_list,
        Ref2D args_mem_loc,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* local_work_size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Kernel> kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> local_work_size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
        uint blocking_read,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
        MaybeBool<uint> blocking_read,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
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
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
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
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        CommandQueue* command_queue,
        Program* program,
        sbyte* pipe_symbol,
        uint blocking_read,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueReadHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReadHostPipeINTEL")]
    int EnqueueReadHostPipeINTEL(
        Ref<CommandQueue> command_queue,
        Ref<Program> program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_read,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* image,
        uint blocking_read,
        nuint* origin,
        nuint* region,
        nuint row_pitch,
        nuint slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> image,
        MaybeBool<uint> blocking_read,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint row_pitch,
        nuint slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        CommandQueue* command_queue,
        uint num_mem_objects,
        Mem** mem_objects,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueReleaseExternalMemObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_external_memory"], ImpliesSets = ["CL_VERSION_3_0"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR")]
    int EnqueueReleaseExternalMemObjectsKHR(
        Ref<CommandQueue> command_queue,
        uint num_mem_objects,
        Ref2D<Mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        CommandQueue* command_queue,
        uint num_objects,
        Mem** mem_objects,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueReleaseGrallocObjectsIMG")]
    [SupportedApiProfile("opencl", ["cl_img_use_gralloc_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueReleaseGrallocObjectsIMG")]
    int EnqueueReleaseGrallocObjectsIMG(
        Ref<CommandQueue> command_queue,
        uint num_objects,
        Ref2D<Mem> mem_objects,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        CommandQueue* command_queue,
        uint num_sema_objects,
        _cl_semaphore_khr** sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSignalSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSignalSemaphoresKHR")]
    int EnqueueSignalSemaphoresKHR(
        Ref<CommandQueue> command_queue,
        uint num_sema_objects,
        Ref2D<_cl_semaphore_khr> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        CommandQueue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFree")]
    int EnqueueSvmFree(
        Ref<CommandQueue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        CommandQueue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
        void* user_data,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMFreeARM")]
    int EnqueueSvmFreeARM(
        Ref<CommandQueue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        delegate* unmanaged<CommandQueue*, uint, void**, void*, void> pfn_free_func,
        Ref user_data,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        CommandQueue* command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMap")]
    int EnqueueSvmMap(
        Ref<CommandQueue> command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        CommandQueue* command_queue,
        uint blocking_map,
        ulong flags,
        void* svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMapARM")]
    int EnqueueSvmMapARM(
        Ref<CommandQueue> command_queue,
        MaybeBool<uint> blocking_map,
        ulong flags,
        Ref svm_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        CommandQueue* command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpy")]
    int EnqueueSvmMemcpy(
        Ref<CommandQueue> command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        CommandQueue* command_queue,
        uint blocking_copy,
        void* dst_ptr,
        void* src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMemcpyARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemcpyARM")]
    int EnqueueSvmMemcpyARM(
        Ref<CommandQueue> command_queue,
        MaybeBool<uint> blocking_copy,
        Ref dst_ptr,
        Ref src_ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        CommandQueue* command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFill")]
    int EnqueueSvmMemFill(
        Ref<CommandQueue> command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        CommandQueue* command_queue,
        void* svm_ptr,
        void* pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMemFillARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMemFillARM")]
    int EnqueueSvmMemFillARM(
        Ref<CommandQueue> command_queue,
        Ref svm_ptr,
        Ref pattern,
        nuint pattern_size,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        CommandQueue* command_queue,
        uint num_svm_pointers,
        void** svm_pointers,
        nuint* sizes,
        ulong flags,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMMigrateMem")]
    int EnqueueSvmMigrateMem(
        Ref<CommandQueue> command_queue,
        uint num_svm_pointers,
        Ref2D svm_pointers,
        Ref<nuint> sizes,
        ulong flags,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        CommandQueue* command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmap")]
    int EnqueueSvmUnmap(
        Ref<CommandQueue> command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        CommandQueue* command_queue,
        void* svm_ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueSVMUnmapARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueSVMUnmapARM")]
    int EnqueueSvmUnmapARM(
        Ref<CommandQueue> command_queue,
        Ref svm_ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Kernel* kernel,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Kernel> kernel,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* memobj,
        void* mapped_ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> memobj,
        Ref mapped_ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
    int EnqueueWaitForEvents(CommandQueue* command_queue, uint num_events, Event** event_list);

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
        Ref<CommandQueue> command_queue,
        uint num_events,
        Ref2D<Event> event_list
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        CommandQueue* command_queue,
        uint num_sema_objects,
        _cl_semaphore_khr** sema_objects,
        ulong* sema_payload_list,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueWaitSemaphoresKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_semaphore"], ImpliesSets = ["CL_VERSION_1_2"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWaitSemaphoresKHR")]
    int EnqueueWaitSemaphoresKHR(
        Ref<CommandQueue> command_queue,
        uint num_sema_objects,
        Ref2D<_cl_semaphore_khr> sema_objects,
        Ref<ulong> sema_payload_list,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
        uint blocking_write,
        nuint offset,
        nuint size,
        void* ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
        MaybeBool<uint> blocking_write,
        nuint offset,
        nuint size,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* buffer,
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
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> buffer,
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
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        CommandQueue* command_queue,
        Program* program,
        sbyte* pipe_symbol,
        uint blocking_write,
        void* ptr,
        nuint size,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
    );

    [NativeName("clEnqueueWriteHostPipeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_program_scope_host_pipe"])]
    [NativeFunction("opencl", EntryPoint = "clEnqueueWriteHostPipeINTEL")]
    int EnqueueWriteHostPipeINTEL(
        Ref<CommandQueue> command_queue,
        Ref<Program> program,
        Ref<sbyte> pipe_symbol,
        MaybeBool<uint> blocking_write,
        Ref ptr,
        nuint size,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
        CommandQueue* command_queue,
        Mem* image,
        uint blocking_write,
        nuint* origin,
        nuint* region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        void* ptr,
        uint num_events_in_wait_list,
        Event** event_wait_list,
        Event** @event
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
        Ref<CommandQueue> command_queue,
        Ref<Mem> image,
        MaybeBool<uint> blocking_write,
        Ref<nuint> origin,
        Ref<nuint> region,
        nuint input_row_pitch,
        nuint input_slice_pitch,
        Ref ptr,
        uint num_events_in_wait_list,
        Ref2D<Event> event_wait_list,
        Ref2D<Event> @event
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
    int Finish(CommandQueue* command_queue);

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
    int Finish(Ref<CommandQueue> command_queue);

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
    int Flush(CommandQueue* command_queue);

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
    int Flush(Ref<CommandQueue> command_queue);

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
        CommandQueue* command_queue,
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
        Ref<CommandQueue> command_queue,
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
        Context* context,
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
        Ref<Context> context,
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
    int GetDeviceAndHostTimer(DeviceId* device, ulong* device_timestamp, ulong* host_timestamp);

    [NativeName("clGetDeviceAndHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceAndHostTimer")]
    int GetDeviceAndHostTimer(
        Ref<DeviceId> device,
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
        PlatformId* platform,
        ulong device_type,
        uint num_entries,
        DeviceId** devices,
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
        Ref<PlatformId> platform,
        ulong device_type,
        uint num_entries,
        Ref2D<DeviceId> devices,
        Ref<uint> num_devices
    );

    [NativeName("clGetDeviceImageInfoQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_ext_host_ptr"])]
    [NativeFunction("opencl", EntryPoint = "clGetDeviceImageInfoQCOM")]
    int GetDeviceImageInfoQCOM(
        DeviceId* device,
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
        Ref<DeviceId> device,
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
        DeviceId* device,
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
        Ref<DeviceId> device,
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
        Event* @event,
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
        Ref<Event> @event,
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
        Event* @event,
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
        Ref<Event> @event,
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
    void* GetExtensionFunctionAddressForPlatform(PlatformId* platform, sbyte* func_name);

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
    Ptr GetExtensionFunctionAddressForPlatform(Ref<PlatformId> platform, Ref<sbyte> func_name);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(DeviceId* device, ulong* host_timestamp);

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clGetHostTimer")]
    int GetHostTimer(Ref<DeviceId> device, Ref<ulong> host_timestamp);

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
        Mem* image,
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
        Ref<Mem> image,
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
        Context* context,
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
        Ref<Context> context,
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
        Kernel* kernel,
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
        Ref<Kernel> kernel,
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
        Kernel* kernel,
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
        Ref<Kernel> kernel,
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
        Kernel* kernel,
        DeviceId* device,
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
        Ref<Kernel> kernel,
        Ref<DeviceId> device,
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
        Kernel* in_kernel,
        DeviceId* in_device,
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
        Ref<Kernel> in_kernel,
        Ref<DeviceId> in_device,
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
        CommandQueue* command_queue,
        Kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSize")]
    int GetKernelSuggestedLocalWorkSize(
        Ref<CommandQueue> command_queue,
        Ref<Kernel> kernel,
        uint work_dim,
        Ref<nuint> global_work_offset,
        Ref<nuint> global_work_size,
        Ref<nuint> suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        CommandQueue* command_queue,
        Kernel* kernel,
        uint work_dim,
        nuint* global_work_offset,
        nuint* global_work_size,
        nuint* suggested_local_work_size
    );

    [NativeName("clGetKernelSuggestedLocalWorkSizeKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_suggested_local_work_size"])]
    [NativeFunction("opencl", EntryPoint = "clGetKernelSuggestedLocalWorkSizeKHR")]
    int GetKernelSuggestedLocalWorkSizeKHR(
        Ref<CommandQueue> command_queue,
        Ref<Kernel> kernel,
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
        Kernel* kernel,
        DeviceId* device,
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
        Ref<Kernel> kernel,
        Ref<DeviceId> device,
        uint param_name,
        nuint param_value_size,
        Ref param_value,
        Ref<nuint> param_value_size_ret
    );

    [NativeName("clGetMemAllocInfoINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clGetMemAllocInfoINTEL")]
    int GetMemAllocInfoINTEL(
        Context* context,
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
        Ref<Context> context,
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
        Mem* memobj,
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
        Ref<Mem> memobj,
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
        Mem* pipe,
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
        Ref<Mem> pipe,
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
    int GetPlatformIDs(uint num_entries, PlatformId** platforms, uint* num_platforms);

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
    int GetPlatformIDs(uint num_entries, Ref2D<PlatformId> platforms, Ref<uint> num_platforms);

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
        PlatformId* platform,
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
        Ref<PlatformId> platform,
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
        Program* program,
        DeviceId* device,
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
        Ref<Program> program,
        Ref<DeviceId> device,
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
        Program* program,
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
        Ref<Program> program,
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
        Sampler* sampler,
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
        Ref<Sampler> sampler,
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
        DeviceId* device,
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
        Ref<DeviceId> device,
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
        Context* context,
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
        Ref<Context> context,
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
        Context* context,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clHostMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clHostMemAllocINTEL")]
    Ptr HostMemAllocINTEL(
        Ref<Context> context,
        Ref<ulong> properties,
        nuint size,
        uint alignment,
        Ref<int> errcode_ret
    );

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    void* IcdGetFunctionAddressForPlatformKHR(PlatformId* platform, sbyte* func_name);

    [NativeName("clIcdGetFunctionAddressForPlatformKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetFunctionAddressForPlatformKHR")]
    Ptr IcdGetFunctionAddressForPlatformKHR(Ref<PlatformId> platform, Ref<sbyte> func_name);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(uint num_entries, PlatformId** platforms, uint* num_platforms);

    [NativeName("clIcdGetPlatformIDsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdGetPlatformIDsKHR")]
    int IcdGetPlatformIDsKHR(
        uint num_entries,
        Ref2D<PlatformId> platforms,
        Ref<uint> num_platforms
    );

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(PlatformId* platform, void* dispatch_data);

    [NativeName("clIcdSetPlatformDispatchDataKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_icd"])]
    [NativeFunction("opencl", EntryPoint = "clIcdSetPlatformDispatchDataKHR")]
    int IcdSetPlatformDispatchDataKHR(Ref<PlatformId> platform, Ref dispatch_data);

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    Mem* ImportMemoryARM(
        Context* context,
        ulong flags,
        nint* properties,
        void* memory,
        nuint size,
        int* errcode_ret
    );

    [NativeName("clImportMemoryARM")]
    [SupportedApiProfile("opencl", ["cl_arm_import_memory"])]
    [NativeFunction("opencl", EntryPoint = "clImportMemoryARM")]
    Ptr<Mem> ImportMemoryARM(
        Ref<Context> context,
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
    Program* LinkProgram(
        Context* context,
        uint num_devices,
        DeviceId** device_list,
        sbyte* options,
        uint num_input_programs,
        Program** input_programs,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
    Ptr<Program> LinkProgram(
        Ref<Context> context,
        uint num_devices,
        Ref2D<DeviceId> device_list,
        Ref<sbyte> options,
        uint num_input_programs,
        Ref2D<Program> input_programs,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
    int MemBlockingFreeINTEL(Context* context, void* ptr);

    [NativeName("clMemBlockingFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemBlockingFreeINTEL")]
    int MemBlockingFreeINTEL(Ref<Context> context, Ref ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(Context* context, void* ptr);

    [NativeName("clMemFreeINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clMemFreeINTEL")]
    int MemFreeINTEL(Ref<Context> context, Ref ptr);

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
    int ReleaseCommandQueue(CommandQueue* command_queue);

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
    int ReleaseCommandQueue(Ref<CommandQueue> command_queue);

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
    int ReleaseContext(Context* context);

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
    int ReleaseContext(Ref<Context> context);

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
    int ReleaseDevice(DeviceId* device);

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
    int ReleaseDevice(Ref<DeviceId> device);

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
    int ReleaseDeviceEXT(DeviceId* device);

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clReleaseDeviceEXT")]
    int ReleaseDeviceEXT(Ref<DeviceId> device);

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
    int ReleaseEvent(Event* @event);

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
    int ReleaseEvent(Ref<Event> @event);

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
    int ReleaseKernel(Kernel* kernel);

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
    int ReleaseKernel(Ref<Kernel> kernel);

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
    int ReleaseMemObject(Mem* memobj);

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
    int ReleaseMemObject(Ref<Mem> memobj);

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
    int ReleaseProgram(Program* program);

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
    int ReleaseProgram(Ref<Program> program);

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
    int ReleaseSampler(Sampler* sampler);

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
    int ReleaseSampler(Ref<Sampler> sampler);

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
    int RetainCommandQueue(CommandQueue* command_queue);

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
    int RetainCommandQueue(Ref<CommandQueue> command_queue);

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
    int RetainContext(Context* context);

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
    int RetainContext(Ref<Context> context);

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
    int RetainDevice(DeviceId* device);

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
    int RetainDevice(Ref<DeviceId> device);

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
    int RetainDeviceEXT(DeviceId* device);

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    [NativeFunction("opencl", EntryPoint = "clRetainDeviceEXT")]
    int RetainDeviceEXT(Ref<DeviceId> device);

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
    int RetainEvent(Event* @event);

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
    int RetainEvent(Ref<Event> @event);

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
    int RetainKernel(Kernel* kernel);

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
    int RetainKernel(Ref<Kernel> kernel);

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
    int RetainMemObject(Mem* memobj);

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
    int RetainMemObject(Ref<Mem> memobj);

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
    int RetainProgram(Program* program);

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
    int RetainProgram(Ref<Program> program);

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
    int RetainSampler(Sampler* sampler);

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
    int RetainSampler(Ref<Sampler> sampler);

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
    int SetContentSizeBufferPOCL(Mem* buffer, Mem* content_size_buffer);

    [NativeName("clSetContentSizeBufferPoCL")]
    [SupportedApiProfile("opencl", ["cl_pocl_content_size"])]
    [NativeFunction("opencl", EntryPoint = "clSetContentSizeBufferPoCL")]
    int SetContentSizeBufferPOCL(Ref<Mem> buffer, Ref<Mem> content_size_buffer);

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        Context* context,
        delegate* unmanaged<Context*, void*, void> pfn_notify,
        void* user_data
    );

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    [NativeFunction("opencl", EntryPoint = "clSetContextDestructorCallback")]
    int SetContextDestructorCallback(
        Ref<Context> context,
        delegate* unmanaged<Context*, void*, void> pfn_notify,
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
        Context* context,
        DeviceId* device,
        CommandQueue* command_queue
    );

    [NativeName("clSetDefaultDeviceCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetDefaultDeviceCommandQueue")]
    int SetDefaultDeviceCommandQueue(
        Ref<Context> context,
        Ref<DeviceId> device,
        Ref<CommandQueue> command_queue
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
        Event* @event,
        int command_exec_callback_type,
        delegate* unmanaged<Event*, int, void*, void> pfn_notify,
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
        Ref<Event> @event,
        int command_exec_callback_type,
        delegate* unmanaged<Event*, int, void*, void> pfn_notify,
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
    int SetKernelArg(Kernel* kernel, uint arg_index, nuint arg_size, void* arg_value);

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
    int SetKernelArg(Ref<Kernel> kernel, uint arg_index, nuint arg_size, Ref arg_value);

    [NativeName("clSetKernelArgDevicePointerEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_buffer_device_address"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
    int SetKernelArgDevicePointerEXT(Kernel* kernel, uint arg_index, ulong arg_value);

    [NativeName("clSetKernelArgDevicePointerEXT")]
    [SupportedApiProfile(
        "opencl",
        ["cl_ext_buffer_device_address"],
        ImpliesSets = ["CL_VERSION_3_0"]
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgDevicePointerEXT")]
    int SetKernelArgDevicePointerEXT(Ref<Kernel> kernel, uint arg_index, ulong arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(Kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgMemPointerINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgMemPointerINTEL")]
    int SetKernelArgMemPointerINTEL(Ref<Kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(Kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointer")]
    int SetKernelArgSvmPointer(Ref<Kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(Kernel* kernel, uint arg_index, void* arg_value);

    [NativeName("clSetKernelArgSVMPointerARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelArgSVMPointerARM")]
    int SetKernelArgSvmPointerARM(Ref<Kernel> kernel, uint arg_index, Ref arg_value);

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfo")]
    int SetKernelExecInfo(
        Kernel* kernel,
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
        Ref<Kernel> kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        Kernel* kernel,
        uint param_name,
        nuint param_value_size,
        void* param_value
    );

    [NativeName("clSetKernelExecInfoARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSetKernelExecInfoARM")]
    int SetKernelExecInfoARM(
        Ref<Kernel> kernel,
        uint param_name,
        nuint param_value_size,
        Ref param_value
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        Mem* memobj,
        delegate* unmanaged<Mem*, void*, void> pfn_notify,
        void* user_data
    );

    [NativeName("clSetMemObjectDestructorAPPLE")]
    [SupportedApiProfile("opencl", ["cl_APPLE_SetMemObjectDestructor"])]
    [NativeFunction("opencl", EntryPoint = "clSetMemObjectDestructorAPPLE")]
    int SetMemObjectDestructorAPPLE(
        Ref<Mem> memobj,
        delegate* unmanaged<Mem*, void*, void> pfn_notify,
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
        Mem* memobj,
        delegate* unmanaged<Mem*, void*, void> pfn_notify,
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
        Ref<Mem> memobj,
        delegate* unmanaged<Mem*, void*, void> pfn_notify,
        Ref user_data
    );

    [NativeName("clSetPerfHintQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
    [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
    int SetPerfHintQCOM(Context* context, uint perf_hint);

    [NativeName("clSetPerfHintQCOM")]
    [SupportedApiProfile("opencl", ["cl_qcom_perf_hint"])]
    [NativeFunction("opencl", EntryPoint = "clSetPerfHintQCOM")]
    int SetPerfHintQCOM(Ref<Context> context, uint perf_hint);

    [NativeName("clSetProgramReleaseCallback")]
    [Obsolete]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    [NativeFunction("opencl", EntryPoint = "clSetProgramReleaseCallback")]
    int SetProgramReleaseCallback(
        Program* program,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        Ref<Program> program,
        delegate* unmanaged<Program*, void*, void> pfn_notify,
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
        Program* program,
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
        Ref<Program> program,
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
    int SetUserEventStatus(Event* @event, int execution_status);

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
    int SetUserEventStatus(Ref<Event> @event, int execution_status);

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    void* SharedMemAllocINTEL(
        Context* context,
        DeviceId* device,
        ulong* properties,
        nuint size,
        uint alignment,
        int* errcode_ret
    );

    [NativeName("clSharedMemAllocINTEL")]
    [SupportedApiProfile("opencl", ["cl_intel_unified_shared_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSharedMemAllocINTEL")]
    Ptr SharedMemAllocINTEL(
        Ref<Context> context,
        Ref<DeviceId> device,
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
    void* SvmAlloc(Context* context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMAlloc")]
    Ptr SvmAlloc(Ref<Context> context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    void* SvmAllocARM(Context* context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMAllocARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMAllocARM")]
    Ptr SvmAllocARM(Ref<Context> context, ulong flags, nuint size, uint alignment);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(Context* context, void* svm_pointer);

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    [NativeFunction("opencl", EntryPoint = "clSVMFree")]
    void SvmFree(Ref<Context> context, Ref svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(Context* context, void* svm_pointer);

    [NativeName("clSVMFreeARM")]
    [SupportedApiProfile("opencl", ["cl_arm_shared_virtual_memory"])]
    [NativeFunction("opencl", EntryPoint = "clSVMFreeARM")]
    void SvmFreeARM(Ref<Context> context, Ref svm_pointer);

    [NativeName("clTerminateContextKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
    [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
    int TerminateContextKHR(Context* context);

    [NativeName("clTerminateContextKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_terminate_context"])]
    [NativeFunction("opencl", EntryPoint = "clTerminateContextKHR")]
    int TerminateContextKHR(Ref<Context> context);

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
    int UnloadPlatformCompiler(PlatformId* platform);

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
    int UnloadPlatformCompiler(Ref<PlatformId> platform);

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
    int WaitForEvents(uint num_events, Event** event_list);

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
    int WaitForEvents(uint num_events, Ref2D<Event> event_list);
}
