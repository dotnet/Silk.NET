// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VfwCaptureDialogs.xml' path='doc/member[@name="VfwCaptureDialogs"]/*'/>
public enum VfwCaptureDialogs
{
    /// <include file='VfwCaptureDialogs.xml' path='doc/member[@name="VfwCaptureDialogs.VfwCaptureDialog_Source"]/*'/>
    VfwCaptureDialog_Source = 0x1,
    /// <include file='VfwCaptureDialogs.xml' path='doc/member[@name="VfwCaptureDialogs.VfwCaptureDialog_Format"]/*'/>
    VfwCaptureDialog_Format = 0x2,
    /// <include file='VfwCaptureDialogs.xml' path='doc/member[@name="VfwCaptureDialogs.VfwCaptureDialog_Display"]/*'/>
    VfwCaptureDialog_Display = 0x4,
}