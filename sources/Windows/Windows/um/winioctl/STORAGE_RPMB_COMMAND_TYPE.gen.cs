// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE"]/*' />
public enum STORAGE_RPMB_COMMAND_TYPE
{
    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbProgramAuthKey"]/*' />
    StorRpmbProgramAuthKey = 0x00000001,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbQueryWriteCounter"]/*' />
    StorRpmbQueryWriteCounter = 0x00000002,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbAuthenticatedWrite"]/*' />
    StorRpmbAuthenticatedWrite = 0x00000003,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbAuthenticatedRead"]/*' />
    StorRpmbAuthenticatedRead = 0x00000004,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbReadResultRequest"]/*' />
    StorRpmbReadResultRequest = 0x00000005,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbAuthenticatedDeviceConfigWrite"]/*' />
    StorRpmbAuthenticatedDeviceConfigWrite = 0x00000006,

    /// <include file='STORAGE_RPMB_COMMAND_TYPE.xml' path='doc/member[@name="STORAGE_RPMB_COMMAND_TYPE.StorRpmbAuthenticatedDeviceConfigRead"]/*' />
    StorRpmbAuthenticatedDeviceConfigRead = 0x00000007,
}
