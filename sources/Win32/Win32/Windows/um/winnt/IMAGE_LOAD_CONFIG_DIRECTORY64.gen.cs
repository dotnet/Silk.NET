// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_LOAD_CONFIG_DIRECTORY64
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    [NativeTypeName("DWORD")]
    public uint GlobalFlagsClear;

    [NativeTypeName("DWORD")]
    public uint GlobalFlagsSet;

    [NativeTypeName("DWORD")]
    public uint CriticalSectionDefaultTimeout;

    [NativeTypeName("ULONGLONG")]
    public ulong DeCommitFreeBlockThreshold;

    [NativeTypeName("ULONGLONG")]
    public ulong DeCommitTotalFreeThreshold;

    [NativeTypeName("ULONGLONG")]
    public ulong LockPrefixTable;

    [NativeTypeName("ULONGLONG")]
    public ulong MaximumAllocationSize;

    [NativeTypeName("ULONGLONG")]
    public ulong VirtualMemoryThreshold;

    [NativeTypeName("ULONGLONG")]
    public ulong ProcessAffinityMask;

    [NativeTypeName("DWORD")]
    public uint ProcessHeapFlags;

    [NativeTypeName("WORD")]
    public ushort CSDVersion;

    [NativeTypeName("WORD")]
    public ushort DependentLoadFlags;

    [NativeTypeName("ULONGLONG")]
    public ulong EditList;

    [NativeTypeName("ULONGLONG")]
    public ulong SecurityCookie;

    [NativeTypeName("ULONGLONG")]
    public ulong SEHandlerTable;

    [NativeTypeName("ULONGLONG")]
    public ulong SEHandlerCount;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFCheckFunctionPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFDispatchFunctionPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFFunctionTable;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFFunctionCount;

    [NativeTypeName("DWORD")]
    public uint GuardFlags;
    public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardAddressTakenIatEntryTable;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardAddressTakenIatEntryCount;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardLongJumpTargetTable;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardLongJumpTargetCount;

    [NativeTypeName("ULONGLONG")]
    public ulong DynamicValueRelocTable;

    [NativeTypeName("ULONGLONG")]
    public ulong CHPEMetadataPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFFailureRoutine;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFFailureRoutineFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint DynamicValueRelocTableOffset;

    [NativeTypeName("WORD")]
    public ushort DynamicValueRelocTableSection;

    [NativeTypeName("WORD")]
    public ushort Reserved2;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFVerifyStackPointerFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint HotPatchTableOffset;

    [NativeTypeName("DWORD")]
    public uint Reserved3;

    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveConfigurationPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong VolatileMetadataPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardEHContinuationTable;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardEHContinuationCount;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGCheckFunctionPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGDispatchFunctionPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGTableDispatchFunctionPointer;

    [NativeTypeName("ULONGLONG")]
    public ulong CastGuardOsDeterminedFailureMode;

    [NativeTypeName("ULONGLONG")]
    public ulong GuardMemcpyFunctionPointer;
}
