// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRRESIZEPALETTE.xml' path='doc/member[@name="EMRRESIZEPALETTE"]/*'/>
public partial struct EMRRESIZEPALETTE
{
    /// <include file='EMRRESIZEPALETTE.xml' path='doc/member[@name="EMRRESIZEPALETTE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRRESIZEPALETTE.xml' path='doc/member[@name="EMRRESIZEPALETTE.ihPal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihPal;
    /// <include file='EMRRESIZEPALETTE.xml' path='doc/member[@name="EMRRESIZEPALETTE.cEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cEntries;
}