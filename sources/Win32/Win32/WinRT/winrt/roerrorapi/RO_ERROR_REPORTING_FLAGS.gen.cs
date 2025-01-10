// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Flags]
public enum RO_ERROR_REPORTING_FLAGS
{
    RO_ERROR_REPORTING_NONE = 0x00000000,
    RO_ERROR_REPORTING_SUPPRESSEXCEPTIONS = 0x00000001,
    RO_ERROR_REPORTING_FORCEEXCEPTIONS = 0x00000002,
    RO_ERROR_REPORTING_USESETERRORINFO = 0x00000004,
    RO_ERROR_REPORTING_SUPPRESSSETERRORINFO = 0x00000008,
}
