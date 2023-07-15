// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENUMLOGFONTEXW.xml' path='doc/member[@name="ENUMLOGFONTEXW"]/*'/>
public unsafe partial struct ENUMLOGFONTEXW
{
    /// <include file='ENUMLOGFONTEXW.xml' path='doc/member[@name="ENUMLOGFONTEXW.elfLogFont"]/*'/>
    public LOGFONTW elfLogFont;
    /// <include file='ENUMLOGFONTEXW.xml' path='doc/member[@name="ENUMLOGFONTEXW.elfFullName"]/*'/>
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort elfFullName[64];
    /// <include file='ENUMLOGFONTEXW.xml' path='doc/member[@name="ENUMLOGFONTEXW.elfStyle"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort elfStyle[32];
    /// <include file='ENUMLOGFONTEXW.xml' path='doc/member[@name="ENUMLOGFONTEXW.elfScript"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort elfScript[32];
}