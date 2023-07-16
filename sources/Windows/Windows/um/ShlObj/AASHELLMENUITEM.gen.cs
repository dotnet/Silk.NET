// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM"]/*'/>
public unsafe partial struct AASHELLMENUITEM
{
    /// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM.lpReserved1"]/*'/>
    public void* lpReserved1;
    /// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM.iReserved"]/*'/>
    public int iReserved;
    /// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM.uiReserved"]/*'/>
    public uint uiReserved;
    /// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM.lpName"]/*'/>
    [NativeTypeName("LPAASHELLMENUFILENAME")]
    public AASHELLMENUFILENAME* lpName;
    /// <include file='AASHELLMENUITEM.xml' path='doc/member[@name="AASHELLMENUITEM.psz"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* psz;
}