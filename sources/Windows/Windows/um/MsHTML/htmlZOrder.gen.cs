// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlZOrder.xml' path='doc/member[@name="htmlZOrder"]/*'/>
public enum htmlZOrder
{
    /// <include file='htmlZOrder.xml' path='doc/member[@name="htmlZOrder.htmlZOrderFront"]/*'/>
    htmlZOrderFront = 0,
    /// <include file='htmlZOrder.xml' path='doc/member[@name="htmlZOrder.htmlZOrderBack"]/*'/>
    htmlZOrderBack = 1,
    /// <include file='htmlZOrder.xml' path='doc/member[@name="htmlZOrder.htmlZOrder_Max"]/*'/>
    htmlZOrder_Max = 2147483647,
}