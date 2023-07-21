// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleListStylePosition.xml' path='doc/member[@name="styleListStylePosition"]/*' />
public enum styleListStylePosition
{
    /// <include file='styleListStylePosition.xml' path='doc/member[@name="styleListStylePosition.styleListStylePositionNotSet"]/*' />
    styleListStylePositionNotSet = 0,

    /// <include file='styleListStylePosition.xml' path='doc/member[@name="styleListStylePosition.styleListStylePositionInside"]/*' />
    styleListStylePositionInside = 1,

    /// <include file='styleListStylePosition.xml' path='doc/member[@name="styleListStylePosition.styleListStylePositionOutSide"]/*' />
    styleListStylePositionOutSide = 2,

    /// <include file='styleListStylePosition.xml' path='doc/member[@name="styleListStylePosition.styleListStylePosition_Max"]/*' />
    styleListStylePosition_Max = 2147483647,
}
