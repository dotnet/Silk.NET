// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LOAD
{
    [NativeTypeName("#define LOAD_TLB_AS_32BIT 0x20")]
    public const int LOAD_TLB_AS_32BIT = 0x20;

    [NativeTypeName("#define LOAD_TLB_AS_64BIT 0x40")]
    public const int LOAD_TLB_AS_64BIT = 0x40;
}
