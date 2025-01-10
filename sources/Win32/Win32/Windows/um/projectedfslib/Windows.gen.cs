// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjStartVirtualizing(
        [NativeTypeName("PCWSTR")] ushort* virtualizationRootPath,
        [NativeTypeName("const PRJ_CALLBACKS *")] PRJ_CALLBACKS* callbacks,
        [NativeTypeName("const void *")] void* instanceContext,
        [NativeTypeName("const PRJ_STARTVIRTUALIZING_OPTIONS *")]
            PRJ_STARTVIRTUALIZING_OPTIONS* options,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT* namespaceVirtualizationContext
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void PrjStopVirtualizing(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjClearNegativePathCache(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("UINT32 *")] uint* totalEntryNumber
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjGetVirtualizationInstanceInfo(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        PRJ_VIRTUALIZATION_INSTANCE_INFO* virtualizationInstanceInfo
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjMarkDirectoryAsPlaceholder(
        [NativeTypeName("PCWSTR")] ushort* rootPathName,
        [NativeTypeName("PCWSTR")] ushort* targetPathName,
        [NativeTypeName("const PRJ_PLACEHOLDER_VERSION_INFO *")]
            PRJ_PLACEHOLDER_VERSION_INFO* versionInfo,
        [NativeTypeName("const GUID *")] Guid* virtualizationInstanceID
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjWritePlaceholderInfo(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("PCWSTR")] ushort* destinationFileName,
        [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo,
        [NativeTypeName("UINT32")] uint placeholderInfoSize
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT PrjWritePlaceholderInfo2(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("PCWSTR")] ushort* destinationFileName,
        [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo,
        [NativeTypeName("UINT32")] uint placeholderInfoSize,
        [NativeTypeName("const PRJ_EXTENDED_INFO *")] PRJ_EXTENDED_INFO* ExtendedInfo
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjUpdateFileIfNeeded(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("PCWSTR")] ushort* destinationFileName,
        [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo,
        [NativeTypeName("UINT32")] uint placeholderInfoSize,
        PRJ_UPDATE_TYPES updateFlags,
        PRJ_UPDATE_FAILURE_CAUSES* failureReason
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjDeleteFile(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("PCWSTR")] ushort* destinationFileName,
        PRJ_UPDATE_TYPES updateFlags,
        PRJ_UPDATE_FAILURE_CAUSES* failureReason
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjWriteFileData(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("const GUID *")] Guid* dataStreamId,
        void* buffer,
        [NativeTypeName("UINT64")] ulong byteOffset,
        [NativeTypeName("UINT32")] uint length
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjGetOnDiskFileState(
        [NativeTypeName("PCWSTR")] ushort* destinationFileName,
        PRJ_FILE_STATE* fileState
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void* PrjAllocateAlignedBuffer(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("size_t")] nuint size
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void PrjFreeAlignedBuffer(void* buffer);

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjCompleteCommand(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext,
        [NativeTypeName("INT32")] int commandId,
        HRESULT completionResult,
        PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS* extendedParameters
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjFillDirEntryBuffer(
        [NativeTypeName("PCWSTR")] ushort* fileName,
        PRJ_FILE_BASIC_INFO* fileBasicInfo,
        PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT PrjFillDirEntryBuffer2(
        PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle,
        [NativeTypeName("PCWSTR")] ushort* fileName,
        PRJ_FILE_BASIC_INFO* fileBasicInfo,
        PRJ_EXTENDED_INFO* extendedInfo
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern byte PrjFileNameMatch(
        [NativeTypeName("PCWSTR")] ushort* fileNameToCheck,
        [NativeTypeName("PCWSTR")] ushort* pattern
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern int PrjFileNameCompare(
        [NativeTypeName("PCWSTR")] ushort* fileName1,
        [NativeTypeName("PCWSTR")] ushort* fileName2
    );

    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern byte PrjDoesNameContainWildCards(
        [NativeTypeName("LPCWSTR")] ushort* fileName
    );
}
