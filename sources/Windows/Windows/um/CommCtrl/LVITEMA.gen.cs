// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA"]/*' />
public unsafe partial struct LVITEMA
{
    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.mask"]/*' />
    public uint mask;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iItem"]/*' />
    public int iItem;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iSubItem"]/*' />
    public int iSubItem;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.state"]/*' />
    public uint state;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.stateMask"]/*' />
    public uint stateMask;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.pszText"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iImage"]/*' />
    public int iImage;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iIndent"]/*' />
    public int iIndent;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iGroupId"]/*' />
    public int iGroupId;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.cColumns"]/*' />
    public uint cColumns;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.puColumns"]/*' />
    [NativeTypeName("PUINT")]
    public uint* puColumns;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.piColFmt"]/*' />
    public int* piColFmt;

    /// <include file='LVITEMA.xml' path='doc/member[@name="LVITEMA.iGroup"]/*' />
    public int iGroup;
}
