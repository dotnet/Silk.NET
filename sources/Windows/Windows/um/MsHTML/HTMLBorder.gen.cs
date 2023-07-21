// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder"]/*' />
public enum HTMLBorder
{
    /// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder.HTMLBorderNone"]/*' />
    HTMLBorderNone = 0,

    /// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder.HTMLBorderThick"]/*' />
    HTMLBorderThick = 0x40000,

    /// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder.HTMLBorderDialog"]/*' />
    HTMLBorderDialog = 0x400000,

    /// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder.HTMLBorderThin"]/*' />
    HTMLBorderThin = 0x800000,

    /// <include file='HTMLBorder.xml' path='doc/member[@name="HTMLBorder.HTMLBorder_Max"]/*' />
    HTMLBorder_Max = 2147483647,
}
