// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SD_CHANGE_MACHINE_SID_INPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_INPUT"]/*' />
public partial struct SD_CHANGE_MACHINE_SID_INPUT
{
    /// <include file='SD_CHANGE_MACHINE_SID_INPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_INPUT.CurrentMachineSIDOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort CurrentMachineSIDOffset;

    /// <include file='SD_CHANGE_MACHINE_SID_INPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_INPUT.CurrentMachineSIDLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort CurrentMachineSIDLength;

    /// <include file='SD_CHANGE_MACHINE_SID_INPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_INPUT.NewMachineSIDOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort NewMachineSIDOffset;

    /// <include file='SD_CHANGE_MACHINE_SID_INPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_INPUT.NewMachineSIDLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort NewMachineSIDLength;
}
