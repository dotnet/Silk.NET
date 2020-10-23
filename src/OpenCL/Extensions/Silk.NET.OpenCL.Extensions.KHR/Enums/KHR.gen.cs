// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "GLenum")]
    public enum KHR
    {
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE_KHR")]
        SamplerMipFilterModeKhr = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN_KHR")]
        SamplerLodMinKhr = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX_KHR")]
        SamplerLodMaxKhr = 0x1157,
        [NativeName("Name", "CL_INVALID_D3D10_DEVICE_KHR")]
        InvalidD3D10DeviceKhr = unchecked((int)0xFFFFFFFFFFFFFC16),
        [NativeName("Name", "CL_INVALID_D3D10_RESOURCE_KHR")]
        InvalidD3D10ResourceKhr = unchecked((int)0xFFFFFFFFFFFFFC15),
        [NativeName("Name", "CL_D3D10_RESOURCE_ALREADY_ACQUIRED_KHR")]
        D3D10ResourceAlreadyAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC14),
        [NativeName("Name", "CL_D3D10_RESOURCE_NOT_ACQUIRED_KHR")]
        D3D10ResourceNotAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC13),
        [NativeName("Name", "CL_D3D10_DEVICE_KHR")]
        D3D10DeviceKhr = 0x4010,
        [NativeName("Name", "CL_D3D10_DXGI_ADAPTER_KHR")]
        D3D10DxgiAdapterKhr = 0x4011,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D10_KHR")]
        PreferredDevicesForD3D10Khr = 0x4012,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D10_KHR")]
        AllDevicesForD3D10Khr = 0x4013,
        [NativeName("Name", "CL_CONTEXT_D3D10_DEVICE_KHR")]
        ContextD3D10DeviceKhr = 0x4014,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_MEM_D3D10_RESOURCE_KHR")]
        MemD3D10ResourceKhr = 0x4015,
        [NativeName("Name", "CL_IMAGE_D3D10_SUBRESOURCE_KHR")]
        ImageD3D10SubresourceKhr = 0x4016,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR")]
        CommandAcquireD3D10ObjectsKhr = 0x4017,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR")]
        CommandReleaseD3D10ObjectsKhr = 0x4018,
        [NativeName("Name", "CL_INVALID_D3D11_DEVICE_KHR")]
        InvalidD3D11DeviceKhr = unchecked((int)0xFFFFFFFFFFFFFC12),
        [NativeName("Name", "CL_INVALID_D3D11_RESOURCE_KHR")]
        InvalidD3D11ResourceKhr = unchecked((int)0xFFFFFFFFFFFFFC11),
        [NativeName("Name", "CL_D3D11_RESOURCE_ALREADY_ACQUIRED_KHR")]
        D3D11ResourceAlreadyAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC10),
        [NativeName("Name", "CL_D3D11_RESOURCE_NOT_ACQUIRED_KHR")]
        D3D11ResourceNotAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC0F),
        [NativeName("Name", "CL_D3D11_DEVICE_KHR")]
        D3D11DeviceKhr = 0x4019,
        [NativeName("Name", "CL_D3D11_DXGI_ADAPTER_KHR")]
        D3D11DxgiAdapterKhr = 0x401A,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D11_KHR")]
        PreferredDevicesForD3D11Khr = 0x401B,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D11_KHR")]
        AllDevicesForD3D11Khr = 0x401C,
        [NativeName("Name", "CL_CONTEXT_D3D11_DEVICE_KHR")]
        ContextD3D11DeviceKhr = 0x401D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_MEM_D3D11_RESOURCE_KHR")]
        MemD3D11ResourceKhr = 0x401E,
        [NativeName("Name", "CL_IMAGE_D3D11_SUBRESOURCE_KHR")]
        ImageD3D11SubresourceKhr = 0x401F,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR")]
        CommandAcquireD3D11ObjectsKhr = 0x4020,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR")]
        CommandReleaseD3D11ObjectsKhr = 0x4021,
        [NativeName("Name", "CL_DEPTH")]
        Depth = 0x10BD,
        [NativeName("Name", "CL_UNORM_INT16")]
        UnormInt16 = 0x10D3,
        [NativeName("Name", "CL_FLOAT")]
        Float = 0x10DE,
        [NativeName("Name", "CL_UUID_SIZE_KHR")]
        UuidSizeKhr = 0x16,
        [NativeName("Name", "CL_LUID_SIZE_KHR")]
        LuidSizeKhr = 0x8,
        [NativeName("Name", "CL_DEVICE_UUID_KHR")]
        DeviceUuidKhr = 0x106A,
        [NativeName("Name", "CL_DRIVER_UUID_KHR")]
        DriverUuidKhr = 0x106B,
        [NativeName("Name", "CL_DEVICE_LUID_VALID_KHR")]
        DeviceLuidValidKhr = 0x106C,
        [NativeName("Name", "CL_DEVICE_LUID_KHR")]
        DeviceLuidKhr = 0x106D,
        [NativeName("Name", "CL_DEVICE_NODE_MASK_KHR")]
        DeviceNodeMaskKhr = 0x106E,
        [NativeName("Name", "CL_INVALID_DX9_MEDIA_ADAPTER_KHR")]
        InvalidDX9MediaAdapterKhr = unchecked((int)0xFFFFFFFFFFFFFC0E),
        [NativeName("Name", "CL_INVALID_DX9_MEDIA_SURFACE_KHR")]
        InvalidDX9MediaSurfaceKhr = unchecked((int)0xFFFFFFFFFFFFFC0D),
        [NativeName("Name", "CL_DX9_MEDIA_SURFACE_ALREADY_ACQUIRED_KHR")]
        DX9MediaSurfaceAlreadyAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC0C),
        [NativeName("Name", "CL_DX9_MEDIA_SURFACE_NOT_ACQUIRED_KHR")]
        DX9MediaSurfaceNotAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFC0B),
        [NativeName("Name", "CL_ADAPTER_D3D9_KHR")]
        AdapterD3D9Khr = 0x2020,
        [NativeName("Name", "CL_ADAPTER_D3D9EX_KHR")]
        AdapterD3D9EXKhr = 0x2021,
        [NativeName("Name", "CL_ADAPTER_DXVA_KHR")]
        AdapterDxvaKhr = 0x2022,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        PreferredDevicesForDX9MediaAdapterKhr = 0x2023,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        AllDevicesForDX9MediaAdapterKhr = 0x2024,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9_KHR")]
        ContextAdapterD3D9Khr = 0x2025,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
        ContextAdapterD3D9EXKhr = 0x2026,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_DXVA_KHR")]
        ContextAdapterDxvaKhr = 0x2027,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR")]
        MemDX9MediaAdapterTypeKhr = 0x2028,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR")]
        MemDX9MediaSurfaceInfoKhr = 0x2029,
        [NativeName("Name", "CL_IMAGE_DX9_MEDIA_PLANE_KHR")]
        ImageDX9MediaPlaneKhr = 0x202A,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR")]
        CommandAcquireDX9MediaSurfacesKhr = 0x202B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR")]
        CommandReleaseDX9MediaSurfacesKhr = 0x202C,
        [NativeName("Name", "CL_COMMAND_EGL_FENCE_SYNC_OBJECT_KHR")]
        CommandEglFenceSyncObjectKhr = 0x202F,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EGL_OBJECTS_KHR")]
        CommandAcquireEglObjectsKhr = 0x202D,
        [NativeName("Name", "CL_COMMAND_RELEASE_EGL_OBJECTS_KHR")]
        CommandReleaseEglObjectsKhr = 0x202E,
        [NativeName("Name", "CL_INVALID_EGL_OBJECT_KHR")]
        InvalidEglObjectKhr = unchecked((int)0xFFFFFFFFFFFFFBBB),
        [NativeName("Name", "CL_EGL_RESOURCE_NOT_ACQUIRED_KHR")]
        EglResourceNotAcquiredKhr = unchecked((int)0xFFFFFFFFFFFFFBBC),
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        DeviceHalfFPConfig = 0x1033,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DeviceDoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEPTH_STENCIL")]
        DepthStencil = 0x10BE,
        [NativeName("Name", "CL_UNORM_INT24")]
        UnormInt24 = 0x10DF,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        CommandGLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_GL_NUM_SAMPLES")]
        GLNumSamples = 0x2012,
        [NativeName("Name", "CL_INVALID_GL_SHAREGROUP_REFERENCE_KHR")]
        InvalidGLSharegroupReferenceKhr = unchecked((int)0xFFFFFFFFFFFFFC18),
        [NativeName("Name", "CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR")]
        CurrentDeviceForGLContextKhr = 0x2006,
        [NativeName("Name", "CL_DEVICES_FOR_GL_CONTEXT_KHR")]
        DevicesForGLContextKhr = 0x2007,
        [NativeName("Name", "CL_GL_CONTEXT_KHR")]
        GLContextKhr = 0x2008,
        [NativeName("Name", "CL_EGL_DISPLAY_KHR")]
        EglDisplayKhr = 0x2009,
        [NativeName("Name", "CL_GLX_DISPLAY_KHR")]
        GlxDisplayKhr = 0x200A,
        [NativeName("Name", "CL_WGL_HDC_KHR")]
        WglHdcKhr = 0x200B,
        [NativeName("Name", "CL_CGL_SHAREGROUP_KHR")]
        CglSharegroupKhr = 0x200C,
        [NativeName("Name", "CL_GL_OBJECT_BUFFER")]
        GLObjectBuffer = 0x2000,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D")]
        GLObjectTexture2D = 0x2001,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE3D")]
        GLObjectTexture3D = 0x2002,
        [NativeName("Name", "CL_GL_OBJECT_RENDERBUFFER")]
        GLObjectRenderbuffer = 0x2003,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D_ARRAY")]
        GLObjectTexture2DArray = 0x200E,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D")]
        GLObjectTexture1D = 0x200F,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D_ARRAY")]
        GLObjectTexture1DArray = 0x2010,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE_BUFFER")]
        GLObjectTextureBuffer = 0x2011,
        [NativeName("Name", "CL_GL_TEXTURE_TARGET")]
        GLTextureTarget = 0x2004,
        [NativeName("Name", "CL_GL_MIPMAP_LEVEL")]
        GLMipmapLevel = 0x2005,
        [NativeName("Name", "CL_INVALID_GL_OBJECT")]
        InvalidGLObject = unchecked((int)0xFFFFFFFFFFFFFFC4),
        [NativeName("Name", "CL_INVALID_MIP_LEVEL")]
        InvalidMipLevel = unchecked((int)0xFFFFFFFFFFFFFFC2),
        [NativeName("Name", "CL_PLATFORM_ICD_SUFFIX_KHR")]
        PlatformIcdSuffixKhr = 0x920,
        [NativeName("Name", "CL_PLATFORM_NOT_FOUND_KHR")]
        PlatformNotFoundKhr = unchecked((int)0xFFFFFFFFFFFFFC17),
        [NativeName("Name", "CL_DEVICE_IL_VERSION_KHR")]
        DeviceILVersionKhr = 0x105B,
        [NativeName("Name", "CL_PROGRAM_IL_KHR")]
        ProgramILKhr = 0x1169,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
        ContextMemoryInitializeKhr = 0x2030,
        [NativeName("Name", "CL_QUEUE_PRIORITY_KHR")]
        QueuePriorityKhr = 0x1096,
        [NativeName("Name", "CL_QUEUE_PRIORITY_HIGH_KHR")]
        QueuePriorityHighKhr = 0x1,
        [NativeName("Name", "CL_QUEUE_PRIORITY_MED_KHR")]
        QueuePriorityMedKhr = 0x2,
        [NativeName("Name", "CL_QUEUE_PRIORITY_LOW_KHR")]
        QueuePriorityLowKhr = 0x4,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        DeviceSpirVersions = 0x40E0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        ProgramBinaryTypeIntermediate = 0x40E1,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        DeviceMaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        KernelMaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        KernelSubGroupCountForNdrangeKhr = 0x2034,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
        DeviceTerminateCapabilityKhr = 0x2031,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        ContextTerminateKhr = 0x2032,
        [NativeName("Name", "CL_CONTEXT_TERMINATED_KHR")]
        ContextTerminatedKhr = unchecked((int)0xFFFFFFFFFFFFFB9F),
        [NativeName("Name", "CL_QUEUE_THROTTLE_KHR")]
        QueueThrottleKhr = 0x1097,
        [NativeName("Name", "CL_QUEUE_THROTTLE_HIGH_KHR")]
        QueueThrottleHighKhr = 0x1,
        [NativeName("Name", "CL_QUEUE_THROTTLE_MED_KHR")]
        QueueThrottleMedKhr = 0x2,
        [NativeName("Name", "CL_QUEUE_THROTTLE_LOW_KHR")]
        QueueThrottleLowKhr = 0x4,
    }
}
