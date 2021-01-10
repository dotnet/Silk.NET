// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.NV
{
    [NativeName("Name", "GLenum")]
    public enum NV : int
    {
        [NativeName("Name", "EGL_AUTO_STEREO_NV")]
        AutoStereoNV = 0x3136,
        [NativeName("Name", "EGL_CONTEXT_PRIORITY_REALTIME_NV")]
        ContextPriorityRealtimeNV = 0x3357,
        [NativeName("Name", "EGL_COVERAGE_BUFFERS_NV")]
        CoverageBuffersNV = 0x30E0,
        [NativeName("Name", "EGL_COVERAGE_SAMPLES_NV")]
        CoverageSamplesNV = 0x30E1,
        [NativeName("Name", "EGL_COVERAGE_SAMPLE_RESOLVE_NV")]
        CoverageSampleResolveNV = 0x3131,
        [NativeName("Name", "EGL_COVERAGE_SAMPLE_RESOLVE_DEFAULT_NV")]
        CoverageSampleResolveDefaultNV = 0x3132,
        [NativeName("Name", "EGL_COVERAGE_SAMPLE_RESOLVE_NONE_NV")]
        CoverageSampleResolveNoneNV = 0x3133,
        [NativeName("Name", "EGL_CUDA_EVENT_HANDLE_NV")]
        CudaEventHandleNV = 0x323B,
        [NativeName("Name", "EGL_SYNC_CUDA_EVENT_NV")]
        SyncCudaEventNV = 0x323C,
        [NativeName("Name", "EGL_SYNC_CUDA_EVENT_COMPLETE_NV")]
        SyncCudaEventCompleteNV = 0x323D,
        [NativeName("Name", "EGL_DEPTH_ENCODING_NV")]
        DepthEncodingNV = 0x30E2,
        [NativeName("Name", "EGL_DEPTH_ENCODING_NONE_NV")]
        DepthEncodingNoneNV = 0x0,
        [NativeName("Name", "EGL_DEPTH_ENCODING_NONLINEAR_NV")]
        DepthEncodingNonlinearNV = 0x30E3,
        [NativeName("Name", "EGL_CUDA_DEVICE_NV")]
        CudaDeviceNV = 0x323A,
        [NativeName("Name", "EGL_POST_SUB_BUFFER_SUPPORTED_NV")]
        PostSubBufferSupportedNV = 0x30BE,
        [NativeName("Name", "EGL_QUADRUPLE_BUFFER_NV")]
        QuadrupleBufferNV = 0x3231,
        [NativeName("Name", "EGL_GENERATE_RESET_ON_VIDEO_MEMORY_PURGE_NV")]
        GenerateResetOnVideoMemoryPurgeNV = 0x334C,
        [NativeName("Name", "EGL_STREAM_CONSUMER_IMAGE_NV")]
        StreamConsumerImageNV = 0x3373,
        [NativeName("Name", "EGL_STREAM_IMAGE_ADD_NV")]
        StreamImageAddNV = 0x3374,
        [NativeName("Name", "EGL_STREAM_IMAGE_REMOVE_NV")]
        StreamImageRemoveNV = 0x3375,
        [NativeName("Name", "EGL_STREAM_IMAGE_AVAILABLE_NV")]
        StreamImageAvailableNV = 0x3376,
        [NativeName("Name", "EGL_YUV_PLANE0_TEXTURE_UNIT_NV")]
        YuvPlane0TextureUnitNV = 0x332C,
        [NativeName("Name", "EGL_YUV_PLANE1_TEXTURE_UNIT_NV")]
        YuvPlane1TextureUnitNV = 0x332D,
        [NativeName("Name", "EGL_YUV_PLANE2_TEXTURE_UNIT_NV")]
        YuvPlane2TextureUnitNV = 0x332E,
        [NativeName("Name", "EGL_YUV_NUMBER_OF_PLANES_EXT")]
        YuvNumberOfPlanesExt = 0x3311,
        [NativeName("Name", "EGL_YUV_BUFFER_EXT")]
        YuvBufferExt = 0x3300,
        [NativeName("Name", "EGL_STREAM_CROSS_DISPLAY_NV")]
        StreamCrossDisplayNV = 0x334E,
        [NativeName("Name", "EGL_STREAM_CROSS_OBJECT_NV")]
        StreamCrossObjectNV = 0x334D,
        [NativeName("Name", "EGL_STREAM_CROSS_PARTITION_NV")]
        StreamCrossPartitionNV = 0x323F,
        [NativeName("Name", "EGL_STREAM_CROSS_PROCESS_NV")]
        StreamCrossProcessNV = 0x3245,
        [NativeName("Name", "EGL_STREAM_CROSS_SYSTEM_NV")]
        StreamCrossSystemNV = 0x334F,
        [NativeName("Name", "EGL_STREAM_DMA_NV")]
        StreamDmaNV = 0x3371,
        [NativeName("Name", "EGL_STREAM_DMA_SERVER_NV")]
        StreamDmaServerNV = 0x3372,
        [NativeName("Name", "EGL_PENDING_FRAME_NV")]
        PendingFrameNV = 0x3329,
        [NativeName("Name", "EGL_STREAM_TIME_PENDING_NV")]
        StreamTimePendingNV = 0x332A,
        [NativeName("Name", "EGL_STREAM_FIFO_SYNCHRONOUS_NV")]
        StreamFifoSynchronousNV = 0x3336,
        [NativeName("Name", "EGL_PRODUCER_MAX_FRAME_HINT_NV")]
        ProducerMaxFrameHintNV = 0x3337,
        [NativeName("Name", "EGL_CONSUMER_MAX_FRAME_HINT_NV")]
        ConsumerMaxFrameHintNV = 0x3338,
        [NativeName("Name", "EGL_MAX_STREAM_METADATA_BLOCKS_NV")]
        MaxStreamMetadataBlocksNV = 0x3250,
        [NativeName("Name", "EGL_MAX_STREAM_METADATA_BLOCK_SIZE_NV")]
        MaxStreamMetadataBlockSizeNV = 0x3251,
        [NativeName("Name", "EGL_MAX_STREAM_METADATA_TOTAL_SIZE_NV")]
        MaxStreamMetadataTotalSizeNV = 0x3252,
        [NativeName("Name", "EGL_PRODUCER_METADATA_NV")]
        ProducerMetadataNV = 0x3253,
        [NativeName("Name", "EGL_CONSUMER_METADATA_NV")]
        ConsumerMetadataNV = 0x3254,
        [NativeName("Name", "EGL_PENDING_METADATA_NV")]
        PendingMetadataNV = 0x3328,
        [NativeName("Name", "EGL_METADATA0_SIZE_NV")]
        Metadata0SizeNV = 0x3255,
        [NativeName("Name", "EGL_METADATA1_SIZE_NV")]
        Metadata1SizeNV = 0x3256,
        [NativeName("Name", "EGL_METADATA2_SIZE_NV")]
        Metadata2SizeNV = 0x3257,
        [NativeName("Name", "EGL_METADATA3_SIZE_NV")]
        Metadata3SizeNV = 0x3258,
        [NativeName("Name", "EGL_METADATA0_TYPE_NV")]
        Metadata0TypeNV = 0x3259,
        [NativeName("Name", "EGL_METADATA1_TYPE_NV")]
        Metadata1TypeNV = 0x325A,
        [NativeName("Name", "EGL_METADATA2_TYPE_NV")]
        Metadata2TypeNV = 0x325B,
        [NativeName("Name", "EGL_METADATA3_TYPE_NV")]
        Metadata3TypeNV = 0x325C,
        [NativeName("Name", "EGL_STREAM_FRAME_ORIGIN_X_NV")]
        StreamFrameOriginXNV = 0x3366,
        [NativeName("Name", "EGL_STREAM_FRAME_ORIGIN_Y_NV")]
        StreamFrameOriginYNV = 0x3367,
        [NativeName("Name", "EGL_STREAM_FRAME_MAJOR_AXIS_NV")]
        StreamFrameMajorAxisNV = 0x3368,
        [NativeName("Name", "EGL_CONSUMER_AUTO_ORIENTATION_NV")]
        ConsumerAutoOrientationNV = 0x3369,
        [NativeName("Name", "EGL_PRODUCER_AUTO_ORIENTATION_NV")]
        ProducerAutoOrientationNV = 0x336A,
        [NativeName("Name", "EGL_LEFT_NV")]
        LeftNV = 0x336B,
        [NativeName("Name", "EGL_RIGHT_NV")]
        RightNV = 0x336C,
        [NativeName("Name", "EGL_TOP_NV")]
        TopNV = 0x336D,
        [NativeName("Name", "EGL_BOTTOM_NV")]
        BottomNV = 0x336E,
        [NativeName("Name", "EGL_X_AXIS_NV")]
        XAxisNV = 0x336F,
        [NativeName("Name", "EGL_Y_AXIS_NV")]
        YAxisNV = 0x3370,
        [NativeName("Name", "EGL_STREAM_STATE_INITIALIZING_NV")]
        StreamStateInitializingNV = 0x3240,
        [NativeName("Name", "EGL_STREAM_TYPE_NV")]
        StreamTypeNV = 0x3241,
        [NativeName("Name", "EGL_STREAM_PROTOCOL_NV")]
        StreamProtocolNV = 0x3242,
        [NativeName("Name", "EGL_STREAM_ENDPOINT_NV")]
        StreamEndpointNV = 0x3243,
        [NativeName("Name", "EGL_STREAM_LOCAL_NV")]
        StreamLocalNV = 0x3244,
        [NativeName("Name", "EGL_STREAM_PRODUCER_NV")]
        StreamProducerNV = 0x3247,
        [NativeName("Name", "EGL_STREAM_CONSUMER_NV")]
        StreamConsumerNV = 0x3248,
        [NativeName("Name", "EGL_STREAM_PROTOCOL_FD_NV")]
        StreamProtocolFDNV = 0x3246,
        [NativeName("Name", "EGL_SUPPORT_RESET_NV")]
        SupportResetNV = 0x3334,
        [NativeName("Name", "EGL_SUPPORT_REUSE_NV")]
        SupportReuseNV = 0x3335,
        [NativeName("Name", "EGL_STREAM_PROTOCOL_SOCKET_NV")]
        StreamProtocolSocketNV = 0x324B,
        [NativeName("Name", "EGL_SOCKET_HANDLE_NV")]
        SocketHandleNV = 0x324C,
        [NativeName("Name", "EGL_SOCKET_TYPE_NV")]
        SocketTypeNV = 0x324D,
        [NativeName("Name", "EGL_SOCKET_TYPE_INET_NV")]
        SocketTypeInetNV = 0x324F,
        [NativeName("Name", "EGL_SOCKET_TYPE_UNIX_NV")]
        SocketTypeUnixNV = 0x324E,
        [NativeName("Name", "EGL_SYNC_TYPE_KHR")]
        SyncTypeKhr = 0x30F7,
        [NativeName("Name", "EGL_SYNC_NEW_FRAME_NV")]
        SyncNewFrameNV = 0x321F,
        [NativeName("Name", "EGL_SYNC_PRIOR_COMMANDS_COMPLETE_NV")]
        SyncPriorCommandsCompleteNV = 0x30E6,
        [NativeName("Name", "EGL_SYNC_STATUS_NV")]
        SyncStatusNV = 0x30E7,
        [NativeName("Name", "EGL_SIGNALED_NV")]
        SignaledNV = 0x30E8,
        [NativeName("Name", "EGL_UNSIGNALED_NV")]
        UnsignaledNV = 0x30E9,
        [NativeName("Name", "EGL_SYNC_FLUSH_COMMANDS_BIT_NV")]
        SyncFlushCommandsBitNV = 0x1,
        [NativeName("Name", "EGL_FOREVER_NV")]
        ForeverNV = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_ALREADY_SIGNALED_NV")]
        AlreadySignaledNV = 0x30EA,
        [NativeName("Name", "EGL_TIMEOUT_EXPIRED_NV")]
        TimeoutExpiredNV = 0x30EB,
        [NativeName("Name", "EGL_CONDITION_SATISFIED_NV")]
        ConditionSatisfiedNV = 0x30EC,
        [NativeName("Name", "EGL_SYNC_TYPE_NV")]
        SyncTypeNV = 0x30ED,
        [NativeName("Name", "EGL_SYNC_CONDITION_NV")]
        SyncConditionNV = 0x30EE,
        [NativeName("Name", "EGL_SYNC_FENCE_NV")]
        SyncFenceNV = 0x30EF,
        [NativeName("Name", "EGL_NO_SYNC_NV")]
        NoSyncNV = 0x0,
        [NativeName("Name", "EGL_TRIPLE_BUFFER_NV")]
        TripleBufferNV = 0x3230,
    }
}
