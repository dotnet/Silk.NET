// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_RESPONSE_HEADERS
{
    public ushort UnknownHeaderCount;

    [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
    public HTTP_UNKNOWN_HEADER* pUnknownHeaders;
    public ushort TrailerCount;

    [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
    public HTTP_UNKNOWN_HEADER* pTrailers;

    [NativeTypeName("HTTP_KNOWN_HEADER[30]")]
    public _KnownHeaders_e__FixedBuffer KnownHeaders;

    [InlineArray(30)]
    public partial struct _KnownHeaders_e__FixedBuffer
    {
        public HTTP_KNOWN_HEADER e0;
    }
}
