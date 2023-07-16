// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechMMSysAudio.xml' path='doc/member[@name="DISPID_SpeechMMSysAudio"]/*'/>
public enum DISPID_SpeechMMSysAudio
{
    /// <include file='DISPID_SpeechMMSysAudio.xml' path='doc/member[@name="DISPID_SpeechMMSysAudio.DISPID_SMSADeviceId"]/*'/>
    DISPID_SMSADeviceId = 300,
    /// <include file='DISPID_SpeechMMSysAudio.xml' path='doc/member[@name="DISPID_SpeechMMSysAudio.DISPID_SMSALineId"]/*'/>
    DISPID_SMSALineId = (DISPID_SMSADeviceId + 1),
    /// <include file='DISPID_SpeechMMSysAudio.xml' path='doc/member[@name="DISPID_SpeechMMSysAudio.DISPID_SMSAMMHandle"]/*'/>
    DISPID_SMSAMMHandle = (DISPID_SMSALineId + 1),
}