// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo"]/*'/>
public partial struct DVD_MUA_MixingInfo
{
    /// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo.fMixTo0"]/*'/>
    public BOOL fMixTo0;
    /// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo.fMixTo1"]/*'/>
    public BOOL fMixTo1;
    /// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo.fMix0InPhase"]/*'/>
    public BOOL fMix0InPhase;
    /// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo.fMix1InPhase"]/*'/>
    public BOOL fMix1InPhase;
    /// <include file='DVD_MUA_MixingInfo.xml' path='doc/member[@name="DVD_MUA_MixingInfo.dwSpeakerPosition"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSpeakerPosition;
}