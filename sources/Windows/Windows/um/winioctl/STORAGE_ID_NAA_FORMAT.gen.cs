// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ID_NAA_FORMAT.xml' path='doc/member[@name="STORAGE_ID_NAA_FORMAT"]/*'/>
public enum STORAGE_ID_NAA_FORMAT
{
    /// <include file='STORAGE_ID_NAA_FORMAT.xml' path='doc/member[@name="STORAGE_ID_NAA_FORMAT.StorageIdNAAFormatIEEEExtended"]/*'/>
    StorageIdNAAFormatIEEEExtended = 2,
    /// <include file='STORAGE_ID_NAA_FORMAT.xml' path='doc/member[@name="STORAGE_ID_NAA_FORMAT.StorageIdNAAFormatIEEERegistered"]/*'/>
    StorageIdNAAFormatIEEERegistered = 3,
    /// <include file='STORAGE_ID_NAA_FORMAT.xml' path='doc/member[@name="STORAGE_ID_NAA_FORMAT.StorageIdNAAFormatIEEEERegisteredExtended"]/*'/>
    StorageIdNAAFormatIEEEERegisteredExtended = 5,
}