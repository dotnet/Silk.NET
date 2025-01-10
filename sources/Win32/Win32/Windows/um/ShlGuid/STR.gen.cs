// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STR
{
    [NativeTypeName("#define STR_MYDOCS_CLSID \"{450D8FBA-AD25-11D0-98A8-0800361B1103}\"")]
    public static ReadOnlySpan<byte> STR_MYDOCS_CLSID => "{450D8FBA-AD25-11D0-98A8-0800361B1103}"u8;
}
