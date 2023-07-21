// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_FAULT_REASON.xml' path='doc/member[@name="WS_FAULT_REASON"]/*' />
public partial struct WS_FAULT_REASON
{
    /// <include file='WS_FAULT_REASON.xml' path='doc/member[@name="WS_FAULT_REASON.text"]/*' />
    public WS_STRING text;

    /// <include file='WS_FAULT_REASON.xml' path='doc/member[@name="WS_FAULT_REASON.lang"]/*' />
    public WS_STRING lang;
}
