// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor"]/*'/>
public enum styleTextAnchor
{
    /// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor.styleTextAnchorNotSet"]/*'/>
    styleTextAnchorNotSet = 0,
    /// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor.styleTextAnchorStart"]/*'/>
    styleTextAnchorStart = 1,
    /// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor.styleTextAnchorMiddle"]/*'/>
    styleTextAnchorMiddle = 2,
    /// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor.styleTextAnchorEnd"]/*'/>
    styleTextAnchorEnd = 3,
    /// <include file='styleTextAnchor.xml' path='doc/member[@name="styleTextAnchor.styleTextAnchor_Max"]/*'/>
    styleTextAnchor_Max = 2147483647,
}