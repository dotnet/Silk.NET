// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA"]/*'/>
public unsafe partial struct ENUMLOGFONTA
{
    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfLogFont"]/*'/>
    public LOGFONTA elfLogFont;
    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfFullName"]/*'/>
    [NativeTypeName("BYTE[64]")]
    public fixed byte elfFullName[64];
    /// <include file='ENUMLOGFONTA.xml' path='doc/member[@name="ENUMLOGFONTA.elfStyle"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte elfStyle[32];
}