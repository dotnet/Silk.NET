// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_QueryRate.xml' path='doc/member[@name="AM_QueryRate"]/*'/>
public partial struct AM_QueryRate
{
    /// <include file='AM_QueryRate.xml' path='doc/member[@name="AM_QueryRate.lMaxForwardFullFrame"]/*'/>
    [NativeTypeName("LONG")]
    public int lMaxForwardFullFrame;
    /// <include file='AM_QueryRate.xml' path='doc/member[@name="AM_QueryRate.lMaxReverseFullFrame"]/*'/>
    [NativeTypeName("LONG")]
    public int lMaxReverseFullFrame;
}