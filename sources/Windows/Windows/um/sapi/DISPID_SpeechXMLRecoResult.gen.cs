// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.DISPID_SpeechRecoResult;

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechXMLRecoResult.xml' path='doc/member[@name="DISPID_SpeechXMLRecoResult"]/*' />
public enum DISPID_SpeechXMLRecoResult
{
    /// <include file='DISPID_SpeechXMLRecoResult.xml' path='doc/member[@name="DISPID_SpeechXMLRecoResult.DISPID_SRRGetXMLResult"]/*' />
    DISPID_SRRGetXMLResult = (DISPID_SRRDiscardResultInfo + 1),

    /// <include file='DISPID_SpeechXMLRecoResult.xml' path='doc/member[@name="DISPID_SpeechXMLRecoResult.DISPID_SRRGetXMLErrorInfo"]/*' />
    DISPID_SRRGetXMLErrorInfo = (DISPID_SRRGetXMLResult + 1),
}
