// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA"]/*'/>
public unsafe partial struct AXISINFOA
{
    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axMinValue"]/*'/>
    [NativeTypeName("LONG")]
    public int axMinValue;
    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axMaxValue"]/*'/>
    [NativeTypeName("LONG")]
    public int axMaxValue;
    /// <include file='AXISINFOA.xml' path='doc/member[@name="AXISINFOA.axAxisName"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte axAxisName[16];
}