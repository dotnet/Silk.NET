// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_PROPERTY_SET.xml' path='doc/member[@name="STORAGE_PROPERTY_SET"]/*'/>
public unsafe partial struct STORAGE_PROPERTY_SET
{
    /// <include file='STORAGE_PROPERTY_SET.xml' path='doc/member[@name="STORAGE_PROPERTY_SET.PropertyId"]/*'/>
    public STORAGE_PROPERTY_ID PropertyId;
    /// <include file='STORAGE_PROPERTY_SET.xml' path='doc/member[@name="STORAGE_PROPERTY_SET.SetType"]/*'/>
    public STORAGE_SET_TYPE SetType;
    /// <include file='STORAGE_PROPERTY_SET.xml' path='doc/member[@name="STORAGE_PROPERTY_SET.AdditionalParameters"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte AdditionalParameters[1];
}