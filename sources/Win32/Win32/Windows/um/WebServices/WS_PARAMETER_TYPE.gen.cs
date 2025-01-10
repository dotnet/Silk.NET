// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_PARAMETER_TYPE
{
    WS_PARAMETER_TYPE_NORMAL = 0,
    WS_PARAMETER_TYPE_ARRAY = 1,
    WS_PARAMETER_TYPE_ARRAY_COUNT = 2,
    WS_PARAMETER_TYPE_MESSAGES = 3,
}
