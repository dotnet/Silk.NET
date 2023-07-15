// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.DISPID_SpeechXMLRecoResult;

namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechRecoResult2.xml' path='doc/member[@name="DISPID_SpeechRecoResult2"]/*'/>
public enum DISPID_SpeechRecoResult2
{
    /// <include file='DISPID_SpeechRecoResult2.xml' path='doc/member[@name="DISPID_SpeechRecoResult2.DISPID_SRRSetTextFeedback"]/*'/>
    DISPID_SRRSetTextFeedback = (DISPID_SRRGetXMLErrorInfo + 1),
}