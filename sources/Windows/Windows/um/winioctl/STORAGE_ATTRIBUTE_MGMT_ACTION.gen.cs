// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_ATTRIBUTE_MGMT_ACTION.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT_ACTION"]/*'/>
public enum STORAGE_ATTRIBUTE_MGMT_ACTION
{
    /// <include file='STORAGE_ATTRIBUTE_MGMT_ACTION.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT_ACTION.StorAttributeMgmt_ClearAttribute"]/*'/>
    StorAttributeMgmt_ClearAttribute = 0,
    /// <include file='STORAGE_ATTRIBUTE_MGMT_ACTION.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT_ACTION.StorAttributeMgmt_SetAttribute"]/*'/>
    StorAttributeMgmt_SetAttribute = 1,
    /// <include file='STORAGE_ATTRIBUTE_MGMT_ACTION.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT_ACTION.StorAttributeMgmt_ResetAttribute"]/*'/>
    StorAttributeMgmt_ResetAttribute = 2,
}