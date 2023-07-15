// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType"]/*'/>
public enum WICComponentType
{
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICDecoder"]/*'/>
    WICDecoder = 0x1,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICEncoder"]/*'/>
    WICEncoder = 0x2,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICPixelFormatConverter"]/*'/>
    WICPixelFormatConverter = 0x4,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICMetadataReader"]/*'/>
    WICMetadataReader = 0x8,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICMetadataWriter"]/*'/>
    WICMetadataWriter = 0x10,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICPixelFormat"]/*'/>
    WICPixelFormat = 0x20,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICAllComponents"]/*'/>
    WICAllComponents = 0x3f,
    /// <include file='WICComponentType.xml' path='doc/member[@name="WICComponentType.WICCOMPONENTTYPE_FORCE_DWORD"]/*'/>
    WICCOMPONENTTYPE_FORCE_DWORD = 0x7fffffff,
}