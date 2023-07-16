// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility"]/*'/>
public enum styleVisibility
{
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibilityNotSet"]/*'/>
    styleVisibilityNotSet = 0,
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibilityInherit"]/*'/>
    styleVisibilityInherit = 1,
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibilityVisible"]/*'/>
    styleVisibilityVisible = 2,
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibilityHidden"]/*'/>
    styleVisibilityHidden = 3,
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibilityCollapse"]/*'/>
    styleVisibilityCollapse = 4,
    /// <include file='styleVisibility.xml' path='doc/member[@name="styleVisibility.styleVisibility_Max"]/*'/>
    styleVisibility_Max = 2147483647,
}