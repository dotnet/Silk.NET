// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents"]/*'/>
public enum SpeechRecoEvents
{
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREStreamEnd"]/*'/>
    SREStreamEnd = (1 << 0),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SRESoundStart"]/*'/>
    SRESoundStart = (1 << 1),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SRESoundEnd"]/*'/>
    SRESoundEnd = (1 << 2),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREPhraseStart"]/*'/>
    SREPhraseStart = (1 << 3),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SRERecognition"]/*'/>
    SRERecognition = (1 << 4),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREHypothesis"]/*'/>
    SREHypothesis = (1 << 5),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREBookmark"]/*'/>
    SREBookmark = (1 << 6),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREPropertyNumChange"]/*'/>
    SREPropertyNumChange = (1 << 7),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREPropertyStringChange"]/*'/>
    SREPropertyStringChange = (1 << 8),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREFalseRecognition"]/*'/>
    SREFalseRecognition = (1 << 9),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREInterference"]/*'/>
    SREInterference = (1 << 10),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SRERequestUI"]/*'/>
    SRERequestUI = (1 << 11),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREStateChange"]/*'/>
    SREStateChange = (1 << 12),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREAdaptation"]/*'/>
    SREAdaptation = (1 << 13),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREStreamStart"]/*'/>
    SREStreamStart = (1 << 14),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SRERecoOtherContext"]/*'/>
    SRERecoOtherContext = (1 << 15),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREAudioLevel"]/*'/>
    SREAudioLevel = (1 << 16),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREPrivate"]/*'/>
    SREPrivate = (1 << 18),
    /// <include file='SpeechRecoEvents.xml' path='doc/member[@name="SpeechRecoEvents.SREAllEvents"]/*'/>
    SREAllEvents = 0x5ffff,
}