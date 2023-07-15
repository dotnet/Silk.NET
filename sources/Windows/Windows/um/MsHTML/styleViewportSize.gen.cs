// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleViewportSize.xml' path='doc/member[@name="styleViewportSize"]/*'/>
public enum styleViewportSize
{
    /// <include file='styleViewportSize.xml' path='doc/member[@name="styleViewportSize.styleViewportSizeAuto"]/*'/>
    styleViewportSizeAuto = 0,
    /// <include file='styleViewportSize.xml' path='doc/member[@name="styleViewportSize.styleViewportSizeDeviceWidth"]/*'/>
    styleViewportSizeDeviceWidth = 1,
    /// <include file='styleViewportSize.xml' path='doc/member[@name="styleViewportSize.styleViewportSizeDeviceHeight"]/*'/>
    styleViewportSizeDeviceHeight = 2,
    /// <include file='styleViewportSize.xml' path='doc/member[@name="styleViewportSize.styleViewportSize_Max"]/*'/>
    styleViewportSize_Max = 2147483647,
}