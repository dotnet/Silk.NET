// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS"]/*' />
public enum MF_TOPOSTATUS
{
    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_INVALID"]/*' />
    MF_TOPOSTATUS_INVALID = 0,

    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_READY"]/*' />
    MF_TOPOSTATUS_READY = 100,

    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_STARTED_SOURCE"]/*' />
    MF_TOPOSTATUS_STARTED_SOURCE = 200,

    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_DYNAMIC_CHANGED"]/*' />
    MF_TOPOSTATUS_DYNAMIC_CHANGED = 210,

    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_SINK_SWITCHED"]/*' />
    MF_TOPOSTATUS_SINK_SWITCHED = 300,

    /// <include file='MF_TOPOSTATUS.xml' path='doc/member[@name="MF_TOPOSTATUS.MF_TOPOSTATUS_ENDED"]/*' />
    MF_TOPOSTATUS_ENDED = 400,
}
