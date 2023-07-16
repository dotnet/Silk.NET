// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SpeechEngineConfidence.xml' path='doc/member[@name="SpeechEngineConfidence"]/*'/>
public enum SpeechEngineConfidence
{
    /// <include file='SpeechEngineConfidence.xml' path='doc/member[@name="SpeechEngineConfidence.SECLowConfidence"]/*'/>
    SECLowConfidence = -1,
    /// <include file='SpeechEngineConfidence.xml' path='doc/member[@name="SpeechEngineConfidence.SECNormalConfidence"]/*'/>
    SECNormalConfidence = 0,
    /// <include file='SpeechEngineConfidence.xml' path='doc/member[@name="SpeechEngineConfidence.SECHighConfidence"]/*'/>
    SECHighConfidence = 1,
}