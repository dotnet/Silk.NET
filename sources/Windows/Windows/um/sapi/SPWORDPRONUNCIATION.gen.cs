// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION"]/*'/>
public unsafe partial struct SPWORDPRONUNCIATION
{
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.pNextWordPronunciation"]/*'/>
    [NativeTypeName("struct SPWORDPRONUNCIATION *")]
    public SPWORDPRONUNCIATION* pNextWordPronunciation;
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.eLexiconType"]/*'/>
    public SPLEXICONTYPE eLexiconType;
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.LangID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LangID;
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.wPronunciationFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPronunciationFlags;
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.ePartOfSpeech"]/*'/>
    public SPPARTOFSPEECH ePartOfSpeech;
    /// <include file='SPWORDPRONUNCIATION.xml' path='doc/member[@name="SPWORDPRONUNCIATION.szPronunciation"]/*'/>
    [NativeTypeName("SPPHONEID[1]")]
    public fixed ushort szPronunciation[1];
}