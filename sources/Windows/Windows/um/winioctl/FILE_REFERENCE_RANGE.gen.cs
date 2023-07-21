// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_REFERENCE_RANGE.xml' path='doc/member[@name="FILE_REFERENCE_RANGE"]/*' />
public partial struct FILE_REFERENCE_RANGE
{
    /// <include file='FILE_REFERENCE_RANGE.xml' path='doc/member[@name="FILE_REFERENCE_RANGE.StartingFileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong StartingFileReferenceNumber;

    /// <include file='FILE_REFERENCE_RANGE.xml' path='doc/member[@name="FILE_REFERENCE_RANGE.EndingFileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong EndingFileReferenceNumber;
}
