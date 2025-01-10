// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAPI_READ_TRACK_ADDRESS_TYPE
{
    IMAPI_READ_TRACK_ADDRESS_TYPE_LBA = 0,
    IMAPI_READ_TRACK_ADDRESS_TYPE_TRACK = 1,
    IMAPI_READ_TRACK_ADDRESS_TYPE_SESSION = 2,
}
