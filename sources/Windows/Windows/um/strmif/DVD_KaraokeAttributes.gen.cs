// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes"]/*'/>
public unsafe partial struct DVD_KaraokeAttributes
{
    /// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes.bVersion"]/*'/>
    public byte bVersion;
    /// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes.fMasterOfCeremoniesInGuideVocal1"]/*'/>
    public BOOL fMasterOfCeremoniesInGuideVocal1;
    /// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes.fDuet"]/*'/>
    public BOOL fDuet;
    /// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes.ChannelAssignment"]/*'/>
    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment;
    /// <include file='DVD_KaraokeAttributes.xml' path='doc/member[@name="DVD_KaraokeAttributes.wChannelContents"]/*'/>
    [NativeTypeName("WORD[8]")]
    public fixed ushort wChannelContents[8];
}