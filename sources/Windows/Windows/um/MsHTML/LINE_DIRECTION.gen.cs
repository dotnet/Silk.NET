// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LINE_DIRECTION.xml' path='doc/member[@name="LINE_DIRECTION"]/*' />
public enum LINE_DIRECTION
{
    /// <include file='LINE_DIRECTION.xml' path='doc/member[@name="LINE_DIRECTION.LINE_DIRECTION_RightToLeft"]/*' />
    LINE_DIRECTION_RightToLeft = 1,

    /// <include file='LINE_DIRECTION.xml' path='doc/member[@name="LINE_DIRECTION.LINE_DIRECTION_LeftToRight"]/*' />
    LINE_DIRECTION_LeftToRight = 2,

    /// <include file='LINE_DIRECTION.xml' path='doc/member[@name="LINE_DIRECTION.LINE_DIRECTION_Max"]/*' />
    LINE_DIRECTION_Max = 2147483647,
}
