// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateCompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CreateCompressor([NativeTypeName("DWORD")] uint Algorithm, [NativeTypeName("PCOMPRESS_ALLOCATION_ROUTINES")] COMPRESS_ALLOCATION_ROUTINES* AllocationRoutines, [NativeTypeName("PCOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE* CompressorHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCompressorInformation"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetCompressorInformation(COMPRESSOR_HANDLE CompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("LPCVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryCompressorInformation"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL QueryCompressorInformation(COMPRESSOR_HANDLE CompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("PVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Compress"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL Compress(COMPRESSOR_HANDLE CompressorHandle, [NativeTypeName("LPCVOID")] void* UncompressedData, [NativeTypeName("SIZE_T")] nuint UncompressedDataSize, [NativeTypeName("PVOID")] void* CompressedBuffer, [NativeTypeName("SIZE_T")] nuint CompressedBufferSize, [NativeTypeName("PSIZE_T")] nuint* CompressedDataSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetCompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL ResetCompressor(COMPRESSOR_HANDLE CompressorHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseCompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CloseCompressor(COMPRESSOR_HANDLE CompressorHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDecompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CreateDecompressor([NativeTypeName("DWORD")] uint Algorithm, [NativeTypeName("PCOMPRESS_ALLOCATION_ROUTINES")] COMPRESS_ALLOCATION_ROUTINES* AllocationRoutines, [NativeTypeName("PDECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE* DecompressorHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDecompressorInformation"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetDecompressorInformation([NativeTypeName("DECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE DecompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("LPCVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryDecompressorInformation"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL QueryDecompressorInformation([NativeTypeName("DECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE DecompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("PVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Decompress"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL Decompress([NativeTypeName("DECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE DecompressorHandle, [NativeTypeName("LPCVOID")] void* CompressedData, [NativeTypeName("SIZE_T")] nuint CompressedDataSize, [NativeTypeName("PVOID")] void* UncompressedBuffer, [NativeTypeName("SIZE_T")] nuint UncompressedBufferSize, [NativeTypeName("PSIZE_T")] nuint* UncompressedDataSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetDecompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL ResetDecompressor([NativeTypeName("DECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE DecompressorHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseDecompressor"]/*'/>
    [DllImport("cabinet", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CloseDecompressor([NativeTypeName("DECOMPRESSOR_HANDLE")] COMPRESSOR_HANDLE DecompressorHandle);
    [NativeTypeName("#define COMPRESS_ALGORITHM_INVALID 0")]
    public const int COMPRESS_ALGORITHM_INVALID = 0;
    [NativeTypeName("#define COMPRESS_ALGORITHM_NULL 1")]
    public const int COMPRESS_ALGORITHM_NULL = 1;
    [NativeTypeName("#define COMPRESS_ALGORITHM_MSZIP 2")]
    public const int COMPRESS_ALGORITHM_MSZIP = 2;
    [NativeTypeName("#define COMPRESS_ALGORITHM_XPRESS 3")]
    public const int COMPRESS_ALGORITHM_XPRESS = 3;
    [NativeTypeName("#define COMPRESS_ALGORITHM_XPRESS_HUFF 4")]
    public const int COMPRESS_ALGORITHM_XPRESS_HUFF = 4;
    [NativeTypeName("#define COMPRESS_ALGORITHM_LZMS 5")]
    public const int COMPRESS_ALGORITHM_LZMS = 5;
    [NativeTypeName("#define COMPRESS_ALGORITHM_MAX 6")]
    public const int COMPRESS_ALGORITHM_MAX = 6;
    [NativeTypeName("#define COMPRESS_RAW (1 << 29)")]
    public const int COMPRESS_RAW = (1 << 29);
}