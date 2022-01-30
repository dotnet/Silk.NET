// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "GLenum")]
    public enum INTEL : int
    {
        [NativeName("Name", "CL_ACCELERATOR_DESCRIPTOR_INTEL")]
        AcceleratorDescriptorIntel = 0x4090,
        [NativeName("Name", "CL_ACCELERATOR_REFERENCE_COUNT_INTEL")]
        AcceleratorReferenceCountIntel = 0x4091,
        [NativeName("Name", "CL_ACCELERATOR_CONTEXT_INTEL")]
        AcceleratorContextIntel = 0x4092,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_INTEL")]
        AcceleratorTypeIntel = 0x4093,
        [NativeName("Name", "CL_INVALID_ACCELERATOR_INTEL")]
        InvalidAcceleratorIntel = unchecked((int)0xFFFFFFFFFFFFFBBA),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_TYPE_INTEL")]
        InvalidAcceleratorTypeIntel = unchecked((int)0xFFFFFFFFFFFFFBB9),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_DESCRIPTOR_INTEL")]
        InvalidAcceleratorDescriptorIntel = unchecked((int)0xFFFFFFFFFFFFFBB8),
        [NativeName("Name", "CL_ACCELERATOR_TYPE_NOT_SUPPORTED_INTEL")]
        AcceleratorTypeNotSupportedIntel = unchecked((int)0xFFFFFFFFFFFFFBB7),
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        DeviceMEVersionIntel = 0x407E,
        [NativeName("Name", "CL_ME_VERSION_LEGACY_INTEL")]
        MEVersionLegacyIntel = 0x0,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_1_INTEL")]
        MEVersionAdvancedVer1Intel = 0x1,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_2_INTEL")]
        MEVersionAdvancedVer2Intel = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
        MEChromaIntraPredictEnabledIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
        MELumaIntraPredictEnabledIntel = 0x2,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_16x16_INTEL")]
        MESkipBlockType16x16Intel = 0x0,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_8x8_INTEL")]
        MESkipBlockType8x8Intel = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_NONE_INTEL")]
        MECostPenaltyNoneIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PENALTY_LOW_INTEL")]
        MECostPenaltyLowIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_NORMAL_INTEL")]
        MECostPenaltyNormalIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PENALTY_HIGH_INTEL")]
        MECostPenaltyHighIntel = 0x3,
        [NativeName("Name", "CL_ME_COST_PRECISION_QPEL_INTEL")]
        MECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PRECISION_HPEL_INTEL")]
        MECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PRECISION_PEL_INTEL")]
        MECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PRECISION_DPEL_INTEL")]
        MECostPrecisionDpelIntel = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        MELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        MELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        MELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        MELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        MELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        MELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        MELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        MELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        MELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        MELumaPredictorModeHorizontalUpIntel = 0x8,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        MEChromaPredictorModeDCIntel = 0x0,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        MEChromaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        MEChromaPredictorModeVerticalIntel = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        MEChromaPredictorModePlaneIntel = 0x3,
        [NativeName("Name", "CL_ME_FORWARD_INPUT_MODE_INTEL")]
        MEForwardInputModeIntel = 0x1,
        [NativeName("Name", "CL_ME_BACKWARD_INPUT_MODE_INTEL")]
        MEBackwardInputModeIntel = 0x2,
        [NativeName("Name", "CL_ME_BIDIRECTION_INPUT_MODE_INTEL")]
        MEBidirectionInputModeIntel = 0x3,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        MEBidirWeightQuarterIntel = 0x16,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        MEBidirWeightThirdIntel = 0x21,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_HALF_INTEL")]
        MEBidirWeightHalfIntel = 0x32,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        MEBidirWeightTwoThirdIntel = 0x43,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        MEBidirWeightThreeQuarterIntel = 0x48,
        [NativeName("Name", "CL_QUEUE_FAMILY_MAX_NAME_SIZE_INTEL")]
        QueueFamilyMaxNameSizeIntel = 0x64,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        DeviceQueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        QueueFamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        QueueIndexIntel = 0x418D,
        [NativeName("Name", "CL_QUEUE_DEFAULT_CAPABILITIES_INTEL")]
        QueueDefaultCapabilitiesIntel = 0x0,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_SINGLE_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateSingleQueueEventsIntel = 0x1,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_CROSS_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateCrossQueueEventsIntel = 0x2,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_SINGLE_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilitySingleQueueEventWaitListIntel = 0x4,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CROSS_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilityCrossQueueEventWaitListIntel = 0x8,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_INTEL")]
        QueueCapabilityTransferBufferIntel = 0x100,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_RECT_INTEL")]
        QueueCapabilityTransferBufferRectIntel = 0x200,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_BUFFER_INTEL")]
        QueueCapabilityMapBufferIntel = 0x400,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_BUFFER_INTEL")]
        QueueCapabilityFillBufferIntel = 0x800,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_INTEL")]
        QueueCapabilityTransferImageIntel = 0x1000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_IMAGE_INTEL")]
        QueueCapabilityMapImageIntel = 0x2000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_IMAGE_INTEL")]
        QueueCapabilityFillImageIntel = 0x4000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_IMAGE_INTEL")]
        QueueCapabilityTransferBufferImageIntel = 0x8000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_BUFFER_INTEL")]
        QueueCapabilityTransferImageBufferIntel = 0x10000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MARKER_INTEL")]
        QueueCapabilityMarkerIntel = 0x1000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_BARRIER_INTEL")]
        QueueCapabilityBarrierIntel = 0x2000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_KERNEL_INTEL")]
        QueueCapabilityKernelIntel = 0x4000000,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DP4A_INTEL")]
        DeviceFeatureFlagDP4AIntel = 0x1,
        [NativeName("Name", "CL_DEVICE_FEATURE_FLAG_DPAS_INTEL")]
        DeviceFeatureFlagDpasIntel = 0x2,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        DeviceIPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        DeviceIDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        DeviceNumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        DeviceNumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        DeviceNumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        DeviceNumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        DeviceFeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_INTEL")]
        DevicePartitionByNamesIntel = 0x4052,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        DeviceAvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        DeviceAvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        DeviceAvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_AVC_ME_VERSION_0_INTEL")]
        AvcMEVersion0Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_VERSION_1_INTEL")]
        AvcMEVersion1Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x16_INTEL")]
        AvcMEMajor16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x8_INTEL")]
        AvcMEMajor16x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x16_INTEL")]
        AvcMEMajor8x16Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x8_INTEL")]
        AvcMEMajor8x8Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x8_INTEL")]
        AvcMEMinor8x8Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MINOR_8x4_INTEL")]
        AvcMEMinor8x4Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x8_INTEL")]
        AvcMEMinor4x8Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MINOR_4x4_INTEL")]
        AvcMEMinor4x4Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_MAJOR_FORWARD_INTEL")]
        AvcMEMajorForwardIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BACKWARD_INTEL")]
        AvcMEMajorBackwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
        AvcMEMajorBidirectionalIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_ALL_INTEL")]
        AvcMEPartitionMaskAllIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x16_INTEL")]
        AvcMEPartitionMask16x16Intel = 0x7E,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x8_INTEL")]
        AvcMEPartitionMask16x8Intel = 0x7D,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x16_INTEL")]
        AvcMEPartitionMask8x16Intel = 0x7B,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x8_INTEL")]
        AvcMEPartitionMask8x8Intel = 0x77,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x4_INTEL")]
        AvcMEPartitionMask8x4Intel = 0x6F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x8_INTEL")]
        AvcMEPartitionMask4x8Intel = 0x5F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x4_INTEL")]
        AvcMEPartitionMask4x4Intel = 0x3F,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        AvcMESearchWindowExhaustiveIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        AvcMESearchWindowSmallIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        AvcMESearchWindowTinyIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        AvcMESearchWindowExtraTinyIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        AvcMESearchWindowDiamondIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        AvcMESearchWindowLargeDiamondIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        AvcMESearchWindowReserved0Intel = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        AvcMESearchWindowReserved1Intel = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        AvcMESearchWindowCustomIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        AvcMESearchWindow16x12RadiusIntel = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        AvcMESearchWindow4x4RadiusIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        AvcMESearchWindow2x2RadiusIntel = 0xA,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        AvcMESadAdjustModeNoneIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        AvcMESadAdjustModeHaarIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        AvcMESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        AvcMESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        AvcMESubpixelModeQpelIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_QPEL_INTEL")]
        AvcMECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_HPEL_INTEL")]
        AvcMECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_PEL_INTEL")]
        AvcMECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_DPEL_INTEL")]
        AvcMECostPrecisionDpelIntel = 0x3,
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
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_LEFT_INTEL")]
        AvcMEBorderReachedLeftIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_RIGHT_INTEL")]
        AvcMEBorderReachedRightIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_TOP_INTEL")]
        AvcMEBorderReachedTopIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_BOTTOM_INTEL")]
        AvcMEBorderReachedBottomIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_16x16_INTEL")]
        AvcMESkipBlockPartition16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_8x8_INTEL")]
        AvcMESkipBlockPartition8x8Intel = 0x4000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16ForwardEnableIntel = 16777216,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16BackwardEnableIntel = 33554432,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock16x16DualEnableIntel = 50331648,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8ForwardEnableIntel = 1426063360,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8BackwardEnableIntel = -1442840576,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock8x8DualEnableIntel = -16777216,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80ForwardEnableIntel = 16777216,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80BackwardEnableIntel = 33554432,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81ForwardEnableIntel = 67108864,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81BackwardEnableIntel = 134217728,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82ForwardEnableIntel = 268435456,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82BackwardEnableIntel = 536870912,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83ForwardEnableIntel = 1073741824,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83BackwardEnableIntel = -2147483648,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_4x4_INTEL")]
        AvcMEBlockBasedSkip4x4Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_8x8_INTEL")]
        AvcMEBlockBasedSkip8x8Intel = 0x80,
        [NativeName("Name", "CL_AVC_ME_INTRA_16x16_INTEL")]
        AvcMEIntra16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTRA_8x8_INTEL")]
        AvcMEIntra8x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTRA_4x4_INTEL")]
        AvcMEIntra4x4Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_16x16_INTEL")]
        AvcMEIntraLumaPartitionMask16x16Intel = 0x6,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_8x8_INTEL")]
        AvcMEIntraLumaPartitionMask8x8Intel = 0x5,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_4x4_INTEL")]
        AvcMEIntraLumaPartitionMask4x4Intel = 0x3,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborLeftMaskEnableIntel = 0x60,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperMaskEnableIntel = 0x10,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperRightMaskEnableIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperLeftMaskEnableIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        AvcMELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        AvcMELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        AvcMELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        AvcMELumaPredictorModeHorizontalUpIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMEChromaPredictorModeDCIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMEChromaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMEChromaPredictorModeVerticalIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMEChromaPredictorModePlaneIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_FRAME_FORWARD_INTEL")]
        AvcMEFrameForwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_FRAME_BACKWARD_INTEL")]
        AvcMEFrameBackwardIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_FRAME_DUAL_INTEL")]
        AvcMEFrameDualIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_PRED_INTEL")]
        AvcMESliceTypePredIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_BPRED_INTEL")]
        AvcMESliceTypeBpredIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_INTRA_INTEL")]
        AvcMESliceTypeIntraIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_TOP_FIELD_INTEL")]
        AvcMEInterlacedScanTopFieldIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_BOTTOM_FIELD_INTEL")]
        AvcMEInterlacedScanBottomFieldIntel = 0x1,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ContextShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        ContextDiagnosticsLevelAllIntel = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        ContextDiagnosticsLevelGoodIntel = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        ContextDiagnosticsLevelBadIntel = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        ContextDiagnosticsLevelNeutralIntel = 0x4,
        [NativeName("Name", "CL_INVALID_DX9_DEVICE_INTEL")]
        InvalidDX9DeviceIntel = unchecked((int)0xFFFFFFFFFFFFFC0E),
        [NativeName("Name", "CL_INVALID_DX9_RESOURCE_INTEL")]
        InvalidDX9ResourceIntel = unchecked((int)0xFFFFFFFFFFFFFC0D),
        [NativeName("Name", "CL_DX9_RESOURCE_ALREADY_ACQUIRED_INTEL")]
        DX9ResourceAlreadyAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFC0C),
        [NativeName("Name", "CL_DX9_RESOURCE_NOT_ACQUIRED_INTEL")]
        DX9ResourceNotAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFC0B),
        [NativeName("Name", "CL_D3D9_DEVICE_INTEL")]
        D3D9DeviceIntel = 0x4022,
        [NativeName("Name", "CL_D3D9EX_DEVICE_INTEL")]
        D3D9EXDeviceIntel = 0x4070,
        [NativeName("Name", "CL_DXVA_DEVICE_INTEL")]
        DxvaDeviceIntel = 0x4071,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_INTEL")]
        PreferredDevicesForDX9Intel = 0x4024,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_INTEL")]
        AllDevicesForDX9Intel = 0x4025,
        [NativeName("Name", "CL_CONTEXT_D3D9_DEVICE_INTEL")]
        ContextD3D9DeviceIntel = 0x4026,
        [NativeName("Name", "CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
        ContextD3D9EXDeviceIntel = 0x4072,
        [NativeName("Name", "CL_CONTEXT_DXVA_DEVICE_INTEL")]
        ContextDxvaDeviceIntel = 0x4073,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        MemDX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        MemDX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        ImageDX9PlaneIntel = 0x4075,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        CommandAcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        CommandReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        EglYuvPlaneIntel = 0x4107,
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        QueueThreadLocalExecEnableIntel = unchecked((int)0x80000000),
        [NativeName("Name", "CL_MEM_CHANNEL_INTEL")]
        MemChannelIntel = 0x4213,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        MemForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_MOTION_ESTIMATION_INTEL")]
        AcceleratorTypeMotionEstimationIntel = 0x0,
        [NativeName("Name", "CL_ME_MB_TYPE_16x16_INTEL")]
        MEMBType16x16Intel = 0x0,
        [NativeName("Name", "CL_ME_MB_TYPE_8x8_INTEL")]
        MEMBType8x8Intel = 0x1,
        [NativeName("Name", "CL_ME_MB_TYPE_4x4_INTEL")]
        MEMBType4x4Intel = 0x2,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        MESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        MESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        MESubpixelModeQpelIntel = 0x2,
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        MESadAdjustModeNoneIntel = 0x0,
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        MESadAdjustModeHaarIntel = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
        MESearchPathRadius22Intel = 0x0,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
        MESearchPathRadius44Intel = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
        MESearchPathRadius1612Intel = 0x5,
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
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        MemNoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        MemAccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        DevicePlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        DevicePlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        DeviceSubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        KernelSpillMemSizeIntel = 0x4109,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        KernelCompileSubGroupSizeIntel = 0x410A,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceSimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceNumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        DeviceHostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceDeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceSingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceCrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        DeviceSharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ACCESS_INTEL")]
        UnifiedSharedMemoryAccessIntel = 0x1,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ATOMIC_ACCESS_INTEL")]
        UnifiedSharedMemoryAtomicAccessIntel = 0x2,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ACCESS_INTEL")]
        UnifiedSharedMemoryConcurrentAccessIntel = 0x4,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ATOMIC_ACCESS_INTEL")]
        UnifiedSharedMemoryConcurrentAtomicAccessIntel = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_INTEL")]
        MemAllocFlagsIntel = 0x4195,
        [NativeName("Name", "CL_MEM_ALLOC_WRITE_COMBINED_INTEL")]
        MemAllocWriteCombinedIntel = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_DEVICE_INTEL")]
        MemAllocInitialPlacementDeviceIntel = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_HOST_INTEL")]
        MemAllocInitialPlacementHostIntel = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_TYPE_INTEL")]
        MemAllocTypeIntel = 0x419A,
        [NativeName("Name", "CL_MEM_ALLOC_BASE_PTR_INTEL")]
        MemAllocBasePtrIntel = 0x419B,
        [NativeName("Name", "CL_MEM_ALLOC_SIZE_INTEL")]
        MemAllocSizeIntel = 0x419C,
        [NativeName("Name", "CL_MEM_ALLOC_DEVICE_INTEL")]
        MemAllocDeviceIntel = 0x419D,
        [NativeName("Name", "CL_MEM_TYPE_UNKNOWN_INTEL")]
        MemTypeUnknownIntel = 0x4196,
        [NativeName("Name", "CL_MEM_TYPE_HOST_INTEL")]
        MemTypeHostIntel = 0x4197,
        [NativeName("Name", "CL_MEM_TYPE_DEVICE_INTEL")]
        MemTypeDeviceIntel = 0x4198,
        [NativeName("Name", "CL_MEM_TYPE_SHARED_INTEL")]
        MemTypeSharedIntel = 0x4199,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        KernelExecInfoIndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        KernelExecInfoIndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        KernelExecInfoIndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        KernelExecInfoUsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        CommandMemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        CommandMemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        CommandMigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        CommandMemadviseIntel = 0x4207,
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_ADAPTER_INTEL")]
        InvalidVAApiMediaAdapterIntel = unchecked((int)0xFFFFFFFFFFFFFBB6),
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_SURFACE_INTEL")]
        InvalidVAApiMediaSurfaceIntel = unchecked((int)0xFFFFFFFFFFFFFBB5),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_ALREADY_ACQUIRED_INTEL")]
        VAApiMediaSurfaceAlreadyAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFBB4),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_NOT_ACQUIRED_INTEL")]
        VAApiMediaSurfaceNotAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFBB3),
        [NativeName("Name", "CL_VA_API_DISPLAY_INTEL")]
        VAApiDisplayIntel = 0x4094,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_VA_API_INTEL")]
        PreferredDevicesForVAApiIntel = 0x4095,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_VA_API_INTEL")]
        AllDevicesForVAApiIntel = 0x4096,
        [NativeName("Name", "CL_CONTEXT_VA_API_DISPLAY_INTEL")]
        ContextVAApiDisplayIntel = 0x4097,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        MemVAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        ImageVAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandAcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandReleaseVAApiMediaSurfacesIntel = 0x409B,
    }
}
