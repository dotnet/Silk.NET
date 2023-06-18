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

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public unsafe partial class CL : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_BIT")]
        public const sbyte CharBit = unchecked((sbyte) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MAX")]
        public const sbyte CharMax = unchecked((sbyte) sbyte.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MIN")]
        public const sbyte CharMin = unchecked((sbyte) sbyte.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_DIG")]
        public const double DblDig = unchecked((double) 15);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_EPSILON")]
        public const double DblEpsilon = unchecked((double) 2.220446049250313080847e-16);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MANT_DIG")]
        public const double DblMantDig = unchecked((double) 53);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX")]
        public const double DblMax = unchecked((double) double.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_10_EXP")]
        public const double DblMax10Exp = unchecked((double) +308);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_EXP")]
        public const double DblMaxExp = unchecked((double) +1024);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN")]
        public const double DblMin = unchecked((double) double.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN_10_EXP")]
        public const double DblMin10Exp = unchecked((double) -307);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN_EXP")]
        public const double DblMinExp = unchecked((double) -1021);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_RADIX")]
        public const double DblRadix = unchecked((double) 2);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DEVICE_HANDLE_LIST_END_KHR")]
        public const int DeviceHandleListEndKhr = unchecked((int) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_LIST_END")]
        public const int DevicePartitionByCountsListEnd = unchecked((int) 0x0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_DIG")]
        public const float FltDig = unchecked((float) 6);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_EPSILON")]
        public const float FltEpsilon = unchecked((float) 1.1920928955078125e-7f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MANT_DIG")]
        public const float FltMantDig = unchecked((float) 24);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX")]
        public const float FltMax = unchecked((float) float.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_10_EXP")]
        public const float FltMax10Exp = unchecked((float) +38);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_EXP")]
        public const float FltMaxExp = unchecked((float) +128);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN")]
        public const float FltMin = unchecked((float) float.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN_10_EXP")]
        public const float FltMin10Exp = unchecked((float) -37);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN_EXP")]
        public const float FltMinExp = unchecked((float) -125);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_RADIX")]
        public const float FltRadix = unchecked((float) 2);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_DIG")]
        public const float HalfDig = unchecked((float) 3);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_EPSILON")]
        public const float HalfEpsilon = unchecked((float) 9.765625e-04f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MANT_DIG")]
        public const float HalfMantDig = unchecked((float) 11);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX")]
        public const float HalfMax = unchecked((float) 65504.0f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_10_EXP")]
        public const float HalfMax10Exp = unchecked((float) +4);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_EXP")]
        public const float HalfMaxExp = unchecked((float) +16);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN")]
        public const float HalfMin = unchecked((float) 6.103515625e-05f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_10_EXP")]
        public const float HalfMin10Exp = unchecked((float) -4);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_EXP")]
        public const float HalfMinExp = unchecked((float) -13);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_RADIX")]
        public const float HalfRadix = unchecked((float) 2);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VAL")]
        public const double HugeVal = unchecked((double) double.PositiveInfinity);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VALF")]
        public const float HugeValf = unchecked((float) float.PositiveInfinity);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_IMPORT_MEMORY_WHOLE_ALLOCATION_ARM")]
        public const ulong ImportMemoryWholeAllocationArm = unchecked((ulong) ulong.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INFINITY")]
        public const float Infinity = unchecked((float) float.PositiveInfinity);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MAX")]
        public const int IntMax = unchecked((int) int.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MIN")]
        public const int IntMin = unchecked((int) int.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LAYER_API_VERSION_100")]
        public const int LayerApiVersion100 = unchecked((int) 100);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MAX")]
        public const long LongMax = unchecked((long) long.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MIN")]
        public const long LongMin = unchecked((long) long.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LUID_SIZE_KHR")]
        public const int LuidSizeKhr = unchecked((int) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_1_PI")]
        public const double M1PI = unchecked((double) 0.31830988618379067154);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_1_PI_F")]
        public const float M1PIF = unchecked((float) 0.318309886f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_PI")]
        public const double M2PI = unchecked((double) 0.63661977236758134308);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_PI_F")]
        public const float M2PIF = unchecked((float) 0.636619772f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_SQRTPI")]
        public const double M2Sqrtpi = unchecked((double) 1.12837916709551257390);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_2_SQRTPI_F")]
        public const float M2SqrtpiF = unchecked((float) 1.128379167f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_MAXFLOAT")]
        public const float Maxfloat = unchecked((float) float.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_E")]
        public const double ME = unchecked((double) 2.7182818284590452354);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_E_F")]
        public const float MEF = unchecked((float) 2.718281828f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN10")]
        public const double MLN10 = unchecked((double) 2.30258509299404568402);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN10_F")]
        public const float MLN10F = unchecked((float) 2.302585093f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN2")]
        public const double MLN2 = unchecked((double) 0.69314718055994530942);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LN2_F")]
        public const float MLN2F = unchecked((float) 0.693147181f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG10E")]
        public const double MLog10E = unchecked((double) 0.43429448190325182765);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG10E_F")]
        public const float MLog10EF = unchecked((float) 0.434294482f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG2E")]
        public const double MLog2E = unchecked((double) 1.4426950408889634074);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_LOG2E_F")]
        public const float MLog2EF = unchecked((float) 1.442695041f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI")]
        public const double MPI = unchecked((double) 3.14159265358979323846);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_2")]
        public const double MPI2 = unchecked((double) 1.57079632679489661923);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_2_F")]
        public const float MPI2F = unchecked((float) 1.570796327f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_4")]
        public const double MPI4 = unchecked((double) 0.78539816339744830962);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_4_F")]
        public const float MPI4F = unchecked((float) 0.785398163f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_PI_F")]
        public const float MPIF = unchecked((float) 3.141592654f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT1_2")]
        public const double MSqrt12 = unchecked((double) 0.70710678118654752440);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT1_2_F")]
        public const float MSqrt12F = unchecked((float) 0.707106781f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT2")]
        public const double MSqrt2 = unchecked((double) 1.41421356237309504880);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_M_SQRT2_F")]
        public const float MSqrt2F = unchecked((float) 1.414213562f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE")]
        public const int NameVersionMaxNameSize = unchecked((int) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE_KHR")]
        public const int NameVersionMaxNameSizeKhr = unchecked((int) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_NAN")]
        public const float Nan = unchecked((float) float.NaN);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_COUNTS_LIST_END_EXT")]
        public const uint PartitionByCountsListEndExt = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_EXT")]
        public const ulong PartitionByNamesListEndExt = unchecked((ulong) ulong.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_INTEL")]
        public const ulong PartitionByNamesListEndIntel = unchecked((ulong) ulong.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PROPERTIES_LIST_END_EXT")]
        public const uint PropertiesListEndExt = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_QUEUE_DEFAULT_CAPABILITIES_INTEL")]
        public const int QueueDefaultCapabilitiesIntel = unchecked((int) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_QUEUE_FAMILY_MAX_NAME_SIZE_INTEL")]
        public const int QueueFamilyMaxNameSizeIntel = unchecked((int) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MAX")]
        public const sbyte ScharMax = unchecked((sbyte) sbyte.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MIN")]
        public const sbyte ScharMin = unchecked((sbyte) sbyte.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SEMAPHORE_EXPORT_HANDLE_TYPES_LIST_END_KHR")]
        public const int SemaphoreExportHandleTypesListEndKhr = unchecked((int) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MAX")]
        public const short ShrtMax = unchecked((short) short.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MIN")]
        public const short ShrtMin = unchecked((short) short.MinValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UCHAR_MAX")]
        public const byte UcharMax = unchecked((byte) byte.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UINT_MAX")]
        public const uint UintMax = unchecked((uint) uint.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_ULONG_MAX")]
        public const ulong UlongMax = unchecked((ulong) ulong.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_USHRT_MAX")]
        public const ushort UshrtMax = unchecked((ushort) ushort.MaxValue);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UUID_SIZE_KHR")]
        public const int UuidSizeKhr = unchecked((int) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MAJOR_BITS")]
        public const int VersionMajorBits = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MAJOR_BITS_KHR")]
        public const int VersionMajorBitsKhr = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MINOR_BITS")]
        public const int VersionMinorBits = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MINOR_BITS_KHR")]
        public const int VersionMinorBitsKhr = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_PATCH_BITS")]
        public const int VersionPatchBits = unchecked((int) 12);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_PATCH_BITS_KHR")]
        public const int VersionPatchBitsKhr = unchecked((int) 12);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageDesc* image_desc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSetContextDestructorCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetContextDestructorCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetProgramReleaseCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetProgramSpecializationConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint spec_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint spec_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* spec_value);

        [NativeApi(EntryPoint = "clCreateProgramWithIL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* il, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceAndHostTimer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* device_timestamp, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetHostTimer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clCloneKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint OneKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint source_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSetDefaultDeviceCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int SetDefaultDeviceCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueueProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePipe([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipe_packet_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pipe_max_packets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSamplerWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerProperties* sampler_properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetPipeInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPipeInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pipe, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipeInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgSvmpointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelExecInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelExecInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* param_value);

        [NativeApi(EntryPoint = "clSVMAlloc", Convention = CallingConvention.Winapi)]
        public unsafe partial void* Svmalloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmMemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment);

        [NativeApi(EntryPoint = "clSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial void Svmfree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointer);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* device_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_input_headers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* input_headers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** header_include_names, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageDesc* image_desc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* device_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* kernel_names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueBarrierWithWaitList([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fill_color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarkerWithWaitList([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* func_name);

        [NativeApi(EntryPoint = "clGetKernelArgInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelArgInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelArgInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* device_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_input_programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* input_programs, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clReleaseDevice", Convention = CallingConvention.Winapi)]
        public partial int ReleaseDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clRetainDevice", Convention = CallingConvention.Winapi)]
        public partial int RetainDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clUnloadPlatformCompiler", Convention = CallingConvention.Winapi)]
        public partial int UnloadPlatformCompiler([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform);

        [NativeApi(EntryPoint = "clCreateSubBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSubBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCreateType buffer_create_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* buffer_create_info, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateUserEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateUserEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* buffer_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* host_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint buffer_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint buffer_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint host_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint host_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* buffer_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* host_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint buffer_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint buffer_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint host_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint host_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clSetEventCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetEventCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int command_exec_callback_type, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] EventNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetMemObjectDestructorCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetUserEventStatus", Convention = CallingConvention.Winapi)]
        public partial int SetUserEventStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int execution_status);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* device_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCreateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueue", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceType device_type, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageFormat* image_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint image_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* kernel_name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateKernelsInProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_kernels, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* kernels, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_devices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* device_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* lengths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** binaries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* binary_status, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** strings, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* lengths, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AddressingMode addressing_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterMode filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrier", Convention = CallingConvention.Winapi)]
        public partial int EnqueueBarrier([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags map_flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags map_flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* image_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* image_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMarker", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarker([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] UserFunction user_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* args, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb_args, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** args_mem_loc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* local_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueTask", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueTask([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* mapped_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitForEvents([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_list);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clFinish", Convention = CallingConvention.Winapi)]
        public partial int Finish([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clFlush", Convention = CallingConvention.Winapi)]
        public partial int Flush([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetCommandQueueInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetContextInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceType device_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EventInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventProfilingInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProfilingInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* func_name);

        [NativeApi(EntryPoint = "clGetImageInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetImageInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelWorkGroupInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelWorkGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemObjectInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformIDs([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PlatformInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramBuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramBuildInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSamplerInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedImageFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageFormat* image_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_image_formats);

        [NativeApi(EntryPoint = "clReleaseCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int ReleaseCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clReleaseContext", Convention = CallingConvention.Winapi)]
        public partial int ReleaseContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context);

        [NativeApi(EntryPoint = "clReleaseEvent", Convention = CallingConvention.Winapi)]
        public partial int ReleaseEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event);

        [NativeApi(EntryPoint = "clReleaseKernel", Convention = CallingConvention.Winapi)]
        public partial int ReleaseKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel);

        [NativeApi(EntryPoint = "clReleaseMemObject", Convention = CallingConvention.Winapi)]
        public partial int ReleaseMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj);

        [NativeApi(EntryPoint = "clReleaseProgram", Convention = CallingConvention.Winapi)]
        public partial int ReleaseProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program);

        [NativeApi(EntryPoint = "clReleaseSampler", Convention = CallingConvention.Winapi)]
        public partial int ReleaseSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sampler);

        [NativeApi(EntryPoint = "clRetainCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int RetainCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clRetainContext", Convention = CallingConvention.Winapi)]
        public partial int RetainContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context);

        [NativeApi(EntryPoint = "clRetainEvent", Convention = CallingConvention.Winapi)]
        public partial int RetainEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @event);

        [NativeApi(EntryPoint = "clRetainKernel", Convention = CallingConvention.Winapi)]
        public partial int RetainKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel);

        [NativeApi(EntryPoint = "clRetainMemObject", Convention = CallingConvention.Winapi)]
        public partial int RetainMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj);

        [NativeApi(EntryPoint = "clRetainProgram", Convention = CallingConvention.Winapi)]
        public partial int RetainProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program);

        [NativeApi(EntryPoint = "clRetainSampler", Convention = CallingConvention.Winapi)]
        public partial int RetainSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sampler);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetCommandQueueProperty([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enable, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] CommandQueueProperties* old_properties);

        [NativeApi(EntryPoint = "clSetKernelArg", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArg([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint arg_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clUnloadCompiler", Convention = CallingConvention.Winapi)]
        public partial int UnloadCompiler();

        [NativeApi(EntryPoint = "clWaitForEvents", Convention = CallingConvention.Winapi)]
        public unsafe partial int WaitForEvents([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_list);


        public CL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

