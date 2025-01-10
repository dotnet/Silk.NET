// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CIP_STATUS
{
    CIP_DISK_FULL = 0,
    CIP_ACCESS_DENIED = (CIP_DISK_FULL + 1),
    CIP_NEWER_VERSION_EXISTS = (CIP_ACCESS_DENIED + 1),
    CIP_OLDER_VERSION_EXISTS = (CIP_NEWER_VERSION_EXISTS + 1),
    CIP_NAME_CONFLICT = (CIP_OLDER_VERSION_EXISTS + 1),
    CIP_TRUST_VERIFICATION_COMPONENT_MISSING = (CIP_NAME_CONFLICT + 1),
    CIP_EXE_SELF_REGISTERATION_TIMEOUT = (CIP_TRUST_VERIFICATION_COMPONENT_MISSING + 1),
    CIP_UNSAFE_TO_ABORT = (CIP_EXE_SELF_REGISTERATION_TIMEOUT + 1),
    CIP_NEED_REBOOT = (CIP_UNSAFE_TO_ABORT + 1),
    CIP_NEED_REBOOT_UI_PERMISSION = (CIP_NEED_REBOOT + 1),
}
