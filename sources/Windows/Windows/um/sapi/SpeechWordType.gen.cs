// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPWORDTYPE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechWordType.xml' path='doc/member[@name="SpeechWordType"]/*'/>
public enum SpeechWordType
{
    /// <include file='SpeechWordType.xml' path='doc/member[@name="SpeechWordType.SWTAdded"]/*'/>
    SWTAdded = eWORDTYPE_ADDED,
    /// <include file='SpeechWordType.xml' path='doc/member[@name="SpeechWordType.SWTDeleted"]/*'/>
    SWTDeleted = eWORDTYPE_DELETED,
}