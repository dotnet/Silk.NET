// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct _HTTP_RESPONSE_V2 : _HTTP_RESPONSE_V1")]
[NativeInheritance("_HTTP_RESPONSE_V1")]
public unsafe partial struct HTTP_RESPONSE_V2
{
    public HTTP_RESPONSE_V1 Base;
    public ushort ResponseInfoCount;

    [NativeTypeName("PHTTP_RESPONSE_INFO")]
    public HTTP_RESPONSE_INFO* pResponseInfo;
}
