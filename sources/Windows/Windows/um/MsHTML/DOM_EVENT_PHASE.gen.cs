// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DOM_EVENT_PHASE.xml' path='doc/member[@name="DOM_EVENT_PHASE"]/*'/>
public enum DOM_EVENT_PHASE
{
    /// <include file='DOM_EVENT_PHASE.xml' path='doc/member[@name="DOM_EVENT_PHASE.DEP_CAPTURING_PHASE"]/*'/>
    DEP_CAPTURING_PHASE = 0x1,
    /// <include file='DOM_EVENT_PHASE.xml' path='doc/member[@name="DOM_EVENT_PHASE.DEP_AT_TARGET"]/*'/>
    DEP_AT_TARGET = 0x2,
    /// <include file='DOM_EVENT_PHASE.xml' path='doc/member[@name="DOM_EVENT_PHASE.DEP_BUBBLING_PHASE"]/*'/>
    DEP_BUBBLING_PHASE = 0x3,
    /// <include file='DOM_EVENT_PHASE.xml' path='doc/member[@name="DOM_EVENT_PHASE.DOM_EVENT_PHASE_Max"]/*'/>
    DOM_EVENT_PHASE_Max = 2147483647,
}