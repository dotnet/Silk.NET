// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public enum MF_MEDIAKEY_STATUS
{
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_USABLE"]/*'/>
    MF_MEDIAKEY_STATUS_USABLE = 0,
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_EXPIRED"]/*'/>
    MF_MEDIAKEY_STATUS_EXPIRED = (MF_MEDIAKEY_STATUS_USABLE + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_OUTPUT_DOWNSCALED"]/*'/>
    MF_MEDIAKEY_STATUS_OUTPUT_DOWNSCALED = (MF_MEDIAKEY_STATUS_EXPIRED + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_OUTPUT_NOT_ALLOWED"]/*'/>
    MF_MEDIAKEY_STATUS_OUTPUT_NOT_ALLOWED = (MF_MEDIAKEY_STATUS_OUTPUT_DOWNSCALED + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_STATUS_PENDING"]/*'/>
    MF_MEDIAKEY_STATUS_STATUS_PENDING = (MF_MEDIAKEY_STATUS_OUTPUT_NOT_ALLOWED + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_INTERNAL_ERROR"]/*'/>
    MF_MEDIAKEY_STATUS_INTERNAL_ERROR = (MF_MEDIAKEY_STATUS_STATUS_PENDING + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_RELEASED"]/*'/>
    MF_MEDIAKEY_STATUS_RELEASED = (MF_MEDIAKEY_STATUS_INTERNAL_ERROR + 1),
    /// <include file='MF_MEDIAKEY_STATUS.xml' path='doc/member[@name="MF_MEDIAKEY_STATUS.MF_MEDIAKEY_STATUS_OUTPUT_RESTRICTED"]/*'/>
    MF_MEDIAKEY_STATUS_OUTPUT_RESTRICTED = (MF_MEDIAKEY_STATUS_RELEASED + 1),
}