// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENUMLOGFONTEXA.xml' path='doc/member[@name="ENUMLOGFONTEXA"]/*'/>
public unsafe partial struct ENUMLOGFONTEXA
{
    /// <include file='ENUMLOGFONTEXA.xml' path='doc/member[@name="ENUMLOGFONTEXA.elfLogFont"]/*'/>
    public LOGFONTA elfLogFont;
    /// <include file='ENUMLOGFONTEXA.xml' path='doc/member[@name="ENUMLOGFONTEXA.elfFullName"]/*'/>
    [NativeTypeName("BYTE[64]")]
    public fixed byte elfFullName[64];
    /// <include file='ENUMLOGFONTEXA.xml' path='doc/member[@name="ENUMLOGFONTEXA.elfStyle"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte elfStyle[32];
    /// <include file='ENUMLOGFONTEXA.xml' path='doc/member[@name="ENUMLOGFONTEXA.elfScript"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte elfScript[32];
}