// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define RQ_BEGIN_REQUEST 0x00000001")]
    public const int RQ_BEGIN_REQUEST = 0x00000001;

    [NativeTypeName("#define RQ_AUTHENTICATE_REQUEST 0x00000002")]
    public const int RQ_AUTHENTICATE_REQUEST = 0x00000002;

    [NativeTypeName("#define RQ_AUTHORIZE_REQUEST 0x00000004")]
    public const int RQ_AUTHORIZE_REQUEST = 0x00000004;

    [NativeTypeName("#define RQ_RESOLVE_REQUEST_CACHE 0x00000008")]
    public const int RQ_RESOLVE_REQUEST_CACHE = 0x00000008;

    [NativeTypeName("#define RQ_MAP_REQUEST_HANDLER 0x00000010")]
    public const int RQ_MAP_REQUEST_HANDLER = 0x00000010;

    [NativeTypeName("#define RQ_ACQUIRE_REQUEST_STATE 0x00000020")]
    public const int RQ_ACQUIRE_REQUEST_STATE = 0x00000020;

    [NativeTypeName("#define RQ_PRE_EXECUTE_REQUEST_HANDLER 0x00000040")]
    public const int RQ_PRE_EXECUTE_REQUEST_HANDLER = 0x00000040;

    [NativeTypeName("#define RQ_EXECUTE_REQUEST_HANDLER 0x00000080")]
    public const int RQ_EXECUTE_REQUEST_HANDLER = 0x00000080;

    [NativeTypeName("#define RQ_RELEASE_REQUEST_STATE 0x00000100")]
    public const int RQ_RELEASE_REQUEST_STATE = 0x00000100;

    [NativeTypeName("#define RQ_UPDATE_REQUEST_CACHE 0x00000200")]
    public const int RQ_UPDATE_REQUEST_CACHE = 0x00000200;

    [NativeTypeName("#define RQ_LOG_REQUEST 0x00000400")]
    public const int RQ_LOG_REQUEST = 0x00000400;

    [NativeTypeName("#define RQ_END_REQUEST 0x00000800")]
    public const int RQ_END_REQUEST = 0x00000800;

    [NativeTypeName("#define RQ_SEND_RESPONSE_STATUS_AND_HEADERS 0x08000000")]
    public const int RQ_SEND_RESPONSE_STATUS_AND_HEADERS = 0x08000000;

    [NativeTypeName("#define RQ_CUSTOM_NOTIFICATION 0x10000000")]
    public const int RQ_CUSTOM_NOTIFICATION = 0x10000000;

    [NativeTypeName("#define RQ_SEND_RESPONSE 0x20000000")]
    public const int RQ_SEND_RESPONSE = 0x20000000;

    [NativeTypeName("#define RQ_READ_ENTITY 0x40000000")]
    public const int RQ_READ_ENTITY = 0x40000000;

    [NativeTypeName("#define RQ_MAP_PATH 0x80000000")]
    public const uint RQ_MAP_PATH = 0x80000000;

    [NativeTypeName("#define PRIORITY_ALIAS_FIRST L\"FIRST\"")]
    public const string PRIORITY_ALIAS_FIRST = "FIRST";

    [NativeTypeName("#define PRIORITY_ALIAS_HIGH L\"HIGH\"")]
    public const string PRIORITY_ALIAS_HIGH = "HIGH";

    [NativeTypeName("#define PRIORITY_ALIAS_MEDIUM L\"MEDIUM\"")]
    public const string PRIORITY_ALIAS_MEDIUM = "MEDIUM";

    [NativeTypeName("#define PRIORITY_ALIAS_LOW L\"LOW\"")]
    public const string PRIORITY_ALIAS_LOW = "LOW";

    [NativeTypeName("#define PRIORITY_ALIAS_LAST L\"LAST\"")]
    public const string PRIORITY_ALIAS_LAST = "LAST";

    [NativeTypeName("#define CLONE_FLAG_BASICS 0x01")]
    public const int CLONE_FLAG_BASICS = 0x01;

    [NativeTypeName("#define CLONE_FLAG_HEADERS 0x02")]
    public const int CLONE_FLAG_HEADERS = 0x02;

    [NativeTypeName("#define CLONE_FLAG_ENTITY 0x04")]
    public const int CLONE_FLAG_ENTITY = 0x04;

    [NativeTypeName("#define CLONE_FLAG_NO_PRECONDITION 0x08")]
    public const int CLONE_FLAG_NO_PRECONDITION = 0x08;

    [NativeTypeName("#define CLONE_FLAG_NO_DAV 0x10")]
    public const int CLONE_FLAG_NO_DAV = 0x10;

    [NativeTypeName("#define CLONE_FLAG_USER_CACHE_VARY_BY 0x20")]
    public const int CLONE_FLAG_USER_CACHE_VARY_BY = 0x20;

    [NativeTypeName("#define CLONE_FLAG_SERVER_VARIABLE 0x40")]
    public const int CLONE_FLAG_SERVER_VARIABLE = 0x40;

    [NativeTypeName("#define EXECUTE_FLAG_NO_HEADERS 0x01")]
    public const int EXECUTE_FLAG_NO_HEADERS = 0x01;

    [NativeTypeName("#define EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR 0x02")]
    public const int EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR = 0x02;

    [NativeTypeName("#define EXECUTE_FLAG_IGNORE_APPPOOL 0x04")]
    public const int EXECUTE_FLAG_IGNORE_APPPOOL = 0x04;

    [NativeTypeName("#define EXECUTE_FLAG_DISABLE_CUSTOM_ERROR 0x08")]
    public const int EXECUTE_FLAG_DISABLE_CUSTOM_ERROR = 0x08;

    [NativeTypeName("#define EXECUTE_FLAG_SAME_URL 0x10")]
    public const int EXECUTE_FLAG_SAME_URL = 0x10;

    [NativeTypeName("#define EXECUTE_FLAG_BUFFER_RESPONSE 0x20")]
    public const int EXECUTE_FLAG_BUFFER_RESPONSE = 0x20;

    [NativeTypeName("#define EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE 0x40")]
    public const int EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE = 0x40;

    [NativeTypeName("#define MODULE_REGISTERMODULE \"RegisterModule\"")]
    public static ReadOnlySpan<byte> MODULE_REGISTERMODULE => "RegisterModule"u8;
}
