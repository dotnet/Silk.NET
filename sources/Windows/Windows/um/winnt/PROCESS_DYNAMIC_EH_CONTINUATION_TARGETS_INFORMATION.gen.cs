// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION"]/*' />
public unsafe partial struct PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION
{
    /// <include file='PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.NumberOfTargets"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfTargets;

    /// <include file='PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;

    /// <include file='PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION.Targets"]/*' />
    [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")]
    public PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets;
}
