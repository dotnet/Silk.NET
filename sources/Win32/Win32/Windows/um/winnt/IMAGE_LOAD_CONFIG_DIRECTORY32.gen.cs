// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_LOAD_CONFIG_DIRECTORY32
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

    [NativeTypeName("DWORD")]
    public uint DeCommitFreeBlockThreshold;

    [NativeTypeName("DWORD")]
    public uint DeCommitTotalFreeThreshold;

    [NativeTypeName("DWORD")]
    public uint LockPrefixTable;

    [NativeTypeName("DWORD")]
    public uint MaximumAllocationSize;

    [NativeTypeName("DWORD")]
    public uint VirtualMemoryThreshold;

    [NativeTypeName("DWORD")]
    public uint ProcessHeapFlags;

    [NativeTypeName("DWORD")]
    public uint ProcessAffinityMask;

    [NativeTypeName("WORD")]
    public ushort CSDVersion;

    [NativeTypeName("WORD")]
    public ushort DependentLoadFlags;

    [NativeTypeName("DWORD")]
    public uint EditList;

    [NativeTypeName("DWORD")]
    public uint SecurityCookie;

    [NativeTypeName("DWORD")]
    public uint SEHandlerTable;

    [NativeTypeName("DWORD")]
    public uint SEHandlerCount;

    [NativeTypeName("DWORD")]
    public uint GuardCFCheckFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint GuardCFDispatchFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint GuardCFFunctionTable;

    [NativeTypeName("DWORD")]
    public uint GuardCFFunctionCount;

    [NativeTypeName("DWORD")]
    public uint GuardFlags;
    public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;

    [NativeTypeName("DWORD")]
    public uint GuardAddressTakenIatEntryTable;

    [NativeTypeName("DWORD")]
    public uint GuardAddressTakenIatEntryCount;

    [NativeTypeName("DWORD")]
    public uint GuardLongJumpTargetTable;

    [NativeTypeName("DWORD")]
    public uint GuardLongJumpTargetCount;

    [NativeTypeName("DWORD")]
    public uint DynamicValueRelocTable;

    [NativeTypeName("DWORD")]
    public uint CHPEMetadataPointer;

    [NativeTypeName("DWORD")]
    public uint GuardRFFailureRoutine;

    [NativeTypeName("DWORD")]
    public uint GuardRFFailureRoutineFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint DynamicValueRelocTableOffset;

    [NativeTypeName("WORD")]
    public ushort DynamicValueRelocTableSection;

    [NativeTypeName("WORD")]
    public ushort Reserved2;

    [NativeTypeName("DWORD")]
    public uint GuardRFVerifyStackPointerFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint HotPatchTableOffset;

    [NativeTypeName("DWORD")]
    public uint Reserved3;

    [NativeTypeName("DWORD")]
    public uint EnclaveConfigurationPointer;

    [NativeTypeName("DWORD")]
    public uint VolatileMetadataPointer;

    [NativeTypeName("DWORD")]
    public uint GuardEHContinuationTable;

    [NativeTypeName("DWORD")]
    public uint GuardEHContinuationCount;

    [NativeTypeName("DWORD")]
    public uint GuardXFGCheckFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint GuardXFGDispatchFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint GuardXFGTableDispatchFunctionPointer;

    [NativeTypeName("DWORD")]
    public uint CastGuardOsDeterminedFailureMode;

    [NativeTypeName("DWORD")]
    public uint GuardMemcpyFunctionPointer;
}
