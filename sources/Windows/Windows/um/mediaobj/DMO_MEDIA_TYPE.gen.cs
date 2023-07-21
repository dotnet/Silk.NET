// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE"]/*' />
public unsafe partial struct DMO_MEDIA_TYPE
{
    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.majortype"]/*' />
    public Guid majortype;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.subtype"]/*' />
    public Guid subtype;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.bFixedSizeSamples"]/*' />
    public BOOL bFixedSizeSamples;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.bTemporalCompression"]/*' />
    public BOOL bTemporalCompression;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.lSampleSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint lSampleSize;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.formattype"]/*' />
    public Guid formattype;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.pUnk"]/*' />
    public IUnknown* pUnk;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.cbFormat"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbFormat;

    /// <include file='DMO_MEDIA_TYPE.xml' path='doc/member[@name="DMO_MEDIA_TYPE.pbFormat"]/*' />
    public byte* pbFormat;
}
