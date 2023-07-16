// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_FLAGS
{
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_NONE"]/*'/>
    INTERACTION_FLAG_NONE = 0x00000000,
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_BEGIN"]/*'/>
    INTERACTION_FLAG_BEGIN = 0x00000001,
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_END"]/*'/>
    INTERACTION_FLAG_END = 0x00000002,
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_CANCEL"]/*'/>
    INTERACTION_FLAG_CANCEL = 0x00000004,
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_INERTIA"]/*'/>
    INTERACTION_FLAG_INERTIA = 0x00000008,
    /// <include file='INTERACTION_FLAGS.xml' path='doc/member[@name="INTERACTION_FLAGS.INTERACTION_FLAG_MAX"]/*'/>
    INTERACTION_FLAG_MAX = unchecked((int)(0xffffffff)),
}