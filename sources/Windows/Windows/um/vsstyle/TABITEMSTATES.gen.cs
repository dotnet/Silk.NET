// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES"]/*'/>
public enum TABITEMSTATES
{
    /// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES.TIS_NORMAL"]/*'/>
    TIS_NORMAL = 1,
    /// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES.TIS_HOT"]/*'/>
    TIS_HOT = 2,
    /// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES.TIS_SELECTED"]/*'/>
    TIS_SELECTED = 3,
    /// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES.TIS_DISABLED"]/*'/>
    TIS_DISABLED = 4,
    /// <include file='TABITEMSTATES.xml' path='doc/member[@name="TABITEMSTATES.TIS_FOCUSED"]/*'/>
    TIS_FOCUSED = 5,
}