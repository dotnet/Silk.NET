// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlEditable.xml' path='doc/member[@name="htmlEditable"]/*' />
public enum htmlEditable
{
    /// <include file='htmlEditable.xml' path='doc/member[@name="htmlEditable.htmlEditableInherit"]/*' />
    htmlEditableInherit = 0,

    /// <include file='htmlEditable.xml' path='doc/member[@name="htmlEditable.htmlEditableTrue"]/*' />
    htmlEditableTrue = 1,

    /// <include file='htmlEditable.xml' path='doc/member[@name="htmlEditable.htmlEditableFalse"]/*' />
    htmlEditableFalse = 2,

    /// <include file='htmlEditable.xml' path='doc/member[@name="htmlEditable.htmlEditable_Max"]/*' />
    htmlEditable_Max = 2147483647,
}
