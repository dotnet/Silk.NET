// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class RESOURCE
{
    [NativeTypeName("#define RESOURCE_MANAGER_VOLATILE 0x00000001")]
    public const int RESOURCE_MANAGER_VOLATILE = 0x00000001;

    [NativeTypeName("#define RESOURCE_MANAGER_COMMUNICATION 0x00000002")]
    public const int RESOURCE_MANAGER_COMMUNICATION = 0x00000002;

    [NativeTypeName("#define RESOURCE_MANAGER_MAXIMUM_OPTION 0x00000003")]
    public const int RESOURCE_MANAGER_MAXIMUM_OPTION = 0x00000003;

    [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_PATH L\"\\\\ResourceManager\\\\\"")]
    public const string RESOURCE_MANAGER_OBJECT_PATH = "\\ResourceManager\\";

    [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(RESOURCE_MANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
    public const uint RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (36 + (38 * 2));
}
