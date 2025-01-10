// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public unsafe partial struct HttpProgress
{
    [NativeTypeName("ABI::Windows::Web::Http::HttpProgressStage")]
    public HttpProgressStage Stage;

    [NativeTypeName("UINT64")]
    public ulong BytesSent;

    [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
    public IReference<ulong>* TotalBytesToSend;

    [NativeTypeName("UINT64")]
    public ulong BytesReceived;

    [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
    public IReference<ulong>* TotalBytesToReceive;

    [NativeTypeName("UINT32")]
    public uint Retries;
}
