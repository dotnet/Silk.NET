// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DXGIMessages.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id"]/*'/>
public enum DXGI_Message_Id
{
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_InvalidOutputWindow"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_InvalidOutputWindow = 0,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_BufferWidthInferred"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_BufferWidthInferred,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_BufferHeightInferred"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_BufferHeightInferred,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_NoScanoutFlagChanged"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrResizeBuffers_NoScanoutFlagChanged,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Creation_MaxBufferCountExceeded"]/*'/>
    DXGI_MSG_IDXGISwapChain_Creation_MaxBufferCountExceeded,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Creation_TooFewBuffers"]/*'/>
    DXGI_MSG_IDXGISwapChain_Creation_TooFewBuffers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Creation_NoOutputWindow"]/*'/>
    DXGI_MSG_IDXGISwapChain_Creation_NoOutputWindow,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Destruction_OtherMethodsCalled"]/*'/>
    DXGI_MSG_IDXGISwapChain_Destruction_OtherMethodsCalled,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetDesc_pDescIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetDesc_pDescIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetBuffer_ppSurfaceIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetBuffer_ppSurfaceIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetBuffer_NoAllocatedBuffers"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetBuffer_NoAllocatedBuffers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetBuffer_iBufferMustBeZero"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetBuffer_iBufferMustBeZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetBuffer_iBufferOOB"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetBuffer_iBufferOOB,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetContainingOutput_ppOutputIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetContainingOutput_ppOutputIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_SyncIntervalOOB"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_SyncIntervalOOB,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_InvalidNonPreRotatedFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_InvalidNonPreRotatedFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_NoAllocatedBuffers"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_NoAllocatedBuffers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_GetDXGIAdapterFailed"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_GetDXGIAdapterFailed,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_BufferCountOOB"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_BufferCountOOB,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_UnreleasedReferences"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_UnreleasedReferences,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidSwapChainFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidSwapChainFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidNonPreRotatedFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidNonPreRotatedFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeTarget_RefreshRateDivideByZero"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeTarget_RefreshRateDivideByZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_InvalidTarget"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_InvalidTarget,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetFrameStatistics_pStatsIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetFrameStatistics_pStatsIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetLastPresentCount_pLastPresentCountIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetLastPresentCount_pLastPresentCountIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_RemoteNotSupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_RemoteNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_FailedToAcquireFullscreenMutex"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_FailedToAcquireFullscreenMutex,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSoftwareAdapter_ppAdapterInterfaceIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSoftwareAdapter_ppAdapterInterfaceIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_EnumAdapters_ppAdapterInterfaceIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_EnumAdapters_ppAdapterInterfaceIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ppSwapChainIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ppSwapChainIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_pDescIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_pDescIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_UnknownSwapEffect"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_UnknownSwapEffect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidFlags"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_NonPreRotatedFlagAndWindowed"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_NonPreRotatedFlagAndWindowed,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_NullDeviceInterface"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_NullDeviceInterface,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_GetWindowAssociation_phWndIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_GetWindowAssociation_phWndIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_MakeWindowAssociation_InvalidFlags"]/*'/>
    DXGI_MSG_IDXGIFactory_MakeWindowAssociation_InvalidFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_InvalidSurface"]/*'/>
    DXGI_MSG_IDXGISurface_Map_InvalidSurface,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_FlagsSetToZero"]/*'/>
    DXGI_MSG_IDXGISurface_Map_FlagsSetToZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_DiscardAndReadFlagSet"]/*'/>
    DXGI_MSG_IDXGISurface_Map_DiscardAndReadFlagSet,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_DiscardButNotWriteFlagSet"]/*'/>
    DXGI_MSG_IDXGISurface_Map_DiscardButNotWriteFlagSet,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_NoCPUAccess"]/*'/>
    DXGI_MSG_IDXGISurface_Map_NoCPUAccess,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_ReadFlagSetButCPUAccessIsDynamic"]/*'/>
    DXGI_MSG_IDXGISurface_Map_ReadFlagSetButCPUAccessIsDynamic,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_DiscardFlagSetButCPUAccessIsNotDynamic"]/*'/>
    DXGI_MSG_IDXGISurface_Map_DiscardFlagSetButCPUAccessIsNotDynamic,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplayModeList_pNumModesIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplayModeList_pNumModesIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_ModeHasInvalidWidthOrHeight"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_ModeHasInvalidWidthOrHeight,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetCammaControlCapabilities_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_GetCammaControlCapabilities_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_pDeviceIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_pDeviceIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_pDestinationIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_pDestinationIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_MapOfDestinationFailed"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_MapOfDestinationFailed,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetFrameStatistics_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_GetFrameStatistics_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetFrameStatistics_pStatsIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_GetFrameStatistics_pStatsIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetGammaControl_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_SetGammaControl_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetGammaControl_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_GetGammaControl_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetGammaControl_NoGammaControls"]/*'/>
    DXGI_MSG_IDXGIOutput_GetGammaControl_NoGammaControls,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetDisplaySurface_IDXGIResourceNotSupportedBypPrimary"]/*'/>
    DXGI_MSG_IDXGIOutput_SetDisplaySurface_IDXGIResourceNotSupportedBypPrimary,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetDisplaySurface_pPrimaryIsInvalid"]/*'/>
    DXGI_MSG_IDXGIOutput_SetDisplaySurface_pPrimaryIsInvalid,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetDisplaySurface_NoOwnerDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_SetDisplaySurface_NoOwnerDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_RemoteDeviceNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_RemoteDeviceNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplayModeList_RemoteDeviceNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplayModeList_RemoteDeviceNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_RemoteDeviceNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_RemoteDeviceNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDevice_CreateSurface_InvalidParametersWithpSharedResource"]/*'/>
    DXGI_MSG_IDXGIDevice_CreateSurface_InvalidParametersWithpSharedResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIObject_GetPrivateData_puiDataSizeIsNULL"]/*'/>
    DXGI_MSG_IDXGIObject_GetPrivateData_puiDataSizeIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Creation_InvalidOutputWindow"]/*'/>
    DXGI_MSG_IDXGISwapChain_Creation_InvalidOutputWindow,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Release_SwapChainIsFullscreen"]/*'/>
    DXGI_MSG_IDXGISwapChain_Release_SwapChainIsFullscreen,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_InvalidTargetSurfaceFormat"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_InvalidTargetSurfaceFormat,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSoftwareAdapter_ModuleIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSoftwareAdapter_ModuleIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_IDXGIDeviceNotSupportedBypConcernedDevice"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_IDXGIDeviceNotSupportedBypConcernedDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_pModeToMatchOrpClosestMatchIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_pModeToMatchOrpClosestMatchIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_ModeHasRefreshRateDenominatorZero"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_ModeHasRefreshRateDenominatorZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_UnknownFormatIsInvalidForConfiguration"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_UnknownFormatIsInvalidForConfiguration,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeScanlineOrdering"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeScanlineOrdering,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeScaling"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeScaling,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeFormatAndDeviceCombination"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_InvalidDisplayModeFormatAndDeviceCombination,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_Creation_CalledFromDllMain"]/*'/>
    DXGI_MSG_IDXGIFactory_Creation_CalledFromDllMain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_OutputNotOwnedBySwapChainDevice"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_OutputNotOwnedBySwapChainDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Creation_InvalidWindowStyle"]/*'/>
    DXGI_MSG_IDXGISwapChain_Creation_InvalidWindowStyle,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetFrameStatistics_UnsupportedStatistics"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetFrameStatistics_UnsupportedStatistics,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetContainingOutput_SwapchainAdapterDoesNotControlOutput"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetContainingOutput_SwapchainAdapterDoesNotControlOutput,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetOrGetGammaControl_pArrayIsNULL"]/*'/>
    DXGI_MSG_IDXGIOutput_SetOrGetGammaControl_pArrayIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_FullscreenInvalidForChildWindows"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_FullscreenInvalidForChildWindows,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_Release_CalledFromDllMain"]/*'/>
    DXGI_MSG_IDXGIFactory_Release_CalledFromDllMain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_UnreleasedHDC"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_UnreleasedHDC,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_NonPreRotatedAndGDICompatibleFlags"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_NonPreRotatedAndGDICompatibleFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_NonPreRotatedAndGDICompatibleFlags"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_NonPreRotatedAndGDICompatibleFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_GetDC_pHdcIsNULL"]/*'/>
    DXGI_MSG_IDXGISurface1_GetDC_pHdcIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_GetDC_SurfaceNotTexture2D"]/*'/>
    DXGI_MSG_IDXGISurface1_GetDC_SurfaceNotTexture2D,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_GetDC_GDICompatibleFlagNotSet"]/*'/>
    DXGI_MSG_IDXGISurface1_GetDC_GDICompatibleFlagNotSet,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_GetDC_UnreleasedHDC"]/*'/>
    DXGI_MSG_IDXGISurface1_GetDC_UnreleasedHDC,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface_Map_NoCPUAccess2"]/*'/>
    DXGI_MSG_IDXGISurface_Map_NoCPUAccess2,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_ReleaseDC_GetDCNotCalled"]/*'/>
    DXGI_MSG_IDXGISurface1_ReleaseDC_GetDCNotCalled,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_ReleaseDC_InvalidRectangleDimensions"]/*'/>
    DXGI_MSG_IDXGISurface1_ReleaseDC_InvalidRectangleDimensions,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_RemoteOutputNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_RemoteOutputNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_RemoteOutputNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_FindClosestMatchingMode_RemoteOutputNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplayModeList_RemoteOutputNotSupported"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplayModeList_RemoteOutputNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_pDeviceHasMismatchedDXGIFactory"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_pDeviceHasMismatchedDXGIFactory,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_NonOptimalFSConfiguration"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_NonOptimalFSConfiguration,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_FlipSequentialNotSupportedOnD3D10"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_FlipSequentialNotSupportedOnD3D10,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_BufferCountOOBForFlipSequential"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_BufferCountOOBForFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidFormatForFlipSequential"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidFormatForFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_MultiSamplingNotSupportedForFlipSequential"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_MultiSamplingNotSupportedForFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_BufferCountOOBForFlipSequential"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_BufferCountOOBForFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidFormatForFlipSequential"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidFormatForFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_PartialPresentationBeforeStandardPresentation"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_PartialPresentationBeforeStandardPresentation,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_FullscreenPartialPresentIsInvalid"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_FullscreenPartialPresentIsInvalid,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_InvalidPresentTestOrDoNotSequenceFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_InvalidPresentTestOrDoNotSequenceFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ScrollInfoWithNoDirtyRectsSpecified"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ScrollInfoWithNoDirtyRectsSpecified,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_EmptyScrollRect"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_EmptyScrollRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ScrollRectOutOfBackbufferBounds"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ScrollRectOutOfBackbufferBounds,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ScrollRectOutOfBackbufferBoundsWithOffset"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ScrollRectOutOfBackbufferBoundsWithOffset,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_EmptyDirtyRect"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_EmptyDirtyRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_DirtyRectOutOfBackbufferBounds"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_DirtyRectOutOfBackbufferBounds,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_UnsupportedBufferUsageFlags"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_UnsupportedBufferUsageFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_DoNotSequenceFlagSetButPreviousBufferIsUndefined"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_DoNotSequenceFlagSetButPreviousBufferIsUndefined,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_UnsupportedFlags"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_UnsupportedFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_FlipModelChainMustResizeOrCreateOnFSTransition"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_FlipModelChainMustResizeOrCreateOnFSTransition,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_pRestrictToOutputFromOtherIDXGIFactory"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_pRestrictToOutputFromOtherIDXGIFactory,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_RestrictOutputNotSupportedOnAdapter"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_RestrictOutputNotSupportedOnAdapter,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_RestrictToOutputFlagSetButInvalidpRestrictToOutput"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_RestrictToOutputFlagSetButInvalidpRestrictToOutput,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_RestrictToOutputFlagdWithFullscreen"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_RestrictToOutputFlagdWithFullscreen,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_RestrictOutputFlagWithStaleSwapChain"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_RestrictOutputFlagWithStaleSwapChain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_OtherFlagsCausingInvalidPresentTestFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_OtherFlagsCausingInvalidPresentTestFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_UnavailableInSession0"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_UnavailableInSession0,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_MakeWindowAssociation_UnavailableInSession0"]/*'/>
    DXGI_MSG_IDXGIFactory_MakeWindowAssociation_UnavailableInSession0,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_GetWindowAssociation_UnavailableInSession0"]/*'/>
    DXGI_MSG_IDXGIFactory_GetWindowAssociation_UnavailableInSession0,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIAdapter_EnumOutputs_UnavailableInSession0"]/*'/>
    DXGI_MSG_IDXGIAdapter_EnumOutputs_UnavailableInSession0,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrSetFullscreenState_StereoDisabled"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrSetFullscreenState_StereoDisabled,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_UnregisterStatus_CookieNotFound"]/*'/>
    DXGI_MSG_IDXGIFactory2_UnregisterStatus_CookieNotFound,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithoutFSOrOverlay"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithoutFSOrOverlay,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithoutFlipSequential"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithoutFlipSequential,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ProtectedContentWithRDPDriver"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ProtectedContentWithRDPDriver,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithDWMOffOrInvalidDisplayAffinity"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ProtectedContentInWindowedModeWithDWMOffOrInvalidDisplayAffinity,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_WidthOrHeightIsZero"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_WidthOrHeightIsZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_OnlyFlipSequentialSupported"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_OnlyFlipSequentialSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_UnsupportedOnAdapter"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_UnsupportedOnAdapter,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_UnsupportedOnWindows7"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_UnsupportedOnWindows7,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_FSTransitionWithCompositionSwapChain"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_FSTransitionWithCompositionSwapChain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeTarget_InvalidWithCompositionSwapChain"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeTarget_InvalidWithCompositionSwapChain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_WidthOrHeightIsZero"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_WidthOrHeightIsZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingNoneIsFlipModelOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingNoneIsFlipModelOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingUnrecognized"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingUnrecognized,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyFullscreenUnsupported"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyFullscreenUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyUnsupported"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_RestartIsFullscreenOnly"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_RestartIsFullscreenOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_ProtectedWindowlessPresentationRequiresDisplayOnly"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_ProtectedWindowlessPresentationRequiresDisplayOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_DisplayOnlyUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_DisplayOnlyUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_SetBackgroundColor_OutOfRange"]/*'/>
    DXGI_MSG_IDXGISwapChain1_SetBackgroundColor_OutOfRange,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyFullscreenUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyFullscreenUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapchain_Present_ScrollUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapchain_Present_ScrollUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_SetRotation_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGISwapChain1_SetRotation_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_GetRotation_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGISwapChain1_GetRotation_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapchain_Present_FullscreenRotation"]/*'/>
    DXGI_MSG_IDXGISwapchain_Present_FullscreenRotation,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_PartialPresentationWithMSAABuffers"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_PartialPresentationWithMSAABuffers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_SetRotation_FlipSequentialRequired"]/*'/>
    DXGI_MSG_IDXGISwapChain1_SetRotation_FlipSequentialRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_SetRotation_InvalidRotation"]/*'/>
    DXGI_MSG_IDXGISwapChain1_SetRotation_InvalidRotation,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain1_GetRotation_FlipSequentialRequired"]/*'/>
    DXGI_MSG_IDXGISwapChain1_GetRotation_FlipSequentialRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetHwnd_WrongType"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetHwnd_WrongType,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetCompositionSurface_WrongType"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetCompositionSurface_WrongType,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetCoreWindow_WrongType"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetCoreWindow_WrongType,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetFullscreenDesc_NonHwnd"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetFullscreenDesc_NonHwnd,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_CoreWindow"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_CoreWindow,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_UnsupportedOnWindows7"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_UnsupportedOnWindows7,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_pWindowIsNULL"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_pWindowIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_FSUnsupportedForModernApps"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_FSUnsupportedForModernApps,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_MakeWindowAssociation_ModernApp"]/*'/>
    DXGI_MSG_IDXGIFactory_MakeWindowAssociation_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeTarget_ModernApp"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeTarget_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeTarget_pNewTargetParametersIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeTarget_pNewTargetParametersIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_SetDisplaySurface_ModernApp"]/*'/>
    DXGI_MSG_IDXGIOutput_SetDisplaySurface_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_ModernApp"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_pWindowIsInvalid"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_pWindowIsInvalid,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCompositionSurface_InvalidHandle"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCompositionSurface_InvalidHandle,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISurface1_GetDC_ModernApp"]/*'/>
    DXGI_MSG_IDXGISurface1_GetDC_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingNoneRequiresWindows8OrNewer"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ScalingNoneRequiresWindows8OrNewer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoAndPreferRight"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoAndPreferRight,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoOrPreferRightWithDoNotSequence"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoOrPreferRightWithDoNotSequence,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoOrPreferRightWithoutStereo"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoOrPreferRightWithoutStereo,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_TemporaryMonoUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_ArraySizeMismatch"]/*'/>
    DXGI_MSG_IDXGIOutput_GetDisplaySurfaceData_ArraySizeMismatch,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_PartialPresentationWithSwapEffectDiscard"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_PartialPresentationWithSwapEffectDiscard,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaUnrecognized"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaUnrecognized,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaIsWindowlessOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaIsWindowlessOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaIsFlipModelOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_AlphaIsFlipModelOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_RestrictToOutputAdapterMismatch"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_RestrictToOutputAdapterMismatch,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyOnLegacy"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_DisplayOnlyOnLegacy,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyOnLegacy"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_DisplayOnlyOnLegacy,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIResource1_CreateSubresourceSurface_InvalidIndex"]/*'/>
    DXGI_MSG_IDXGIResource1_CreateSubresourceSurface_InvalidIndex,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_InvalidScaling"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_InvalidScaling,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForCoreWindow_InvalidSwapEffect"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForCoreWindow_InvalidSwapEffect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIResource1_CreateSharedHandle_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIResource1_CreateSharedHandle_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_RegisterOcclusionStatusWindow_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIFactory2_RegisterOcclusionStatusWindow_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_RegisterOcclusionStatusEvent_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIFactory2_RegisterOcclusionStatusEvent_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_DuplicateOutput_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIOutput1_DuplicateOutput_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDisplayControl_IsStereoEnabled_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIDisplayControl_IsStereoEnabled_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_InvalidAlphaMode"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForComposition_InvalidAlphaMode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_InvalidResource"]/*'/>
    DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_InvalidResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_InvalidLUID"]/*'/>
    DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_InvalidLUID,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_UnsupportedOS"]/*'/>
    DXGI_MSG_IDXGIFactory_GetSharedResourceAdapterLuid_UnsupportedOS,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_2DOnly"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_2DOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_StagingOnly"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_StagingOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_NeedCPUAccessWrite"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_NeedCPUAccessWrite,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_NoShared"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_NoShared,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_OnlyMipLevels1"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_OnlyMipLevels1,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_MappedOrOfferedResource"]/*'/>
    DXGI_MSG_IDXGIOutput1_GetDisplaySurfaceData1_MappedOrOfferedResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_FSUnsupportedForModernApps"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_FSUnsupportedForModernApps,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_FailedToGoFSButNonPreRotated"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_FailedToGoFSButNonPreRotated,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainOrRegisterOcclusionStatus_BlitModelUsedWhileRegisteredForOcclusionStatusEvents"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainOrRegisterOcclusionStatus_BlitModelUsedWhileRegisteredForOcclusionStatusEvents,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_BlitModelUsedWhileRegisteredForOcclusionStatusEvents"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_BlitModelUsedWhileRegisteredForOcclusionStatusEvents,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_WaitableSwapChainsAreFlipModelOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_WaitableSwapChainsAreFlipModelOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_WaitableSwapChainsAreNotFullscreen"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_WaitableSwapChainsAreNotFullscreen,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_Waitable"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_Waitable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveWaitableFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveWaitableFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetFrameLatencyWaitableObject_OnlyWaitable"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetFrameLatencyWaitableObject_OnlyWaitable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetMaximumFrameLatency_OnlyWaitable"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetMaximumFrameLatency_OnlyWaitable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetMaximumFrameLatency_pMaxLatencyIsNULL"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetMaximumFrameLatency_pMaxLatencyIsNULL,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMaximumFrameLatency_OnlyWaitable"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMaximumFrameLatency_OnlyWaitable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMaximumFrameLatency_MaxLatencyIsOutOfBounds"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMaximumFrameLatency_MaxLatencyIsOutOfBounds,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ForegroundIsCoreWindowOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ForegroundIsCoreWindowOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_ForegroundUnsupportedOnAdapter"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_ForegroundUnsupportedOnAdapter,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_InvalidScaling"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_InvalidScaling,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_InvalidAlphaMode"]/*'/>
    DXGI_MSG_IDXGIFactory2_CreateSwapChainForCoreWindow_InvalidAlphaMode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveForegroundFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveForegroundFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixPointerCannotBeNull"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixPointerCannotBeNull,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMatrixTransform_RequiresCompositionSwapChain"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMatrixTransform_RequiresCompositionSwapChain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixMustBeFinite"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixMustBeFinite,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixMustBeTranslateAndOrScale"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMatrixTransform_MatrixMustBeTranslateAndOrScale,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetMatrixTransform_MatrixPointerCannotBeNull"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetMatrixTransform_MatrixPointerCannotBeNull,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetMatrixTransform_RequiresCompositionSwapChain"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetMatrixTransform_RequiresCompositionSwapChain,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_DXGIGetDebugInterface1_NULL_ppDebug"]/*'/>
    DXGI_MSG_DXGIGetDebugInterface1_NULL_ppDebug,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_DXGIGetDebugInterface1_InvalidFlags"]/*'/>
    DXGI_MSG_DXGIGetDebugInterface1_InvalidFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_Decode"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_Decode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_Decode"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_Decode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetSourceSize_FlipModel"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetSourceSize_FlipModel,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetSourceSize_Decode"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetSourceSize_Decode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetSourceSize_WidthHeight"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetSourceSize_WidthHeight,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetSourceSize_NullPointers"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetSourceSize_NullPointers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetSourceSize_Decode"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetSourceSize_Decode,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_SetColorSpace_InvalidFlags"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_SetColorSpace_InvalidFlags,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_SetSourceRect_InvalidRect"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_SetSourceRect_InvalidRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_SetTargetRect_InvalidRect"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_SetTargetRect_InvalidRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_SetDestSize_InvalidSize"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_SetDestSize_InvalidSize,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_GetSourceRect_InvalidPointer"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_GetSourceRect_InvalidPointer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_GetTargetRect_InvalidPointer"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_GetTargetRect_InvalidPointer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIDecodeSwapChain_GetDestSize_InvalidPointer"]/*'/>
    DXGI_MSG_IDXGIDecodeSwapChain_GetDestSize_InvalidPointer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_PresentBuffer_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_PresentBuffer_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetSourceSize_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetSourceSize_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetSourceSize_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetSourceSize_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetMatrixTransform_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetMatrixTransform_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_GetMatrixTransform_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_GetMatrixTransform_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_PartialPresentation_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_PartialPresentation_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveFlag_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveFlag_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_Alignment_YUV"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_Alignment_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_ShaderInputUnsupported_YUV"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_ShaderInputUnsupported_YUV,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput3_CheckOverlaySupport_NullPointers"]/*'/>
    DXGI_MSG_IDXGIOutput3_CheckOverlaySupport_NullPointers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput3_CheckOverlaySupport_IDXGIDeviceNotSupportedBypConcernedDevice"]/*'/>
    DXGI_MSG_IDXGIOutput3_CheckOverlaySupport_IDXGIDeviceNotSupportedBypConcernedDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIAdapter_EnumOutputs2_InvalidEnumOutputs2Flag"]/*'/>
    DXGI_MSG_IDXGIAdapter_EnumOutputs2_InvalidEnumOutputs2Flag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreationOrSetFullscreenState_FSUnsupportedForFlipDiscard"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreationOrSetFullscreenState_FSUnsupportedForFlipDiscard,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput4_CheckOverlayColorSpaceSupport_NullPointers"]/*'/>
    DXGI_MSG_IDXGIOutput4_CheckOverlayColorSpaceSupport_NullPointers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput4_CheckOverlayColorSpaceSupport_IDXGIDeviceNotSupportedBypConcernedDevice"]/*'/>
    DXGI_MSG_IDXGIOutput4_CheckOverlayColorSpaceSupport_IDXGIDeviceNotSupportedBypConcernedDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_CheckColorSpaceSupport_NullPointers"]/*'/>
    DXGI_MSG_IDXGISwapChain3_CheckColorSpaceSupport_NullPointers,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_SetColorSpace1_InvalidColorSpace"]/*'/>
    DXGI_MSG_IDXGISwapChain3_SetColorSpace1_InvalidColorSpace,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidHwProtect"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidHwProtect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_HwProtectUnsupported"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_HwProtectUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidHwProtect"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidHwProtect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_HwProtectUnsupported"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_HwProtectUnsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers1_D3D12Only"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers1_D3D12Only,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers1_FlipModel"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers1_FlipModel,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers1_NodeMaskAndQueueRequired"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers1_NodeMaskAndQueueRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_CreateSwapChain_InvalidHwProtectGdiFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_CreateSwapChain_InvalidHwProtectGdiFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidHwProtectGdiFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_InvalidHwProtectGdiFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_10BitFormatNotSupported"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_10BitFormatNotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_FlipSwapEffectRequired"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_FlipSwapEffectRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidDevice"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidDevice,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_TakeOwnership_Unsupported"]/*'/>
    DXGI_MSG_IDXGIOutput_TakeOwnership_Unsupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidQueue"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_InvalidQueue,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_ResizeBuffers1_InvalidQueue"]/*'/>
    DXGI_MSG_IDXGISwapChain3_ResizeBuffers1_InvalidQueue,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChainForHwnd_InvalidScaling"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChainForHwnd_InvalidScaling,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidSize"]/*'/>
    DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidSize,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidPointer"]/*'/>
    DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidPointer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidType"]/*'/>
    DXGI_MSG_IDXGISwapChain3_SetHDRMetaData_InvalidType,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_FullscreenAllowTearingIsInvalid"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_FullscreenAllowTearingIsInvalid,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_AllowTearingRequiresPresentIntervalZero"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_AllowTearingRequiresPresentIntervalZero,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_AllowTearingRequiresCreationFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_AllowTearingRequiresCreationFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveAllowTearingFlag"]/*'/>
    DXGI_MSG_IDXGISwapChain_ResizeBuffers_CannotAddOrRemoveAllowTearingFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_AllowTearingFlagIsFlipModelOnly"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_AllowTearingFlagIsFlipModelOnly,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CheckFeatureSupport_InvalidFeature"]/*'/>
    DXGI_MSG_IDXGIFactory_CheckFeatureSupport_InvalidFeature,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CheckFeatureSupport_InvalidSize"]/*'/>
    DXGI_MSG_IDXGIFactory_CheckFeatureSupport_InvalidSize,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput6_CheckHardwareCompositionSupport_NullPointer"]/*'/>
    DXGI_MSG_IDXGIOutput6_CheckHardwareCompositionSupport_NullPointer,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_SetFullscreenState_PerMonitorDpiShimApplied"]/*'/>
    DXGI_MSG_IDXGISwapChain_SetFullscreenState_PerMonitorDpiShimApplied,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_DuplicateOutput_PerMonitorDpiShimApplied"]/*'/>
    DXGI_MSG_IDXGIOutput_DuplicateOutput_PerMonitorDpiShimApplied,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIOutput_DuplicateOutput1_PerMonitorDpiRequired"]/*'/>
    DXGI_MSG_IDXGIOutput_DuplicateOutput1_PerMonitorDpiRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory7_UnregisterAdaptersChangedEvent_CookieNotFound"]/*'/>
    DXGI_MSG_IDXGIFactory7_UnregisterAdaptersChangedEvent_CookieNotFound,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_LegacyBltModelSwapEffect"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_LegacyBltModelSwapEffect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain4_SetHDRMetaData_MetadataUnchanged"]/*'/>
    DXGI_MSG_IDXGISwapChain4_SetHDRMetaData_MetadataUnchanged,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGISwapChain_Present_11On12_Released_Resource"]/*'/>
    DXGI_MSG_IDXGISwapChain_Present_11On12_Released_Resource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_CreateSwapChain_MultipleSwapchainRefToSurface_DeferredDtr"]/*'/>
    DXGI_MSG_IDXGIFactory_CreateSwapChain_MultipleSwapchainRefToSurface_DeferredDtr,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_IDXGIFactory_MakeWindowAssociation_NoOpBehavior"]/*'/>
    DXGI_MSG_IDXGIFactory_MakeWindowAssociation_NoOpBehavior,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_NotForegroundWindow"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_NotForegroundWindow = 1000,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_DISCARD_BufferCount"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_DISCARD_BufferCount,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_SetFullscreenState_NotAvailable"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_SetFullscreenState_NotAvailable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_ResizeBuffers_NotAvailable"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_ResizeBuffers_NotAvailable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_ResizeTarget_NotAvailable"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_ResizeTarget_NotAvailable,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidLayerIndex"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidLayerIndex,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_MultipleLayerIndex"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_MultipleLayerIndex,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidLayerFlag"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidLayerFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidRotation"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidRotation,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidBlend"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidBlend,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidResource"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidMultiPlaneOverlayResource"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidMultiPlaneOverlayResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidIndexForPrimary"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidIndexForPrimary,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidIndexForOverlay"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidIndexForOverlay,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidSubResourceIndex"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidSubResourceIndex,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidSourceRect"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidSourceRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidDestinationRect"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidDestinationRect,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_MultipleResource"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_MultipleResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_NotSharedResource"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_NotSharedResource,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidFlag"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidFlag,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidInterval"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_InvalidInterval,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_MSAA_NotSupported"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_MSAA_NotSupported,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_ScalingAspectRatioStretch_Supported_ModernApp"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_ScalingAspectRatioStretch_Supported_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_GetFrameStatistics_NotAvailable_ModernApp"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_GetFrameStatistics_NotAvailable_ModernApp,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present_ReplaceInterval0With1"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present_ReplaceInterval0With1,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FailedRegisterWithCompositor"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FailedRegisterWithCompositor,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_NotForegroundWindow_AtRendering"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_NotForegroundWindow_AtRendering,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FLIP_SEQUENTIAL_BufferCount"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FLIP_SEQUENTIAL_BufferCount,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FLIP_Modern_CoreWindow_Only"]/*'/>
    DXGI_MSG_Phone_IDXGIFactory_CreateSwapChain_FLIP_Modern_CoreWindow_Only,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_Present1_RequiresOverlays"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_Present1_RequiresOverlays,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_SetBackgroundColor_FlipSequentialRequired"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_SetBackgroundColor_FlipSequentialRequired,
    /// <include file='DXGI_Message_Id.xml' path='doc/member[@name="DXGI_Message_Id.DXGI_MSG_Phone_IDXGISwapChain_GetBackgroundColor_FlipSequentialRequired"]/*'/>
    DXGI_MSG_Phone_IDXGISwapChain_GetBackgroundColor_FlipSequentialRequired,
}