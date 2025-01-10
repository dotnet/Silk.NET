// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct BackgroundDownloadProgress
{
    [NativeTypeName("UINT64")]
    public ulong BytesReceived;

    [NativeTypeName("UINT64")]
    public ulong TotalBytesToReceive;

    [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferStatus")]
    public BackgroundTransferStatus Status;

    [NativeTypeName("boolean")]
    public byte HasResponseChanged;

    [NativeTypeName("boolean")]
    public byte HasRestarted;
}
