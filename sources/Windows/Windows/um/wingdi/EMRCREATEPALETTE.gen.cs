// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRCREATEPALETTE.xml' path='doc/member[@name="EMRCREATEPALETTE"]/*'/>
public partial struct EMRCREATEPALETTE
{
    /// <include file='EMRCREATEPALETTE.xml' path='doc/member[@name="EMRCREATEPALETTE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCREATEPALETTE.xml' path='doc/member[@name="EMRCREATEPALETTE.ihPal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihPal;
    /// <include file='EMRCREATEPALETTE.xml' path='doc/member[@name="EMRCREATEPALETTE.lgpl"]/*'/>
    public LOGPALETTE lgpl;
}