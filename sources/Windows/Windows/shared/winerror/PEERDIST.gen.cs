// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PEERDIST
{
    [NativeTypeName("#define PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED 4050L")]
    public const int PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED = 4050;

    [NativeTypeName("#define PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO 4051L")]
    public const int PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO = 4051;

    [NativeTypeName("#define PEERDIST_ERROR_MISSING_DATA 4052L")]
    public const int PEERDIST_ERROR_MISSING_DATA = 4052;

    [NativeTypeName("#define PEERDIST_ERROR_NO_MORE 4053L")]
    public const int PEERDIST_ERROR_NO_MORE = 4053;

    [NativeTypeName("#define PEERDIST_ERROR_NOT_INITIALIZED 4054L")]
    public const int PEERDIST_ERROR_NOT_INITIALIZED = 4054;

    [NativeTypeName("#define PEERDIST_ERROR_ALREADY_INITIALIZED 4055L")]
    public const int PEERDIST_ERROR_ALREADY_INITIALIZED = 4055;

    [NativeTypeName("#define PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS 4056L")]
    public const int PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS = 4056;

    [NativeTypeName("#define PEERDIST_ERROR_INVALIDATED 4057L")]
    public const int PEERDIST_ERROR_INVALIDATED = 4057;

    [NativeTypeName("#define PEERDIST_ERROR_ALREADY_EXISTS 4058L")]
    public const int PEERDIST_ERROR_ALREADY_EXISTS = 4058;

    [NativeTypeName("#define PEERDIST_ERROR_OPERATION_NOTFOUND 4059L")]
    public const int PEERDIST_ERROR_OPERATION_NOTFOUND = 4059;

    [NativeTypeName("#define PEERDIST_ERROR_ALREADY_COMPLETED 4060L")]
    public const int PEERDIST_ERROR_ALREADY_COMPLETED = 4060;

    [NativeTypeName("#define PEERDIST_ERROR_OUT_OF_BOUNDS 4061L")]
    public const int PEERDIST_ERROR_OUT_OF_BOUNDS = 4061;

    [NativeTypeName("#define PEERDIST_ERROR_VERSION_UNSUPPORTED 4062L")]
    public const int PEERDIST_ERROR_VERSION_UNSUPPORTED = 4062;

    [NativeTypeName("#define PEERDIST_ERROR_INVALID_CONFIGURATION 4063L")]
    public const int PEERDIST_ERROR_INVALID_CONFIGURATION = 4063;

    [NativeTypeName("#define PEERDIST_ERROR_NOT_LICENSED 4064L")]
    public const int PEERDIST_ERROR_NOT_LICENSED = 4064;

    [NativeTypeName("#define PEERDIST_ERROR_SERVICE_UNAVAILABLE 4065L")]
    public const int PEERDIST_ERROR_SERVICE_UNAVAILABLE = 4065;

    [NativeTypeName("#define PEERDIST_ERROR_TRUST_FAILURE 4066L")]
    public const int PEERDIST_ERROR_TRUST_FAILURE = 4066;
}
