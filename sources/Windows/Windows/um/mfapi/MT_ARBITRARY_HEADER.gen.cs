// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER"]/*' />
public partial struct MT_ARBITRARY_HEADER
{
    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.majortype"]/*' />
    public Guid majortype;

    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.subtype"]/*' />
    public Guid subtype;

    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.bFixedSizeSamples"]/*' />
    public BOOL bFixedSizeSamples;

    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.bTemporalCompression"]/*' />
    public BOOL bTemporalCompression;

    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.lSampleSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint lSampleSize;

    /// <include file='MT_ARBITRARY_HEADER.xml' path='doc/member[@name="MT_ARBITRARY_HEADER.formattype"]/*' />
    public Guid formattype;
}
