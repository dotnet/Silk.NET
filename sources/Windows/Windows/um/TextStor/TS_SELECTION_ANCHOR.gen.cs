// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TS_SELECTION_ANCHOR.xml' path='doc/member[@name="TS_SELECTION_ANCHOR"]/*' />
public unsafe partial struct TS_SELECTION_ANCHOR
{
    /// <include file='TS_SELECTION_ANCHOR.xml' path='doc/member[@name="TS_SELECTION_ANCHOR.paStart"]/*' />
    public IAnchor* paStart;

    /// <include file='TS_SELECTION_ANCHOR.xml' path='doc/member[@name="TS_SELECTION_ANCHOR.paEnd"]/*' />
    public IAnchor* paEnd;

    /// <include file='TS_SELECTION_ANCHOR.xml' path='doc/member[@name="TS_SELECTION_ANCHOR.style"]/*' />
    public TS_SELECTIONSTYLE style;
}
