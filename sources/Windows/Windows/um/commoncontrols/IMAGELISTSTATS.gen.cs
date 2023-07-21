// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGELISTSTATS.xml' path='doc/member[@name="IMAGELISTSTATS"]/*' />
public partial struct IMAGELISTSTATS
{
    /// <include file='IMAGELISTSTATS.xml' path='doc/member[@name="IMAGELISTSTATS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='IMAGELISTSTATS.xml' path='doc/member[@name="IMAGELISTSTATS.cAlloc"]/*' />
    public int cAlloc;

    /// <include file='IMAGELISTSTATS.xml' path='doc/member[@name="IMAGELISTSTATS.cUsed"]/*' />
    public int cUsed;

    /// <include file='IMAGELISTSTATS.xml' path='doc/member[@name="IMAGELISTSTATS.cStandby"]/*' />
    public int cStandby;
}
