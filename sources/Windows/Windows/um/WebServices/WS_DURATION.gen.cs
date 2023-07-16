// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION"]/*'/>
public partial struct WS_DURATION
{
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.negative"]/*'/>
    public BOOL negative;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.years"]/*'/>
    [NativeTypeName("ULONG")]
    public uint years;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.months"]/*'/>
    [NativeTypeName("ULONG")]
    public uint months;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.days"]/*'/>
    [NativeTypeName("ULONG")]
    public uint days;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.hours"]/*'/>
    [NativeTypeName("ULONG")]
    public uint hours;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.minutes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint minutes;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.seconds"]/*'/>
    [NativeTypeName("ULONG")]
    public uint seconds;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.milliseconds"]/*'/>
    [NativeTypeName("ULONG")]
    public uint milliseconds;
    /// <include file='WS_DURATION.xml' path='doc/member[@name="WS_DURATION.ticks"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ticks;
}