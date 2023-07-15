// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin"]/*'/>
public enum styleBackgroundOrigin
{
    /// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin.styleBackgroundOriginBorderBox"]/*'/>
    styleBackgroundOriginBorderBox = 0,
    /// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin.styleBackgroundOriginPaddingBox"]/*'/>
    styleBackgroundOriginPaddingBox = 1,
    /// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin.styleBackgroundOriginContentBox"]/*'/>
    styleBackgroundOriginContentBox = 2,
    /// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin.styleBackgroundOriginNotSet"]/*'/>
    styleBackgroundOriginNotSet = 3,
    /// <include file='styleBackgroundOrigin.xml' path='doc/member[@name="styleBackgroundOrigin.styleBackgroundOrigin_Max"]/*'/>
    styleBackgroundOrigin_Max = 2147483647,
}