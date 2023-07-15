// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMREOF.xml' path='doc/member[@name="EMREOF"]/*'/>
public partial struct EMREOF
{
    /// <include file='EMREOF.xml' path='doc/member[@name="EMREOF.emr"]/*'/>
    public EMR emr;
    /// <include file='EMREOF.xml' path='doc/member[@name="EMREOF.nPalEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPalEntries;
    /// <include file='EMREOF.xml' path='doc/member[@name="EMREOF.offPalEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offPalEntries;
    /// <include file='EMREOF.xml' path='doc/member[@name="EMREOF.nSizeLast"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nSizeLast;
}