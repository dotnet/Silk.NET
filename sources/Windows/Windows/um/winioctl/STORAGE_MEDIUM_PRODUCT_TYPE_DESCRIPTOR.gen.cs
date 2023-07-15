// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR
{
    /// <include file='STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR.MediumProductType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MediumProductType;
}