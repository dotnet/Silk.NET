// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPCONTEXTSTATE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechRecoContextState.xml' path='doc/member[@name="SpeechRecoContextState"]/*'/>
public enum SpeechRecoContextState
{
    /// <include file='SpeechRecoContextState.xml' path='doc/member[@name="SpeechRecoContextState.SRCS_Disabled"]/*'/>
    SRCS_Disabled = SPCS_DISABLED,
    /// <include file='SpeechRecoContextState.xml' path='doc/member[@name="SpeechRecoContextState.SRCS_Enabled"]/*'/>
    SRCS_Enabled = SPCS_ENABLED,
}