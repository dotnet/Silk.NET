// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_TEMPERATURE_THRESHOLD
{
    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Flags"]/*' />
    [NativeTypeName("WORD")]
    public ushort Flags;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Index"]/*' />
    [NativeTypeName("WORD")]
    public ushort Index;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Threshold"]/*' />
    public short Threshold;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.OverThreshold"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte OverThreshold;

    /// <include file='STORAGE_TEMPERATURE_THRESHOLD.xml' path='doc/member[@name="STORAGE_TEMPERATURE_THRESHOLD.Reserved"]/*' />
    public byte Reserved;
}
