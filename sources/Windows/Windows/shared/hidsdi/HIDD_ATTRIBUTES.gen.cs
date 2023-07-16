// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HIDD_ATTRIBUTES.xml' path='doc/member[@name="HIDD_ATTRIBUTES"]/*'/>
public partial struct HIDD_ATTRIBUTES
{
    /// <include file='HIDD_ATTRIBUTES.xml' path='doc/member[@name="HIDD_ATTRIBUTES.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='HIDD_ATTRIBUTES.xml' path='doc/member[@name="HIDD_ATTRIBUTES.VendorID"]/*'/>
    public ushort VendorID;
    /// <include file='HIDD_ATTRIBUTES.xml' path='doc/member[@name="HIDD_ATTRIBUTES.ProductID"]/*'/>
    public ushort ProductID;
    /// <include file='HIDD_ATTRIBUTES.xml' path='doc/member[@name="HIDD_ATTRIBUTES.VersionNumber"]/*'/>
    public ushort VersionNumber;
}