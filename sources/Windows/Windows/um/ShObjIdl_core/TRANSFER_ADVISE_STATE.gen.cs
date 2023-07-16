// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TRANSFER_ADVISE_STATE.xml' path='doc/member[@name="TRANSFER_ADVISE_STATE"]/*'/>
[Flags]
public enum TRANSFER_ADVISE_STATE
{
    /// <include file='TRANSFER_ADVISE_STATE.xml' path='doc/member[@name="TRANSFER_ADVISE_STATE.TS_NONE"]/*'/>
    TS_NONE = 0,
    /// <include file='TRANSFER_ADVISE_STATE.xml' path='doc/member[@name="TRANSFER_ADVISE_STATE.TS_PERFORMING"]/*'/>
    TS_PERFORMING = 0x1,
    /// <include file='TRANSFER_ADVISE_STATE.xml' path='doc/member[@name="TRANSFER_ADVISE_STATE.TS_PREPARING"]/*'/>
    TS_PREPARING = 0x2,
    /// <include file='TRANSFER_ADVISE_STATE.xml' path='doc/member[@name="TRANSFER_ADVISE_STATE.TS_INDETERMINATE"]/*'/>
    TS_INDETERMINATE = 0x4,
}