// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EC
{
    [NativeTypeName("#define EC_VARIANT_TYPE_MASK 0x7f")]
    public const int EC_VARIANT_TYPE_MASK = 0x7f;
    [NativeTypeName("#define EC_VARIANT_TYPE_ARRAY 128")]
    public const int EC_VARIANT_TYPE_ARRAY = 128;
    [NativeTypeName("#define EC_READ_ACCESS 1")]
    public const int EC_READ_ACCESS = 1;
    [NativeTypeName("#define EC_WRITE_ACCESS 2")]
    public const int EC_WRITE_ACCESS = 2;
    [NativeTypeName("#define EC_OPEN_ALWAYS 0")]
    public const int EC_OPEN_ALWAYS = 0;
    [NativeTypeName("#define EC_CREATE_NEW 1")]
    public const int EC_CREATE_NEW = 1;
    [NativeTypeName("#define EC_OPEN_EXISTING 2")]
    public const int EC_OPEN_EXISTING = 2;
}