// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_HMSF_TIMECODE.xml' path='doc/member[@name="DVD_HMSF_TIMECODE"]/*'/>
public partial struct DVD_HMSF_TIMECODE
{
    /// <include file='DVD_HMSF_TIMECODE.xml' path='doc/member[@name="DVD_HMSF_TIMECODE.bHours"]/*'/>
    public byte bHours;
    /// <include file='DVD_HMSF_TIMECODE.xml' path='doc/member[@name="DVD_HMSF_TIMECODE.bMinutes"]/*'/>
    public byte bMinutes;
    /// <include file='DVD_HMSF_TIMECODE.xml' path='doc/member[@name="DVD_HMSF_TIMECODE.bSeconds"]/*'/>
    public byte bSeconds;
    /// <include file='DVD_HMSF_TIMECODE.xml' path='doc/member[@name="DVD_HMSF_TIMECODE.bFrames"]/*'/>
    public byte bFrames;
}