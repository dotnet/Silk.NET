// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloader =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloader";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloader2 =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloader2";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloader3 =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloader3";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloaderFactory =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloaderFactory";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloaderStaticMethods =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloaderStaticMethods2 =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods2";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundDownloaderUserConsent =
        "Windows.Networking.BackgroundTransfer.IBackgroundDownloaderUserConsent";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferBase =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferBase";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferCompletionGroup =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroup";

    [NativeTypeName("const WCHAR[87]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferCompletionGroupTriggerDetails =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroupTriggerDetails";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferContentPart =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPart";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferContentPartFactory =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPartFactory";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferErrorStaticMethods =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferErrorStaticMethods";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferGroup =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferGroup";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferGroupStatics =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferGroupStatics";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferOperation =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation";

    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferOperationPriority =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority";

    [NativeTypeName("const WCHAR[83]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundTransferRangesDownloadedEventArgs =
        "Windows.Networking.BackgroundTransfer.IBackgroundTransferRangesDownloadedEventArgs";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploader =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploader";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploader2 =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploader2";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploader3 =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploader3";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploaderFactory =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploaderFactory";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploaderStaticMethods =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploaderStaticMethods2 =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods2";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IBackgroundUploaderUserConsent =
        "Windows.Networking.BackgroundTransfer.IBackgroundUploaderUserConsent";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IContentPrefetcher =
        "Windows.Networking.BackgroundTransfer.IContentPrefetcher";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IContentPrefetcherTime =
        "Windows.Networking.BackgroundTransfer.IContentPrefetcherTime";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IDownloadOperation =
        "Windows.Networking.BackgroundTransfer.IDownloadOperation";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IDownloadOperation2 =
        "Windows.Networking.BackgroundTransfer.IDownloadOperation2";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IDownloadOperation3 =
        "Windows.Networking.BackgroundTransfer.IDownloadOperation3";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IDownloadOperation4 =
        "Windows.Networking.BackgroundTransfer.IDownloadOperation4";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IDownloadOperation5 =
        "Windows.Networking.BackgroundTransfer.IDownloadOperation5";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IResponseInformation =
        "Windows.Networking.BackgroundTransfer.IResponseInformation";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IUnconstrainedTransferRequestResult =
        "Windows.Networking.BackgroundTransfer.IUnconstrainedTransferRequestResult";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IUploadOperation =
        "Windows.Networking.BackgroundTransfer.IUploadOperation";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IUploadOperation2 =
        "Windows.Networking.BackgroundTransfer.IUploadOperation2";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IUploadOperation3 =
        "Windows.Networking.BackgroundTransfer.IUploadOperation3";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Networking_BackgroundTransfer_IUploadOperation4 =
        "Windows.Networking.BackgroundTransfer.IUploadOperation4";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundDownloader =
        "Windows.Networking.BackgroundTransfer.BackgroundDownloader";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferCompletionGroup =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup";

    [NativeTypeName("const WCHAR[86]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferCompletionGroupTriggerDetails =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroupTriggerDetails";

    [NativeTypeName("const WCHAR[68]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferContentPart =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart";

    [NativeTypeName("const WCHAR[62]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferError =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferError";

    [NativeTypeName("const WCHAR[62]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferGroup =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferGroup";

    [NativeTypeName("const WCHAR[82]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundTransferRangesDownloadedEventArgs =
        "Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_BackgroundUploader =
        "Windows.Networking.BackgroundTransfer.BackgroundUploader";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_ContentPrefetcher =
        "Windows.Networking.BackgroundTransfer.ContentPrefetcher";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_DownloadOperation =
        "Windows.Networking.BackgroundTransfer.DownloadOperation";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_ResponseInformation =
        "Windows.Networking.BackgroundTransfer.ResponseInformation";

    [NativeTypeName("const WCHAR[73]")]
    [Obsolete(
        "UnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_UnconstrainedTransferRequestResult =
        "Windows.Networking.BackgroundTransfer.UnconstrainedTransferRequestResult";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_Networking_BackgroundTransfer_UploadOperation =
        "Windows.Networking.BackgroundTransfer.UploadOperation";
}
