// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS"]/*'/>
[Flags]
public enum tagMENUPOPUPPOPUPFLAGS
{
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_SETFOCUS"]/*'/>
    MPPF_SETFOCUS = 0x1,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_INITIALSELECT"]/*'/>
    MPPF_INITIALSELECT = 0x2,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_NOANIMATE"]/*'/>
    MPPF_NOANIMATE = 0x4,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_KEYBOARD"]/*'/>
    MPPF_KEYBOARD = 0x10,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_REPOSITION"]/*'/>
    MPPF_REPOSITION = 0x20,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_FORCEZORDER"]/*'/>
    MPPF_FORCEZORDER = 0x40,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_FINALSELECT"]/*'/>
    MPPF_FINALSELECT = 0x80,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_TOP"]/*'/>
    MPPF_TOP = 0x20000000,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_LEFT"]/*'/>
    MPPF_LEFT = 0x40000000,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_RIGHT"]/*'/>
    MPPF_RIGHT = 0x60000000,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_BOTTOM"]/*'/>
    MPPF_BOTTOM = unchecked((int)(0x80000000)),
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_POS_MASK"]/*'/>
    MPPF_POS_MASK = unchecked((int)(0xe0000000)),
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_ALIGN_LEFT"]/*'/>
    MPPF_ALIGN_LEFT = 0x2000000,
    /// <include file='tagMENUPOPUPPOPUPFLAGS.xml' path='doc/member[@name="tagMENUPOPUPPOPUPFLAGS.MPPF_ALIGN_RIGHT"]/*'/>
    MPPF_ALIGN_RIGHT = 0x4000000,
}