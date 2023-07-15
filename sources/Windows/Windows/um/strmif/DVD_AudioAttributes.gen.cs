// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes"]/*'/>
public unsafe partial struct DVD_AudioAttributes
{
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.AppMode"]/*'/>
    public DVD_AUDIO_APPMODE AppMode;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.AppModeData"]/*'/>
    public byte AppModeData;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.AudioFormat"]/*'/>
    public DVD_AUDIO_FORMAT AudioFormat;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.Language"]/*'/>
    [NativeTypeName("LCID")]
    public uint Language;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.LanguageExtension"]/*'/>
    public DVD_AUDIO_LANG_EXT LanguageExtension;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.fHasMultichannelInfo"]/*'/>
    public BOOL fHasMultichannelInfo;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.dwFrequency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFrequency;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.bQuantization"]/*'/>
    public byte bQuantization;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.bNumberOfChannels"]/*'/>
    public byte bNumberOfChannels;
    /// <include file='DVD_AudioAttributes.xml' path='doc/member[@name="DVD_AudioAttributes.dwReserved"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwReserved[2];
}