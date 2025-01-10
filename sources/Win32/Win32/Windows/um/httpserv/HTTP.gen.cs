// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HTTP
{
    [NativeTypeName("#define HTTP_USER_VARIABLE_SID \"SID\"")]
    public static ReadOnlySpan<byte> HTTP_USER_VARIABLE_SID => "SID"u8;

    [NativeTypeName("#define HTTP_USER_VARIABLE_CTXT_HANDLE \"CtxtHandle\"")]
    public static ReadOnlySpan<byte> HTTP_USER_VARIABLE_CTXT_HANDLE => "CtxtHandle"u8;

    [NativeTypeName("#define HTTP_USER_VARIABLE_CRED_HANDLE \"CredHandle\"")]
    public static ReadOnlySpan<byte> HTTP_USER_VARIABLE_CRED_HANDLE => "CredHandle"u8;
}
