// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjStartVirtualizing"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjStartVirtualizing([NativeTypeName("PCWSTR")] ushort* virtualizationRootPath, [NativeTypeName("const PRJ_CALLBACKS *")] PRJ_CALLBACKS* callbacks, [NativeTypeName("const void *")] void* instanceContext, [NativeTypeName("const PRJ_STARTVIRTUALIZING_OPTIONS *")] PRJ_STARTVIRTUALIZING_OPTIONS* options, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT* namespaceVirtualizationContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjStopVirtualizing"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void PrjStopVirtualizing(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjClearNegativePathCache"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjClearNegativePathCache(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("UINT32 *")] uint* totalEntryNumber);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjGetVirtualizationInstanceInfo"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjGetVirtualizationInstanceInfo(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, PRJ_VIRTUALIZATION_INSTANCE_INFO* virtualizationInstanceInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjMarkDirectoryAsPlaceholder"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjMarkDirectoryAsPlaceholder([NativeTypeName("PCWSTR")] ushort* rootPathName, [NativeTypeName("PCWSTR")] ushort* targetPathName, [NativeTypeName("const PRJ_PLACEHOLDER_VERSION_INFO *")] PRJ_PLACEHOLDER_VERSION_INFO* versionInfo, [NativeTypeName("const GUID *")] Guid* virtualizationInstanceID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjWritePlaceholderInfo"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjWritePlaceholderInfo(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjWritePlaceholderInfo2"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT PrjWritePlaceholderInfo2(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, [NativeTypeName("const PRJ_EXTENDED_INFO *")] PRJ_EXTENDED_INFO* ExtendedInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjUpdateFileIfNeeded"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjUpdateFileIfNeeded(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjDeleteFile"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjDeleteFile(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjWriteFileData"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjWriteFileData(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("const GUID *")] Guid* dataStreamId, void* buffer, [NativeTypeName("UINT64")] ulong byteOffset, [NativeTypeName("UINT32")] uint length);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjGetOnDiskFileState"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjGetOnDiskFileState([NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_FILE_STATE* fileState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjAllocateAlignedBuffer"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void* PrjAllocateAlignedBuffer(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("size_t")] nuint size);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjFreeAlignedBuffer"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void PrjFreeAlignedBuffer(void* buffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjCompleteCommand"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjCompleteCommand(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("INT32")] int commandId, HRESULT completionResult, PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS* extendedParameters);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjFillDirEntryBuffer"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT PrjFillDirEntryBuffer([NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjFillDirEntryBuffer2"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT PrjFillDirEntryBuffer2(PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle, [NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, PRJ_EXTENDED_INFO* extendedInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjFileNameMatch"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern byte PrjFileNameMatch([NativeTypeName("PCWSTR")] ushort* fileNameToCheck, [NativeTypeName("PCWSTR")] ushort* pattern);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjFileNameCompare"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern int PrjFileNameCompare([NativeTypeName("PCWSTR")] ushort* fileName1, [NativeTypeName("PCWSTR")] ushort* fileName2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrjDoesNameContainWildCards"]/*'/>
    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern byte PrjDoesNameContainWildCards([NativeTypeName("LPCWSTR")] ushort* fileName);
}