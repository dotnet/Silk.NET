// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICRawRenderMode.xml' path='doc/member[@name="WICRawRenderMode"]/*'/>
public enum WICRawRenderMode
{
    /// <include file='WICRawRenderMode.xml' path='doc/member[@name="WICRawRenderMode.WICRawRenderModeDraft"]/*'/>
    WICRawRenderModeDraft = 0x1,
    /// <include file='WICRawRenderMode.xml' path='doc/member[@name="WICRawRenderMode.WICRawRenderModeNormal"]/*'/>
    WICRawRenderModeNormal = 0x2,
    /// <include file='WICRawRenderMode.xml' path='doc/member[@name="WICRawRenderMode.WICRawRenderModeBestQuality"]/*'/>
    WICRawRenderModeBestQuality = 0x3,
    /// <include file='WICRawRenderMode.xml' path='doc/member[@name="WICRawRenderMode.WICRAWRENDERMODE_FORCE_DWORD"]/*'/>
    WICRAWRENDERMODE_FORCE_DWORD = 0x7fffffff,
}