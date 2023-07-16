// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propkey.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class STORAGE
{
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_PRIVATE L\"Private\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_PRIVATE = "Private";
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_SHARED L\"Shared\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_SHARED = "Shared";
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_PUBLIC L\"Public\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_PUBLIC = "Public";
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_GROUP L\"Group\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_GROUP = "Group";
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_OWNER L\"Owner\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_OWNER = "Owner";
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_NOTSHARED 0ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_NOTSHARED = 0U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED 1ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED = 1U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PRIVATE 2ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PRIVATE = 2U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC 3ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC = 3U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED_OWNED 4ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED_OWNED = 4U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED_COOWNED 5ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED_COOWNED = 5U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_OWNED 6ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_OWNED = 6U;
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_COOWNED 7ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_COOWNED = 7U;
}