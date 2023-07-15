// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA"]/*'/>
public unsafe partial struct CREDUI_INFOA
{
    /// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA.hwndParent"]/*'/>
    public HWND hwndParent;
    /// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA.pszMessageText"]/*'/>
    [NativeTypeName("PCSTR")]
    public sbyte* pszMessageText;
    /// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA.pszCaptionText"]/*'/>
    [NativeTypeName("PCSTR")]
    public sbyte* pszCaptionText;
    /// <include file='CREDUI_INFOA.xml' path='doc/member[@name="CREDUI_INFOA.hbmBanner"]/*'/>
    public HBITMAP hbmBanner;
}