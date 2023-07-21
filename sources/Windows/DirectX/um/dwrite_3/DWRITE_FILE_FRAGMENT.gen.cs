// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_FILE_FRAGMENT.xml' path='doc/member[@name="DWRITE_FILE_FRAGMENT"]/*' />
public partial struct DWRITE_FILE_FRAGMENT
{
    /// <include file='DWRITE_FILE_FRAGMENT.xml' path='doc/member[@name="DWRITE_FILE_FRAGMENT.fileOffset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong fileOffset;

    /// <include file='DWRITE_FILE_FRAGMENT.xml' path='doc/member[@name="DWRITE_FILE_FRAGMENT.fragmentSize"]/*' />
    [NativeTypeName("UINT64")]
    public ulong fragmentSize;
}
