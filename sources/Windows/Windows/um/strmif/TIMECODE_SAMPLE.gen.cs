// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TIMECODE_SAMPLE.xml' path='doc/member[@name="TIMECODE_SAMPLE"]/*'/>
public partial struct TIMECODE_SAMPLE
{
    /// <include file='TIMECODE_SAMPLE.xml' path='doc/member[@name="TIMECODE_SAMPLE.qwTick"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long qwTick;
    /// <include file='TIMECODE_SAMPLE.xml' path='doc/member[@name="TIMECODE_SAMPLE.timecode"]/*'/>
    public TIMECODE timecode;
    /// <include file='TIMECODE_SAMPLE.xml' path='doc/member[@name="TIMECODE_SAMPLE.dwUser"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUser;
    /// <include file='TIMECODE_SAMPLE.xml' path='doc/member[@name="TIMECODE_SAMPLE.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}