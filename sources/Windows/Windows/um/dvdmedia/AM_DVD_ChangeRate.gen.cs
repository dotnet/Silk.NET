// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_DVD_ChangeRate.xml' path='doc/member[@name="AM_DVD_ChangeRate"]/*'/>
public partial struct AM_DVD_ChangeRate
{
    /// <include file='AM_DVD_ChangeRate.xml' path='doc/member[@name="AM_DVD_ChangeRate.StartInTime"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long StartInTime;
    /// <include file='AM_DVD_ChangeRate.xml' path='doc/member[@name="AM_DVD_ChangeRate.StartOutTime"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long StartOutTime;
    /// <include file='AM_DVD_ChangeRate.xml' path='doc/member[@name="AM_DVD_ChangeRate.Rate"]/*'/>
    [NativeTypeName("LONG")]
    public int Rate;
}