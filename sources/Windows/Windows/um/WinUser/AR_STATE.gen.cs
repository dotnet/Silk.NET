// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE"]/*'/>
[Flags]
public enum AR_STATE
{
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_ENABLED"]/*'/>
    AR_ENABLED = 0x0,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_DISABLED"]/*'/>
    AR_DISABLED = 0x1,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_SUPPRESSED"]/*'/>
    AR_SUPPRESSED = 0x2,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_REMOTESESSION"]/*'/>
    AR_REMOTESESSION = 0x4,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_MULTIMON"]/*'/>
    AR_MULTIMON = 0x8,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_NOSENSOR"]/*'/>
    AR_NOSENSOR = 0x10,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_NOT_SUPPORTED"]/*'/>
    AR_NOT_SUPPORTED = 0x20,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_DOCKED"]/*'/>
    AR_DOCKED = 0x40,
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_LAPTOP"]/*'/>
    AR_LAPTOP = 0x80,
}