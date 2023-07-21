// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW"]/*' />
public unsafe partial struct GCP_RESULTSW
{
    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpOutString"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpOutString;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpOrder"]/*' />
    public uint* lpOrder;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpDx"]/*' />
    public int* lpDx;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpCaretPos"]/*' />
    public int* lpCaretPos;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpClass"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpClass;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.lpGlyphs"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpGlyphs;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.nGlyphs"]/*' />
    public uint nGlyphs;

    /// <include file='GCP_RESULTSW.xml' path='doc/member[@name="GCP_RESULTSW.nMaxFit"]/*' />
    public int nMaxFit;
}
