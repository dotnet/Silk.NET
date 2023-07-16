// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable"]/*'/>
public enum svgFocusable
{
    /// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable.svgFocusableNotSet"]/*'/>
    svgFocusableNotSet = 0,
    /// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable.svgFocusableAuto"]/*'/>
    svgFocusableAuto = 1,
    /// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable.svgFocusableTrue"]/*'/>
    svgFocusableTrue = 2,
    /// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable.svgFocusableFalse"]/*'/>
    svgFocusableFalse = 3,
    /// <include file='svgFocusable.xml' path='doc/member[@name="svgFocusable.svgFocusable_Max"]/*'/>
    svgFocusable_Max = 2147483647,
}