// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign"]/*' />
public enum htmlCellAlign
{
    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlignNotSet"]/*' />
    htmlCellAlignNotSet = 0,

    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlignLeft"]/*' />
    htmlCellAlignLeft = 1,

    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlignCenter"]/*' />
    htmlCellAlignCenter = 2,

    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlignRight"]/*' />
    htmlCellAlignRight = 3,

    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlignMiddle"]/*' />
    htmlCellAlignMiddle = htmlCellAlignCenter,

    /// <include file='htmlCellAlign.xml' path='doc/member[@name="htmlCellAlign.htmlCellAlign_Max"]/*' />
    htmlCellAlign_Max = 2147483647,
}
