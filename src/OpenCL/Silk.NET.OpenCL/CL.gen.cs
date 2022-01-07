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
        public const int CharBit = unchecked((int) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MAX")]
        public const int CharMax = unchecked((int) 127);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_CHAR_MIN")]
        public const int CharMin = unchecked((int) -127 - 1);
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
        public const double DblMax = unchecked((double) 1.7976931348623158e+308);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_10_EXP")]
        public const double DblMax10Exp = unchecked((double) +308);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MAX_EXP")]
        public const double DblMaxExp = unchecked((double) +1024);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_DBL_MIN")]
        public const double DblMin = unchecked((double) 2.225073858507201383090e-308);
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
        public const float FltMax = unchecked((float) 340282346638528859811704183484516925440.0f);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_10_EXP")]
        public const float FltMax10Exp = unchecked((float) +38);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MAX_EXP")]
        public const float FltMaxExp = unchecked((float) +128);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_FLT_MIN")]
        public const float FltMin = unchecked((float) 1.175494350822287507969e-38f);
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
        public const short HalfDig = unchecked((short) 3);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_EPSILON")]
        public const short HalfEpsilon = unchecked((short) unchecked((short)9.765625e-04f));
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MANT_DIG")]
        public const short HalfMantDig = unchecked((short) 11);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX")]
        public const short HalfMax = unchecked((short) unchecked((short)65504.0f));
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_10_EXP")]
        public const short HalfMax10Exp = unchecked((short) +4);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MAX_EXP")]
        public const short HalfMaxExp = unchecked((short) +16);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN")]
        public const short HalfMin = unchecked((short) unchecked((short)6.103515625e-05f));
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_10_EXP")]
        public const short HalfMin10Exp = unchecked((short) -4);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_MIN_EXP")]
        public const short HalfMinExp = unchecked((short) -13);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HALF_RADIX")]
        public const short HalfRadix = unchecked((short) 2);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VAL")]
        public const double HugeVal = unchecked((double) double.PositiveInfinity);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_HUGE_VALF")]
        public const float HugeValf = unchecked((float) (float) 1e50);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INFINITY")]
        public const float Infinity = unchecked((float) float.PositiveInfinity);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MAX")]
        public const int IntMax = unchecked((int) 2147483647);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_INT_MIN")]
        public const int IntMin = unchecked((int) -2147483647 - 1);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MAX")]
        public const long LongMax = unchecked((long) 0x7FFFFFFFFFFFFFFFL);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_LONG_MIN")]
        public const long LongMin = unchecked((long) -0x7FFFFFFFFFFFFFFFL - 1L);
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
        [NativeName("Name", "CL_NAN")]
        public const float Nan = unchecked((float) float.NaN);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_COUNTS_LIST_END_EXT")]
        public const int PartitionByCountsListEndExt = unchecked((int) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_EXT")]
        public const int PartitionByNamesListEndExt = unchecked((int) 0 - 1);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PARTITION_BY_NAMES_LIST_END_INTEL")]
        public const int PartitionByNamesListEndIntel = unchecked((int) -1);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_PROPERTIES_LIST_END_EXT")]
        public const int PropertiesListEndExt = unchecked((int) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MAX")]
        public const int ScharMax = unchecked((int) 127);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SCHAR_MIN")]
        public const int ScharMin = unchecked((int) -127 - 1);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MAX")]
        public const short ShrtMax = unchecked((short) 32767);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_SHRT_MIN")]
        public const short ShrtMin = unchecked((short) -32767 - 1);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UCHAR_MAX")]
        public const int UcharMax = unchecked((int) 255);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_UINT_MAX")]
        public const uint UintMax = unchecked((uint) 0xffffffffU);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_ULONG_MAX")]
        public const ulong UlongMax = unchecked((ulong) 0xFFFFFFFFFFFFFFFFUL);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_USHRT_MAX")]
        public const ushort UshrtMax = unchecked((ushort) 65535);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MAJOR_BITS")]
        public const int VersionMajorBits = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_MINOR_BITS")]
        public const int VersionMinorBits = unchecked((int) 10);
        [NativeName("Type", "")]
        [NativeName("Name", "CL_VERSION_PATCH_BITS")]
        public const int VersionPatchBits = unchecked((int) 12);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithProperties", Convention = CallingConvention.Winapi)]
        public partial nint CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImageWithProperties", Convention = CallingConvention.Winapi)]
        public partial nint CreateImageWithProperties<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetContextDestructorCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetContextDestructorCallback([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetContextDestructorCallback", Convention = CallingConvention.Winapi)]
        public partial int SetContextDestructorCallback<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetProgramReleaseCallback([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetProgramReleaseCallback", Convention = CallingConvention.Winapi)]
        public partial int SetProgramReleaseCallback<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetProgramSpecializationConstant([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] nuint spec_size, [Flow(FlowDirection.In)] void* spec_value);

        [NativeApi(EntryPoint = "clSetProgramSpecializationConstant", Convention = CallingConvention.Winapi)]
        public partial int SetProgramSpecializationConstant<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint spec_id, [Flow(FlowDirection.In)] nuint spec_size, [Flow(FlowDirection.In)] in T0 spec_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithIL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithIL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithIL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithIL<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithIL", Convention = CallingConvention.Winapi)]
        public partial nint CreateProgramWithIL<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] void** svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] nuint* sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMigrateMem", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.In)] in void* svm_pointers, [Flow(FlowDirection.In)] in nuint sizes, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] ulong* device_timestamp, [Flow(FlowDirection.Out)] out ulong host_timestamp);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] out ulong device_timestamp, [Flow(FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetDeviceAndHostTimer", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceAndHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] out ulong device_timestamp, [Flow(FlowDirection.Out)] out ulong host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] ulong* host_timestamp);

        [NativeApi(EntryPoint = "clGetHostTimer", Convention = CallingConvention.Winapi)]
        public partial int GetHostTimer([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.Out)] out ulong host_timestamp);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelSubGroupInfo", Convention = CallingConvention.Winapi)]
        public partial int GetKernelSubGroupInfo<T0, T1>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] in T0 input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clCloneKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint OneKernel([Flow(FlowDirection.In)] nint source_kernel, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCloneKernel", Convention = CallingConvention.Winapi)]
        public partial nint OneKernel([Flow(FlowDirection.In)] nint source_kernel, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clSetDefaultDeviceCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int SetDefaultDeviceCommandQueue([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueueWithProperties", Convention = CallingConvention.Winapi)]
        public partial nint CreateCommandQueueWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePipe([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePipe([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePipe([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreatePipe", Convention = CallingConvention.Winapi)]
        public partial nint CreatePipe([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint pipe_packet_size, [Flow(FlowDirection.In)] uint pipe_max_packets, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSamplerWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSamplerWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* sampler_properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSamplerWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum sampler_properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSamplerWithProperties", Convention = CallingConvention.Winapi)]
        public partial nint CreateSamplerWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum sampler_properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T1 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T1 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T1 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMFree", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] out T0 svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] out T1 user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMap", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpy", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMMemFill", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueSVMUnmap", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPipeInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPipeInfo([Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPipeInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPipeInfo([Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPipeInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPipeInfo<T0>([Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPipeInfo", Convention = CallingConvention.Winapi)]
        public partial int GetPipeInfo<T0>([Flow(FlowDirection.In)] nint pipe, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgSvmpointer([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointer", Convention = CallingConvention.Winapi)]
        public partial int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] in T0 arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelExecInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelExecInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] void* param_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfo", Convention = CallingConvention.Winapi)]
        public partial int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] in T0 param_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSVMAlloc", Convention = CallingConvention.Winapi)]
        public unsafe partial void* Svmalloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment);

        [NativeApi(EntryPoint = "clSVMFree", Convention = CallingConvention.Winapi)]
        public unsafe partial void Svmfree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* svm_pointer);

        [NativeApi(EntryPoint = "clSVMFree", Convention = CallingConvention.Winapi)]
        public partial void Svmfree<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] out T0 svm_pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] byte** header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clCompileProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] in byte* header_include_names, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage", Convention = CallingConvention.Winapi)]
        public partial nint CreateImage<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] in ImageDesc image_desc, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBuiltInKernels", Convention = CallingConvention.Winapi)]
        public partial nint CreateProgramWithBuiltInKernel([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_names, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] out uint num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] out uint num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] out uint num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] uint* num_devices_ret);

        [NativeApi(EntryPoint = "clCreateSubDevices", Convention = CallingConvention.Winapi)]
        public partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] out uint num_devices_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueBarrierWithWaitList", Convention = CallingConvention.Winapi)]
        public partial int EnqueueBarrierWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillBuffer", Convention = CallingConvention.Winapi)]
        public partial int EnqueueFillBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueFillImage", Convention = CallingConvention.Winapi)]
        public partial int EnqueueFillImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] in T0 fill_color, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMarkerWithWaitList", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMarkerWithWaitList([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjects", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMemObjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] byte* func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] in byte func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddressForPlatform", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddressForPlatform([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string func_name);

        [NativeApi(EntryPoint = "clGetKernelArgInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelArgInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelArgInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelArgInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelArgInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelArgInfo", Convention = CallingConvention.Winapi)]
        public partial int GetKernelArgInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] nint* input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLinkProgram", Convention = CallingConvention.Winapi)]
        public partial nint LinkProgram<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_programs, [Flow(FlowDirection.In)] in nint input_programs, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseDevice", Convention = CallingConvention.Winapi)]
        public partial int ReleaseDevice([Flow(FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clRetainDevice", Convention = CallingConvention.Winapi)]
        public partial int RetainDevice([Flow(FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clUnloadPlatformCompiler", Convention = CallingConvention.Winapi)]
        public partial int UnloadPlatformCompiler([Flow(FlowDirection.In)] nint platform);

        [NativeApi(EntryPoint = "clCreateSubBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSubBuffer([Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSubBuffer([Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] void* buffer_create_info, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSubBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSubBuffer<T0>([Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] in T0 buffer_create_info, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateSubBuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateSubBuffer<T0>([Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint buffer_create_type, [Flow(FlowDirection.In)] in T0 buffer_create_info, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateUserEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateUserEvent([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateUserEvent", Convention = CallingConvention.Winapi)]
        public partial nint CreateUserEvent([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferRect", Convention = CallingConvention.Winapi)]
        public partial int EnqueueCopyBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBufferRect", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReadBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] nuint* host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBufferRect", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWriteBufferRect<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint buffer_origin, [Flow(FlowDirection.In)] in nuint host_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint buffer_row_pitch, [Flow(FlowDirection.In)] nuint buffer_slice_pitch, [Flow(FlowDirection.In)] nuint host_row_pitch, [Flow(FlowDirection.In)] nuint host_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetEventCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetEventCallback([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetEventCallback", Convention = CallingConvention.Winapi)]
        public partial int SetEventCallback<T0>([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] int command_exec_callback_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetMemObjectDestructorCallback([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorCallback", Convention = CallingConvention.Winapi)]
        public partial int SetMemObjectDestructorCallback<T0>([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetUserEventStatus", Convention = CallingConvention.Winapi)]
        public partial int SetUserEventStatus([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] int execution_status);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int BuildProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clBuildProgram", Convention = CallingConvention.Winapi)]
        public partial int BuildProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBuffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBuffer<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreateBuffer<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateCommandQueue", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandQueue([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateCommandQueue", Convention = CallingConvention.Winapi)]
        public partial nint CreateCommandQueue([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateContext<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint devices, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType<T0>([Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextFromType<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateContextFromType", Convention = CallingConvention.Winapi)]
        public partial nint CreateContextFromType<T0>([Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage2D", Convention = CallingConvention.Winapi)]
        public partial nint CreateImage2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateImage3D", Convention = CallingConvention.Winapi)]
        public partial nint CreateImage3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] nuint image_width, [Flow(FlowDirection.In)] nuint image_height, [Flow(FlowDirection.In)] nuint image_depth, [Flow(FlowDirection.In)] nuint image_row_pitch, [Flow(FlowDirection.In)] nuint image_slice_pitch, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* kernel_name, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte kernel_name, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_name, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernel", Convention = CallingConvention.Winapi)]
        public partial nint CreateKernel([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string kernel_name, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateKernelsInProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] nint* kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateKernelsInProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] nint* kernels, [Flow(FlowDirection.Out)] out uint num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateKernelsInProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] out nint kernels, [Flow(FlowDirection.Out)] uint* num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateKernelsInProgram", Convention = CallingConvention.Winapi)]
        public partial int CreateKernelsInProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_kernels, [Flow(FlowDirection.Out)] out nint kernels, [Flow(FlowDirection.Out)] out uint num_kernels_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] byte** binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] in byte* binaries, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] byte** strings, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateProgramWithSource", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in byte* strings, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSampler([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSampler", Convention = CallingConvention.Winapi)]
        public partial nint CreateSampler([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] bool normalized_coords, [Flow(FlowDirection.In)] uint addressing_mode, [Flow(FlowDirection.In)] uint filter_mode, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueBarrier", Convention = CallingConvention.Winapi)]
        public partial int EnqueueBarrier([Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBuffer", Convention = CallingConvention.Winapi)]
        public partial int EnqueueCopyBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyBufferToImage", Convention = CallingConvention.Winapi)]
        public partial int EnqueueCopyBufferToImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImage", Convention = CallingConvention.Winapi)]
        public partial int EnqueueCopyImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint dst_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueCopyImageToBuffer", Convention = CallingConvention.Winapi)]
        public partial int EnqueueCopyImageToBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] in nuint src_origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] nuint* image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] nuint* image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMapImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void* EnqueueMapImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum map_flags, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.Out)] out nuint image_row_pitch, [Flow(FlowDirection.Out)] out nuint image_slice_pitch, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMarker", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMarker([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMarker", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMarker([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] void* args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] void** args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNativeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNativeKernel<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] PfnVoidFunction user_func, [Flow(FlowDirection.Out)] out T0 args, [Flow(FlowDirection.In)] nuint cb_args, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] in nint mem_list, [Flow(FlowDirection.In)] in void* args_mem_loc, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueNDRangeKernel", Convention = CallingConvention.Winapi)]
        public partial int EnqueueNdrangeKernel([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] in nuint global_work_offset, [Flow(FlowDirection.In)] in nuint global_work_size, [Flow(FlowDirection.In)] in nuint local_work_size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadBuffer", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReadBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadImage", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReadImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint row_pitch, [Flow(FlowDirection.In)] nuint slice_pitch, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueTask", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueTask([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueTask", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueTask([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueTask", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueTask([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueTask", Convention = CallingConvention.Winapi)]
        public partial int EnqueueTask([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] void* mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out T0 mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out T0 mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out T0 mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueUnmapMemObject", Convention = CallingConvention.Winapi)]
        public partial int EnqueueUnmapMemObject<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.Out)] out T0 mapped_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitForEvents([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] nint* event_list);

        [NativeApi(EntryPoint = "clEnqueueWaitForEvents", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWaitForEvents([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] in nint event_list);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteBuffer", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWriteBuffer<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteImage", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWriteImage<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in nuint origin, [Flow(FlowDirection.In)] in nuint region, [Flow(FlowDirection.In)] nuint input_row_pitch, [Flow(FlowDirection.In)] nuint input_slice_pitch, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clFinish", Convention = CallingConvention.Winapi)]
        public partial int Finish([Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clFlush", Convention = CallingConvention.Winapi)]
        public partial int Flush([Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetCommandQueueInfo([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetCommandQueueInfo([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetCommandQueueInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetCommandQueueInfo", Convention = CallingConvention.Winapi)]
        public partial int GetCommandQueueInfo<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetContextInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetContextInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetContextInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetContextInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetContextInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetContextInfo", Convention = CallingConvention.Winapi)]
        public partial int GetContextInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDs([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDs([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDs([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDs", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceIDs([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] CLEnum device_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceInfo([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceInfo([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceInfo<T0>([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceInfo", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceInfo<T0>([Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventInfo([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventInfo([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventInfo<T0>([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventInfo", Convention = CallingConvention.Winapi)]
        public partial int GetEventInfo<T0>([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventProfilingInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventProfilingInfo([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventProfilingInfo([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetEventProfilingInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetEventProfilingInfo", Convention = CallingConvention.Winapi)]
        public partial int GetEventProfilingInfo<T0>([Flow(FlowDirection.In)] nint @event, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] byte* func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In)] in byte func_name);

        [NativeApi(EntryPoint = "clGetExtensionFunctionAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetExtensionFunctionAddress([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string func_name);

        [NativeApi(EntryPoint = "clGetImageInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetImageInfo([Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetImageInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetImageInfo([Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetImageInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetImageInfo<T0>([Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetImageInfo", Convention = CallingConvention.Winapi)]
        public partial int GetImageInfo<T0>([Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelInfo", Convention = CallingConvention.Winapi)]
        public partial int GetKernelInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelWorkGroupInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetKernelWorkGroupInfo", Convention = CallingConvention.Winapi)]
        public partial int GetKernelWorkGroupInfo<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemObjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemObjectInfo([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemObjectInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemObjectInfo", Convention = CallingConvention.Winapi)]
        public partial int GetMemObjectInfo<T0>([Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPlatformIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* platforms, [Flow(FlowDirection.Out)] out uint num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformIDs", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint platforms, [Flow(FlowDirection.Out)] uint* num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformIDs", Convention = CallingConvention.Winapi)]
        public partial int GetPlatformIDs([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint platforms, [Flow(FlowDirection.Out)] out uint num_platforms);

        [NativeApi(EntryPoint = "clGetPlatformInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformInfo([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformInfo([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetPlatformInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetPlatformInfo<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetPlatformInfo", Convention = CallingConvention.Winapi)]
        public partial int GetPlatformInfo<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramBuildInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramBuildInfo([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramBuildInfo([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramBuildInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramBuildInfo", Convention = CallingConvention.Winapi)]
        public partial int GetProgramBuildInfo<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramInfo([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramInfo([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetProgramInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetProgramInfo<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetProgramInfo", Convention = CallingConvention.Winapi)]
        public partial int GetProgramInfo<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSamplerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSamplerInfo([Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSamplerInfo([Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSamplerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSamplerInfo<T0>([Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSamplerInfo", Convention = CallingConvention.Winapi)]
        public partial int GetSamplerInfo<T0>([Flow(FlowDirection.In)] nint sampler, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSupportedImageFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedImageFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedImageFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* image_formats, [Flow(FlowDirection.Out)] out uint num_image_formats);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedImageFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint image_formats, [Flow(FlowDirection.Out)] uint* num_image_formats);

        [NativeApi(EntryPoint = "clGetSupportedImageFormats", Convention = CallingConvention.Winapi)]
        public partial int GetSupportedImageFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint image_formats, [Flow(FlowDirection.Out)] out uint num_image_formats);

        [NativeApi(EntryPoint = "clReleaseCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int ReleaseCommandQueue([Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clReleaseContext", Convention = CallingConvention.Winapi)]
        public partial int ReleaseContext([Flow(FlowDirection.In)] nint context);

        [NativeApi(EntryPoint = "clReleaseEvent", Convention = CallingConvention.Winapi)]
        public partial int ReleaseEvent([Flow(FlowDirection.In)] nint @event);

        [NativeApi(EntryPoint = "clReleaseKernel", Convention = CallingConvention.Winapi)]
        public partial int ReleaseKernel([Flow(FlowDirection.In)] nint kernel);

        [NativeApi(EntryPoint = "clReleaseMemObject", Convention = CallingConvention.Winapi)]
        public partial int ReleaseMemObject([Flow(FlowDirection.In)] nint memobj);

        [NativeApi(EntryPoint = "clReleaseProgram", Convention = CallingConvention.Winapi)]
        public partial int ReleaseProgram([Flow(FlowDirection.In)] nint program);

        [NativeApi(EntryPoint = "clReleaseSampler", Convention = CallingConvention.Winapi)]
        public partial int ReleaseSampler([Flow(FlowDirection.In)] nint sampler);

        [NativeApi(EntryPoint = "clRetainCommandQueue", Convention = CallingConvention.Winapi)]
        public partial int RetainCommandQueue([Flow(FlowDirection.In)] nint command_queue);

        [NativeApi(EntryPoint = "clRetainContext", Convention = CallingConvention.Winapi)]
        public partial int RetainContext([Flow(FlowDirection.In)] nint context);

        [NativeApi(EntryPoint = "clRetainEvent", Convention = CallingConvention.Winapi)]
        public partial int RetainEvent([Flow(FlowDirection.In)] nint @event);

        [NativeApi(EntryPoint = "clRetainKernel", Convention = CallingConvention.Winapi)]
        public partial int RetainKernel([Flow(FlowDirection.In)] nint kernel);

        [NativeApi(EntryPoint = "clRetainMemObject", Convention = CallingConvention.Winapi)]
        public partial int RetainMemObject([Flow(FlowDirection.In)] nint memobj);

        [NativeApi(EntryPoint = "clRetainProgram", Convention = CallingConvention.Winapi)]
        public partial int RetainProgram([Flow(FlowDirection.In)] nint program);

        [NativeApi(EntryPoint = "clRetainSampler", Convention = CallingConvention.Winapi)]
        public partial int RetainSampler([Flow(FlowDirection.In)] nint sampler);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetCommandQueueProperty([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] CLEnum* old_properties);

        [NativeApi(EntryPoint = "clSetCommandQueueProperty", Convention = CallingConvention.Winapi)]
        public partial int SetCommandQueueProperty([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] CLEnum properties, [Flow(FlowDirection.In)] bool enable, [Flow(FlowDirection.Out)] out CLEnum old_properties);

        [NativeApi(EntryPoint = "clSetKernelArg", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArg([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] nuint arg_size, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArg", Convention = CallingConvention.Winapi)]
        public partial int SetKernelArg<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] nuint arg_size, [Flow(FlowDirection.In)] in T0 arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clUnloadCompiler", Convention = CallingConvention.Winapi)]
        public partial int UnloadCompiler();

        [NativeApi(EntryPoint = "clWaitForEvents", Convention = CallingConvention.Winapi)]
        public unsafe partial int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] nint* event_list);

        [NativeApi(EntryPoint = "clWaitForEvents", Convention = CallingConvention.Winapi)]
        public partial int WaitForEvents([Flow(FlowDirection.In)] uint num_events, [Flow(FlowDirection.In)] in nint event_list);

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, in options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, in options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, in options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, in options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] byte* options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, in options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, in options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, in options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in byte options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, in options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] nint* input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] void* user_data)
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe int CompileProgram<T0>([Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string options, [Flow(FlowDirection.In)] uint num_input_headers, [Flow(FlowDirection.In)] in nint input_headers, [Flow(FlowDirection.In)] string[] header_include_namesSa, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] out T0 user_data) where T0 : unmanaged
        {
            // StringArrayOverloader
            var header_include_names = (byte**) SilkMarshal.StringArrayToPtr(header_include_namesSa);
            var ret = CompileProgram(program, num_devices, in device_list, options, num_input_headers, in input_headers, header_include_names, pfn_notify, out user_data);
            SilkMarshal.CopyPtrToStringArray((nint) header_include_names, header_include_namesSa);
            SilkMarshal.Free((nint) header_include_names);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, out binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, lengths, binaries, out binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, in lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, in lengths, binaries, binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, in lengths, binaries, out binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] nint* device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, device_list, in lengths, binaries, out binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, lengths, binaries, binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, lengths, binaries, out binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, lengths, binaries, out binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, in lengths, binaries, binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] int* binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, in lengths, binaries, binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, in lengths, binaries, out binary_status, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithBinary([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint num_devices, [Flow(FlowDirection.In)] in nint device_list, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.In)] string[] binariesSa, [Flow(FlowDirection.Out)] out int binary_status, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var binaries = (byte**) SilkMarshal.StringArrayToPtr(binariesSa);
            var ret = CreateProgramWithBinary(context, num_devices, in device_list, in lengths, binaries, out binary_status, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) binaries, binariesSa);
            SilkMarshal.Free((nint) binaries);
            return ret;
        }

        public unsafe nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }

        public unsafe nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] nuint* lengths, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, lengths, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }

        public unsafe nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, in lengths, errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }

        public unsafe nint CreateProgramWithSource([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string[] stringsSa, [Flow(FlowDirection.In)] in nuint lengths, [Flow(FlowDirection.Out)] out int errcode_ret)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateProgramWithSource(context, count, strings, in lengths, out errcode_ret);
            SilkMarshal.CopyPtrToStringArray((nint) strings, stringsSa);
            SilkMarshal.Free((nint) strings);
            return ret;
        }


        public CL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

