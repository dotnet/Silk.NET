// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_DEVICE_PROPERTY
{
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.logicalMin"]/*'/>
    [NativeTypeName("INT32")]
    public int logicalMin;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.logicalMax"]/*'/>
    [NativeTypeName("INT32")]
    public int logicalMax;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.physicalMin"]/*'/>
    [NativeTypeName("INT32")]
    public int physicalMin;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.physicalMax"]/*'/>
    [NativeTypeName("INT32")]
    public int physicalMax;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.unit"]/*'/>
    [NativeTypeName("UINT32")]
    public uint unit;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.unitExponent"]/*'/>
    [NativeTypeName("UINT32")]
    public uint unitExponent;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.usagePageId"]/*'/>
    public ushort usagePageId;
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.usageId"]/*'/>
    public ushort usageId;
}