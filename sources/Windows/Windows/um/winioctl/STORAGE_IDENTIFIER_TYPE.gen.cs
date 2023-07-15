// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE"]/*'/>
public enum STORAGE_IDENTIFIER_TYPE
{
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeVendorSpecific"]/*'/>
    StorageIdTypeVendorSpecific = 0,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeVendorId"]/*'/>
    StorageIdTypeVendorId = 1,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeEUI64"]/*'/>
    StorageIdTypeEUI64 = 2,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeFCPHName"]/*'/>
    StorageIdTypeFCPHName = 3,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypePortRelative"]/*'/>
    StorageIdTypePortRelative = 4,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeTargetPortGroup"]/*'/>
    StorageIdTypeTargetPortGroup = 5,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeLogicalUnitGroup"]/*'/>
    StorageIdTypeLogicalUnitGroup = 6,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeMD5LogicalUnitIdentifier"]/*'/>
    StorageIdTypeMD5LogicalUnitIdentifier = 7,
    /// <include file='STORAGE_IDENTIFIER_TYPE.xml' path='doc/member[@name="STORAGE_IDENTIFIER_TYPE.StorageIdTypeScsiNameString"]/*'/>
    StorageIdTypeScsiNameString = 8,
}