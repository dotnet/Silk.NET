// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eAVEncAudioInputContent.xml' path='doc/member[@name="eAVEncAudioInputContent"]/*'/>
public enum eAVEncAudioInputContent
{
    /// <include file='eAVEncAudioInputContent.xml' path='doc/member[@name="eAVEncAudioInputContent.AVEncAudioInputContent_Unknown"]/*'/>
    AVEncAudioInputContent_Unknown = 0,
    /// <include file='eAVEncAudioInputContent.xml' path='doc/member[@name="eAVEncAudioInputContent.AVEncAudioInputContent_Voice"]/*'/>
    AVEncAudioInputContent_Voice = 1,
    /// <include file='eAVEncAudioInputContent.xml' path='doc/member[@name="eAVEncAudioInputContent.AVEncAudioInputContent_Music"]/*'/>
    AVEncAudioInputContent_Music = 2,
}