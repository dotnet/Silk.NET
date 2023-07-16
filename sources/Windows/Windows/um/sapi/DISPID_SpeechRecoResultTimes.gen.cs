// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechRecoResultTimes.xml' path='doc/member[@name="DISPID_SpeechRecoResultTimes"]/*'/>
public enum DISPID_SpeechRecoResultTimes
{
    /// <include file='DISPID_SpeechRecoResultTimes.xml' path='doc/member[@name="DISPID_SpeechRecoResultTimes.DISPID_SRRTStreamTime"]/*'/>
    DISPID_SRRTStreamTime = 1,
    /// <include file='DISPID_SpeechRecoResultTimes.xml' path='doc/member[@name="DISPID_SpeechRecoResultTimes.DISPID_SRRTLength"]/*'/>
    DISPID_SRRTLength = (DISPID_SRRTStreamTime + 1),
    /// <include file='DISPID_SpeechRecoResultTimes.xml' path='doc/member[@name="DISPID_SpeechRecoResultTimes.DISPID_SRRTTickCount"]/*'/>
    DISPID_SRRTTickCount = (DISPID_SRRTLength + 1),
    /// <include file='DISPID_SpeechRecoResultTimes.xml' path='doc/member[@name="DISPID_SpeechRecoResultTimes.DISPID_SRRTOffsetFromStart"]/*'/>
    DISPID_SRRTOffsetFromStart = (DISPID_SRRTTickCount + 1),
}