// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_LOAD_CONFIG_DIRECTORY64
{
    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MinorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GlobalFlagsClear"]/*' />
    [NativeTypeName("DWORD")]
    public uint GlobalFlagsClear;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GlobalFlagsSet"]/*' />
    [NativeTypeName("DWORD")]
    public uint GlobalFlagsSet;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CriticalSectionDefaultTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint CriticalSectionDefaultTimeout;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DeCommitFreeBlockThreshold"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong DeCommitFreeBlockThreshold;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DeCommitTotalFreeThreshold"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong DeCommitTotalFreeThreshold;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.LockPrefixTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong LockPrefixTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MaximumAllocationSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MaximumAllocationSize;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.VirtualMemoryThreshold"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong VirtualMemoryThreshold;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.ProcessAffinityMask"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ProcessAffinityMask;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.ProcessHeapFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProcessHeapFlags;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CSDVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort CSDVersion;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DependentLoadFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort DependentLoadFlags;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.EditList"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EditList;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SecurityCookie"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SecurityCookie;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SEHandlerTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SEHandlerTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SEHandlerCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong SEHandlerCount;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFCheckFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFCheckFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFDispatchFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFDispatchFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFFunctionTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFFunctionTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFFunctionCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardCFFunctionCount;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint GuardFlags;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CodeIntegrity"]/*' />
    public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardAddressTakenIatEntryTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardAddressTakenIatEntryTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardAddressTakenIatEntryCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardAddressTakenIatEntryCount;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardLongJumpTargetTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardLongJumpTargetTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardLongJumpTargetCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardLongJumpTargetCount;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong DynamicValueRelocTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CHPEMetadataPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CHPEMetadataPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFFailureRoutine"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFFailureRoutine;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFFailureRoutineFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFFailureRoutineFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTableOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint DynamicValueRelocTableOffset;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTableSection"]/*' />
    [NativeTypeName("WORD")]
    public ushort DynamicValueRelocTableSection;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Reserved2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved2;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFVerifyStackPointerFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardRFVerifyStackPointerFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.HotPatchTableOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint HotPatchTableOffset;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Reserved3"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved3;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.EnclaveConfigurationPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveConfigurationPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.VolatileMetadataPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong VolatileMetadataPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardEHContinuationTable"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardEHContinuationTable;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardEHContinuationCount"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardEHContinuationCount;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardXFGCheckFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGCheckFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardXFGDispatchFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGDispatchFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardXFGTableDispatchFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardXFGTableDispatchFunctionPointer;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CastGuardOsDeterminedFailureMode"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong CastGuardOsDeterminedFailureMode;

    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardMemcpyFunctionPointer"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong GuardMemcpyFunctionPointer;
}
