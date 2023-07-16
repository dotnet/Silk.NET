// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES"]/*'/>
public enum TREEITEMSTATES
{
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_NORMAL"]/*'/>
    TREIS_NORMAL = 1,
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_HOT"]/*'/>
    TREIS_HOT = 2,
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_SELECTED"]/*'/>
    TREIS_SELECTED = 3,
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_DISABLED"]/*'/>
    TREIS_DISABLED = 4,
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_SELECTEDNOTFOCUS"]/*'/>
    TREIS_SELECTEDNOTFOCUS = 5,
    /// <include file='TREEITEMSTATES.xml' path='doc/member[@name="TREEITEMSTATES.TREIS_HOTSELECTED"]/*'/>
    TREIS_HOTSELECTED = 6,
}