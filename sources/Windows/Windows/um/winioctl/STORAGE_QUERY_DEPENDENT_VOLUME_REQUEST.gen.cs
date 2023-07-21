// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST"]/*' />
public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST
{
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST.RequestLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint RequestLevel;

    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_REQUEST.RequestFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint RequestFlags;
}
