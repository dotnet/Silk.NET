// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows6.3")]
public enum SYNC_ENGINE_STATE_FLAGS
{
    SESF_NONE = 0,
    SESF_SERVICE_QUOTA_NEARING_LIMIT = 0x1,
    SESF_SERVICE_QUOTA_EXCEEDED_LIMIT = 0x2,
    SESF_AUTHENTICATION_ERROR = 0x4,
    SESF_PAUSED_DUE_TO_METERED_NETWORK = 0x8,
    SESF_PAUSED_DUE_TO_DISK_SPACE_FULL = 0x10,
    SESF_PAUSED_DUE_TO_CLIENT_POLICY = 0x20,
    SESF_PAUSED_DUE_TO_SERVICE_POLICY = 0x40,
    SESF_SERVICE_UNAVAILABLE = 0x80,
    SESF_PAUSED_DUE_TO_USER_REQUEST = 0x100,
    SESF_ALL_FLAGS =
        (
            (
                (
                    (
                        (
                            (
                                (
                                    (
                                        (SESF_NONE | SESF_SERVICE_QUOTA_NEARING_LIMIT)
                                        | SESF_SERVICE_QUOTA_EXCEEDED_LIMIT
                                    ) | SESF_AUTHENTICATION_ERROR
                                ) | SESF_PAUSED_DUE_TO_METERED_NETWORK
                            ) | SESF_PAUSED_DUE_TO_DISK_SPACE_FULL
                        ) | SESF_PAUSED_DUE_TO_CLIENT_POLICY
                    ) | SESF_PAUSED_DUE_TO_SERVICE_POLICY
                ) | SESF_SERVICE_UNAVAILABLE
            ) | SESF_PAUSED_DUE_TO_USER_REQUEST
        ),
}
