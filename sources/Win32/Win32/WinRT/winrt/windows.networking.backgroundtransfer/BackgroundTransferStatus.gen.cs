// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BackgroundTransferStatus
{
    BackgroundTransferStatus_Idle = 0,
    BackgroundTransferStatus_Running = 1,
    BackgroundTransferStatus_PausedByApplication = 2,
    BackgroundTransferStatus_PausedCostedNetwork = 3,
    BackgroundTransferStatus_PausedNoNetwork = 4,
    BackgroundTransferStatus_Completed = 5,
    BackgroundTransferStatus_Canceled = 6,
    BackgroundTransferStatus_Error = 7,
    BackgroundTransferStatus_PausedRecoverableWebErrorStatus = 8,
    BackgroundTransferStatus_PausedSystemPolicy = 32,
}
