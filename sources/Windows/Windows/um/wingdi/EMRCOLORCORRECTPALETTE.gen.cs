// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE"]/*'/>
public partial struct EMRCOLORCORRECTPALETTE
{
    /// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE.ihPalette"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihPalette;
    /// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE.nFirstEntry"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFirstEntry;
    /// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE.nPalEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPalEntries;
    /// <include file='EMRCOLORCORRECTPALETTE.xml' path='doc/member[@name="EMRCOLORCORRECTPALETTE.nReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nReserved;
}