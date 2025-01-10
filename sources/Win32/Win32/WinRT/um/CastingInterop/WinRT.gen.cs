// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[25]")]
    public const string CastingSourceInfo_Property_PreferredSourceUriScheme =
        "PreferredSourceUriScheme";

    [NativeTypeName("const WCHAR[13]")]
    public const string CastingSourceInfo_Property_CastingTypes = "CastingTypes";

    [NativeTypeName("const WCHAR[15]")]
    public const string CastingSourceInfo_Property_ProtectedMedia = "ProtectedMedia";
}
