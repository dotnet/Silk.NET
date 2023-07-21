// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_IDLE_POWERUP_REASON.xml' path='doc/member[@name="STORAGE_IDLE_POWERUP_REASON"]/*' />
public partial struct STORAGE_IDLE_POWERUP_REASON
{
    /// <include file='STORAGE_IDLE_POWERUP_REASON.xml' path='doc/member[@name="STORAGE_IDLE_POWERUP_REASON.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_IDLE_POWERUP_REASON.xml' path='doc/member[@name="STORAGE_IDLE_POWERUP_REASON.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_IDLE_POWERUP_REASON.xml' path='doc/member[@name="STORAGE_IDLE_POWERUP_REASON.PowerupReason"]/*' />
    public STORAGE_POWERUP_REASON_TYPE PowerupReason;
}
