// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT"]/*'/>
public unsafe partial struct NMCUSTOMTEXT
{
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.hDC"]/*'/>
    public HDC hDC;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.lpString"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpString;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.nCount"]/*'/>
    public int nCount;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.lpRect"]/*'/>
    [NativeTypeName("LPRECT")]
    public RECT* lpRect;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.uFormat"]/*'/>
    public uint uFormat;
    /// <include file='NMCUSTOMTEXT.xml' path='doc/member[@name="NMCUSTOMTEXT.fLink"]/*'/>
    public BOOL fLink;
}