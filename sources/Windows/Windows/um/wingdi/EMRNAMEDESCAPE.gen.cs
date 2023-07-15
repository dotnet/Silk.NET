// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE"]/*'/>
public unsafe partial struct EMRNAMEDESCAPE
{
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.iEscape"]/*'/>
    public int iEscape;
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.cbDriver"]/*'/>
    public int cbDriver;
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.cbEscData"]/*'/>
    public int cbEscData;
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.EscData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte EscData[1];
}