// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_RPMB_FRAME_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_FRAME_TYPE"]/*'/>
public enum STORAGE_RPMB_FRAME_TYPE
{
    /// <include file='STORAGE_RPMB_FRAME_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_FRAME_TYPE.StorageRpmbFrameTypeUnknown"]/*'/>
    StorageRpmbFrameTypeUnknown = 0,
    /// <include file='STORAGE_RPMB_FRAME_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_FRAME_TYPE.StorageRpmbFrameTypeStandard"]/*'/>
    StorageRpmbFrameTypeStandard,
    /// <include file='STORAGE_RPMB_FRAME_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_FRAME_TYPE.StorageRpmbFrameTypeMax"]/*'/>
    StorageRpmbFrameTypeMax,
}