// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState"]/*' />
public enum htmlReadyState
{
    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyStateuninitialized"]/*' />
    htmlReadyStateuninitialized = 0,

    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyStateloading"]/*' />
    htmlReadyStateloading = 1,

    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyStateloaded"]/*' />
    htmlReadyStateloaded = 2,

    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyStateinteractive"]/*' />
    htmlReadyStateinteractive = 3,

    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyStatecomplete"]/*' />
    htmlReadyStatecomplete = 4,

    /// <include file='htmlReadyState.xml' path='doc/member[@name="htmlReadyState.htmlReadyState_Max"]/*' />
    htmlReadyState_Max = 2147483647,
}
