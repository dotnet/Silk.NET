// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public unsafe partial class CL : NativeAPI
    {
        public const int CharBit = 8;
        public const int CharMax = 127;
        public const int CharMin = -127 - 1;
        public const double DblDig = 15;
        public const double DblEpsilon = 2.220446049250313080847e-16;
        public const double DblMantDig = 53;
        public const double DblMax = 1.7976931348623158e+308;
        public const double DblMax10Exp = +308;
        public const double DblMaxExp = +1024;
        public const double DblMin = 2.225073858507201383090e-308;
        public const double DblMin10Exp = -307;
        public const double DblMinExp = -1021;
        public const double DblRadix = 2;
        public const int DevicePartitionByCountsListEnd = 0x0;
        public const float FltDig = 6;
        public const float FltEpsilon = 1.1920928955078125e-7f;
        public const float FltMantDig = 24;
        public const float FltMax = 340282346638528859811704183484516925440.0f;
        public const float FltMax10Exp = +38;
        public const float FltMaxExp = +128;
        public const float FltMin = 1.175494350822287507969e-38f;
        public const float FltMin10Exp = -37;
        public const float FltMinExp = -125;
        public const float FltRadix = 2;
        public const short HalfDig = 3;
        public const short HalfEpsilon = unchecked((short)9.765625e-04f);
        public const short HalfMantDig = 11;
        public const short HalfMax = unchecked((short)65504.0f);
        public const short HalfMax10Exp = +4;
        public const short HalfMaxExp = +16;
        public const short HalfMin = unchecked((short)6.103515625e-05f);
        public const short HalfMin10Exp = -4;
        public const short HalfMinExp = -13;
        public const short HalfRadix = 2;
        public const double HugeVal = double.PositiveInfinity;
        public const float HugeValf = (float) 1e50;
        public const float Infinity = float.PositiveInfinity;
        public const int IntMax = 2147483647;
        public const int IntMin = -2147483647 - 1;
        public const long LongMax = 0x7FFFFFFFFFFFFFFFL;
        public const long LongMin = -0x7FFFFFFFFFFFFFFFL - 1L;
        public const double M1PI = 0.31830988618379067154;
        public const float M1PIF = 0.318309886f;
        public const double M2PI = 0.63661977236758134308;
        public const float M2PIF = 0.636619772f;
        public const double M2Sqrtpi = 1.12837916709551257390;
        public const float M2SqrtpiF = 1.128379167f;
        public const float Maxfloat = float.MaxValue;
        public const double ME = 2.7182818284590452354;
        public const float MEF = 2.718281828f;
        public const double MLN10 = 2.30258509299404568402;
        public const float MLN10F = 2.302585093f;
        public const double MLN2 = 0.69314718055994530942;
        public const float MLN2F = 0.693147181f;
        public const double MLog10E = 0.43429448190325182765;
        public const float MLog10EF = 0.434294482f;
        public const double MLog2E = 1.4426950408889634074;
        public const float MLog2EF = 1.442695041f;
        public const double MPI = 3.14159265358979323846;
        public const double MPI2 = 1.57079632679489661923;
        public const float MPI2F = 1.570796327f;
        public const double MPI4 = 0.78539816339744830962;
        public const float MPI4F = 0.785398163f;
        public const float MPIF = 3.141592654f;
        public const double MSqrt12 = 0.70710678118654752440;
        public const float MSqrt12F = 0.707106781f;
        public const double MSqrt2 = 1.41421356237309504880;
        public const float MSqrt2F = 1.414213562f;
        public const int NameVersionMaxNameSize = 64;
        public const float Nan = float.NaN;
        public const int PartitionByCountsListEndExt = 0;
        public const int PartitionByNamesListEndExt = 0 - 1;
        public const int PartitionByNamesListEndIntel = -1;
        public const int PropertiesListEndExt = 0;
        public const int ScharMax = 127;
        public const int ScharMin = -127 - 1;
        public const short ShrtMax = 32767;
        public const short ShrtMin = -32767 - 1;
        public const int UcharMax = 255;
        public const uint UintMax = 0xffffffffU;
        public const ulong UlongMax = 0xFFFFFFFFFFFFFFFFUL;
        public const ushort UshrtMax = 65535;
        public const int VersionMajorBits = 10;
        public const int VersionMinorBits = 10;
        public const int VersionPatchBits = 12;

        [NativeApi(EntryPoint = "clBuildProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplBuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clBuildProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int BuildProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplBuildProgram<T0>(program, num_devices, device_list, options, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCreateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateBuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateBuffer(context, flags, size, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateBuffer<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateBuffer<T0>(context, flags, size, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateCommandQueue(context, device, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateCommandQueue(context, device, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateContext([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateContext(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateContext<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateContext<T0>(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateContextFromType([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateContextFromType(properties, device_type, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateContextFromType<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateContextFromType<T0>(properties, device_type, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateImage2D<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateImage2D<T0>(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_depth, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.In)] UIntPtr image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateImage3D<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_depth, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.In)] UIntPtr image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateImage3D<T0>(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] char* kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateKernel(program, kernel_name, errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] Span<char> kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateKernel(program, kernel_name, errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateKernelsInProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] IntPtr* kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret)
            => ImplCreateKernelsInProgram(program, num_kernels, kernels, num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int CreateKernelsInProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<IntPtr> kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret)
            => ImplCreateKernelsInProgram(program, num_kernels, kernels, num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateProgramWithSource(context, count, strings, lengths, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateProgramWithSource(context, count, strings, lengths, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSampler([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateSampler([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrier")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueBarrier([Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplEnqueueBarrier(command_queue);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueCopyBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueCopyImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueCopyImage(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplEnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplEnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.Out)] UIntPtr* image_row_pitch, [Flow(FlowDirection.Out)] UIntPtr* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplEnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.Out)] Span<UIntPtr> image_row_pitch, [Flow(FlowDirection.Out)] Span<UIntPtr> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplEnqueueMapImage(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMarker")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarker([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMarker(command_queue, @event);

        [NativeApi(EntryPoint = "clEnqueueMarker")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMarker([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueMarker(command_queue, @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueNativeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] FuncPtr user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] UIntPtr cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueNativeKernel(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueNativeKernel<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] FuncPtr user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] UIntPtr cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueNativeKernel<T0, T1>(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueNdrangeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] UIntPtr* global_work_offset, [Flow(FlowDirection.In)] UIntPtr* global_work_size, [Flow(FlowDirection.In)] UIntPtr* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueNdrangeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_offset, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_size, [Flow(FlowDirection.In)] Span<UIntPtr> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueNdrangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueReadBuffer<T0>(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr row_pitch, [Flow(FlowDirection.In)] UIntPtr slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReadImage(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReadImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr row_pitch, [Flow(FlowDirection.In)] UIntPtr slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueReadImage<T0>(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueTask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueTask([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueTask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueTask([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueUnmapMemObject([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueUnmapMemObject(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueUnmapMemObject<T0>(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWaitForEvents([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list)
            => ImplEnqueueWaitForEvents(command_queue, num_events, event_list);

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueWaitForEvents([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list)
            => ImplEnqueueWaitForEvents(command_queue, num_events, event_list);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueWriteBuffer<T0>(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr input_row_pitch, [Flow(FlowDirection.In)] UIntPtr input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueWriteImage(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr input_row_pitch, [Flow(FlowDirection.In)] UIntPtr input_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueWriteImage<T0>(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clFinish")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int Finish([Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplFinish(command_queue);

        [NativeApi(EntryPoint = "clFlush")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int Flush([Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplFlush(command_queue);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetCommandQueueInfo([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetCommandQueueInfo(command_queue, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetCommandQueueInfo<T0>(command_queue, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetContextInfo([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetContextInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetContextInfo<T0>(context, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceIDs")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDs([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
            => ImplGetDeviceIDs(platform, device_type, num_entries, devices, num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDs")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetDeviceIDs([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
            => ImplGetDeviceIDs(platform, device_type, num_entries, devices, num_devices);

        [NativeApi(EntryPoint = "clGetDeviceInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetDeviceInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetDeviceInfo<T0>(device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventInfo([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetEventInfo(@event, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetEventInfo<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetEventInfo<T0>(@event, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventProfilingInfo([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetEventProfilingInfo(@event, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetEventProfilingInfo<T0>(@event, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] char* func_name)
            => ImplGetExtensionFunctionAddress(func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] Span<char> func_name)
            => ImplGetExtensionFunctionAddress(func_name);

        [NativeApi(EntryPoint = "clGetImageInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetImageInfo([Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetImageInfo(image, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetImageInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetImageInfo<T0>([Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetImageInfo<T0>(image, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetKernelInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetKernelInfo<T0>(kernel, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetKernelWorkGroupInfo<T0>(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemObjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetMemObjectInfo(memobj, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetMemObjectInfo<T0>(memobj, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformIDs")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* platforms, [Flow(FlowDirection.Out)] uint* num_platforms)
            => ImplGetPlatformIDs(num_entries, platforms, num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformIDs")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms)
            => ImplGetPlatformIDs(num_entries, platforms, num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPlatformInfo([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetPlatformInfo(platform, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetPlatformInfo<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetPlatformInfo<T0>(platform, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramBuildInfo([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetProgramBuildInfo(program, device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetProgramBuildInfo<T0>(program, device, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramInfo([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetProgramInfo(program, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramInfo<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetProgramInfo<T0>(program, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSamplerInfo([Flow(FlowDirection.In)] IntPtr sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetSamplerInfo(sampler, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetSamplerInfo<T0>([Flow(FlowDirection.In)] IntPtr sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetSamplerInfo<T0>(sampler, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSupportedImageFormats([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats)
            => ImplGetSupportedImageFormats(context, flags, image_type, num_entries, image_formats, num_image_formats);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetSupportedImageFormats([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats)
            => ImplGetSupportedImageFormats(context, flags, image_type, num_entries, image_formats, num_image_formats);

        [NativeApi(EntryPoint = "clReleaseCommandQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseCommandQueue([Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplReleaseCommandQueue(command_queue);

        [NativeApi(EntryPoint = "clReleaseContext")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseContext([Flow(FlowDirection.In)] IntPtr context)
            => ImplReleaseContext(context);

        [NativeApi(EntryPoint = "clReleaseEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseEvent([Flow(FlowDirection.In)] IntPtr @event)
            => ImplReleaseEvent(@event);

        [NativeApi(EntryPoint = "clReleaseKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseKernel([Flow(FlowDirection.In)] IntPtr kernel)
            => ImplReleaseKernel(kernel);

        [NativeApi(EntryPoint = "clReleaseMemObject")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseMemObject([Flow(FlowDirection.In)] IntPtr memobj)
            => ImplReleaseMemObject(memobj);

        [NativeApi(EntryPoint = "clReleaseProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseProgram([Flow(FlowDirection.In)] IntPtr program)
            => ImplReleaseProgram(program);

        [NativeApi(EntryPoint = "clReleaseSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseSampler([Flow(FlowDirection.In)] IntPtr sampler)
            => ImplReleaseSampler(sampler);

        [NativeApi(EntryPoint = "clRetainCommandQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainCommandQueue([Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplRetainCommandQueue(command_queue);

        [NativeApi(EntryPoint = "clRetainContext")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainContext([Flow(FlowDirection.In)] IntPtr context)
            => ImplRetainContext(context);

        [NativeApi(EntryPoint = "clRetainEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainEvent([Flow(FlowDirection.In)] IntPtr @event)
            => ImplRetainEvent(@event);

        [NativeApi(EntryPoint = "clRetainKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainKernel([Flow(FlowDirection.In)] IntPtr kernel)
            => ImplRetainKernel(kernel);

        [NativeApi(EntryPoint = "clRetainMemObject")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainMemObject([Flow(FlowDirection.In)] IntPtr memobj)
            => ImplRetainMemObject(memobj);

        [NativeApi(EntryPoint = "clRetainProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainProgram([Flow(FlowDirection.In)] IntPtr program)
            => ImplRetainProgram(program);

        [NativeApi(EntryPoint = "clRetainSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainSampler([Flow(FlowDirection.In)] IntPtr sampler)
            => ImplRetainSampler(sampler);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetCommandQueueProperty([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] CLEnum* old_properties)
            => ImplSetCommandQueueProperty(command_queue, properties, enable, old_properties);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetCommandQueueProperty([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] Span<CLEnum> old_properties)
            => ImplSetCommandQueueProperty(command_queue, properties, enable, old_properties);

        [NativeApi(EntryPoint = "clSetKernelArg")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArg([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] UIntPtr arg_size, [Flow(FlowDirection.In)] void* arg_value)
            => ImplSetKernelArg(kernel, arg_index, arg_size, arg_value);

        [NativeApi(EntryPoint = "clSetKernelArg")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetKernelArg<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] UIntPtr arg_size, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
            => ImplSetKernelArg<T0>(kernel, arg_index, arg_size, arg_value);

        [NativeApi(EntryPoint = "clUnloadCompiler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int UnloadCompiler([Flow(FlowDirection.In)] void* unnamedParameter0)
            => ImplUnloadCompiler(unnamedParameter0);

        [NativeApi(EntryPoint = "clUnloadCompiler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int UnloadCompiler<T0>([Flow(FlowDirection.In)] Span<T0> unnamedParameter0) where T0 : unmanaged
            => ImplUnloadCompiler<T0>(unnamedParameter0);

        [NativeApi(EntryPoint = "clWaitForEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list)
            => ImplWaitForEvents(num_events, event_list);

        [NativeApi(EntryPoint = "clWaitForEvents")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list)
            => ImplWaitForEvents(num_events, event_list);

        [NativeApi(EntryPoint = "clBuildProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplBuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clBuildProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int BuildProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplBuildProgram<T0>(program, num_devices, device_list, options, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCreateKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateKernel(program, kernel_name, errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateKernel(program, kernel_name, errcode_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] string func_name)
            => ImplGetExtensionFunctionAddress(func_name);

        [NativeApi(EntryPoint = "clCreateSubBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSubBuffer([Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateSubBuffer<T0>([Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] Span<T0> buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateSubBuffer<T0>(buffer, flags, buffer_create_type, buffer_create_info, errcode_ret);

        [NativeApi(EntryPoint = "clCreateUserEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateUserEvent([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateUserEvent(context, errcode_ret);

        [NativeApi(EntryPoint = "clCreateUserEvent")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateUserEvent([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateUserEvent(context, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr src_row_pitch, [Flow(FlowDirection.In)] UIntPtr src_slice_pitch, [Flow(FlowDirection.In)] UIntPtr dst_row_pitch, [Flow(FlowDirection.In)] UIntPtr dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueCopyBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr src_row_pitch, [Flow(FlowDirection.In)] UIntPtr src_slice_pitch, [Flow(FlowDirection.In)] UIntPtr dst_row_pitch, [Flow(FlowDirection.In)] UIntPtr dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_offset, host_offset, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueReadBufferRect<T0>(command_queue, buffer, blocking_read, buffer_offset, host_offset, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_offset, host_offset, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueWriteBufferRect<T0>(command_queue, buffer, blocking_write, buffer_offset, host_offset, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clSetEventCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetEventCallback([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplSetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetEventCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetEventCallback<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplSetEventCallback<T0>(@event, command_exec_callback_type, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetMemObjectDestructorCallback([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplSetMemObjectDestructorCallback(memobj, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetMemObjectDestructorCallback<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplSetMemObjectDestructorCallback<T0>(memobj, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetUserEventStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetUserEventStatus([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int execution_status)
            => ImplSetUserEventStatus(@event, execution_status);

        [NativeApi(EntryPoint = "clCompileProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplCompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCompileProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplCompileProgram<T0>(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCreateImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateImage(context, flags, image_format, image_desc, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateImage<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateImage<T0>(context, flags, image_format, image_desc, host_ptr, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
            => ImplCreateSubDevices(in_device, properties, num_devices, out_devices, num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
            => ImplCreateSubDevices(in_device, properties, num_devices, out_devices, num_devices_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueFillBuffer(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] Span<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueFillBuffer<T0>(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueFillImage(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueFillImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<T0> fill_color, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueFillImage<T0>(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] char* func_name)
            => ImplGetExtensionFunctionAddressForPlatform(platform, func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] Span<char> func_name)
            => ImplGetExtensionFunctionAddressForPlatform(platform, func_name);

        [NativeApi(EntryPoint = "clGetKernelArgInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelArgInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelArgInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetKernelArgInfo<T0>(kernel, arg_index, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clLinkProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplLinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplLinkProgram<T0>(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clReleaseDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseDevice([Flow(FlowDirection.In)] IntPtr device)
            => ImplReleaseDevice(device);

        [NativeApi(EntryPoint = "clRetainDevice")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainDevice([Flow(FlowDirection.In)] IntPtr device)
            => ImplRetainDevice(device);

        [NativeApi(EntryPoint = "clUnloadPlatformCompiler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int UnloadPlatformCompiler([Flow(FlowDirection.In)] IntPtr platform)
            => ImplUnloadPlatformCompiler(platform);

        [NativeApi(EntryPoint = "clCompileProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplCompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCompileProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplCompileProgram<T0>(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateProgramWithBuiltInKernel(context, num_devices, device_list, kernel_names, errcode_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] string func_name)
            => ImplGetExtensionFunctionAddressForPlatform(platform, func_name);

        [NativeApi(EntryPoint = "clLinkProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplLinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplLinkProgram<T0>(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateCommandQueueWithProperties(context, device, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateCommandQueueWithProperties(context, device, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreatePipe([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreatePipe([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateSamplerWithProperties(context, sampler_properties, errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<CLEnum> sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateSamplerWithProperties(context, sampler_properties, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMFree")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmfree([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueSvmfree<T0, T1>(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueSvmmap<T0>(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueSvmmemcpy<T0, T1>(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueSvmmemFill<T0, T1>(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmunmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueSvmunmap<T0>(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetPipeInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPipeInfo([Flow(FlowDirection.In)] IntPtr pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetPipeInfo(pipe, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPipeInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetPipeInfo<T0>([Flow(FlowDirection.In)] IntPtr pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
            => ImplGetPipeInfo<T0>(pipe, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgSvmpointer([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
            => ImplSetKernelArgSvmpointer(kernel, arg_index, arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
            => ImplSetKernelArgSvmpointer<T0>(kernel, arg_index, arg_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelExecInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] void* param_value)
            => ImplSetKernelExecInfo(kernel, param_name, param_value_size, param_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged
            => ImplSetKernelExecInfo<T0>(kernel, param_name, param_value_size, param_value);

        [NativeApi(EntryPoint = "clSVMAlloc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* Svmalloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment)
            => ImplSvmalloc(context, flags, size, alignment);

        [NativeApi(EntryPoint = "clSVMFree")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Svmfree([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] void* svm_pointer)
            => ImplSvmfree(context, svm_pointer);

        [NativeApi(EntryPoint = "clSVMFree")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Svmfree<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
            => ImplSvmfree<T0>(context, svm_pointer);

        [NativeApi(EntryPoint = "clCreateProgramWithIL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateProgramWithIL(context, il, length, errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithIL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplCreateProgramWithIL<T0>(context, il, length, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] UIntPtr* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueSvmmigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] Span<UIntPtr> sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueSvmmigrateMem<T0>(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceAndHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp)
            => ImplGetDeviceAndHostTimer(device, device_timestamp, host_timestamp);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetDeviceAndHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
            => ImplGetDeviceAndHostTimer(device, device_timestamp, host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] ulong* host_timestamp)
            => ImplGetHostTimer(device, host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
            => ImplGetHostTimer(device, host_timestamp);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelSubGroupInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
            => ImplGetKernelSubGroupInfo<T0, T1>(kernel, device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clCloneKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr OneKernel([Flow(FlowDirection.In)] IntPtr source_kernel, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplOneKernel(source_kernel, errcode_ret);

        [NativeApi(EntryPoint = "clCloneKernel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr OneKernel([Flow(FlowDirection.In)] IntPtr source_kernel, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplOneKernel(source_kernel, errcode_ret);

        [NativeApi(EntryPoint = "clSetDefaultDeviceCommandQueue")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetDefaultDeviceCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] IntPtr command_queue)
            => ImplSetDefaultDeviceCommandQueue(context, device, command_queue);

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramReleaseCallback([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
            => ImplSetProgramReleaseCallback(program, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetProgramReleaseCallback<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
            => ImplSetProgramReleaseCallback<T0>(program, pfn_notify, user_data);

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramSpecializationConstant([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] UIntPtr spec_size, [Flow(FlowDirection.In)] void* spec_value)
            => ImplSetProgramSpecializationConstant(program, spec_id, spec_size, spec_value);

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetProgramSpecializationConstant<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] UIntPtr spec_size, [Flow(FlowDirection.In)] Span<T0> spec_value) where T0 : unmanaged
            => ImplSetProgramSpecializationConstant<T0>(program, spec_id, spec_size, spec_value);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateBuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateBuffer(new IntPtr(context), flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateBuffer<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateBuffer(new IntPtr(context), flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueue(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueue(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage2D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_row_pitch), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage2D<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage2D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_row_pitch), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_depth, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.In)] uint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage3D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_depth), new UIntPtr(image_row_pitch), new UIntPtr(image_slice_pitch), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage3D<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_depth, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.In)] uint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage3D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_depth), new UIntPtr(image_row_pitch), new UIntPtr(image_slice_pitch), host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] char* kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] Span<char> kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateKernelsInProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] IntPtr* kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret)
        {
            // IntPtrOverloader
            return CreateKernelsInProgram(new IntPtr(program), num_kernels, kernels, num_kernels_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateKernelsInProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<IntPtr> kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret)
        {
            // IntPtrOverloader
            return CreateKernelsInProgram(new IntPtr(program), num_kernels, kernels, num_kernels_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBinary(new IntPtr(context), num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.MarshalStringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) binaries, binariesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBinary(new IntPtr(context), num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.MarshalStringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) binaries, binariesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithSource(new IntPtr(context), count, strings, lengths, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithSource(new IntPtr(context), count, strings, lengths, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSampler([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSampler(new IntPtr(context), normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSampler([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateSampler(new IntPtr(context), normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueBarrier([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return EnqueueBarrier(new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBuffer(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), new UIntPtr(src_offset), new UIntPtr(dst_offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBuffer(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), new UIntPtr(src_offset), new UIntPtr(dst_offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferToImage(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_image), new UIntPtr(src_offset), dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferToImage(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_image), new UIntPtr(src_offset), dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImage(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImage(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImageToBuffer(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_buffer), src_origin, region, new UIntPtr(dst_offset), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImageToBuffer(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_buffer), src_origin, region, new UIntPtr(dst_offset), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_map, map_flags, new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_map, map_flags, new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.Out)] UIntPtr* image_row_pitch, [Flow(FlowDirection.Out)] UIntPtr* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapImage(new IntPtr(command_queue), new IntPtr(image), blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.Out)] Span<UIntPtr> image_row_pitch, [Flow(FlowDirection.Out)] Span<UIntPtr> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapImage(new IntPtr(command_queue), new IntPtr(image), blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarker([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMarker(new IntPtr(command_queue), @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarker([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMarker(new IntPtr(command_queue), @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueNdrangeKernel([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] UIntPtr* global_work_offset, [Flow(FlowDirection.In)] UIntPtr* global_work_size, [Flow(FlowDirection.In)] UIntPtr* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueNdrangeKernel(new IntPtr(command_queue), new IntPtr(kernel), work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueNdrangeKernel([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_offset, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_size, [Flow(FlowDirection.In)] Span<UIntPtr> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueNdrangeKernel(new IntPtr(command_queue), new IntPtr(kernel), work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint row_pitch, [Flow(FlowDirection.In)] uint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadImage(new IntPtr(command_queue), new IntPtr(image), blocking_read, origin, region, new UIntPtr(row_pitch), new UIntPtr(slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint row_pitch, [Flow(FlowDirection.In)] uint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadImage(new IntPtr(command_queue), new IntPtr(image), blocking_read, origin, region, new UIntPtr(row_pitch), new UIntPtr(slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueTask([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueTask(new IntPtr(command_queue), new IntPtr(kernel), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueTask([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueTask(new IntPtr(command_queue), new IntPtr(kernel), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueUnmapMemObject([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueUnmapMemObject(new IntPtr(command_queue), new IntPtr(memobj), mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueUnmapMemObject(new IntPtr(command_queue), new IntPtr(memobj), mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWaitForEvents([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list)
        {
            // IntPtrOverloader
            return EnqueueWaitForEvents(new IntPtr(command_queue), num_events, event_list);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWaitForEvents([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list)
        {
            // IntPtrOverloader
            return EnqueueWaitForEvents(new IntPtr(command_queue), num_events, event_list);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint input_row_pitch, [Flow(FlowDirection.In)] uint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteImage(new IntPtr(command_queue), new IntPtr(image), blocking_write, origin, region, new UIntPtr(input_row_pitch), new UIntPtr(input_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint input_row_pitch, [Flow(FlowDirection.In)] uint input_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteImage(new IntPtr(command_queue), new IntPtr(image), blocking_write, origin, region, new UIntPtr(input_row_pitch), new UIntPtr(input_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int Finish([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return Finish(new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int Flush([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return Flush(new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetCommandQueueInfo([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetCommandQueueInfo(new IntPtr(command_queue), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetCommandQueueInfo(new IntPtr(command_queue), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetContextInfo([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetContextInfo(new IntPtr(context), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetContextInfo<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetContextInfo(new IntPtr(context), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDs([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDs(new IntPtr(platform), device_type, num_entries, devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDs([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDs(new IntPtr(platform), device_type, num_entries, devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceInfo([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetDeviceInfo(new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceInfo<T0>([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceInfo(new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventInfo([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetEventInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventInfo<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetEventInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventProfilingInfo([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetEventProfilingInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetEventProfilingInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetImageInfo([Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetImageInfo(new IntPtr(image), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetImageInfo<T0>([Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetImageInfo(new IntPtr(image), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelWorkGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelWorkGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemObjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetMemObjectInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetMemObjectInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPlatformInfo([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetPlatformInfo(new IntPtr(platform), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPlatformInfo<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetPlatformInfo(new IntPtr(platform), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramBuildInfo([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetProgramBuildInfo(new IntPtr(program), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetProgramBuildInfo(new IntPtr(program), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramInfo([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetProgramInfo(new IntPtr(program), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramInfo<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetProgramInfo(new IntPtr(program), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSamplerInfo([Flow(FlowDirection.In)] int sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetSamplerInfo(new IntPtr(sampler), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSamplerInfo<T0>([Flow(FlowDirection.In)] int sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetSamplerInfo(new IntPtr(sampler), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSupportedImageFormats([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats)
        {
            // IntPtrOverloader
            return GetSupportedImageFormats(new IntPtr(context), flags, image_type, num_entries, image_formats, num_image_formats);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSupportedImageFormats([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats)
        {
            // IntPtrOverloader
            return GetSupportedImageFormats(new IntPtr(context), flags, image_type, num_entries, image_formats, num_image_formats);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseCommandQueue([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return ReleaseCommandQueue(new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseContext([Flow(FlowDirection.In)] int context)
        {
            // IntPtrOverloader
            return ReleaseContext(new IntPtr(context));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseEvent([Flow(FlowDirection.In)] int @event)
        {
            // IntPtrOverloader
            return ReleaseEvent(new IntPtr(@event));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseKernel([Flow(FlowDirection.In)] int kernel)
        {
            // IntPtrOverloader
            return ReleaseKernel(new IntPtr(kernel));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseMemObject([Flow(FlowDirection.In)] int memobj)
        {
            // IntPtrOverloader
            return ReleaseMemObject(new IntPtr(memobj));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseProgram([Flow(FlowDirection.In)] int program)
        {
            // IntPtrOverloader
            return ReleaseProgram(new IntPtr(program));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseSampler([Flow(FlowDirection.In)] int sampler)
        {
            // IntPtrOverloader
            return ReleaseSampler(new IntPtr(sampler));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainCommandQueue([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return RetainCommandQueue(new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainContext([Flow(FlowDirection.In)] int context)
        {
            // IntPtrOverloader
            return RetainContext(new IntPtr(context));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainEvent([Flow(FlowDirection.In)] int @event)
        {
            // IntPtrOverloader
            return RetainEvent(new IntPtr(@event));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainKernel([Flow(FlowDirection.In)] int kernel)
        {
            // IntPtrOverloader
            return RetainKernel(new IntPtr(kernel));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainMemObject([Flow(FlowDirection.In)] int memobj)
        {
            // IntPtrOverloader
            return RetainMemObject(new IntPtr(memobj));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainProgram([Flow(FlowDirection.In)] int program)
        {
            // IntPtrOverloader
            return RetainProgram(new IntPtr(program));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainSampler([Flow(FlowDirection.In)] int sampler)
        {
            // IntPtrOverloader
            return RetainSampler(new IntPtr(sampler));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetCommandQueueProperty([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] CLEnum* old_properties)
        {
            // IntPtrOverloader
            return SetCommandQueueProperty(new IntPtr(command_queue), properties, enable, old_properties);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetCommandQueueProperty([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] Span<CLEnum> old_properties)
        {
            // IntPtrOverloader
            return SetCommandQueueProperty(new IntPtr(command_queue), properties, enable, old_properties);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArg([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint arg_size, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArg(new IntPtr(kernel), arg_index, new UIntPtr(arg_size), arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArg<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint arg_size, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArg(new IntPtr(kernel), arg_index, new UIntPtr(arg_size), arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int BuildProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSubBuffer([Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSubBuffer(new IntPtr(buffer), flags, buffer_create_type, buffer_create_info, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSubBuffer<T0>([Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] Span<T0> buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateSubBuffer(new IntPtr(buffer), flags, buffer_create_type, buffer_create_info, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateUserEvent([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateUserEvent(new IntPtr(context), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateUserEvent([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateUserEvent(new IntPtr(context), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint src_row_pitch, [Flow(FlowDirection.In)] uint src_slice_pitch, [Flow(FlowDirection.In)] uint dst_row_pitch, [Flow(FlowDirection.In)] uint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferRect(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), src_origin, dst_origin, region, new UIntPtr(src_row_pitch), new UIntPtr(src_slice_pitch), new UIntPtr(dst_row_pitch), new UIntPtr(dst_slice_pitch), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueCopyBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint src_row_pitch, [Flow(FlowDirection.In)] uint src_slice_pitch, [Flow(FlowDirection.In)] uint dst_row_pitch, [Flow(FlowDirection.In)] uint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferRect(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), src_origin, dst_origin, region, new UIntPtr(src_row_pitch), new UIntPtr(src_slice_pitch), new UIntPtr(dst_row_pitch), new UIntPtr(dst_slice_pitch), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetEventCallback([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetEventCallback(new IntPtr(@event), command_exec_callback_type, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetEventCallback<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetEventCallback(new IntPtr(@event), command_exec_callback_type, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetMemObjectDestructorCallback([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetMemObjectDestructorCallback(new IntPtr(memobj), pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetMemObjectDestructorCallback<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetMemObjectDestructorCallback(new IntPtr(memobj), pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetUserEventStatus([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int execution_status)
        {
            // IntPtrOverloader
            return SetUserEventStatus(new IntPtr(@event), execution_status);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(context), flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateImage<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(context), flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_devices, out_devices, num_devices_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_devices, out_devices, num_devices_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueBarrierWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueBarrierWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueFillBuffer(new IntPtr(command_queue), new IntPtr(buffer), pattern, new UIntPtr(pattern_size), new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] Span<T0> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueFillBuffer(new IntPtr(command_queue), new IntPtr(buffer), pattern, new UIntPtr(pattern_size), new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueFillImage(new IntPtr(command_queue), new IntPtr(image), fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueFillImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<T0> fill_color, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueFillImage(new IntPtr(command_queue), new IntPtr(image), fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMarkerWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMarkerWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObjects(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObjects(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] char* func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] Span<char> func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelArgInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelArgInfo(new IntPtr(kernel), arg_index, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelArgInfo(new IntPtr(kernel), arg_index, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return ReleaseDevice(new IntPtr(device));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return RetainDevice(new IntPtr(device));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int UnloadPlatformCompiler([Flow(FlowDirection.In)] int platform)
        {
            // IntPtrOverloader
            return UnloadPlatformCompiler(new IntPtr(platform));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] string func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreatePipe([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreatePipe(new IntPtr(context), flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreatePipe([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreatePipe(new IntPtr(context), flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSamplerWithProperties(new IntPtr(context), sampler_properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<CLEnum> sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateSamplerWithProperties(new IntPtr(context), sampler_properties, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmfree([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemcpy([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemFill([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmunmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPipeInfo([Flow(FlowDirection.In)] int pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetPipeInfo(new IntPtr(pipe), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetPipeInfo<T0>([Flow(FlowDirection.In)] int pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetPipeInfo(new IntPtr(pipe), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgSvmpointer([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelExecInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] void* param_value)
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* Svmalloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // IntPtrOverloader
            return Svmalloc(new IntPtr(context), flags, new UIntPtr(size), alignment);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Svmfree([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] void* svm_pointer)
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Svmfree<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceAndHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp)
        {
            // IntPtrOverloader
            return GetDeviceAndHostTimer(new IntPtr(device), device_timestamp, host_timestamp);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceAndHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // IntPtrOverloader
            return GetDeviceAndHostTimer(new IntPtr(device), device_timestamp, host_timestamp);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] ulong* host_timestamp)
        {
            // IntPtrOverloader
            return GetHostTimer(new IntPtr(device), host_timestamp);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // IntPtrOverloader
            return GetHostTimer(new IntPtr(device), host_timestamp);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelSubGroupInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr OneKernel([Flow(FlowDirection.In)] int source_kernel, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return OneKernel(new IntPtr(source_kernel), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr OneKernel([Flow(FlowDirection.In)] int source_kernel, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return OneKernel(new IntPtr(source_kernel), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetDefaultDeviceCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return SetDefaultDeviceCommandQueue(new IntPtr(context), new IntPtr(device), new IntPtr(command_queue));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramReleaseCallback([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetProgramReleaseCallback(new IntPtr(program), pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramReleaseCallback<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetProgramReleaseCallback(new IntPtr(program), pfn_notify, user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramSpecializationConstant([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] uint spec_size, [Flow(FlowDirection.In)] void* spec_value)
        {
            // IntPtrOverloader
            return SetProgramSpecializationConstant(new IntPtr(program), spec_id, new UIntPtr(spec_size), spec_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetProgramSpecializationConstant<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] uint spec_size, [Flow(FlowDirection.In)] Span<T0> spec_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetProgramSpecializationConstant(new IntPtr(program), spec_id, new UIntPtr(spec_size), spec_value);
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new OpenCLLibraryNameContainer();

        public CL(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

