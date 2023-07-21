// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG"]/*' />
public partial struct STORAGE_FAILURE_PREDICTION_CONFIG
{
    /// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG.Set"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Set;

    /// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG.Enabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Enabled;

    /// <include file='STORAGE_FAILURE_PREDICTION_CONFIG.xml' path='doc/member[@name="STORAGE_FAILURE_PREDICTION_CONFIG.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;
}
