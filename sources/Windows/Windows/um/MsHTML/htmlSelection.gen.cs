// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection"]/*'/>
public enum htmlSelection
{
    /// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection.htmlSelectionNone"]/*'/>
    htmlSelectionNone = 0,
    /// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection.htmlSelectionText"]/*'/>
    htmlSelectionText = 1,
    /// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection.htmlSelectionControl"]/*'/>
    htmlSelectionControl = 2,
    /// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection.htmlSelectionTable"]/*'/>
    htmlSelectionTable = 3,
    /// <include file='htmlSelection.xml' path='doc/member[@name="htmlSelection.htmlSelection_Max"]/*'/>
    htmlSelection_Max = 2147483647,
}