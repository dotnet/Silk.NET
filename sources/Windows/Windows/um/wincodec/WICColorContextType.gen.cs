// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICColorContextType.xml' path='doc/member[@name="WICColorContextType"]/*'/>
public enum WICColorContextType
{
    /// <include file='WICColorContextType.xml' path='doc/member[@name="WICColorContextType.WICColorContextUninitialized"]/*'/>
    WICColorContextUninitialized = 0,
    /// <include file='WICColorContextType.xml' path='doc/member[@name="WICColorContextType.WICColorContextProfile"]/*'/>
    WICColorContextProfile = 0x1,
    /// <include file='WICColorContextType.xml' path='doc/member[@name="WICColorContextType.WICColorContextExifColorSpace"]/*'/>
    WICColorContextExifColorSpace = 0x2,
}