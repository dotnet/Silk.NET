// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT.xml' path='doc/member[@name="VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT"]/*' />
public partial struct VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT
{
    /// <include file='VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT.xml' path='doc/member[@name="VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT.xml' path='doc/member[@name="VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT.BehaviorCode"]/*' />
    public VIRTUAL_STORAGE_BEHAVIOR_CODE BehaviorCode;
}
