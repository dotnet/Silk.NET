// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET"]/*'/>
public enum STORAGE_PORT_CODE_SET
{
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetReserved"]/*'/>
    StoragePortCodeSetReserved = 0,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetStorport"]/*'/>
    StoragePortCodeSetStorport = 1,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetSCSIport"]/*'/>
    StoragePortCodeSetSCSIport = 2,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetSpaceport"]/*'/>
    StoragePortCodeSetSpaceport = 3,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetATAport"]/*'/>
    StoragePortCodeSetATAport = 4,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetUSBport"]/*'/>
    StoragePortCodeSetUSBport = 5,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetSBP2port"]/*'/>
    StoragePortCodeSetSBP2port = 6,
    /// <include file='STORAGE_PORT_CODE_SET.xml' path='doc/member[@name="STORAGE_PORT_CODE_SET.StoragePortCodeSetSDport"]/*'/>
    StoragePortCodeSetSDport = 7,
}