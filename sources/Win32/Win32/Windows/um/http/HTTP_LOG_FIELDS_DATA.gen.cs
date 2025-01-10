// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_LOG_FIELDS_DATA
{
    public HTTP_LOG_DATA Base;
    public ushort UserNameLength;
    public ushort UriStemLength;
    public ushort ClientIpLength;
    public ushort ServerNameLength;
    public ushort ServiceNameLength;
    public ushort ServerIpLength;
    public ushort MethodLength;
    public ushort UriQueryLength;
    public ushort HostLength;
    public ushort UserAgentLength;
    public ushort CookieLength;
    public ushort ReferrerLength;

    [NativeTypeName("PWCHAR")]
    public ushort* UserName;

    [NativeTypeName("PWCHAR")]
    public ushort* UriStem;

    [NativeTypeName("PCHAR")]
    public sbyte* ClientIp;

    [NativeTypeName("PCHAR")]
    public sbyte* ServerName;

    [NativeTypeName("PCHAR")]
    public sbyte* ServiceName;

    [NativeTypeName("PCHAR")]
    public sbyte* ServerIp;

    [NativeTypeName("PCHAR")]
    public sbyte* Method;

    [NativeTypeName("PCHAR")]
    public sbyte* UriQuery;

    [NativeTypeName("PCHAR")]
    public sbyte* Host;

    [NativeTypeName("PCHAR")]
    public sbyte* UserAgent;

    [NativeTypeName("PCHAR")]
    public sbyte* Cookie;

    [NativeTypeName("PCHAR")]
    public sbyte* Referrer;
    public ushort ServerPort;
    public ushort ProtocolStatus;

    [NativeTypeName("ULONG")]
    public uint Win32Status;
    public HTTP_VERB MethodNum;
    public ushort SubStatus;
}
