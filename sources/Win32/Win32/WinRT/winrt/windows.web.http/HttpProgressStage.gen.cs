// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum HttpProgressStage
{
    HttpProgressStage_None = 0,
    HttpProgressStage_DetectingProxy = 10,
    HttpProgressStage_ResolvingName = 20,
    HttpProgressStage_ConnectingToServer = 30,
    HttpProgressStage_NegotiatingSsl = 40,
    HttpProgressStage_SendingHeaders = 50,
    HttpProgressStage_SendingContent = 60,
    HttpProgressStage_WaitingForResponse = 70,
    HttpProgressStage_ReceivingHeaders = 80,
    HttpProgressStage_ReceivingContent = 90,
}
