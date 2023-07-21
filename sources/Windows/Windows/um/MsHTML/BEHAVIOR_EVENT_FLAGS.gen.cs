// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BEHAVIOR_EVENT_FLAGS.xml' path='doc/member[@name="BEHAVIOR_EVENT_FLAGS"]/*' />
public enum BEHAVIOR_EVENT_FLAGS
{
    /// <include file='BEHAVIOR_EVENT_FLAGS.xml' path='doc/member[@name="BEHAVIOR_EVENT_FLAGS.BEHAVIOREVENTFLAGS_BUBBLE"]/*' />
    BEHAVIOREVENTFLAGS_BUBBLE = 1,

    /// <include file='BEHAVIOR_EVENT_FLAGS.xml' path='doc/member[@name="BEHAVIOR_EVENT_FLAGS.BEHAVIOREVENTFLAGS_STANDARDADDITIVE"]/*' />
    BEHAVIOREVENTFLAGS_STANDARDADDITIVE = 2,

    /// <include file='BEHAVIOR_EVENT_FLAGS.xml' path='doc/member[@name="BEHAVIOR_EVENT_FLAGS.BEHAVIOR_EVENT_FLAGS_Max"]/*' />
    BEHAVIOR_EVENT_FLAGS_Max = 2147483647,
}
