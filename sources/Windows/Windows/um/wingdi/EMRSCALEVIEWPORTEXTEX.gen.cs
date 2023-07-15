// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX"]/*'/>
public partial struct EMRSCALEVIEWPORTEXTEX
{
    /// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX.xNum"]/*'/>
    [NativeTypeName("LONG")]
    public int xNum;
    /// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX.xDenom"]/*'/>
    [NativeTypeName("LONG")]
    public int xDenom;
    /// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX.yNum"]/*'/>
    [NativeTypeName("LONG")]
    public int yNum;
    /// <include file='EMRSCALEVIEWPORTEXTEX.xml' path='doc/member[@name="EMRSCALEVIEWPORTEXTEX.yDenom"]/*'/>
    [NativeTypeName("LONG")]
    public int yDenom;
}