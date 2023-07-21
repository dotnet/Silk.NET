// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PPM_WMI_LEGACY_PERFSTATE.xml' path='doc/member[@name="PPM_WMI_LEGACY_PERFSTATE"]/*' />
public partial struct PPM_WMI_LEGACY_PERFSTATE
{
    /// <include file='PPM_WMI_LEGACY_PERFSTATE.xml' path='doc/member[@name="PPM_WMI_LEGACY_PERFSTATE.Frequency"]/*' />
    [NativeTypeName("DWORD")]
    public uint Frequency;

    /// <include file='PPM_WMI_LEGACY_PERFSTATE.xml' path='doc/member[@name="PPM_WMI_LEGACY_PERFSTATE.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='PPM_WMI_LEGACY_PERFSTATE.xml' path='doc/member[@name="PPM_WMI_LEGACY_PERFSTATE.PercentFrequency"]/*' />
    [NativeTypeName("DWORD")]
    public uint PercentFrequency;
}
