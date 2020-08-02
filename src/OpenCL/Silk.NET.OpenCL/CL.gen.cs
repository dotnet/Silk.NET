// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public unsafe partial class CL : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_BIT")]
        public const int CharBit = 8;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MAX")]
        public const int CharMax = 127;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MIN")]
        public const int CharMin = -127 - 1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_DIG")]
        public const double DblDig = 15;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_EPSILON")]
        public const double DblEpsilon = 2.220446049250313080847e-16;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MANT_DIG")]
        public const double DblMantDig = 53;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX")]
        public const double DblMax = 1.7976931348623158e+308;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_10_EXP")]
        public const double DblMax10Exp = +308;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_EXP")]
        public const double DblMaxExp = +1024;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN")]
        public const double DblMin = 2.225073858507201383090e-308;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN_10_EXP")]
        public const double DblMin10Exp = -307;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN_EXP")]
        public const double DblMinExp = -1021;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_RADIX")]
        public const double DblRadix = 2;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_LIST_END")]
        public const int DevicePartitionByCountsListEnd = 0x0;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_DIG")]
        public const float FltDig = 6;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_EPSILON")]
        public const float FltEpsilon = 1.1920928955078125e-7f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MANT_DIG")]
        public const float FltMantDig = 24;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX")]
        public const float FltMax = 340282346638528859811704183484516925440.0f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_10_EXP")]
        public const float FltMax10Exp = +38;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_EXP")]
        public const float FltMaxExp = +128;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN")]
        public const float FltMin = 1.175494350822287507969e-38f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN_10_EXP")]
        public const float FltMin10Exp = -37;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN_EXP")]
        public const float FltMinExp = -125;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_RADIX")]
        public const float FltRadix = 2;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_DIG")]
        public const short HalfDig = 3;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_EPSILON")]
        public const short HalfEpsilon = unchecked((short)9.765625e-04f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MANT_DIG")]
        public const short HalfMantDig = 11;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX")]
        public const short HalfMax = unchecked((short)65504.0f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_10_EXP")]
        public const short HalfMax10Exp = +4;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_EXP")]
        public const short HalfMaxExp = +16;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN")]
        public const short HalfMin = unchecked((short)6.103515625e-05f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_10_EXP")]
        public const short HalfMin10Exp = -4;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_EXP")]
        public const short HalfMinExp = -13;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_RADIX")]
        public const short HalfRadix = 2;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VAL")]
        public const double HugeVal = double.PositiveInfinity;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VALF")]
        public const float HugeValf = (float) 1e50;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INFINITY")]
        public const float Infinity = float.PositiveInfinity;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MAX")]
        public const int IntMax = 2147483647;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MIN")]
        public const int IntMin = -2147483647 - 1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MAX")]
        public const long LongMax = 0x7FFFFFFFFFFFFFFFL;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MIN")]
        public const long LongMin = -0x7FFFFFFFFFFFFFFFL - 1L;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_1_PI")]
        public const double M1PI = 0.31830988618379067154;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_1_PI_F")]
        public const float M1PIF = 0.318309886f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_PI")]
        public const double M2PI = 0.63661977236758134308;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_PI_F")]
        public const float M2PIF = 0.636619772f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_SQRTPI")]
        public const double M2Sqrtpi = 1.12837916709551257390;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_SQRTPI_F")]
        public const float M2SqrtpiF = 1.128379167f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_MAXFLOAT")]
        public const float Maxfloat = float.MaxValue;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_E")]
        public const double ME = 2.7182818284590452354;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_E_F")]
        public const float MEF = 2.718281828f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN10")]
        public const double MLN10 = 2.30258509299404568402;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN10_F")]
        public const float MLN10F = 2.302585093f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN2")]
        public const double MLN2 = 0.69314718055994530942;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN2_F")]
        public const float MLN2F = 0.693147181f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG10E")]
        public const double MLog10E = 0.43429448190325182765;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG10E_F")]
        public const float MLog10EF = 0.434294482f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG2E")]
        public const double MLog2E = 1.4426950408889634074;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG2E_F")]
        public const float MLog2EF = 1.442695041f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI")]
        public const double MPI = 3.14159265358979323846;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_2")]
        public const double MPI2 = 1.57079632679489661923;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_2_F")]
        public const float MPI2F = 1.570796327f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_4")]
        public const double MPI4 = 0.78539816339744830962;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_4_F")]
        public const float MPI4F = 0.785398163f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_F")]
        public const float MPIF = 3.141592654f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT1_2")]
        public const double MSqrt12 = 0.70710678118654752440;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT1_2_F")]
        public const float MSqrt12F = 0.707106781f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT2")]
        public const double MSqrt2 = 1.41421356237309504880;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT2_F")]
        public const float MSqrt2F = 1.414213562f;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE")]
        public const int NameVersionMaxNameSize = 64;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_NAN")]
        public const float Nan = float.NaN;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_COUNTS_LIST_END_EXT")]
        public const int PartitionByCountsListEndExt = 0;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_EXT")]
        public const int PartitionByNamesListEndExt = 0 - 1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_INTEL")]
        public const int PartitionByNamesListEndIntel = -1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PROPERTIES_LIST_END_EXT")]
        public const int PropertiesListEndExt = 0;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MAX")]
        public const int ScharMax = 127;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MIN")]
        public const int ScharMin = -127 - 1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MAX")]
        public const short ShrtMax = 32767;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MIN")]
        public const short ShrtMin = -32767 - 1;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UCHAR_MAX")]
        public const int UcharMax = 255;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UINT_MAX")]
        public const uint UintMax = 0xffffffffU;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_ULONG_MAX")]
        public const ulong UlongMax = 0xFFFFFFFFFFFFFFFFUL;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_USHRT_MAX")]
        public const ushort UshrtMax = 65535;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MAJOR_BITS")]
        public const int VersionMajorBits = 10;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MINOR_BITS")]
        public const int VersionMinorBits = 10;
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_PATCH_BITS")]
        public const int VersionPatchBits = 12;

        [NativeApi(EntryPoint = "clCreateBufferWithProperties")]
        public unsafe partial IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties")]
        public partial IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties")]
        public unsafe partial IntPtr CreateImageWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties")]
        public partial IntPtr CreateImageWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetContextDestructorCallback")]
        public unsafe partial int SetContextDestructorCallback([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetContextDestructorCallback")]
        public partial int SetContextDestructorCallback<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback")]
        public unsafe partial int SetProgramReleaseCallback([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback")]
        public partial int SetProgramReleaseCallback<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant")]
        public unsafe partial int SetProgramSpecializationConstant([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] UIntPtr spec_size, [Flow(FlowDirection.In)] void* spec_value);

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant")]
        public partial int SetProgramSpecializationConstant<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] UIntPtr spec_size, [Flow(FlowDirection.In)] Span<T0> spec_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithIL")]
        public unsafe partial IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithIL")]
        public partial IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem")]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] UIntPtr* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem")]
        public unsafe partial int EnqueueSvmmigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] Span<UIntPtr> sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer")]
        public unsafe partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer")]
        public partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer")]
        public unsafe partial int GetHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer")]
        public partial int GetHostTimer([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo")]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo")]
        public partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clCloneKernel")]
        public unsafe partial IntPtr OneKernel([Flow(FlowDirection.In)] IntPtr source_kernel, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCloneKernel")]
        public partial IntPtr OneKernel([Flow(FlowDirection.In)] IntPtr source_kernel, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clSetDefaultDeviceCommandQueue")]
        public partial int SetDefaultDeviceCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties")]
        public unsafe partial IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties")]
        public partial IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe")]
        public unsafe partial IntPtr CreatePipe([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe")]
        public partial IntPtr CreatePipe([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties")]
        public unsafe partial IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties")]
        public partial IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<CLEnum> sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMFree")]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree")]
        public partial int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMap")]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap")]
        public partial int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy")]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy")]
        public partial int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill")]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill")]
        public partial int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap")]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap")]
        public partial int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPipeInfo")]
        public unsafe partial int GetPipeInfo([Flow(FlowDirection.In)] IntPtr pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPipeInfo")]
        public partial int GetPipeInfo<T0>([Flow(FlowDirection.In)] IntPtr pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer")]
        public unsafe partial int SetKernelArgSvmpointer([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer")]
        public partial int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelExecInfo")]
        public unsafe partial int SetKernelExecInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] void* param_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfo")]
        public partial int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSVMAlloc")]
        public unsafe partial void* Svmalloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment);

        [NativeApi(EntryPoint = "clSVMFree")]
        public unsafe partial void Svmfree([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] void* svm_pointer);

        [NativeApi(EntryPoint = "clSVMFree")]
        public partial void Svmfree<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram")]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram")]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage")]
        public unsafe partial IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage")]
        public partial IntPtr CreateImage<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public unsafe partial IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public partial IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices")]
        public partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList")]
        public unsafe partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList")]
        public partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer")]
        public unsafe partial int EnqueueFillBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer")]
        public partial int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] Span<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage")]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage")]
        public partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<T0> fill_color, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList")]
        public unsafe partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList")]
        public partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects")]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects")]
        public partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] char* func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] Span<char> func_name);

        [NativeApi(EntryPoint = "clGetKernelArgInfo")]
        public unsafe partial int GetKernelArgInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelArgInfo")]
        public partial int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram")]
        public unsafe partial IntPtr LinkProgram([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram")]
        public partial IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseDevice")]
        public partial int ReleaseDevice([Flow(FlowDirection.In)] IntPtr device);

        [NativeApi(EntryPoint = "clRetainDevice")]
        public partial int RetainDevice([Flow(FlowDirection.In)] IntPtr device);

        [NativeApi(EntryPoint = "clUnloadPlatformCompiler")]
        public partial int UnloadPlatformCompiler([Flow(FlowDirection.In)] IntPtr platform);

        [NativeApi(EntryPoint = "clCompileProgram")]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram")]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public unsafe partial IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public partial IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] string func_name);

        [NativeApi(EntryPoint = "clLinkProgram")]
        public unsafe partial IntPtr LinkProgram([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram")]
        public partial IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateSubBuffer")]
        public unsafe partial IntPtr CreateSubBuffer([Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubBuffer")]
        public partial IntPtr CreateSubBuffer<T0>([Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] Span<T0> buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateUserEvent")]
        public unsafe partial IntPtr CreateUserEvent([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateUserEvent")]
        public partial IntPtr CreateUserEvent([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect")]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr src_row_pitch, [Flow(FlowDirection.In)] UIntPtr src_slice_pitch, [Flow(FlowDirection.In)] UIntPtr dst_row_pitch, [Flow(FlowDirection.In)] UIntPtr dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect")]
        public partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr src_row_pitch, [Flow(FlowDirection.In)] UIntPtr src_slice_pitch, [Flow(FlowDirection.In)] UIntPtr dst_row_pitch, [Flow(FlowDirection.In)] UIntPtr dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect")]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect")]
        public partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect")]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect")]
        public partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr buffer_row_pitch, [Flow(FlowDirection.In)] UIntPtr buffer_slice_pitch, [Flow(FlowDirection.In)] UIntPtr host_row_pitch, [Flow(FlowDirection.In)] UIntPtr host_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetEventCallback")]
        public unsafe partial int SetEventCallback([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetEventCallback")]
        public partial int SetEventCallback<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback")]
        public unsafe partial int SetMemObjectDestructorCallback([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback")]
        public partial int SetMemObjectDestructorCallback<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetUserEventStatus")]
        public partial int SetUserEventStatus([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] int execution_status);

        [NativeApi(EntryPoint = "clBuildProgram")]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram")]
        public partial int BuildProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBuffer")]
        public unsafe partial IntPtr CreateBuffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBuffer")]
        public partial IntPtr CreateBuffer<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateCommandQueue")]
        public unsafe partial IntPtr CreateCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueue")]
        public partial IntPtr CreateCommandQueue([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext")]
        public unsafe partial IntPtr CreateContext([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext")]
        public partial IntPtr CreateContext<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContextFromType")]
        public unsafe partial IntPtr CreateContextFromType([Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType")]
        public partial IntPtr CreateContextFromType<T0>([Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage2D")]
        public unsafe partial IntPtr CreateImage2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D")]
        public partial IntPtr CreateImage2D<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage3D")]
        public unsafe partial IntPtr CreateImage3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_depth, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.In)] UIntPtr image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D")]
        public partial IntPtr CreateImage3D<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] UIntPtr image_depth, [Flow(FlowDirection.In)] UIntPtr image_row_pitch, [Flow(FlowDirection.In)] UIntPtr image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateKernel")]
        public unsafe partial IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] char* kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel")]
        public partial IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] Span<char> kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram")]
        public unsafe partial int CreateKernelsInProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] IntPtr* kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram")]
        public partial int CreateKernelsInProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<IntPtr> kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary")]
        public unsafe partial IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary")]
        public unsafe partial IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource")]
        public unsafe partial IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource")]
        public unsafe partial IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler")]
        public unsafe partial IntPtr CreateSampler([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler")]
        public partial IntPtr CreateSampler([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrier")]
        public partial int EnqueueBarrier([Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer")]
        public unsafe partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer")]
        public partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage")]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage")]
        public partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_buffer, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr src_offset, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage")]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage")]
        public partial int EnqueueCopyImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_image, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer")]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer")]
        public partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr src_image, [Flow(FlowDirection.In)] IntPtr dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer")]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer")]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage")]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.Out)] UIntPtr* image_row_pitch, [Flow(FlowDirection.Out)] UIntPtr* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage")]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.Out)] Span<UIntPtr> image_row_pitch, [Flow(FlowDirection.Out)] Span<UIntPtr> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMarker")]
        public unsafe partial int EnqueueMarker([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMarker")]
        public partial int EnqueueMarker([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel")]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] FuncPtr user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] UIntPtr cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel")]
        public unsafe partial int EnqueueNativeKernel<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] FuncPtr user_func, [Flow(FlowDirection.Out)] Span<T0> args, [Flow(FlowDirection.In)] UIntPtr cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel")]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] UIntPtr* global_work_offset, [Flow(FlowDirection.In)] UIntPtr* global_work_size, [Flow(FlowDirection.In)] UIntPtr* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel")]
        public partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_offset, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_size, [Flow(FlowDirection.In)] Span<UIntPtr> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer")]
        public unsafe partial int EnqueueReadBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer")]
        public partial int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage")]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr row_pitch, [Flow(FlowDirection.In)] UIntPtr slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage")]
        public partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr row_pitch, [Flow(FlowDirection.In)] UIntPtr slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueTask")]
        public unsafe partial int EnqueueTask([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueTask")]
        public partial int EnqueueTask([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject")]
        public unsafe partial int EnqueueUnmapMemObject([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject")]
        public partial int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents")]
        public unsafe partial int EnqueueWaitForEvents([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list);

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents")]
        public partial int EnqueueWaitForEvents([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer")]
        public unsafe partial int EnqueueWriteBuffer([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer")]
        public partial int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage")]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] UIntPtr input_row_pitch, [Flow(FlowDirection.In)] UIntPtr input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage")]
        public partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] UIntPtr input_row_pitch, [Flow(FlowDirection.In)] UIntPtr input_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clFinish")]
        public partial int Finish([Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clFlush")]
        public partial int Flush([Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo")]
        public unsafe partial int GetCommandQueueInfo([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo")]
        public partial int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetContextInfo")]
        public unsafe partial int GetContextInfo([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo")]
        public partial int GetContextInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDs")]
        public unsafe partial int GetDeviceIDs([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDs")]
        public partial int GetDeviceIDs([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices);

        [NativeApi(EntryPoint = "clGetDeviceInfo")]
        public unsafe partial int GetDeviceInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceInfo")]
        public partial int GetDeviceInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventInfo")]
        public unsafe partial int GetEventInfo([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo")]
        public partial int GetEventInfo<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventProfilingInfo")]
        public unsafe partial int GetEventProfilingInfo([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo")]
        public partial int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] IntPtr @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] char* func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] Span<char> func_name);

        [NativeApi(EntryPoint = "clGetImageInfo")]
        public unsafe partial int GetImageInfo([Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetImageInfo")]
        public partial int GetImageInfo<T0>([Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelInfo")]
        public unsafe partial int GetKernelInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo")]
        public partial int GetKernelInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo")]
        public unsafe partial int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo")]
        public partial int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemObjectInfo")]
        public unsafe partial int GetMemObjectInfo([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo")]
        public partial int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] IntPtr memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPlatformIDs")]
        public unsafe partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformIDs")]
        public partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformInfo")]
        public unsafe partial int GetPlatformInfo([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformInfo")]
        public partial int GetPlatformInfo<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramBuildInfo")]
        public unsafe partial int GetProgramBuildInfo([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo")]
        public partial int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramInfo")]
        public unsafe partial int GetProgramInfo([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo")]
        public partial int GetProgramInfo<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSamplerInfo")]
        public unsafe partial int GetSamplerInfo([Flow(FlowDirection.In)] IntPtr sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo")]
        public partial int GetSamplerInfo<T0>([Flow(FlowDirection.In)] IntPtr sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSupportedImageFormats")]
        public unsafe partial int GetSupportedImageFormats([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats")]
        public partial int GetSupportedImageFormats([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats);

        [NativeApi(EntryPoint = "clReleaseCommandQueue")]
        public partial int ReleaseCommandQueue([Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clReleaseContext")]
        public partial int ReleaseContext([Flow(FlowDirection.In)] IntPtr context);

        [NativeApi(EntryPoint = "clReleaseEvent")]
        public partial int ReleaseEvent([Flow(FlowDirection.In)] IntPtr @event);

        [NativeApi(EntryPoint = "clReleaseKernel")]
        public partial int ReleaseKernel([Flow(FlowDirection.In)] IntPtr kernel);

        [NativeApi(EntryPoint = "clReleaseMemObject")]
        public partial int ReleaseMemObject([Flow(FlowDirection.In)] IntPtr memobj);

        [NativeApi(EntryPoint = "clReleaseProgram")]
        public partial int ReleaseProgram([Flow(FlowDirection.In)] IntPtr program);

        [NativeApi(EntryPoint = "clReleaseSampler")]
        public partial int ReleaseSampler([Flow(FlowDirection.In)] IntPtr sampler);

        [NativeApi(EntryPoint = "clRetainCommandQueue")]
        public partial int RetainCommandQueue([Flow(FlowDirection.In)] IntPtr command_queue);

        [NativeApi(EntryPoint = "clRetainContext")]
        public partial int RetainContext([Flow(FlowDirection.In)] IntPtr context);

        [NativeApi(EntryPoint = "clRetainEvent")]
        public partial int RetainEvent([Flow(FlowDirection.In)] IntPtr @event);

        [NativeApi(EntryPoint = "clRetainKernel")]
        public partial int RetainKernel([Flow(FlowDirection.In)] IntPtr kernel);

        [NativeApi(EntryPoint = "clRetainMemObject")]
        public partial int RetainMemObject([Flow(FlowDirection.In)] IntPtr memobj);

        [NativeApi(EntryPoint = "clRetainProgram")]
        public partial int RetainProgram([Flow(FlowDirection.In)] IntPtr program);

        [NativeApi(EntryPoint = "clRetainSampler")]
        public partial int RetainSampler([Flow(FlowDirection.In)] IntPtr sampler);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty")]
        public unsafe partial int SetCommandQueueProperty([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] CLEnum* old_properties);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty")]
        public partial int SetCommandQueueProperty([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] Span<CLEnum> old_properties);

        [NativeApi(EntryPoint = "clSetKernelArg")]
        public unsafe partial int SetKernelArg([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] UIntPtr arg_size, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArg")]
        public partial int SetKernelArg<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] UIntPtr arg_size, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clUnloadCompiler")]
        public unsafe partial int UnloadCompiler([Flow(FlowDirection.In)] void* unnamedParameter0);

        [NativeApi(EntryPoint = "clUnloadCompiler")]
        public partial int UnloadCompiler<T0>([Flow(FlowDirection.In)] Span<T0> unnamedParameter0) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clWaitForEvents")]
        public unsafe partial int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list);

        [NativeApi(EntryPoint = "clWaitForEvents")]
        public partial int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list);

        [NativeApi(EntryPoint = "clBuildProgram")]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram")]
        public partial int BuildProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateKernel")]
        public unsafe partial IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel")]
        public partial IntPtr CreateKernel([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress")]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] string func_name);

        public unsafe IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateBufferWithProperties(new IntPtr(context), properties, flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateBufferWithProperties(new IntPtr(context), properties, flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImageWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImageWithProperties(new IntPtr(context), properties, flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImageWithProperties<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImageWithProperties(new IntPtr(context), properties, flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        public unsafe int SetContextDestructorCallback([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetContextDestructorCallback(new IntPtr(context), pfn_notify, user_data);
        }

        public unsafe int SetContextDestructorCallback<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetContextDestructorCallback(new IntPtr(context), pfn_notify, user_data);
        }

        public unsafe int SetProgramReleaseCallback([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetProgramReleaseCallback(new IntPtr(program), pfn_notify, user_data);
        }

        public unsafe int SetProgramReleaseCallback<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetProgramReleaseCallback(new IntPtr(program), pfn_notify, user_data);
        }

        public unsafe int SetProgramSpecializationConstant([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] uint spec_size, [Flow(FlowDirection.In)] void* spec_value)
        {
            // IntPtrOverloader
            return SetProgramSpecializationConstant(new IntPtr(program), spec_id, new UIntPtr(spec_size), spec_value);
        }

        public unsafe int SetProgramSpecializationConstant<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] uint spec_size, [Flow(FlowDirection.In)] Span<T0> spec_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetProgramSpecializationConstant(new IntPtr(program), spec_id, new UIntPtr(spec_size), spec_value);
        }

        public unsafe IntPtr CreateProgramWithIL([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithIL<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateProgramWithIL(new IntPtr(context), il, new UIntPtr(length), errcode_ret);
        }

        public unsafe int GetDeviceAndHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp)
        {
            // IntPtrOverloader
            return GetDeviceAndHostTimer(new IntPtr(device), device_timestamp, host_timestamp);
        }

        public unsafe int GetDeviceAndHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] Span<ulong> device_timestamp, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // IntPtrOverloader
            return GetDeviceAndHostTimer(new IntPtr(device), device_timestamp, host_timestamp);
        }

        public unsafe int GetHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] ulong* host_timestamp)
        {
            // IntPtrOverloader
            return GetHostTimer(new IntPtr(device), host_timestamp);
        }

        public unsafe int GetHostTimer([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.Out)] Span<ulong> host_timestamp)
        {
            // IntPtrOverloader
            return GetHostTimer(new IntPtr(device), host_timestamp);
        }

        public unsafe int GetKernelSubGroupInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelSubGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(input_value_size), input_value, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe IntPtr OneKernel([Flow(FlowDirection.In)] int source_kernel, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return OneKernel(new IntPtr(source_kernel), errcode_ret);
        }

        public unsafe IntPtr OneKernel([Flow(FlowDirection.In)] int source_kernel, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return OneKernel(new IntPtr(source_kernel), errcode_ret);
        }

        public unsafe int SetDefaultDeviceCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return SetDefaultDeviceCommandQueue(new IntPtr(context), new IntPtr(device), new IntPtr(command_queue));
        }

        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public unsafe IntPtr CreateCommandQueueWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] Span<CLEnum> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueueWithProperties(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public unsafe IntPtr CreatePipe([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreatePipe(new IntPtr(context), flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        }

        public unsafe IntPtr CreatePipe([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreatePipe(new IntPtr(context), flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        }

        public unsafe IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSamplerWithProperties(new IntPtr(context), sampler_properties, errcode_ret);
        }

        public unsafe IntPtr CreateSamplerWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<CLEnum> sampler_properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateSamplerWithProperties(new IntPtr(context), sampler_properties, errcode_ret);
        }

        public unsafe int EnqueueSvmfree([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemcpy([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemFill([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmunmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int GetPipeInfo([Flow(FlowDirection.In)] int pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetPipeInfo(new IntPtr(pipe), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetPipeInfo<T0>([Flow(FlowDirection.In)] int pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetPipeInfo(new IntPtr(pipe), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int SetKernelArgSvmpointer([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        public unsafe int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        public unsafe int SetKernelExecInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] void* param_value)
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        public unsafe int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        public unsafe void* Svmalloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // IntPtrOverloader
            return Svmalloc(new IntPtr(context), flags, new UIntPtr(size), alignment);
        }

        public unsafe void Svmfree([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] void* svm_pointer)
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        public unsafe void Svmfree<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(context), flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImage<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] Span<ImageDesc> image_desc, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(context), flags, image_format, image_desc, host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_devices, out_devices, num_devices_ret);
        }

        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices_ret)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_devices, out_devices, num_devices_ret);
        }

        public unsafe int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueBarrierWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueBarrierWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueFillBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueFillBuffer(new IntPtr(command_queue), new IntPtr(buffer), pattern, new UIntPtr(pattern_size), new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] Span<T0> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueFillBuffer(new IntPtr(command_queue), new IntPtr(buffer), pattern, new UIntPtr(pattern_size), new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueFillImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueFillImage(new IntPtr(command_queue), new IntPtr(image), fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueFillImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<T0> fill_color, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueFillImage(new IntPtr(command_queue), new IntPtr(image), fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMarkerWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMarkerWithWaitList(new IntPtr(command_queue), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObjects(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMemObjects(new IntPtr(command_queue), num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] char* func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] Span<char> func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        public unsafe int GetKernelArgInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelArgInfo(new IntPtr(kernel), arg_index, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelArgInfo(new IntPtr(kernel), arg_index, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public unsafe IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public unsafe int ReleaseDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return ReleaseDevice(new IntPtr(device));
        }

        public unsafe int RetainDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return RetainDevice(new IntPtr(device));
        }

        public unsafe int UnloadPlatformCompiler([Flow(FlowDirection.In)] int platform)
        {
            // IntPtrOverloader
            return UnloadPlatformCompiler(new IntPtr(platform));
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] IntPtr* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] char** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CompileProgram(new IntPtr(program), num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] IntPtr program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] Span<IntPtr> input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (char**) SilkMarshal.MarshalStringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((IntPtr) header_include_names, header_include_namesSa);
            return ret;
        }

        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string kernel_names, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBuiltInKernel(new IntPtr(context), num_devices, device_list, kernel_names, errcode_ret);
        }

        public unsafe void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] string func_name)
        {
            // IntPtrOverloader
            return GetExtensionFunctionAddressForPlatform(new IntPtr(platform), func_name);
        }

        public unsafe IntPtr LinkProgram([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] IntPtr* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public unsafe IntPtr LinkProgram<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] Span<IntPtr> input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return LinkProgram(new IntPtr(context), num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }

        public unsafe IntPtr CreateSubBuffer([Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSubBuffer(new IntPtr(buffer), flags, buffer_create_type, buffer_create_info, errcode_ret);
        }

        public unsafe IntPtr CreateSubBuffer<T0>([Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] Span<T0> buffer_create_info, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateSubBuffer(new IntPtr(buffer), flags, buffer_create_type, buffer_create_info, errcode_ret);
        }

        public unsafe IntPtr CreateUserEvent([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateUserEvent(new IntPtr(context), errcode_ret);
        }

        public unsafe IntPtr CreateUserEvent([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateUserEvent(new IntPtr(context), errcode_ret);
        }

        public unsafe int EnqueueCopyBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint src_row_pitch, [Flow(FlowDirection.In)] uint src_slice_pitch, [Flow(FlowDirection.In)] uint dst_row_pitch, [Flow(FlowDirection.In)] uint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferRect(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), src_origin, dst_origin, region, new UIntPtr(src_row_pitch), new UIntPtr(src_slice_pitch), new UIntPtr(dst_row_pitch), new UIntPtr(dst_slice_pitch), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint src_row_pitch, [Flow(FlowDirection.In)] uint src_slice_pitch, [Flow(FlowDirection.In)] uint dst_row_pitch, [Flow(FlowDirection.In)] uint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferRect(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), src_origin, dst_origin, region, new UIntPtr(src_row_pitch), new UIntPtr(src_slice_pitch), new UIntPtr(dst_row_pitch), new UIntPtr(dst_slice_pitch), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWriteBufferRect([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* buffer_offset, [Flow(FlowDirection.In)] UIntPtr* host_offset, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> buffer_offset, [Flow(FlowDirection.In)] Span<UIntPtr> host_offset, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint buffer_row_pitch, [Flow(FlowDirection.In)] uint buffer_slice_pitch, [Flow(FlowDirection.In)] uint host_row_pitch, [Flow(FlowDirection.In)] uint host_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteBufferRect(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, buffer_offset, host_offset, region, new UIntPtr(buffer_row_pitch), new UIntPtr(buffer_slice_pitch), new UIntPtr(host_row_pitch), new UIntPtr(host_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int SetEventCallback([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetEventCallback(new IntPtr(@event), command_exec_callback_type, pfn_notify, user_data);
        }

        public unsafe int SetEventCallback<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetEventCallback(new IntPtr(@event), command_exec_callback_type, pfn_notify, user_data);
        }

        public unsafe int SetMemObjectDestructorCallback([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return SetMemObjectDestructorCallback(new IntPtr(memobj), pfn_notify, user_data);
        }

        public unsafe int SetMemObjectDestructorCallback<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetMemObjectDestructorCallback(new IntPtr(memobj), pfn_notify, user_data);
        }

        public unsafe int SetUserEventStatus([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] int execution_status)
        {
            // IntPtrOverloader
            return SetUserEventStatus(new IntPtr(@event), execution_status);
        }

        public unsafe int BuildProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] char* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        public unsafe int BuildProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<char> options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        public unsafe IntPtr CreateBuffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateBuffer(new IntPtr(context), flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateBuffer<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateBuffer(new IntPtr(context), flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueue(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public unsafe IntPtr CreateCommandQueue([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateCommandQueue(new IntPtr(context), new IntPtr(device), properties, errcode_ret);
        }

        public unsafe IntPtr CreateImage2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage2D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_row_pitch), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImage2D<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage2D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_row_pitch), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImage3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_depth, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.In)] uint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateImage3D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_depth), new UIntPtr(image_row_pitch), new UIntPtr(image_slice_pitch), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateImage3D<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint image_depth, [Flow(FlowDirection.In)] uint image_row_pitch, [Flow(FlowDirection.In)] uint image_slice_pitch, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateImage3D(new IntPtr(context), flags, image_format, new UIntPtr(image_width), new UIntPtr(image_height), new UIntPtr(image_depth), new UIntPtr(image_row_pitch), new UIntPtr(image_slice_pitch), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] char* kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] Span<char> kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        public unsafe int CreateKernelsInProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] IntPtr* kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret)
        {
            // IntPtrOverloader
            return CreateKernelsInProgram(new IntPtr(program), num_kernels, kernels, num_kernels_ret);
        }

        public unsafe int CreateKernelsInProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] Span<IntPtr> kernels, [Flow(FlowDirection.Out)] Span<uint> num_kernels_ret)
        {
            // IntPtrOverloader
            return CreateKernelsInProgram(new IntPtr(program), num_kernels, kernels, num_kernels_ret);
        }

        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBinary(new IntPtr(context), num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.MarshalStringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) binaries, binariesSa);
            return ret;
        }

        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithBinary(new IntPtr(context), num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithBinary([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] Span<int> binary_status, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.MarshalStringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) binaries, binariesSa);
            return ret;
        }

        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithSource(new IntPtr(context), count, strings, lengths, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] UIntPtr* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] char** strings, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateProgramWithSource(new IntPtr(context), count, strings, lengths, errcode_ret);
        }

        public unsafe IntPtr CreateProgramWithSource([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] Span<UIntPtr> lengths, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe IntPtr CreateSampler([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateSampler(new IntPtr(context), normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        public unsafe IntPtr CreateSampler([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateSampler(new IntPtr(context), normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        public unsafe int EnqueueBarrier([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return EnqueueBarrier(new IntPtr(command_queue));
        }

        public unsafe int EnqueueCopyBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBuffer(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), new UIntPtr(src_offset), new UIntPtr(dst_offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBuffer(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_buffer), new UIntPtr(src_offset), new UIntPtr(dst_offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferToImage(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_image), new UIntPtr(src_offset), dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_buffer, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] uint src_offset, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyBufferToImage(new IntPtr(command_queue), new IntPtr(src_buffer), new IntPtr(dst_image), new UIntPtr(src_offset), dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* dst_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImage(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_image, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> dst_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImage(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_image), src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] UIntPtr* src_origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImageToBuffer(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_buffer), src_origin, region, new UIntPtr(dst_offset), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int src_image, [Flow(FlowDirection.In)] int dst_buffer, [Flow(FlowDirection.In)] Span<UIntPtr> src_origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueCopyImageToBuffer(new IntPtr(command_queue), new IntPtr(src_image), new IntPtr(dst_buffer), src_origin, region, new UIntPtr(dst_offset), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_map, map_flags, new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public unsafe void* EnqueueMapBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_map, map_flags, new UIntPtr(offset), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.Out)] UIntPtr* image_row_pitch, [Flow(FlowDirection.Out)] UIntPtr* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapImage(new IntPtr(command_queue), new IntPtr(image), blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public unsafe void* EnqueueMapImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.Out)] Span<UIntPtr> image_row_pitch, [Flow(FlowDirection.Out)] Span<UIntPtr> image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return EnqueueMapImage(new IntPtr(command_queue), new IntPtr(image), blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }

        public unsafe int EnqueueMarker([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMarker(new IntPtr(command_queue), @event);
        }

        public unsafe int EnqueueMarker([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueMarker(new IntPtr(command_queue), @event);
        }

        public unsafe int EnqueueNdrangeKernel([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] UIntPtr* global_work_offset, [Flow(FlowDirection.In)] UIntPtr* global_work_size, [Flow(FlowDirection.In)] UIntPtr* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueNdrangeKernel(new IntPtr(command_queue), new IntPtr(kernel), work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueNdrangeKernel([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_offset, [Flow(FlowDirection.In)] Span<UIntPtr> global_work_size, [Flow(FlowDirection.In)] Span<UIntPtr> local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueNdrangeKernel(new IntPtr(command_queue), new IntPtr(kernel), work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_read, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint row_pitch, [Flow(FlowDirection.In)] uint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReadImage(new IntPtr(command_queue), new IntPtr(image), blocking_read, origin, region, new UIntPtr(row_pitch), new UIntPtr(slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReadImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint row_pitch, [Flow(FlowDirection.In)] uint slice_pitch, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueReadImage(new IntPtr(command_queue), new IntPtr(image), blocking_read, origin, region, new UIntPtr(row_pitch), new UIntPtr(slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueTask([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueTask(new IntPtr(command_queue), new IntPtr(kernel), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueTask([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueTask(new IntPtr(command_queue), new IntPtr(kernel), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueUnmapMemObject([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueUnmapMemObject(new IntPtr(command_queue), new IntPtr(memobj), mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.Out)] Span<T0> mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueUnmapMemObject(new IntPtr(command_queue), new IntPtr(memobj), mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWaitForEvents([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] IntPtr* event_list)
        {
            // IntPtrOverloader
            return EnqueueWaitForEvents(new IntPtr(command_queue), num_events, event_list);
        }

        public unsafe int EnqueueWaitForEvents([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] Span<IntPtr> event_list)
        {
            // IntPtrOverloader
            return EnqueueWaitForEvents(new IntPtr(command_queue), num_events, event_list);
        }

        public unsafe int EnqueueWriteBuffer([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteBuffer(new IntPtr(command_queue), new IntPtr(buffer), blocking_write, new UIntPtr(offset), new UIntPtr(size), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWriteImage([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] UIntPtr* origin, [Flow(FlowDirection.In)] UIntPtr* region, [Flow(FlowDirection.In)] uint input_row_pitch, [Flow(FlowDirection.In)] uint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueWriteImage(new IntPtr(command_queue), new IntPtr(image), blocking_write, origin, region, new UIntPtr(input_row_pitch), new UIntPtr(input_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<UIntPtr> origin, [Flow(FlowDirection.In)] Span<UIntPtr> region, [Flow(FlowDirection.In)] uint input_row_pitch, [Flow(FlowDirection.In)] uint input_slice_pitch, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueWriteImage(new IntPtr(command_queue), new IntPtr(image), blocking_write, origin, region, new UIntPtr(input_row_pitch), new UIntPtr(input_slice_pitch), ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int Finish([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return Finish(new IntPtr(command_queue));
        }

        public unsafe int Flush([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return Flush(new IntPtr(command_queue));
        }

        public unsafe int GetCommandQueueInfo([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetCommandQueueInfo(new IntPtr(command_queue), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetCommandQueueInfo(new IntPtr(command_queue), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetContextInfo([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetContextInfo(new IntPtr(context), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetContextInfo<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetContextInfo(new IntPtr(context), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetDeviceIDs([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDs(new IntPtr(platform), device_type, num_entries, devices, num_devices);
        }

        public unsafe int GetDeviceIDs([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDs(new IntPtr(platform), device_type, num_entries, devices, num_devices);
        }

        public unsafe int GetDeviceInfo([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetDeviceInfo(new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetDeviceInfo<T0>([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceInfo(new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetEventInfo([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetEventInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetEventInfo<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetEventInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetEventProfilingInfo([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetEventProfilingInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] int @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetEventProfilingInfo(new IntPtr(@event), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetImageInfo([Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetImageInfo(new IntPtr(image), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetImageInfo<T0>([Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetImageInfo(new IntPtr(image), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetKernelWorkGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetKernelWorkGroupInfo(new IntPtr(kernel), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetMemObjectInfo([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetMemObjectInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] int memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetMemObjectInfo(new IntPtr(memobj), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetPlatformInfo([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetPlatformInfo(new IntPtr(platform), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetPlatformInfo<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetPlatformInfo(new IntPtr(platform), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetProgramBuildInfo([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetProgramBuildInfo(new IntPtr(program), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetProgramBuildInfo(new IntPtr(program), new IntPtr(device), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetProgramInfo([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetProgramInfo(new IntPtr(program), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetProgramInfo<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetProgramInfo(new IntPtr(program), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetSamplerInfo([Flow(FlowDirection.In)] int sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetSamplerInfo(new IntPtr(sampler), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetSamplerInfo<T0>([Flow(FlowDirection.In)] int sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetSamplerInfo(new IntPtr(sampler), param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetSupportedImageFormats([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats)
        {
            // IntPtrOverloader
            return GetSupportedImageFormats(new IntPtr(context), flags, image_type, num_entries, image_formats, num_image_formats);
        }

        public unsafe int GetSupportedImageFormats([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> image_formats, [Flow(FlowDirection.Out)] Span<uint> num_image_formats)
        {
            // IntPtrOverloader
            return GetSupportedImageFormats(new IntPtr(context), flags, image_type, num_entries, image_formats, num_image_formats);
        }

        public unsafe int ReleaseCommandQueue([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return ReleaseCommandQueue(new IntPtr(command_queue));
        }

        public unsafe int ReleaseContext([Flow(FlowDirection.In)] int context)
        {
            // IntPtrOverloader
            return ReleaseContext(new IntPtr(context));
        }

        public unsafe int ReleaseEvent([Flow(FlowDirection.In)] int @event)
        {
            // IntPtrOverloader
            return ReleaseEvent(new IntPtr(@event));
        }

        public unsafe int ReleaseKernel([Flow(FlowDirection.In)] int kernel)
        {
            // IntPtrOverloader
            return ReleaseKernel(new IntPtr(kernel));
        }

        public unsafe int ReleaseMemObject([Flow(FlowDirection.In)] int memobj)
        {
            // IntPtrOverloader
            return ReleaseMemObject(new IntPtr(memobj));
        }

        public unsafe int ReleaseProgram([Flow(FlowDirection.In)] int program)
        {
            // IntPtrOverloader
            return ReleaseProgram(new IntPtr(program));
        }

        public unsafe int ReleaseSampler([Flow(FlowDirection.In)] int sampler)
        {
            // IntPtrOverloader
            return ReleaseSampler(new IntPtr(sampler));
        }

        public unsafe int RetainCommandQueue([Flow(FlowDirection.In)] int command_queue)
        {
            // IntPtrOverloader
            return RetainCommandQueue(new IntPtr(command_queue));
        }

        public unsafe int RetainContext([Flow(FlowDirection.In)] int context)
        {
            // IntPtrOverloader
            return RetainContext(new IntPtr(context));
        }

        public unsafe int RetainEvent([Flow(FlowDirection.In)] int @event)
        {
            // IntPtrOverloader
            return RetainEvent(new IntPtr(@event));
        }

        public unsafe int RetainKernel([Flow(FlowDirection.In)] int kernel)
        {
            // IntPtrOverloader
            return RetainKernel(new IntPtr(kernel));
        }

        public unsafe int RetainMemObject([Flow(FlowDirection.In)] int memobj)
        {
            // IntPtrOverloader
            return RetainMemObject(new IntPtr(memobj));
        }

        public unsafe int RetainProgram([Flow(FlowDirection.In)] int program)
        {
            // IntPtrOverloader
            return RetainProgram(new IntPtr(program));
        }

        public unsafe int RetainSampler([Flow(FlowDirection.In)] int sampler)
        {
            // IntPtrOverloader
            return RetainSampler(new IntPtr(sampler));
        }

        public unsafe int SetCommandQueueProperty([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] CLEnum* old_properties)
        {
            // IntPtrOverloader
            return SetCommandQueueProperty(new IntPtr(command_queue), properties, enable, old_properties);
        }

        public unsafe int SetCommandQueueProperty([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] Span<CLEnum> old_properties)
        {
            // IntPtrOverloader
            return SetCommandQueueProperty(new IntPtr(command_queue), properties, enable, old_properties);
        }

        public unsafe int SetKernelArg([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint arg_size, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArg(new IntPtr(kernel), arg_index, new UIntPtr(arg_size), arg_value);
        }

        public unsafe int SetKernelArg<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint arg_size, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArg(new IntPtr(kernel), arg_index, new UIntPtr(arg_size), arg_value);
        }

        public unsafe int BuildProgram([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] IntPtr* device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        public unsafe int BuildProgram<T0>([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] Span<IntPtr> device_list, [Flow(FlowDirection.In)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return BuildProgram(new IntPtr(program), num_devices, device_list, options, pfn_notify, user_data);
        }

        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }

        public unsafe IntPtr CreateKernel([Flow(FlowDirection.In)] int program, [Flow(FlowDirection.In)] string kernel_name, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateKernel(new IntPtr(program), kernel_name, errcode_ret);
        }


        public CL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

