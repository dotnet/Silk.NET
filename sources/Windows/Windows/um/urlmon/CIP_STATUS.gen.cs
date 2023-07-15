// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS"]/*'/>
public enum CIP_STATUS
{
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_DISK_FULL"]/*'/>
    CIP_DISK_FULL = 0,
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_ACCESS_DENIED"]/*'/>
    CIP_ACCESS_DENIED = (CIP_DISK_FULL + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_NEWER_VERSION_EXISTS"]/*'/>
    CIP_NEWER_VERSION_EXISTS = (CIP_ACCESS_DENIED + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_OLDER_VERSION_EXISTS"]/*'/>
    CIP_OLDER_VERSION_EXISTS = (CIP_NEWER_VERSION_EXISTS + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_NAME_CONFLICT"]/*'/>
    CIP_NAME_CONFLICT = (CIP_OLDER_VERSION_EXISTS + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_TRUST_VERIFICATION_COMPONENT_MISSING"]/*'/>
    CIP_TRUST_VERIFICATION_COMPONENT_MISSING = (CIP_NAME_CONFLICT + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_EXE_SELF_REGISTERATION_TIMEOUT"]/*'/>
    CIP_EXE_SELF_REGISTERATION_TIMEOUT = (CIP_TRUST_VERIFICATION_COMPONENT_MISSING + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_UNSAFE_TO_ABORT"]/*'/>
    CIP_UNSAFE_TO_ABORT = (CIP_EXE_SELF_REGISTERATION_TIMEOUT + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_NEED_REBOOT"]/*'/>
    CIP_NEED_REBOOT = (CIP_UNSAFE_TO_ABORT + 1),
    /// <include file='CIP_STATUS.xml' path='doc/member[@name="CIP_STATUS.CIP_NEED_REBOOT_UI_PERMISSION"]/*'/>
    CIP_NEED_REBOOT_UI_PERMISSION = (CIP_NEED_REBOOT + 1),
}