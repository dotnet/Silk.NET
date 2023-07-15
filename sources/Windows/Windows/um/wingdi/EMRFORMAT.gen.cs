// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRFORMAT.xml' path='doc/member[@name="EMRFORMAT"]/*'/>
public partial struct EMRFORMAT
{
    /// <include file='EMRFORMAT.xml' path='doc/member[@name="EMRFORMAT.dSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dSignature;
    /// <include file='EMRFORMAT.xml' path='doc/member[@name="EMRFORMAT.nVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nVersion;
    /// <include file='EMRFORMAT.xml' path='doc/member[@name="EMRFORMAT.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='EMRFORMAT.xml' path='doc/member[@name="EMRFORMAT.offData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offData;
}