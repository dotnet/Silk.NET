// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState"]/*' />
public enum htmlMediaReadyState
{
    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyStateHaveNothing"]/*' />
    htmlMediaReadyStateHaveNothing = 0,

    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyStateHaveMetadata"]/*' />
    htmlMediaReadyStateHaveMetadata = 1,

    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyStateHaveCurrentData"]/*' />
    htmlMediaReadyStateHaveCurrentData = 2,

    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyStateHaveFutureData"]/*' />
    htmlMediaReadyStateHaveFutureData = 3,

    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyStateHaveEnoughData"]/*' />
    htmlMediaReadyStateHaveEnoughData = 4,

    /// <include file='htmlMediaReadyState.xml' path='doc/member[@name="htmlMediaReadyState.htmlMediaReadyState_Max"]/*' />
    htmlMediaReadyState_Max = 2147483647,
}
