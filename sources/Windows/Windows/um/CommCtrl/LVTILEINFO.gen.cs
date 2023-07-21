// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO"]/*' />
public unsafe partial struct LVTILEINFO
{
    /// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO.cbSize"]/*' />
    public uint cbSize;

    /// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO.iItem"]/*' />
    public int iItem;

    /// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO.cColumns"]/*' />
    public uint cColumns;

    /// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO.puColumns"]/*' />
    [NativeTypeName("PUINT")]
    public uint* puColumns;

    /// <include file='LVTILEINFO.xml' path='doc/member[@name="LVTILEINFO.piColFmt"]/*' />
    public int* piColFmt;
}
