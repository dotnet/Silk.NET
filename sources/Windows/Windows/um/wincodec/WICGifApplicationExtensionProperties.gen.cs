// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICGifApplicationExtensionProperties.xml' path='doc/member[@name="WICGifApplicationExtensionProperties"]/*'/>
public enum WICGifApplicationExtensionProperties
{
    /// <include file='WICGifApplicationExtensionProperties.xml' path='doc/member[@name="WICGifApplicationExtensionProperties.WICGifApplicationExtensionApplication"]/*'/>
    WICGifApplicationExtensionApplication = 0x1,
    /// <include file='WICGifApplicationExtensionProperties.xml' path='doc/member[@name="WICGifApplicationExtensionProperties.WICGifApplicationExtensionData"]/*'/>
    WICGifApplicationExtensionData = 0x2,
    /// <include file='WICGifApplicationExtensionProperties.xml' path='doc/member[@name="WICGifApplicationExtensionProperties.WICGifApplicationExtensionProperties_FORCE_DWORD"]/*'/>
    WICGifApplicationExtensionProperties_FORCE_DWORD = 0x7fffffff,
}