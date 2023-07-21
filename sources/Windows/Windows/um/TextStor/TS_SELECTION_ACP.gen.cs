// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TS_SELECTION_ACP.xml' path='doc/member[@name="TS_SELECTION_ACP"]/*' />
public partial struct TS_SELECTION_ACP
{
    /// <include file='TS_SELECTION_ACP.xml' path='doc/member[@name="TS_SELECTION_ACP.acpStart"]/*' />
    [NativeTypeName("LONG")]
    public int acpStart;

    /// <include file='TS_SELECTION_ACP.xml' path='doc/member[@name="TS_SELECTION_ACP.acpEnd"]/*' />
    [NativeTypeName("LONG")]
    public int acpEnd;

    /// <include file='TS_SELECTION_ACP.xml' path='doc/member[@name="TS_SELECTION_ACP.style"]/*' />
    public TS_SELECTIONSTYLE style;
}
