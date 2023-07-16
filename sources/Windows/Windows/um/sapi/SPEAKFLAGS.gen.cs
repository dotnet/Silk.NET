// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS"]/*'/>
public enum SPEAKFLAGS
{
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_DEFAULT"]/*'/>
    SPF_DEFAULT = 0,
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_ASYNC"]/*'/>
    SPF_ASYNC = (1 << 0),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PURGEBEFORESPEAK"]/*'/>
    SPF_PURGEBEFORESPEAK = (1 << 1),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_IS_FILENAME"]/*'/>
    SPF_IS_FILENAME = (1 << 2),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_IS_XML"]/*'/>
    SPF_IS_XML = (1 << 3),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_IS_NOT_XML"]/*'/>
    SPF_IS_NOT_XML = (1 << 4),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PERSIST_XML"]/*'/>
    SPF_PERSIST_XML = (1 << 5),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_NLP_SPEAK_PUNC"]/*'/>
    SPF_NLP_SPEAK_PUNC = (1 << 6),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PARSE_SAPI"]/*'/>
    SPF_PARSE_SAPI = (1 << 7),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PARSE_SSML"]/*'/>
    SPF_PARSE_SSML = (1 << 8),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PARSE_AUTODETECT"]/*'/>
    SPF_PARSE_AUTODETECT = 0,
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_NLP_MASK"]/*'/>
    SPF_NLP_MASK = SPF_NLP_SPEAK_PUNC,
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_PARSE_MASK"]/*'/>
    SPF_PARSE_MASK = (SPF_PARSE_SAPI | SPF_PARSE_SSML),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_VOICE_MASK"]/*'/>
    SPF_VOICE_MASK = (((((((SPF_ASYNC | SPF_PURGEBEFORESPEAK) | SPF_IS_FILENAME) | SPF_IS_XML) | SPF_IS_NOT_XML) | SPF_NLP_MASK) | SPF_PERSIST_XML) | SPF_PARSE_MASK),
    /// <include file='SPEAKFLAGS.xml' path='doc/member[@name="SPEAKFLAGS.SPF_UNUSED_FLAGS"]/*'/>
    SPF_UNUSED_FLAGS = ~SPF_VOICE_MASK,
}