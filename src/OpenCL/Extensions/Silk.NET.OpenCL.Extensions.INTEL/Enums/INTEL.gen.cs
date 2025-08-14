// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum INTEL : int
    {
        [NativeName("Name", "CL_ACCELERATOR_DESCRIPTOR_INTEL")]
        Descriptor = 0x4090,
        [NativeName("Name", "CL_ACCELERATOR_DESCRIPTOR_INTEL")]
        AcceleratorDescriptorIntel = 0x4090,
        [NativeName("Name", "CL_ACCELERATOR_REFERENCE_COUNT_INTEL")]
        ReferenceCount = 0x4091,
        [NativeName("Name", "CL_ACCELERATOR_REFERENCE_COUNT_INTEL")]
        AcceleratorReferenceCountIntel = 0x4091,
        [NativeName("Name", "CL_ACCELERATOR_CONTEXT_INTEL")]
        Context = 0x4092,
        [NativeName("Name", "CL_ACCELERATOR_CONTEXT_INTEL")]
        AcceleratorContextIntel = 0x4092,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_INTEL")]
        Type = 0x4093,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_INTEL")]
        AcceleratorTypeIntel = 0x4093,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_MOTION_ESTIMATION_INTEL")]
        MotionEstimation = 0x0,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_MOTION_ESTIMATION_INTEL")]
        AcceleratorTypeMotionEstimationIntel = 0x0,
        [NativeName("Name", "CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
        ChromaIntraPredictEnabled = 0x1,
        [NativeName("Name", "CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
        MEChromaIntraPredictEnabledIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
        LumaIntraPredictEnabled = 0x2,
        [NativeName("Name", "CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
        MELumaIntraPredictEnabledIntel = 0x2,
        [NativeName("Name", "CL_ME_FORWARD_INPUT_MODE_INTEL")]
        ForwardInputMode = 0x1,
        [NativeName("Name", "CL_ME_FORWARD_INPUT_MODE_INTEL")]
        MEForwardInputModeIntel = 0x1,
        [NativeName("Name", "CL_ME_BACKWARD_INPUT_MODE_INTEL")]
        BackwardInputMode = 0x2,
        [NativeName("Name", "CL_ME_BACKWARD_INPUT_MODE_INTEL")]
        MEBackwardInputModeIntel = 0x2,
        [NativeName("Name", "CL_ME_BIDIRECTION_INPUT_MODE_INTEL")]
        BidirectionInputMode = 0x3,
        [NativeName("Name", "CL_ME_BIDIRECTION_INPUT_MODE_INTEL")]
        MEBidirectionInputModeIntel = 0x3,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        Quarter = 0x16,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        MEBidirWeightQuarterIntel = 0x16,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        Third = 0x21,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        MEBidirWeightThirdIntel = 0x21,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_HALF_INTEL")]
        Half = 0x32,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_HALF_INTEL")]
        MEBidirWeightHalfIntel = 0x32,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        TwoThird = 0x43,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        MEBidirWeightTwoThirdIntel = 0x43,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        ThreeQuarter = 0x48,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        MEBidirWeightThreeQuarterIntel = 0x48,
        [NativeName("Name", "CL_ME_VERSION_LEGACY_INTEL")]
        Legacy = 0x0,
        [NativeName("Name", "CL_ME_VERSION_LEGACY_INTEL")]
        MEVersionLegacyIntel = 0x0,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_1_INTEL")]
        AdvancedVer1 = 0x1,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_1_INTEL")]
        MEVersionAdvancedVer1Intel = 0x1,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_2_INTEL")]
        AdvancedVer2 = 0x2,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_2_INTEL")]
        MEVersionAdvancedVer2Intel = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        DC = 0x0,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        MEChromaPredictorModeDCIntel = 0x0,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        Horizontal = 0x1,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        MEChromaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        Vertical = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        MEChromaPredictorModeVerticalIntel = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        Plane = 0x3,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        MEChromaPredictorModePlaneIntel = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        MELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        MELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        MELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        DiagonalDownLeft = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        MELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        DiagonalDownRight = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        MELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        MELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        VerticalRight = 0x5,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        MELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        HorizontalDown = 0x6,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        MELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        VerticalLeft = 0x7,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        MELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        HorizontalUp = 0x8,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        MELumaPredictorModeHorizontalUpIntel = 0x8,
        [NativeName("Name", "CL_ME_COST_PENALTY_NONE_INTEL")]
        None = 0x0,
        [NativeName("Name", "CL_ME_COST_PENALTY_NONE_INTEL")]
        MECostPenaltyNoneIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PENALTY_LOW_INTEL")]
        Low = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_LOW_INTEL")]
        MECostPenaltyLowIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_NORMAL_INTEL")]
        Normal = 0x2,
        [NativeName("Name", "CL_ME_COST_PENALTY_NORMAL_INTEL")]
        MECostPenaltyNormalIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PENALTY_HIGH_INTEL")]
        High = 0x3,
        [NativeName("Name", "CL_ME_COST_PENALTY_HIGH_INTEL")]
        MECostPenaltyHighIntel = 0x3,
        [NativeName("Name", "CL_ME_COST_PRECISION_QPEL_INTEL")]
        Qpel = 0x0,
        [NativeName("Name", "CL_ME_COST_PRECISION_QPEL_INTEL")]
        MECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PRECISION_HPEL_INTEL")]
        Hpel = 0x1,
        [NativeName("Name", "CL_ME_COST_PRECISION_HPEL_INTEL")]
        MECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PRECISION_PEL_INTEL")]
        Pel = 0x2,
        [NativeName("Name", "CL_ME_COST_PRECISION_PEL_INTEL")]
        MECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PRECISION_DPEL_INTEL")]
        Dpel = 0x3,
        [NativeName("Name", "CL_ME_COST_PRECISION_DPEL_INTEL")]
        MECostPrecisionDpelIntel = 0x3,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_16x16_INTEL")]
        Type16x16 = 0x0,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_16x16_INTEL")]
        MESkipBlockType16x16Intel = 0x0,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_8x8_INTEL")]
        Type8x8 = 0x4,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_8x8_INTEL")]
        MESkipBlockType8x8Intel = 0x4,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_SINGLE_QUEUE_EVENTS_INTEL")]
        CreateSingleQueueEvents = 0x1,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_SINGLE_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateSingleQueueEventsIntel = 0x1,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_CROSS_QUEUE_EVENTS_INTEL")]
        CreateCrossQueueEvents = 0x2,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_CROSS_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateCrossQueueEventsIntel = 0x2,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_SINGLE_QUEUE_EVENT_WAIT_LIST_INTEL")]
        SingleQueueEventWaitList = 0x4,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_SINGLE_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilitySingleQueueEventWaitListIntel = 0x4,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CROSS_QUEUE_EVENT_WAIT_LIST_INTEL")]
        CrossQueueEventWaitList = 0x8,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CROSS_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilityCrossQueueEventWaitListIntel = 0x8,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_INTEL")]
        TransferBuffer = 0x100,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_INTEL")]
        QueueCapabilityTransferBufferIntel = 0x100,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_RECT_INTEL")]
        TransferBufferRect = 0x200,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_RECT_INTEL")]
        QueueCapabilityTransferBufferRectIntel = 0x200,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_BUFFER_INTEL")]
        MapBuffer = 0x400,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_BUFFER_INTEL")]
        QueueCapabilityMapBufferIntel = 0x400,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_BUFFER_INTEL")]
        FillBuffer = 0x800,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_BUFFER_INTEL")]
        QueueCapabilityFillBufferIntel = 0x800,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_INTEL")]
        TransferImage = 0x1000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_INTEL")]
        QueueCapabilityTransferImageIntel = 0x1000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_IMAGE_INTEL")]
        MapImage = 0x2000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_IMAGE_INTEL")]
        QueueCapabilityMapImageIntel = 0x2000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_IMAGE_INTEL")]
        FillImage = 0x4000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_IMAGE_INTEL")]
        QueueCapabilityFillImageIntel = 0x4000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_IMAGE_INTEL")]
        TransferBufferImage = 0x8000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_IMAGE_INTEL")]
        QueueCapabilityTransferBufferImageIntel = 0x8000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_BUFFER_INTEL")]
        TransferImageBuffer = 0x10000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_BUFFER_INTEL")]
        QueueCapabilityTransferImageBufferIntel = 0x10000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MARKER_INTEL")]
        Marker = 0x1000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MARKER_INTEL")]
        QueueCapabilityMarkerIntel = 0x1000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_BARRIER_INTEL")]
        Barrier = 0x2000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_BARRIER_INTEL")]
        QueueCapabilityBarrierIntel = 0x2000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_KERNEL_INTEL")]
        Kernel = 0x4000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_KERNEL_INTEL")]
        QueueCapabilityKernelIntel = 0x4000000,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DP4A_INTEL")]
        DP4A = 0x1,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DP4A_INTEL")]
        DeviceFeatureFlagDP4AIntel = 0x1,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DPAS_INTEL")]
        Dpas = 0x2,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DPAS_INTEL")]
        DeviceFeatureFlagDpasIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_INTRA_16x16_INTEL")]
        Intra16x16 = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTRA_16x16_INTEL")]
        AvcMEIntra16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTRA_8x8_INTEL")]
        Intra8x8 = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTRA_8x8_INTEL")]
        AvcMEIntra8x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTRA_4x4_INTEL")]
        Intra4x4 = 0x2,
        [NativeName("Name", "CL_AVC_ME_INTRA_4x4_INTEL")]
        AvcMEIntra4x4Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        AvcMESadAdjustModeNoneIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        Haar = 0x2,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        AvcMESadAdjustModeHaarIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_LEFT_INTEL")]
        Left = 0x0,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_LEFT_INTEL")]
        AvcMEBorderReachedLeftIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_RIGHT_INTEL")]
        Right = 0x2,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_RIGHT_INTEL")]
        AvcMEBorderReachedRightIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_TOP_INTEL")]
        Top = 0x4,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_TOP_INTEL")]
        AvcMEBorderReachedTopIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_BOTTOM_INTEL")]
        Bottom = 0x8,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_BOTTOM_INTEL")]
        AvcMEBorderReachedBottomIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_QPEL_INTEL")]
        AvcMECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_HPEL_INTEL")]
        AvcMECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_PEL_INTEL")]
        AvcMECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_DPEL_INTEL")]
        AvcMECostPrecisionDpelIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_FRAME_FORWARD_INTEL")]
        Forward = 0x1,
        [NativeName("Name", "CL_AVC_ME_FRAME_FORWARD_INTEL")]
        AvcMEFrameForwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_FRAME_BACKWARD_INTEL")]
        Backward = 0x2,
        [NativeName("Name", "CL_AVC_ME_FRAME_BACKWARD_INTEL")]
        AvcMEFrameBackwardIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_FRAME_DUAL_INTEL")]
        Dual = 0x3,
        [NativeName("Name", "CL_AVC_ME_FRAME_DUAL_INTEL")]
        AvcMEFrameDualIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_16x16_INTEL")]
        Mask16x16 = 0x6,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_16x16_INTEL")]
        AvcMEIntraLumaPartitionMask16x16Intel = 0x6,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_8x8_INTEL")]
        Mask8x8 = 0x5,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_8x8_INTEL")]
        AvcMEIntraLumaPartitionMask8x8Intel = 0x5,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_4x4_INTEL")]
        Mask4x4 = 0x3,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_4x4_INTEL")]
        AvcMEIntraLumaPartitionMask4x4Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
        LeftMaskEnable = 0x60,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborLeftMaskEnableIntel = 0x60,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
        UpperMaskEnable = 0x10,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperMaskEnableIntel = 0x10,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
        UpperRightMaskEnable = 0x8,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperRightMaskEnableIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
        UpperLeftMaskEnable = 0x4,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperLeftMaskEnableIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        LumaPredictorModeVertical = 0x0,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        LumaPredictorModeHorizontal = 0x1,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        LumaPredictorModeDC = 0x2,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        LumaPredictorModeDiagonalDownLeft = 0x3,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        LumaPredictorModeDiagonalDownRight = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        LumaPredictorModePlane = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        LumaPredictorModeVerticalRight = 0x5,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        AvcMELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        LumaPredictorModeHorizontalDown = 0x6,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        AvcMELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        LumaPredictorModeVerticalLeft = 0x7,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        AvcMELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        LumaPredictorModeHorizontalUp = 0x8,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        AvcMELumaPredictorModeHorizontalUpIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        ChromaPredictorModeDC = 0x0,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMEChromaPredictorModeDCIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        ChromaPredictorModeHorizontal = 0x1,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMEChromaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        ChromaPredictorModeVertical = 0x2,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMEChromaPredictorModeVerticalIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        ChromaPredictorModePlane = 0x3,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMEChromaPredictorModePlaneIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x16_INTEL")]
        Major16x16 = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x16_INTEL")]
        AvcMEMajor16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x8_INTEL")]
        Major16x8 = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x8_INTEL")]
        AvcMEMajor16x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x16_INTEL")]
        Major8x16 = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x16_INTEL")]
        AvcMEMajor8x16Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x8_INTEL")]
        Major8x8 = 0x3,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x8_INTEL")]
        AvcMEMajor8x8Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_MAJOR_FORWARD_INTEL")]
        AvcMEMajorForwardIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BACKWARD_INTEL")]
        AvcMEMajorBackwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
        Bidirectional = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
        AvcMEMajorBidirectionalIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x8_INTEL")]
        Minor8x8 = 0x0,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x8_INTEL")]
        AvcMEMinor8x8Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x4_INTEL")]
        Minor8x4 = 0x1,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x4_INTEL")]
        AvcMEMinor8x4Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x8_INTEL")]
        Minor4x8 = 0x2,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x8_INTEL")]
        AvcMEMinor4x8Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x4_INTEL")]
        Minor4x4 = 0x3,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x4_INTEL")]
        AvcMEMinor4x4Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_ALL_INTEL")]
        MaskAll = 0x0,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_ALL_INTEL")]
        AvcMEPartitionMaskAllIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x16_INTEL")]
        AvcMEPartitionMask16x16Intel = 0x7E,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x8_INTEL")]
        Mask16x8 = 0x7D,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x8_INTEL")]
        AvcMEPartitionMask16x8Intel = 0x7D,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x16_INTEL")]
        Mask8x16 = 0x7B,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x16_INTEL")]
        AvcMEPartitionMask8x16Intel = 0x7B,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x8_INTEL")]
        AvcMEPartitionMask8x8Intel = 0x77,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x4_INTEL")]
        Mask8x4 = 0x6F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x4_INTEL")]
        AvcMEPartitionMask8x4Intel = 0x6F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x8_INTEL")]
        Mask4x8 = 0x5F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x8_INTEL")]
        AvcMEPartitionMask4x8Intel = 0x5F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x4_INTEL")]
        AvcMEPartitionMask4x4Intel = 0x3F,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_TOP_FIELD_INTEL")]
        TopField = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_TOP_FIELD_INTEL")]
        AvcMEInterlacedScanTopFieldIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_BOTTOM_FIELD_INTEL")]
        BottomField = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_BOTTOM_FIELD_INTEL")]
        AvcMEInterlacedScanBottomFieldIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_16x16_INTEL")]
        Partition16x16 = 0x0,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_16x16_INTEL")]
        AvcMESkipBlockPartition16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_8x8_INTEL")]
        Partition8x8 = 0x4000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_8x8_INTEL")]
        AvcMESkipBlockPartition8x8Intel = 0x4000,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_4x4_INTEL")]
        Skip4x4 = 0x0,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_4x4_INTEL")]
        AvcMEBlockBasedSkip4x4Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_8x8_INTEL")]
        Skip8x8 = 0x80,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_8x8_INTEL")]
        AvcMEBlockBasedSkip8x8Intel = 0x80,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        Block16x16ForwardEnable = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16ForwardEnableIntel = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        Block16x16BackwardEnable = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16BackwardEnableIntel = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        Block16x16DualEnable = 0x3000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock16x16DualEnableIntel = 0x3000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        Block8x8ForwardEnable = 0x55000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8ForwardEnableIntel = 0x55000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        Block8x8BackwardEnable = unchecked((int) 0xAA000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8BackwardEnableIntel = unchecked((int) 0xAA000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        Block8x8DualEnable = unchecked((int) 0xFF000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock8x8DualEnableIntel = unchecked((int) 0xFF000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        Block8x80ForwardEnable = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80ForwardEnableIntel = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        Block8x80BackwardEnable = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80BackwardEnableIntel = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        Block8x81ForwardEnable = 0x4000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81ForwardEnableIntel = 0x4000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        Block8x81BackwardEnable = 0x8000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81BackwardEnableIntel = 0x8000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        Block8x82ForwardEnable = 0x10000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82ForwardEnableIntel = 0x10000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        Block8x82BackwardEnable = 0x20000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82BackwardEnableIntel = 0x20000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        Block8x83ForwardEnable = 0x40000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83ForwardEnableIntel = 0x40000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        Block8x83BackwardEnable = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83BackwardEnableIntel = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_PRED_INTEL")]
        Pred = 0x0,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_PRED_INTEL")]
        AvcMESliceTypePredIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_BPRED_INTEL")]
        Bpred = 0x1,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_BPRED_INTEL")]
        AvcMESliceTypeBpredIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_INTRA_INTEL")]
        Intra = 0x2,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_INTRA_INTEL")]
        AvcMESliceTypeIntraIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        Integer = 0x0,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        AvcMESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        AvcMESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        AvcMESubpixelModeQpelIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_VERSION_0_INTEL")]
        Version0 = 0x0,
        [NativeName("Name", "CL_AVC_ME_VERSION_0_INTEL")]
        AvcMEVersion0Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_VERSION_1_INTEL")]
        Version1 = 0x1,
        [NativeName("Name", "CL_AVC_ME_VERSION_1_INTEL")]
        AvcMEVersion1Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        AvcMEBidirWeightQuarterIntel = 0x10,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        AvcMEBidirWeightThirdIntel = 0x15,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_HALF_INTEL")]
        AvcMEBidirWeightHalfIntel = 0x20,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        AvcMEBidirWeightTwoThirdIntel = 0x2B,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        AvcMEBidirWeightThreeQuarterIntel = 0x30,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        WindowExhaustive = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        AvcMESearchWindowExhaustiveIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        WindowSmall = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        AvcMESearchWindowSmallIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        WindowTiny = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        AvcMESearchWindowTinyIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        WindowExtraTiny = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        AvcMESearchWindowExtraTinyIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        WindowDiamond = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        AvcMESearchWindowDiamondIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        WindowLargeDiamond = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        AvcMESearchWindowLargeDiamondIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        WindowReserved0 = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        AvcMESearchWindowReserved0Intel = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        WindowReserved1 = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        AvcMESearchWindowReserved1Intel = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        WindowCustom = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        AvcMESearchWindowCustomIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        Window16x12Radius = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        AvcMESearchWindow16x12RadiusIntel = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        Window4x4Radius = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        AvcMESearchWindow4x4RadiusIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        Window2x2Radius = 0xA,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        AvcMESearchWindow2x2RadiusIntel = 0xA,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ACCESS_INTEL")]
        Access = 0x1,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ACCESS_INTEL")]
        UnifiedSharedMemoryAccessIntel = 0x1,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ATOMIC_ACCESS_INTEL")]
        AtomicAccess = 0x2,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ATOMIC_ACCESS_INTEL")]
        UnifiedSharedMemoryAtomicAccessIntel = 0x2,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ACCESS_INTEL")]
        ConcurrentAccess = 0x4,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ACCESS_INTEL")]
        UnifiedSharedMemoryConcurrentAccessIntel = 0x4,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ATOMIC_ACCESS_INTEL")]
        ConcurrentAtomicAccess = 0x8,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ATOMIC_ACCESS_INTEL")]
        UnifiedSharedMemoryConcurrentAtomicAccessIntel = 0x8,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        All = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        ContextDiagnosticsLevelAllIntel = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        Good = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        ContextDiagnosticsLevelGoodIntel = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        Bad = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        ContextDiagnosticsLevelBadIntel = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        Neutral = 0x4,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        ContextDiagnosticsLevelNeutralIntel = 0x4,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_INTEL")]
        PreferredDevicesForDX9 = 0x4024,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_INTEL")]
        PreferredDevicesForDX9Intel = 0x4024,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_INTEL")]
        AllDevicesForDX9 = 0x4025,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_INTEL")]
        AllDevicesForDX9Intel = 0x4025,
        [NativeName("Name", "CL_D3D9_DEVICE_INTEL")]
        D3D9Device = 0x4022,
        [NativeName("Name", "CL_D3D9_DEVICE_INTEL")]
        D3D9DeviceIntel = 0x4022,
        [NativeName("Name", "CL_D3D9EX_DEVICE_INTEL")]
        D3D9EXDevice = 0x4070,
        [NativeName("Name", "CL_D3D9EX_DEVICE_INTEL")]
        D3D9EXDeviceIntel = 0x4070,
        [NativeName("Name", "CL_DXVA_DEVICE_INTEL")]
        DxvaDevice = 0x4071,
        [NativeName("Name", "CL_DXVA_DEVICE_INTEL")]
        DxvaDeviceIntel = 0x4071,
        [NativeName("Name", "CL_MEM_ALLOC_WRITE_COMBINED_INTEL")]
        WriteCombined = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_WRITE_COMBINED_INTEL")]
        MemAllocWriteCombinedIntel = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_DEVICE_INTEL")]
        InitialPlacementDevice = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_DEVICE_INTEL")]
        MemAllocInitialPlacementDeviceIntel = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_HOST_INTEL")]
        InitialPlacementHost = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_HOST_INTEL")]
        MemAllocInitialPlacementHostIntel = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_TYPE_INTEL")]
        MemAllocTypeIntel = 0x419A,
        [NativeName("Name", "CL_MEM_ALLOC_BASE_PTR_INTEL")]
        BasePtr = 0x419B,
        [NativeName("Name", "CL_MEM_ALLOC_BASE_PTR_INTEL")]
        MemAllocBasePtrIntel = 0x419B,
        [NativeName("Name", "CL_MEM_ALLOC_SIZE_INTEL")]
        Size = 0x419C,
        [NativeName("Name", "CL_MEM_ALLOC_SIZE_INTEL")]
        MemAllocSizeIntel = 0x419C,
        [NativeName("Name", "CL_MEM_ALLOC_DEVICE_INTEL")]
        Device = 0x419D,
        [NativeName("Name", "CL_MEM_ALLOC_DEVICE_INTEL")]
        MemAllocDeviceIntel = 0x419D,
        [NativeName("Name", "CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
        BufferLocation = 0x419E,
        [NativeName("Name", "CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
        MemAllocBufferLocationIntel = 0x419E,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_INTEL")]
        AllocFlags = 0x4195,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_INTEL")]
        MemAllocFlagsIntel = 0x4195,
        [NativeName("Name", "CL_MEM_CHANNEL_INTEL")]
        Channel = 0x4213,
        [NativeName("Name", "CL_MEM_CHANNEL_INTEL")]
        MemChannelIntel = 0x4213,
        [NativeName("Name", "CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
        AllocBufferLocation = 0x419E,
        [NativeName("Name", "CL_ME_MB_TYPE_16x16_INTEL")]
        MEMBType16x16Intel = 0x0,
        [NativeName("Name", "CL_ME_MB_TYPE_8x8_INTEL")]
        MEMBType8x8Intel = 0x1,
        [NativeName("Name", "CL_ME_MB_TYPE_4x4_INTEL")]
        Type4x4 = 0x2,
        [NativeName("Name", "CL_ME_MB_TYPE_4x4_INTEL")]
        MEMBType4x4Intel = 0x2,
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        MESadAdjustModeNoneIntel = 0x0,
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        MESadAdjustModeHaarIntel = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
        Radius22 = 0x0,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
        MESearchPathRadius22Intel = 0x0,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
        Radius44 = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
        MESearchPathRadius44Intel = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
        Radius1612 = 0x5,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
        MESearchPathRadius1612Intel = 0x5,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        MESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        MESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        MESubpixelModeQpelIntel = 0x2,
        [NativeName("Name", "CL_MEM_TYPE_UNKNOWN_INTEL")]
        Unknown = 0x4196,
        [NativeName("Name", "CL_MEM_TYPE_UNKNOWN_INTEL")]
        MemTypeUnknownIntel = 0x4196,
        [NativeName("Name", "CL_MEM_TYPE_HOST_INTEL")]
        Host = 0x4197,
        [NativeName("Name", "CL_MEM_TYPE_HOST_INTEL")]
        MemTypeHostIntel = 0x4197,
        [NativeName("Name", "CL_MEM_TYPE_DEVICE_INTEL")]
        MemTypeDeviceIntel = 0x4198,
        [NativeName("Name", "CL_MEM_TYPE_SHARED_INTEL")]
        Shared = 0x4199,
        [NativeName("Name", "CL_MEM_TYPE_SHARED_INTEL")]
        MemTypeSharedIntel = 0x4199,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_VA_API_INTEL")]
        PreferredDevicesForVAApi = 0x4095,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_VA_API_INTEL")]
        PreferredDevicesForVAApiIntel = 0x4095,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_VA_API_INTEL")]
        AllDevicesForVAApi = 0x4096,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_VA_API_INTEL")]
        AllDevicesForVAApiIntel = 0x4096,
        [NativeName("Name", "CL_VA_API_DISPLAY_INTEL")]
        Display = 0x4094,
        [NativeName("Name", "CL_VA_API_DISPLAY_INTEL")]
        VAApiDisplayIntel = 0x4094,
        [NativeName("Name", "CL_YUYV_INTEL")]
        YuyvIntel = 0x4076,
        [NativeName("Name", "CL_UYVY_INTEL")]
        UyvyIntel = 0x4077,
        [NativeName("Name", "CL_YVYU_INTEL")]
        YvyuIntel = 0x4078,
        [NativeName("Name", "CL_VYUY_INTEL")]
        VyuyIntel = 0x4079,
        [NativeName("Name", "CL_NV12_INTEL")]
        NV12Intel = 0x410E,
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        ThreadLocalExecEnableIntel = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        QueueThreadLocalExecEnableIntel = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
        NoSyncOperationsIntel = 0x20000000,
        [NativeName("Name", "CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
        QueueNoSyncOperationsIntel = 0x20000000,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        AcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandAcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        ReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        AcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        CommandAcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        ReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        CommandReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        MemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        CommandMemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        MemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        CommandMemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        MigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        CommandMigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        MemadviseIntel = 0x4207,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        CommandMemadviseIntel = 0x4207,
        [NativeName("Name", "CL_CONTEXT_VA_API_DISPLAY_INTEL")]
        ContextVAApiDisplayIntel = 0x4097,
        [NativeName("Name", "CL_CONTEXT_D3D9_DEVICE_INTEL")]
        ContextD3D9DeviceIntel = 0x4026,
        [NativeName("Name", "CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
        ContextD3D9EXDeviceIntel = 0x4072,
        [NativeName("Name", "CL_CONTEXT_DXVA_DEVICE_INTEL")]
        ContextDxvaDeviceIntel = 0x4073,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ContextShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        MEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        DeviceMEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        SimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceSimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        NumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceNumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        SubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        DeviceSubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        PlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        DevicePlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        PlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        DevicePlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        AvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        DeviceAvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        AvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        DeviceAvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        AvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        DeviceAvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        HostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        DeviceHostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceDeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        SingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceSingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        CrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceCrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        SharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        DeviceSharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        QueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        DeviceQueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        IPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        DeviceIPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        IDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        DeviceIDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        NumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        DeviceNumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        NumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        DeviceNumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        NumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        DeviceNumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        NumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        DeviceNumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        FeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        DeviceFeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_INVALID_ACCELERATOR_INTEL")]
        InvalidAcceleratorIntel = unchecked((int) 0xFFFFFFFFFFFFFBBA),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_TYPE_INTEL")]
        InvalidAcceleratorTypeIntel = unchecked((int) 0xFFFFFFFFFFFFFBB9),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_DESCRIPTOR_INTEL")]
        InvalidAcceleratorDescriptorIntel = unchecked((int) 0xFFFFFFFFFFFFFBB8),
        [NativeName("Name", "CL_ACCELERATOR_TYPE_NOT_SUPPORTED_INTEL")]
        AcceleratorTypeNotSupportedIntel = unchecked((int) 0xFFFFFFFFFFFFFBB7),
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_ADAPTER_INTEL")]
        InvalidVAApiMediaAdapterIntel = unchecked((int) 0xFFFFFFFFFFFFFBB6),
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_SURFACE_INTEL")]
        InvalidVAApiMediaSurfaceIntel = unchecked((int) 0xFFFFFFFFFFFFFBB5),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_ALREADY_ACQUIRED_INTEL")]
        VAApiMediaSurfaceAlreadyAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFBB4),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_NOT_ACQUIRED_INTEL")]
        VAApiMediaSurfaceNotAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFBB3),
        [NativeName("Name", "CL_INVALID_DX9_DEVICE_INTEL")]
        InvalidDX9DeviceIntel = unchecked((int) 0xFFFFFFFFFFFFFC0E),
        [NativeName("Name", "CL_INVALID_DX9_RESOURCE_INTEL")]
        InvalidDX9ResourceIntel = unchecked((int) 0xFFFFFFFFFFFFFC0D),
        [NativeName("Name", "CL_DX9_RESOURCE_ALREADY_ACQUIRED_INTEL")]
        DX9ResourceAlreadyAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFC0C),
        [NativeName("Name", "CL_DX9_RESOURCE_NOT_ACQUIRED_INTEL")]
        DX9ResourceNotAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFC0B),
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        VAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        ImageVAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        DX9PlaneIntel = 0x4075,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        ImageDX9PlaneIntel = 0x4075,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        IndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        KernelExecInfoIndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        IndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        KernelExecInfoIndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        IndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        KernelExecInfoIndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        UsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        KernelExecInfoUsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        CompileSubGroupSizeIntel = 0x410A,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        KernelCompileSubGroupSizeIntel = 0x410A,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        SpillMemSizeIntel = 0x4109,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        KernelSpillMemSizeIntel = 0x4109,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        NoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        MemNoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        AccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        MemAccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        ForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        MemForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        VAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        MemVAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        DX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        MemDX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        DX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        MemDX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
        LocallyUncachedResourceIntel = 0x4218,
        [NativeName("Name", "CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
        MemLocallyUncachedResourceIntel = 0x4218,
        [NativeName("Name", "CL_MEM_DEVICE_ID_INTEL")]
        MemDeviceIDIntel = 0x4219,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        FamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        QueueFamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        IndexIntel = 0x418D,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        QueueIndexIntel = 0x418D,
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        YuvPlaneIntel = 0x4107,
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        EglYuvPlaneIntel = 0x4107,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_INTEL")]
        DevicePartitionByNamesIntel = 0x4052,
        [NativeName("Name", "CL_COMMAND_READ_HOST_PIPE_INTEL")]
        CommandReadHostPipeIntel = 0x4214,
        [NativeName("Name", "CL_COMMAND_WRITE_HOST_PIPE_INTEL")]
        CommandWriteHostPipeIntel = 0x4215,
        [NativeName("Name", "CL_PROGRAM_NUM_HOST_PIPES_INTEL")]
        ProgramNumHostPipesIntel = 0x4216,
        [NativeName("Name", "CL_PROGRAM_HOST_PIPE_NAMES_INTEL")]
        ProgramHostPipeNamesIntel = 0x4217,
    }
}
