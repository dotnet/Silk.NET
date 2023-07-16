// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleBorderCollapse.xml' path='doc/member[@name="styleBorderCollapse"]/*'/>
public enum styleBorderCollapse
{
    /// <include file='styleBorderCollapse.xml' path='doc/member[@name="styleBorderCollapse.styleBorderCollapseNotSet"]/*'/>
    styleBorderCollapseNotSet = 0,
    /// <include file='styleBorderCollapse.xml' path='doc/member[@name="styleBorderCollapse.styleBorderCollapseSeparate"]/*'/>
    styleBorderCollapseSeparate = 1,
    /// <include file='styleBorderCollapse.xml' path='doc/member[@name="styleBorderCollapse.styleBorderCollapseCollapse"]/*'/>
    styleBorderCollapseCollapse = 2,
    /// <include file='styleBorderCollapse.xml' path='doc/member[@name="styleBorderCollapse.styleBorderCollapse_Max"]/*'/>
    styleBorderCollapse_Max = 2147483647,
}