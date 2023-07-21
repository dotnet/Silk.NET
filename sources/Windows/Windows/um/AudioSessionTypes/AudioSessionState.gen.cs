// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AudioSessionTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AudioSessionState.xml' path='doc/member[@name="AudioSessionState"]/*' />
public enum AudioSessionState
{
    /// <include file='AudioSessionState.xml' path='doc/member[@name="AudioSessionState.AudioSessionStateInactive"]/*' />
    AudioSessionStateInactive = 0,

    /// <include file='AudioSessionState.xml' path='doc/member[@name="AudioSessionState.AudioSessionStateActive"]/*' />
    AudioSessionStateActive = 1,

    /// <include file='AudioSessionState.xml' path='doc/member[@name="AudioSessionState.AudioSessionStateExpired"]/*' />
    AudioSessionStateExpired = 2,
}
