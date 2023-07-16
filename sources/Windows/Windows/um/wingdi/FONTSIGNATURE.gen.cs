// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE"]/*'/>
public unsafe partial struct FONTSIGNATURE
{
    /// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE.fsUsb"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint fsUsb[4];
    /// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE.fsCsb"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint fsCsb[2];
}