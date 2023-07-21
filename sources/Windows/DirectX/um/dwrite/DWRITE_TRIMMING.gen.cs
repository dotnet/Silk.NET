// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_TRIMMING.xml' path='doc/member[@name="DWRITE_TRIMMING"]/*' />
public partial struct DWRITE_TRIMMING
{
    /// <include file='DWRITE_TRIMMING.xml' path='doc/member[@name="DWRITE_TRIMMING.granularity"]/*' />
    public DWRITE_TRIMMING_GRANULARITY granularity;

    /// <include file='DWRITE_TRIMMING.xml' path='doc/member[@name="DWRITE_TRIMMING.delimiter"]/*' />
    [NativeTypeName("UINT32")]
    public uint delimiter;

    /// <include file='DWRITE_TRIMMING.xml' path='doc/member[@name="DWRITE_TRIMMING.delimiterCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint delimiterCount;
}
