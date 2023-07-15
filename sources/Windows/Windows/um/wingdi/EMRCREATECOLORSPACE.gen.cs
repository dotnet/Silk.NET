// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRCREATECOLORSPACE.xml' path='doc/member[@name="EMRCREATECOLORSPACE"]/*'/>
public partial struct EMRCREATECOLORSPACE
{
    /// <include file='EMRCREATECOLORSPACE.xml' path='doc/member[@name="EMRCREATECOLORSPACE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCREATECOLORSPACE.xml' path='doc/member[@name="EMRCREATECOLORSPACE.ihCS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihCS;
    /// <include file='EMRCREATECOLORSPACE.xml' path='doc/member[@name="EMRCREATECOLORSPACE.lcs"]/*'/>
    public LOGCOLORSPACEA lcs;
}