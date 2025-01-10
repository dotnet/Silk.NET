// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_READ_OPTION
{
    WS_READ_REQUIRED_VALUE = 1,
    WS_READ_REQUIRED_POINTER = 2,
    WS_READ_OPTIONAL_POINTER = 3,
    WS_READ_NILLABLE_POINTER = 4,
    WS_READ_NILLABLE_VALUE = 5,
}
