// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip"]/*'/>
public enum styleBackgroundClip
{
    /// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip.styleBackgroundClipBorderBox"]/*'/>
    styleBackgroundClipBorderBox = 0,
    /// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip.styleBackgroundClipPaddingBox"]/*'/>
    styleBackgroundClipPaddingBox = 1,
    /// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip.styleBackgroundClipContentBox"]/*'/>
    styleBackgroundClipContentBox = 2,
    /// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip.styleBackgroundClipNotSet"]/*'/>
    styleBackgroundClipNotSet = 3,
    /// <include file='styleBackgroundClip.xml' path='doc/member[@name="styleBackgroundClip.styleBackgroundClip_Max"]/*'/>
    styleBackgroundClip_Max = 2147483647,
}