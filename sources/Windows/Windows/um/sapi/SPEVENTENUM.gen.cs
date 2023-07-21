// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM"]/*' />
public enum SPEVENTENUM
{
    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_UNDEFINED"]/*' />
    SPEI_UNDEFINED = 0,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_START_INPUT_STREAM"]/*' />
    SPEI_START_INPUT_STREAM = 1,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_END_INPUT_STREAM"]/*' />
    SPEI_END_INPUT_STREAM = 2,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_VOICE_CHANGE"]/*' />
    SPEI_VOICE_CHANGE = 3,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_TTS_BOOKMARK"]/*' />
    SPEI_TTS_BOOKMARK = 4,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_WORD_BOUNDARY"]/*' />
    SPEI_WORD_BOUNDARY = 5,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_PHONEME"]/*' />
    SPEI_PHONEME = 6,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SENTENCE_BOUNDARY"]/*' />
    SPEI_SENTENCE_BOUNDARY = 7,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_VISEME"]/*' />
    SPEI_VISEME = 8,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_TTS_AUDIO_LEVEL"]/*' />
    SPEI_TTS_AUDIO_LEVEL = 9,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_TTS_PRIVATE"]/*' />
    SPEI_TTS_PRIVATE = 15,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_MIN_TTS"]/*' />
    SPEI_MIN_TTS = 1,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_MAX_TTS"]/*' />
    SPEI_MAX_TTS = 15,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_END_SR_STREAM"]/*' />
    SPEI_END_SR_STREAM = 34,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SOUND_START"]/*' />
    SPEI_SOUND_START = 35,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SOUND_END"]/*' />
    SPEI_SOUND_END = 36,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_PHRASE_START"]/*' />
    SPEI_PHRASE_START = 37,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RECOGNITION"]/*' />
    SPEI_RECOGNITION = 38,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_HYPOTHESIS"]/*' />
    SPEI_HYPOTHESIS = 39,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SR_BOOKMARK"]/*' />
    SPEI_SR_BOOKMARK = 40,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_PROPERTY_NUM_CHANGE"]/*' />
    SPEI_PROPERTY_NUM_CHANGE = 41,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_PROPERTY_STRING_CHANGE"]/*' />
    SPEI_PROPERTY_STRING_CHANGE = 42,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_FALSE_RECOGNITION"]/*' />
    SPEI_FALSE_RECOGNITION = 43,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_INTERFERENCE"]/*' />
    SPEI_INTERFERENCE = 44,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_REQUEST_UI"]/*' />
    SPEI_REQUEST_UI = 45,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RECO_STATE_CHANGE"]/*' />
    SPEI_RECO_STATE_CHANGE = 46,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_ADAPTATION"]/*' />
    SPEI_ADAPTATION = 47,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_START_SR_STREAM"]/*' />
    SPEI_START_SR_STREAM = 48,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RECO_OTHER_CONTEXT"]/*' />
    SPEI_RECO_OTHER_CONTEXT = 49,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SR_AUDIO_LEVEL"]/*' />
    SPEI_SR_AUDIO_LEVEL = 50,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SR_RETAINEDAUDIO"]/*' />
    SPEI_SR_RETAINEDAUDIO = 51,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_SR_PRIVATE"]/*' />
    SPEI_SR_PRIVATE = 52,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_ACTIVE_CATEGORY_CHANGED"]/*' />
    SPEI_ACTIVE_CATEGORY_CHANGED = 53,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RESERVED5"]/*' />
    SPEI_RESERVED5 = 54,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RESERVED6"]/*' />
    SPEI_RESERVED6 = 55,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_MIN_SR"]/*' />
    SPEI_MIN_SR = 34,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_MAX_SR"]/*' />
    SPEI_MAX_SR = 55,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RESERVED1"]/*' />
    SPEI_RESERVED1 = 30,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RESERVED2"]/*' />
    SPEI_RESERVED2 = 33,

    /// <include file='SPEVENTENUM.xml' path='doc/member[@name="SPEVENTENUM.SPEI_RESERVED3"]/*' />
    SPEI_RESERVED3 = 63,
}
