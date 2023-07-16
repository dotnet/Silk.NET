// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_SimpleRateChange.xml' path='doc/member[@name="AM_SimpleRateChange"]/*'/>
public partial struct AM_SimpleRateChange
{
    /// <include file='AM_SimpleRateChange.xml' path='doc/member[@name="AM_SimpleRateChange.StartTime"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long StartTime;
    /// <include file='AM_SimpleRateChange.xml' path='doc/member[@name="AM_SimpleRateChange.Rate"]/*'/>
    [NativeTypeName("LONG")]
    public int Rate;
}