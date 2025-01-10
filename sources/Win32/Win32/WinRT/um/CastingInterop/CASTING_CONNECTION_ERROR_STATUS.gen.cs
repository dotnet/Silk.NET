// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CASTING_CONNECTION_ERROR_STATUS
{
    CASTING_CONNECTION_ERROR_STATUS_SUCCEEDED = 0,
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_DID_NOT_RESPOND = 1,
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_ERROR = 2,
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_LOCKED = 3,
    CASTING_CONNECTION_ERROR_STATUS_PROTECTED_PLAYBACK_FAILED = 4,
    CASTING_CONNECTION_ERROR_STATUS_INVALID_CASTING_SOURCE = 5,
    CASTING_CONNECTION_ERROR_STATUS_UNKNOWN = 6,
}
