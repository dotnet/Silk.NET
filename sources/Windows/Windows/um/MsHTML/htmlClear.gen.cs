// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlClear.xml' path='doc/member[@name="htmlClear"]/*'/>
public enum htmlClear
{
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearNotSet"]/*'/>
    htmlClearNotSet = 0,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearAll"]/*'/>
    htmlClearAll = 1,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearLeft"]/*'/>
    htmlClearLeft = 2,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearRight"]/*'/>
    htmlClearRight = 3,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearBoth"]/*'/>
    htmlClearBoth = 4,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClearNone"]/*'/>
    htmlClearNone = 5,
    /// <include file='htmlClear.xml' path='doc/member[@name="htmlClear.htmlClear_Max"]/*'/>
    htmlClear_Max = 2147483647,
}