// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_PROVIDER_EXTERNAL_INFO_V1.xml' path='doc/member[@name="FILE_PROVIDER_EXTERNAL_INFO_V1"]/*' />
public partial struct FILE_PROVIDER_EXTERNAL_INFO_V1
{
    /// <include file='FILE_PROVIDER_EXTERNAL_INFO_V1.xml' path='doc/member[@name="FILE_PROVIDER_EXTERNAL_INFO_V1.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='FILE_PROVIDER_EXTERNAL_INFO_V1.xml' path='doc/member[@name="FILE_PROVIDER_EXTERNAL_INFO_V1.Algorithm"]/*' />
    [NativeTypeName("DWORD")]
    public uint Algorithm;

    /// <include file='FILE_PROVIDER_EXTERNAL_INFO_V1.xml' path='doc/member[@name="FILE_PROVIDER_EXTERNAL_INFO_V1.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
