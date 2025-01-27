// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvOp_")]
    public enum Op : int
    {
        [NativeName("Name", "SpvOpNop")]
        Nop = 0x0,
        [NativeName("Name", "SpvOpUndef")]
        Undef = 0x1,
        [NativeName("Name", "SpvOpSourceContinued")]
        SourceContinued = 0x2,
        [NativeName("Name", "SpvOpSource")]
        Source = 0x3,
        [NativeName("Name", "SpvOpSourceExtension")]
        SourceExtension = 0x4,
        [NativeName("Name", "SpvOpName")]
        Name = 0x5,
        [NativeName("Name", "SpvOpMemberName")]
        MemberName = 0x6,
        [NativeName("Name", "SpvOpString")]
        String = 0x7,
        [NativeName("Name", "SpvOpLine")]
        Line = 0x8,
        [NativeName("Name", "SpvOpExtension")]
        Extension = 0xA,
        [NativeName("Name", "SpvOpExtInstImport")]
        ExtInstImport = 0xB,
        [NativeName("Name", "SpvOpExtInst")]
        ExtInst = 0xC,
        [NativeName("Name", "SpvOpMemoryModel")]
        MemoryModel = 0xE,
        [NativeName("Name", "SpvOpEntryPoint")]
        EntryPoint = 0xF,
        [NativeName("Name", "SpvOpExecutionMode")]
        ExecutionMode = 0x10,
        [NativeName("Name", "SpvOpCapability")]
        Capability = 0x11,
        [NativeName("Name", "SpvOpTypeVoid")]
        TypeVoid = 0x13,
        [NativeName("Name", "SpvOpTypeBool")]
        TypeBool = 0x14,
        [NativeName("Name", "SpvOpTypeInt")]
        TypeInt = 0x15,
        [NativeName("Name", "SpvOpTypeFloat")]
        TypeFloat = 0x16,
        [NativeName("Name", "SpvOpTypeVector")]
        TypeVector = 0x17,
        [NativeName("Name", "SpvOpTypeMatrix")]
        TypeMatrix = 0x18,
        [NativeName("Name", "SpvOpTypeImage")]
        TypeImage = 0x19,
        [NativeName("Name", "SpvOpTypeSampler")]
        TypeSampler = 0x1A,
        [NativeName("Name", "SpvOpTypeSampledImage")]
        TypeSampledImage = 0x1B,
        [NativeName("Name", "SpvOpTypeArray")]
        TypeArray = 0x1C,
        [NativeName("Name", "SpvOpTypeRuntimeArray")]
        TypeRuntimeArray = 0x1D,
        [NativeName("Name", "SpvOpTypeStruct")]
        TypeStruct = 0x1E,
        [NativeName("Name", "SpvOpTypeOpaque")]
        TypeOpaque = 0x1F,
        [NativeName("Name", "SpvOpTypePointer")]
        TypePointer = 0x20,
        [NativeName("Name", "SpvOpTypeFunction")]
        TypeFunction = 0x21,
        [NativeName("Name", "SpvOpTypeEvent")]
        TypeEvent = 0x22,
        [NativeName("Name", "SpvOpTypeDeviceEvent")]
        TypeDeviceEvent = 0x23,
        [NativeName("Name", "SpvOpTypeReserveId")]
        TypeReserveId = 0x24,
        [NativeName("Name", "SpvOpTypeQueue")]
        TypeQueue = 0x25,
        [NativeName("Name", "SpvOpTypePipe")]
        TypePipe = 0x26,
        [NativeName("Name", "SpvOpTypeForwardPointer")]
        TypeForwardPointer = 0x27,
        [NativeName("Name", "SpvOpConstantTrue")]
        ConstantTrue = 0x29,
        [NativeName("Name", "SpvOpConstantFalse")]
        ConstantFalse = 0x2A,
        [NativeName("Name", "SpvOpConstant")]
        Constant = 0x2B,
        [NativeName("Name", "SpvOpConstantComposite")]
        ConstantComposite = 0x2C,
        [NativeName("Name", "SpvOpConstantSampler")]
        ConstantSampler = 0x2D,
        [NativeName("Name", "SpvOpConstantNull")]
        ConstantNull = 0x2E,
        [NativeName("Name", "SpvOpSpecConstantTrue")]
        SpecConstantTrue = 0x30,
        [NativeName("Name", "SpvOpSpecConstantFalse")]
        SpecConstantFalse = 0x31,
        [NativeName("Name", "SpvOpSpecConstant")]
        SpecConstant = 0x32,
        [NativeName("Name", "SpvOpSpecConstantComposite")]
        SpecConstantComposite = 0x33,
        [NativeName("Name", "SpvOpSpecConstantOp")]
        SpecConstantOp = 0x34,
        [NativeName("Name", "SpvOpFunction")]
        Function = 0x36,
        [NativeName("Name", "SpvOpFunctionParameter")]
        FunctionParameter = 0x37,
        [NativeName("Name", "SpvOpFunctionEnd")]
        FunctionEnd = 0x38,
        [NativeName("Name", "SpvOpFunctionCall")]
        FunctionCall = 0x39,
        [NativeName("Name", "SpvOpVariable")]
        Variable = 0x3B,
        [NativeName("Name", "SpvOpImageTexelPointer")]
        ImageTexelPointer = 0x3C,
        [NativeName("Name", "SpvOpLoad")]
        Load = 0x3D,
        [NativeName("Name", "SpvOpStore")]
        Store = 0x3E,
        [NativeName("Name", "SpvOpCopyMemory")]
        CopyMemory = 0x3F,
        [NativeName("Name", "SpvOpCopyMemorySized")]
        CopyMemorySized = 0x40,
        [NativeName("Name", "SpvOpAccessChain")]
        AccessChain = 0x41,
        [NativeName("Name", "SpvOpInBoundsAccessChain")]
        InBoundsAccessChain = 0x42,
        [NativeName("Name", "SpvOpPtrAccessChain")]
        PtrAccessChain = 0x43,
        [NativeName("Name", "SpvOpArrayLength")]
        ArrayLength = 0x44,
        [NativeName("Name", "SpvOpGenericPtrMemSemantics")]
        GenericPtrMemSemantics = 0x45,
        [NativeName("Name", "SpvOpInBoundsPtrAccessChain")]
        InBoundsPtrAccessChain = 0x46,
        [NativeName("Name", "SpvOpDecorate")]
        Decorate = 0x47,
        [NativeName("Name", "SpvOpMemberDecorate")]
        MemberDecorate = 0x48,
        [NativeName("Name", "SpvOpDecorationGroup")]
        DecorationGroup = 0x49,
        [NativeName("Name", "SpvOpGroupDecorate")]
        GroupDecorate = 0x4A,
        [NativeName("Name", "SpvOpGroupMemberDecorate")]
        GroupMemberDecorate = 0x4B,
        [NativeName("Name", "SpvOpVectorExtractDynamic")]
        VectorExtractDynamic = 0x4D,
        [NativeName("Name", "SpvOpVectorInsertDynamic")]
        VectorInsertDynamic = 0x4E,
        [NativeName("Name", "SpvOpVectorShuffle")]
        VectorShuffle = 0x4F,
        [NativeName("Name", "SpvOpCompositeConstruct")]
        CompositeConstruct = 0x50,
        [NativeName("Name", "SpvOpCompositeExtract")]
        CompositeExtract = 0x51,
        [NativeName("Name", "SpvOpCompositeInsert")]
        CompositeInsert = 0x52,
        [NativeName("Name", "SpvOpCopyObject")]
        CopyObject = 0x53,
        [NativeName("Name", "SpvOpTranspose")]
        Transpose = 0x54,
        [NativeName("Name", "SpvOpSampledImage")]
        SampledImage = 0x56,
        [NativeName("Name", "SpvOpImageSampleImplicitLod")]
        ImageSampleImplicitLod = 0x57,
        [NativeName("Name", "SpvOpImageSampleExplicitLod")]
        ImageSampleExplicitLod = 0x58,
        [NativeName("Name", "SpvOpImageSampleDrefImplicitLod")]
        ImageSampleDrefImplicitLod = 0x59,
        [NativeName("Name", "SpvOpImageSampleDrefExplicitLod")]
        ImageSampleDrefExplicitLod = 0x5A,
        [NativeName("Name", "SpvOpImageSampleProjImplicitLod")]
        ImageSampleProjImplicitLod = 0x5B,
        [NativeName("Name", "SpvOpImageSampleProjExplicitLod")]
        ImageSampleProjExplicitLod = 0x5C,
        [NativeName("Name", "SpvOpImageSampleProjDrefImplicitLod")]
        ImageSampleProjDrefImplicitLod = 0x5D,
        [NativeName("Name", "SpvOpImageSampleProjDrefExplicitLod")]
        ImageSampleProjDrefExplicitLod = 0x5E,
        [NativeName("Name", "SpvOpImageFetch")]
        ImageFetch = 0x5F,
        [NativeName("Name", "SpvOpImageGather")]
        ImageGather = 0x60,
        [NativeName("Name", "SpvOpImageDrefGather")]
        ImageDrefGather = 0x61,
        [NativeName("Name", "SpvOpImageRead")]
        ImageRead = 0x62,
        [NativeName("Name", "SpvOpImageWrite")]
        ImageWrite = 0x63,
        [NativeName("Name", "SpvOpImage")]
        Image = 0x64,
        [NativeName("Name", "SpvOpImageQueryFormat")]
        ImageQueryFormat = 0x65,
        [NativeName("Name", "SpvOpImageQueryOrder")]
        ImageQueryOrder = 0x66,
        [NativeName("Name", "SpvOpImageQuerySizeLod")]
        ImageQuerySizeLod = 0x67,
        [NativeName("Name", "SpvOpImageQuerySize")]
        ImageQuerySize = 0x68,
        [NativeName("Name", "SpvOpImageQueryLod")]
        ImageQueryLod = 0x69,
        [NativeName("Name", "SpvOpImageQueryLevels")]
        ImageQueryLevels = 0x6A,
        [NativeName("Name", "SpvOpImageQuerySamples")]
        ImageQuerySamples = 0x6B,
        [NativeName("Name", "SpvOpConvertFToU")]
        ConvertFToU = 0x6D,
        [NativeName("Name", "SpvOpConvertFToS")]
        ConvertFToS = 0x6E,
        [NativeName("Name", "SpvOpConvertSToF")]
        ConvertSToF = 0x6F,
        [NativeName("Name", "SpvOpConvertUToF")]
        ConvertUToF = 0x70,
        [NativeName("Name", "SpvOpUConvert")]
        UConvert = 0x71,
        [NativeName("Name", "SpvOpSConvert")]
        SConvert = 0x72,
        [NativeName("Name", "SpvOpFConvert")]
        FConvert = 0x73,
        [NativeName("Name", "SpvOpQuantizeToF16")]
        QuantizeToF16 = 0x74,
        [NativeName("Name", "SpvOpConvertPtrToU")]
        ConvertPtrToU = 0x75,
        [NativeName("Name", "SpvOpSatConvertSToU")]
        SatConvertSToU = 0x76,
        [NativeName("Name", "SpvOpSatConvertUToS")]
        SatConvertUToS = 0x77,
        [NativeName("Name", "SpvOpConvertUToPtr")]
        ConvertUToPtr = 0x78,
        [NativeName("Name", "SpvOpPtrCastToGeneric")]
        PtrCastToGeneric = 0x79,
        [NativeName("Name", "SpvOpGenericCastToPtr")]
        GenericCastToPtr = 0x7A,
        [NativeName("Name", "SpvOpGenericCastToPtrExplicit")]
        GenericCastToPtrExplicit = 0x7B,
        [NativeName("Name", "SpvOpBitcast")]
        Bitcast = 0x7C,
        [NativeName("Name", "SpvOpSNegate")]
        SNegate = 0x7E,
        [NativeName("Name", "SpvOpFNegate")]
        FNegate = 0x7F,
        [NativeName("Name", "SpvOpIAdd")]
        IAdd = 0x80,
        [NativeName("Name", "SpvOpFAdd")]
        FAdd = 0x81,
        [NativeName("Name", "SpvOpISub")]
        ISub = 0x82,
        [NativeName("Name", "SpvOpFSub")]
        FSub = 0x83,
        [NativeName("Name", "SpvOpIMul")]
        IMul = 0x84,
        [NativeName("Name", "SpvOpFMul")]
        FMul = 0x85,
        [NativeName("Name", "SpvOpUDiv")]
        UDiv = 0x86,
        [NativeName("Name", "SpvOpSDiv")]
        SDiv = 0x87,
        [NativeName("Name", "SpvOpFDiv")]
        FDiv = 0x88,
        [NativeName("Name", "SpvOpUMod")]
        UMod = 0x89,
        [NativeName("Name", "SpvOpSRem")]
        SRem = 0x8A,
        [NativeName("Name", "SpvOpSMod")]
        SMod = 0x8B,
        [NativeName("Name", "SpvOpFRem")]
        FRem = 0x8C,
        [NativeName("Name", "SpvOpFMod")]
        FMod = 0x8D,
        [NativeName("Name", "SpvOpVectorTimesScalar")]
        VectorTimesScalar = 0x8E,
        [NativeName("Name", "SpvOpMatrixTimesScalar")]
        MatrixTimesScalar = 0x8F,
        [NativeName("Name", "SpvOpVectorTimesMatrix")]
        VectorTimesMatrix = 0x90,
        [NativeName("Name", "SpvOpMatrixTimesVector")]
        MatrixTimesVector = 0x91,
        [NativeName("Name", "SpvOpMatrixTimesMatrix")]
        MatrixTimesMatrix = 0x92,
        [NativeName("Name", "SpvOpOuterProduct")]
        OuterProduct = 0x93,
        [NativeName("Name", "SpvOpDot")]
        Dot = 0x94,
        [NativeName("Name", "SpvOpIAddCarry")]
        IAddCarry = 0x95,
        [NativeName("Name", "SpvOpISubBorrow")]
        ISubBorrow = 0x96,
        [NativeName("Name", "SpvOpUMulExtended")]
        UMulExtended = 0x97,
        [NativeName("Name", "SpvOpSMulExtended")]
        SMulExtended = 0x98,
        [NativeName("Name", "SpvOpAny")]
        Any = 0x9A,
        [NativeName("Name", "SpvOpAll")]
        All = 0x9B,
        [NativeName("Name", "SpvOpIsNan")]
        IsNan = 0x9C,
        [NativeName("Name", "SpvOpIsInf")]
        IsInf = 0x9D,
        [NativeName("Name", "SpvOpIsFinite")]
        IsFinite = 0x9E,
        [NativeName("Name", "SpvOpIsNormal")]
        IsNormal = 0x9F,
        [NativeName("Name", "SpvOpSignBitSet")]
        SignBitSet = 0xA0,
        [NativeName("Name", "SpvOpLessOrGreater")]
        LessOrGreater = 0xA1,
        [NativeName("Name", "SpvOpOrdered")]
        Ordered = 0xA2,
        [NativeName("Name", "SpvOpUnordered")]
        Unordered = 0xA3,
        [NativeName("Name", "SpvOpLogicalEqual")]
        LogicalEqual = 0xA4,
        [NativeName("Name", "SpvOpLogicalNotEqual")]
        LogicalNotEqual = 0xA5,
        [NativeName("Name", "SpvOpLogicalOr")]
        LogicalOr = 0xA6,
        [NativeName("Name", "SpvOpLogicalAnd")]
        LogicalAnd = 0xA7,
        [NativeName("Name", "SpvOpLogicalNot")]
        LogicalNot = 0xA8,
        [NativeName("Name", "SpvOpSelect")]
        Select = 0xA9,
        [NativeName("Name", "SpvOpIEqual")]
        IEqual = 0xAA,
        [NativeName("Name", "SpvOpINotEqual")]
        INotEqual = 0xAB,
        [NativeName("Name", "SpvOpUGreaterThan")]
        UGreaterThan = 0xAC,
        [NativeName("Name", "SpvOpSGreaterThan")]
        SGreaterThan = 0xAD,
        [NativeName("Name", "SpvOpUGreaterThanEqual")]
        UGreaterThanEqual = 0xAE,
        [NativeName("Name", "SpvOpSGreaterThanEqual")]
        SGreaterThanEqual = 0xAF,
        [NativeName("Name", "SpvOpULessThan")]
        ULessThan = 0xB0,
        [NativeName("Name", "SpvOpSLessThan")]
        SLessThan = 0xB1,
        [NativeName("Name", "SpvOpULessThanEqual")]
        ULessThanEqual = 0xB2,
        [NativeName("Name", "SpvOpSLessThanEqual")]
        SLessThanEqual = 0xB3,
        [NativeName("Name", "SpvOpFOrdEqual")]
        FOrdEqual = 0xB4,
        [NativeName("Name", "SpvOpFUnordEqual")]
        FUnordEqual = 0xB5,
        [NativeName("Name", "SpvOpFOrdNotEqual")]
        FOrdNotEqual = 0xB6,
        [NativeName("Name", "SpvOpFUnordNotEqual")]
        FUnordNotEqual = 0xB7,
        [NativeName("Name", "SpvOpFOrdLessThan")]
        FOrdLessThan = 0xB8,
        [NativeName("Name", "SpvOpFUnordLessThan")]
        FUnordLessThan = 0xB9,
        [NativeName("Name", "SpvOpFOrdGreaterThan")]
        FOrdGreaterThan = 0xBA,
        [NativeName("Name", "SpvOpFUnordGreaterThan")]
        FUnordGreaterThan = 0xBB,
        [NativeName("Name", "SpvOpFOrdLessThanEqual")]
        FOrdLessThanEqual = 0xBC,
        [NativeName("Name", "SpvOpFUnordLessThanEqual")]
        FUnordLessThanEqual = 0xBD,
        [NativeName("Name", "SpvOpFOrdGreaterThanEqual")]
        FOrdGreaterThanEqual = 0xBE,
        [NativeName("Name", "SpvOpFUnordGreaterThanEqual")]
        FUnordGreaterThanEqual = 0xBF,
        [NativeName("Name", "SpvOpShiftRightLogical")]
        ShiftRightLogical = 0xC2,
        [NativeName("Name", "SpvOpShiftRightArithmetic")]
        ShiftRightArithmetic = 0xC3,
        [NativeName("Name", "SpvOpShiftLeftLogical")]
        ShiftLeftLogical = 0xC4,
        [NativeName("Name", "SpvOpBitwiseOr")]
        BitwiseOr = 0xC5,
        [NativeName("Name", "SpvOpBitwiseXor")]
        BitwiseXor = 0xC6,
        [NativeName("Name", "SpvOpBitwiseAnd")]
        BitwiseAnd = 0xC7,
        [NativeName("Name", "SpvOpNot")]
        Not = 0xC8,
        [NativeName("Name", "SpvOpBitFieldInsert")]
        BitFieldInsert = 0xC9,
        [NativeName("Name", "SpvOpBitFieldSExtract")]
        BitFieldSExtract = 0xCA,
        [NativeName("Name", "SpvOpBitFieldUExtract")]
        BitFieldUExtract = 0xCB,
        [NativeName("Name", "SpvOpBitReverse")]
        BitReverse = 0xCC,
        [NativeName("Name", "SpvOpBitCount")]
        BitCount = 0xCD,
        [NativeName("Name", "SpvOpDPdx")]
        DPdx = 0xCF,
        [NativeName("Name", "SpvOpDPdy")]
        DPdy = 0xD0,
        [NativeName("Name", "SpvOpFwidth")]
        Fwidth = 0xD1,
        [NativeName("Name", "SpvOpDPdxFine")]
        DPdxFine = 0xD2,
        [NativeName("Name", "SpvOpDPdyFine")]
        DPdyFine = 0xD3,
        [NativeName("Name", "SpvOpFwidthFine")]
        FwidthFine = 0xD4,
        [NativeName("Name", "SpvOpDPdxCoarse")]
        DPdxCoarse = 0xD5,
        [NativeName("Name", "SpvOpDPdyCoarse")]
        DPdyCoarse = 0xD6,
        [NativeName("Name", "SpvOpFwidthCoarse")]
        FwidthCoarse = 0xD7,
        [NativeName("Name", "SpvOpEmitVertex")]
        EmitVertex = 0xDA,
        [NativeName("Name", "SpvOpEndPrimitive")]
        EndPrimitive = 0xDB,
        [NativeName("Name", "SpvOpEmitStreamVertex")]
        EmitStreamVertex = 0xDC,
        [NativeName("Name", "SpvOpEndStreamPrimitive")]
        EndStreamPrimitive = 0xDD,
        [NativeName("Name", "SpvOpControlBarrier")]
        ControlBarrier = 0xE0,
        [NativeName("Name", "SpvOpMemoryBarrier")]
        MemoryBarrier = 0xE1,
        [NativeName("Name", "SpvOpAtomicLoad")]
        AtomicLoad = 0xE3,
        [NativeName("Name", "SpvOpAtomicStore")]
        AtomicStore = 0xE4,
        [NativeName("Name", "SpvOpAtomicExchange")]
        AtomicExchange = 0xE5,
        [NativeName("Name", "SpvOpAtomicCompareExchange")]
        AtomicCompareExchange = 0xE6,
        [NativeName("Name", "SpvOpAtomicCompareExchangeWeak")]
        AtomicCompareExchangeWeak = 0xE7,
        [NativeName("Name", "SpvOpAtomicIIncrement")]
        AtomicIIncrement = 0xE8,
        [NativeName("Name", "SpvOpAtomicIDecrement")]
        AtomicIDecrement = 0xE9,
        [NativeName("Name", "SpvOpAtomicIAdd")]
        AtomicIAdd = 0xEA,
        [NativeName("Name", "SpvOpAtomicISub")]
        AtomicISub = 0xEB,
        [NativeName("Name", "SpvOpAtomicSMin")]
        AtomicSMin = 0xEC,
        [NativeName("Name", "SpvOpAtomicUMin")]
        AtomicUMin = 0xED,
        [NativeName("Name", "SpvOpAtomicSMax")]
        AtomicSMax = 0xEE,
        [NativeName("Name", "SpvOpAtomicUMax")]
        AtomicUMax = 0xEF,
        [NativeName("Name", "SpvOpAtomicAnd")]
        AtomicAnd = 0xF0,
        [NativeName("Name", "SpvOpAtomicOr")]
        AtomicOr = 0xF1,
        [NativeName("Name", "SpvOpAtomicXor")]
        AtomicXor = 0xF2,
        [NativeName("Name", "SpvOpPhi")]
        Phi = 0xF5,
        [NativeName("Name", "SpvOpLoopMerge")]
        LoopMerge = 0xF6,
        [NativeName("Name", "SpvOpSelectionMerge")]
        SelectionMerge = 0xF7,
        [NativeName("Name", "SpvOpLabel")]
        Label = 0xF8,
        [NativeName("Name", "SpvOpBranch")]
        Branch = 0xF9,
        [NativeName("Name", "SpvOpBranchConditional")]
        BranchConditional = 0xFA,
        [NativeName("Name", "SpvOpSwitch")]
        Switch = 0xFB,
        [NativeName("Name", "SpvOpKill")]
        Kill = 0xFC,
        [NativeName("Name", "SpvOpReturn")]
        Return = 0xFD,
        [NativeName("Name", "SpvOpReturnValue")]
        ReturnValue = 0xFE,
        [NativeName("Name", "SpvOpUnreachable")]
        Unreachable = 0xFF,
        [NativeName("Name", "SpvOpLifetimeStart")]
        LifetimeStart = 0x100,
        [NativeName("Name", "SpvOpLifetimeStop")]
        LifetimeStop = 0x101,
        [NativeName("Name", "SpvOpGroupAsyncCopy")]
        GroupAsyncCopy = 0x103,
        [NativeName("Name", "SpvOpGroupWaitEvents")]
        GroupWaitEvents = 0x104,
        [NativeName("Name", "SpvOpGroupAll")]
        GroupAll = 0x105,
        [NativeName("Name", "SpvOpGroupAny")]
        GroupAny = 0x106,
        [NativeName("Name", "SpvOpGroupBroadcast")]
        GroupBroadcast = 0x107,
        [NativeName("Name", "SpvOpGroupIAdd")]
        GroupIAdd = 0x108,
        [NativeName("Name", "SpvOpGroupFAdd")]
        GroupFAdd = 0x109,
        [NativeName("Name", "SpvOpGroupFMin")]
        GroupFMin = 0x10A,
        [NativeName("Name", "SpvOpGroupUMin")]
        GroupUMin = 0x10B,
        [NativeName("Name", "SpvOpGroupSMin")]
        GroupSMin = 0x10C,
        [NativeName("Name", "SpvOpGroupFMax")]
        GroupFMax = 0x10D,
        [NativeName("Name", "SpvOpGroupUMax")]
        GroupUMax = 0x10E,
        [NativeName("Name", "SpvOpGroupSMax")]
        GroupSMax = 0x10F,
        [NativeName("Name", "SpvOpReadPipe")]
        ReadPipe = 0x112,
        [NativeName("Name", "SpvOpWritePipe")]
        WritePipe = 0x113,
        [NativeName("Name", "SpvOpReservedReadPipe")]
        ReservedReadPipe = 0x114,
        [NativeName("Name", "SpvOpReservedWritePipe")]
        ReservedWritePipe = 0x115,
        [NativeName("Name", "SpvOpReserveReadPipePackets")]
        ReserveReadPipePackets = 0x116,
        [NativeName("Name", "SpvOpReserveWritePipePackets")]
        ReserveWritePipePackets = 0x117,
        [NativeName("Name", "SpvOpCommitReadPipe")]
        CommitReadPipe = 0x118,
        [NativeName("Name", "SpvOpCommitWritePipe")]
        CommitWritePipe = 0x119,
        [NativeName("Name", "SpvOpIsValidReserveId")]
        IsValidReserveId = 0x11A,
        [NativeName("Name", "SpvOpGetNumPipePackets")]
        GetNumPipePackets = 0x11B,
        [NativeName("Name", "SpvOpGetMaxPipePackets")]
        GetMaxPipePackets = 0x11C,
        [NativeName("Name", "SpvOpGroupReserveReadPipePackets")]
        GroupReserveReadPipePackets = 0x11D,
        [NativeName("Name", "SpvOpGroupReserveWritePipePackets")]
        GroupReserveWritePipePackets = 0x11E,
        [NativeName("Name", "SpvOpGroupCommitReadPipe")]
        GroupCommitReadPipe = 0x11F,
        [NativeName("Name", "SpvOpGroupCommitWritePipe")]
        GroupCommitWritePipe = 0x120,
        [NativeName("Name", "SpvOpEnqueueMarker")]
        EnqueueMarker = 0x123,
        [NativeName("Name", "SpvOpEnqueueKernel")]
        EnqueueKernel = 0x124,
        [NativeName("Name", "SpvOpGetKernelNDrangeSubGroupCount")]
        GetKernelNDrangeSubGroupCount = 0x125,
        [NativeName("Name", "SpvOpGetKernelNDrangeMaxSubGroupSize")]
        GetKernelNDrangeMaxSubGroupSize = 0x126,
        [NativeName("Name", "SpvOpGetKernelWorkGroupSize")]
        GetKernelWorkGroupSize = 0x127,
        [NativeName("Name", "SpvOpGetKernelPreferredWorkGroupSizeMultiple")]
        GetKernelPreferredWorkGroupSizeMultiple = 0x128,
        [NativeName("Name", "SpvOpRetainEvent")]
        RetainEvent = 0x129,
        [NativeName("Name", "SpvOpReleaseEvent")]
        ReleaseEvent = 0x12A,
        [NativeName("Name", "SpvOpCreateUserEvent")]
        CreateUserEvent = 0x12B,
        [NativeName("Name", "SpvOpIsValidEvent")]
        IsValidEvent = 0x12C,
        [NativeName("Name", "SpvOpSetUserEventStatus")]
        SetUserEventStatus = 0x12D,
        [NativeName("Name", "SpvOpCaptureEventProfilingInfo")]
        CaptureEventProfilingInfo = 0x12E,
        [NativeName("Name", "SpvOpGetDefaultQueue")]
        GetDefaultQueue = 0x12F,
        [NativeName("Name", "SpvOpBuildNDRange")]
        BuildNDRange = 0x130,
        [NativeName("Name", "SpvOpImageSparseSampleImplicitLod")]
        ImageSparseSampleImplicitLod = 0x131,
        [NativeName("Name", "SpvOpImageSparseSampleExplicitLod")]
        ImageSparseSampleExplicitLod = 0x132,
        [NativeName("Name", "SpvOpImageSparseSampleDrefImplicitLod")]
        ImageSparseSampleDrefImplicitLod = 0x133,
        [NativeName("Name", "SpvOpImageSparseSampleDrefExplicitLod")]
        ImageSparseSampleDrefExplicitLod = 0x134,
        [NativeName("Name", "SpvOpImageSparseSampleProjImplicitLod")]
        ImageSparseSampleProjImplicitLod = 0x135,
        [NativeName("Name", "SpvOpImageSparseSampleProjExplicitLod")]
        ImageSparseSampleProjExplicitLod = 0x136,
        [NativeName("Name", "SpvOpImageSparseSampleProjDrefImplicitLod")]
        ImageSparseSampleProjDrefImplicitLod = 0x137,
        [NativeName("Name", "SpvOpImageSparseSampleProjDrefExplicitLod")]
        ImageSparseSampleProjDrefExplicitLod = 0x138,
        [NativeName("Name", "SpvOpImageSparseFetch")]
        ImageSparseFetch = 0x139,
        [NativeName("Name", "SpvOpImageSparseGather")]
        ImageSparseGather = 0x13A,
        [NativeName("Name", "SpvOpImageSparseDrefGather")]
        ImageSparseDrefGather = 0x13B,
        [NativeName("Name", "SpvOpImageSparseTexelsResident")]
        ImageSparseTexelsResident = 0x13C,
        [NativeName("Name", "SpvOpNoLine")]
        NoLine = 0x13D,
        [NativeName("Name", "SpvOpAtomicFlagTestAndSet")]
        AtomicFlagTestAndSet = 0x13E,
        [NativeName("Name", "SpvOpAtomicFlagClear")]
        AtomicFlagClear = 0x13F,
        [NativeName("Name", "SpvOpImageSparseRead")]
        ImageSparseRead = 0x140,
        [NativeName("Name", "SpvOpSizeOf")]
        SizeOf = 0x141,
        [NativeName("Name", "SpvOpTypePipeStorage")]
        TypePipeStorage = 0x142,
        [NativeName("Name", "SpvOpConstantPipeStorage")]
        ConstantPipeStorage = 0x143,
        [NativeName("Name", "SpvOpCreatePipeFromPipeStorage")]
        CreatePipeFromPipeStorage = 0x144,
        [NativeName("Name", "SpvOpGetKernelLocalSizeForSubgroupCount")]
        GetKernelLocalSizeForSubgroupCount = 0x145,
        [NativeName("Name", "SpvOpGetKernelMaxNumSubgroups")]
        GetKernelMaxNumSubgroups = 0x146,
        [NativeName("Name", "SpvOpTypeNamedBarrier")]
        TypeNamedBarrier = 0x147,
        [NativeName("Name", "SpvOpNamedBarrierInitialize")]
        NamedBarrierInitialize = 0x148,
        [NativeName("Name", "SpvOpMemoryNamedBarrier")]
        MemoryNamedBarrier = 0x149,
        [NativeName("Name", "SpvOpModuleProcessed")]
        ModuleProcessed = 0x14A,
        [NativeName("Name", "SpvOpExecutionModeId")]
        ExecutionModeId = 0x14B,
        [NativeName("Name", "SpvOpDecorateId")]
        DecorateId = 0x14C,
        [NativeName("Name", "SpvOpGroupNonUniformElect")]
        GroupNonUniformElect = 0x14D,
        [NativeName("Name", "SpvOpGroupNonUniformAll")]
        GroupNonUniformAll = 0x14E,
        [NativeName("Name", "SpvOpGroupNonUniformAny")]
        GroupNonUniformAny = 0x14F,
        [NativeName("Name", "SpvOpGroupNonUniformAllEqual")]
        GroupNonUniformAllEqual = 0x150,
        [NativeName("Name", "SpvOpGroupNonUniformBroadcast")]
        GroupNonUniformBroadcast = 0x151,
        [NativeName("Name", "SpvOpGroupNonUniformBroadcastFirst")]
        GroupNonUniformBroadcastFirst = 0x152,
        [NativeName("Name", "SpvOpGroupNonUniformBallot")]
        GroupNonUniformBallot = 0x153,
        [NativeName("Name", "SpvOpGroupNonUniformInverseBallot")]
        GroupNonUniformInverseBallot = 0x154,
        [NativeName("Name", "SpvOpGroupNonUniformBallotBitExtract")]
        GroupNonUniformBallotBitExtract = 0x155,
        [NativeName("Name", "SpvOpGroupNonUniformBallotBitCount")]
        GroupNonUniformBallotBitCount = 0x156,
        [NativeName("Name", "SpvOpGroupNonUniformBallotFindLSB")]
        GroupNonUniformBallotFindLsb = 0x157,
        [NativeName("Name", "SpvOpGroupNonUniformBallotFindMSB")]
        GroupNonUniformBallotFindMsb = 0x158,
        [NativeName("Name", "SpvOpGroupNonUniformShuffle")]
        GroupNonUniformShuffle = 0x159,
        [NativeName("Name", "SpvOpGroupNonUniformShuffleXor")]
        GroupNonUniformShuffleXor = 0x15A,
        [NativeName("Name", "SpvOpGroupNonUniformShuffleUp")]
        GroupNonUniformShuffleUp = 0x15B,
        [NativeName("Name", "SpvOpGroupNonUniformShuffleDown")]
        GroupNonUniformShuffleDown = 0x15C,
        [NativeName("Name", "SpvOpGroupNonUniformIAdd")]
        GroupNonUniformIAdd = 0x15D,
        [NativeName("Name", "SpvOpGroupNonUniformFAdd")]
        GroupNonUniformFAdd = 0x15E,
        [NativeName("Name", "SpvOpGroupNonUniformIMul")]
        GroupNonUniformIMul = 0x15F,
        [NativeName("Name", "SpvOpGroupNonUniformFMul")]
        GroupNonUniformFMul = 0x160,
        [NativeName("Name", "SpvOpGroupNonUniformSMin")]
        GroupNonUniformSMin = 0x161,
        [NativeName("Name", "SpvOpGroupNonUniformUMin")]
        GroupNonUniformUMin = 0x162,
        [NativeName("Name", "SpvOpGroupNonUniformFMin")]
        GroupNonUniformFMin = 0x163,
        [NativeName("Name", "SpvOpGroupNonUniformSMax")]
        GroupNonUniformSMax = 0x164,
        [NativeName("Name", "SpvOpGroupNonUniformUMax")]
        GroupNonUniformUMax = 0x165,
        [NativeName("Name", "SpvOpGroupNonUniformFMax")]
        GroupNonUniformFMax = 0x166,
        [NativeName("Name", "SpvOpGroupNonUniformBitwiseAnd")]
        GroupNonUniformBitwiseAnd = 0x167,
        [NativeName("Name", "SpvOpGroupNonUniformBitwiseOr")]
        GroupNonUniformBitwiseOr = 0x168,
        [NativeName("Name", "SpvOpGroupNonUniformBitwiseXor")]
        GroupNonUniformBitwiseXor = 0x169,
        [NativeName("Name", "SpvOpGroupNonUniformLogicalAnd")]
        GroupNonUniformLogicalAnd = 0x16A,
        [NativeName("Name", "SpvOpGroupNonUniformLogicalOr")]
        GroupNonUniformLogicalOr = 0x16B,
        [NativeName("Name", "SpvOpGroupNonUniformLogicalXor")]
        GroupNonUniformLogicalXor = 0x16C,
        [NativeName("Name", "SpvOpGroupNonUniformQuadBroadcast")]
        GroupNonUniformQuadBroadcast = 0x16D,
        [NativeName("Name", "SpvOpGroupNonUniformQuadSwap")]
        GroupNonUniformQuadSwap = 0x16E,
        [NativeName("Name", "SpvOpCopyLogical")]
        CopyLogical = 0x190,
        [NativeName("Name", "SpvOpPtrEqual")]
        PtrEqual = 0x191,
        [NativeName("Name", "SpvOpPtrNotEqual")]
        PtrNotEqual = 0x192,
        [NativeName("Name", "SpvOpPtrDiff")]
        PtrDiff = 0x193,
        [NativeName("Name", "SpvOpColorAttachmentReadEXT")]
        ColorAttachmentReadExt = 0x1040,
        [NativeName("Name", "SpvOpDepthAttachmentReadEXT")]
        DepthAttachmentReadExt = 0x1041,
        [NativeName("Name", "SpvOpStencilAttachmentReadEXT")]
        StencilAttachmentReadExt = 0x1042,
        [NativeName("Name", "SpvOpTerminateInvocation")]
        TerminateInvocation = 0x1140,
        [NativeName("Name", "SpvOpTypeUntypedPointerKHR")]
        TypeUntypedPointerKhr = 0x1141,
        [NativeName("Name", "SpvOpUntypedVariableKHR")]
        UntypedVariableKhr = 0x1142,
        [NativeName("Name", "SpvOpUntypedAccessChainKHR")]
        UntypedAccessChainKhr = 0x1143,
        [NativeName("Name", "SpvOpUntypedInBoundsAccessChainKHR")]
        UntypedInBoundsAccessChainKhr = 0x1144,
        [NativeName("Name", "SpvOpSubgroupBallotKHR")]
        SubgroupBallotKhr = 0x1145,
        [NativeName("Name", "SpvOpSubgroupFirstInvocationKHR")]
        SubgroupFirstInvocationKhr = 0x1146,
        [NativeName("Name", "SpvOpUntypedPtrAccessChainKHR")]
        UntypedPtrAccessChainKhr = 0x1147,
        [NativeName("Name", "SpvOpUntypedInBoundsPtrAccessChainKHR")]
        UntypedInBoundsPtrAccessChainKhr = 0x1148,
        [NativeName("Name", "SpvOpUntypedArrayLengthKHR")]
        UntypedArrayLengthKhr = 0x1149,
        [NativeName("Name", "SpvOpUntypedPrefetchKHR")]
        UntypedPrefetchKhr = 0x114A,
        [NativeName("Name", "SpvOpSubgroupAllKHR")]
        SubgroupAllKhr = 0x114C,
        [NativeName("Name", "SpvOpSubgroupAnyKHR")]
        SubgroupAnyKhr = 0x114D,
        [NativeName("Name", "SpvOpSubgroupAllEqualKHR")]
        SubgroupAllEqualKhr = 0x114E,
        [NativeName("Name", "SpvOpGroupNonUniformRotateKHR")]
        GroupNonUniformRotateKhr = 0x114F,
        [NativeName("Name", "SpvOpSubgroupReadInvocationKHR")]
        SubgroupReadInvocationKhr = 0x1150,
        [NativeName("Name", "SpvOpExtInstWithForwardRefsKHR")]
        ExtInstWithForwardRefsKhr = 0x1151,
        [NativeName("Name", "SpvOpTraceRayKHR")]
        TraceRayKhr = 0x115D,
        [NativeName("Name", "SpvOpExecuteCallableKHR")]
        ExecuteCallableKhr = 0x115E,
        [NativeName("Name", "SpvOpConvertUToAccelerationStructureKHR")]
        ConvertUToAccelerationStructureKhr = 0x115F,
        [NativeName("Name", "SpvOpIgnoreIntersectionKHR")]
        IgnoreIntersectionKhr = 0x1160,
        [NativeName("Name", "SpvOpTerminateRayKHR")]
        TerminateRayKhr = 0x1161,
        [NativeName("Name", "SpvOpSDot")]
        SDot = 0x1162,
        [NativeName("Name", "SpvOpSDotKHR")]
        SDotKhr = 0x1162,
        [NativeName("Name", "SpvOpUDot")]
        UDot = 0x1163,
        [NativeName("Name", "SpvOpUDotKHR")]
        UDotKhr = 0x1163,
        [NativeName("Name", "SpvOpSUDot")]
        SUDot = 0x1164,
        [NativeName("Name", "SpvOpSUDotKHR")]
        SUDotKhr = 0x1164,
        [NativeName("Name", "SpvOpSDotAccSat")]
        SDotAccSat = 0x1165,
        [NativeName("Name", "SpvOpSDotAccSatKHR")]
        SDotAccSatKhr = 0x1165,
        [NativeName("Name", "SpvOpUDotAccSat")]
        UDotAccSat = 0x1166,
        [NativeName("Name", "SpvOpUDotAccSatKHR")]
        UDotAccSatKhr = 0x1166,
        [NativeName("Name", "SpvOpSUDotAccSat")]
        SUDotAccSat = 0x1167,
        [NativeName("Name", "SpvOpSUDotAccSatKHR")]
        SUDotAccSatKhr = 0x1167,
        [NativeName("Name", "SpvOpTypeCooperativeMatrixKHR")]
        TypeCooperativeMatrixKhr = 0x1168,
        [NativeName("Name", "SpvOpCooperativeMatrixLoadKHR")]
        CooperativeMatrixLoadKhr = 0x1169,
        [NativeName("Name", "SpvOpCooperativeMatrixStoreKHR")]
        CooperativeMatrixStoreKhr = 0x116A,
        [NativeName("Name", "SpvOpCooperativeMatrixMulAddKHR")]
        CooperativeMatrixMulAddKhr = 0x116B,
        [NativeName("Name", "SpvOpCooperativeMatrixLengthKHR")]
        CooperativeMatrixLengthKhr = 0x116C,
        [NativeName("Name", "SpvOpConstantCompositeReplicateEXT")]
        ConstantCompositeReplicateExt = 0x116D,
        [NativeName("Name", "SpvOpSpecConstantCompositeReplicateEXT")]
        SpecConstantCompositeReplicateExt = 0x116E,
        [NativeName("Name", "SpvOpCompositeConstructReplicateEXT")]
        CompositeConstructReplicateExt = 0x116F,
        [NativeName("Name", "SpvOpTypeRayQueryKHR")]
        TypeRayQueryKhr = 0x1178,
        [NativeName("Name", "SpvOpRayQueryInitializeKHR")]
        RayQueryInitializeKhr = 0x1179,
        [NativeName("Name", "SpvOpRayQueryTerminateKHR")]
        RayQueryTerminateKhr = 0x117A,
        [NativeName("Name", "SpvOpRayQueryGenerateIntersectionKHR")]
        RayQueryGenerateIntersectionKhr = 0x117B,
        [NativeName("Name", "SpvOpRayQueryConfirmIntersectionKHR")]
        RayQueryConfirmIntersectionKhr = 0x117C,
        [NativeName("Name", "SpvOpRayQueryProceedKHR")]
        RayQueryProceedKhr = 0x117D,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionTypeKHR")]
        RayQueryGetIntersectionTypeKhr = 0x117F,
        [NativeName("Name", "SpvOpImageSampleWeightedQCOM")]
        ImageSampleWeightedQCom = 0x1180,
        [NativeName("Name", "SpvOpImageBoxFilterQCOM")]
        ImageBoxFilterQCom = 0x1181,
        [NativeName("Name", "SpvOpImageBlockMatchSSDQCOM")]
        ImageBlockMatchSsdqcom = 0x1182,
        [NativeName("Name", "SpvOpImageBlockMatchSADQCOM")]
        ImageBlockMatchSadqcom = 0x1183,
        [NativeName("Name", "SpvOpImageBlockMatchWindowSSDQCOM")]
        ImageBlockMatchWindowSsdqcom = 0x1194,
        [NativeName("Name", "SpvOpImageBlockMatchWindowSADQCOM")]
        ImageBlockMatchWindowSadqcom = 0x1195,
        [NativeName("Name", "SpvOpImageBlockMatchGatherSSDQCOM")]
        ImageBlockMatchGatherSsdqcom = 0x1196,
        [NativeName("Name", "SpvOpImageBlockMatchGatherSADQCOM")]
        ImageBlockMatchGatherSadqcom = 0x1197,
        [NativeName("Name", "SpvOpGroupIAddNonUniformAMD")]
        GroupIAddNonUniformAmd = 0x1388,
        [NativeName("Name", "SpvOpGroupFAddNonUniformAMD")]
        GroupFAddNonUniformAmd = 0x1389,
        [NativeName("Name", "SpvOpGroupFMinNonUniformAMD")]
        GroupFMinNonUniformAmd = 0x138A,
        [NativeName("Name", "SpvOpGroupUMinNonUniformAMD")]
        GroupUMinNonUniformAmd = 0x138B,
        [NativeName("Name", "SpvOpGroupSMinNonUniformAMD")]
        GroupSMinNonUniformAmd = 0x138C,
        [NativeName("Name", "SpvOpGroupFMaxNonUniformAMD")]
        GroupFMaxNonUniformAmd = 0x138D,
        [NativeName("Name", "SpvOpGroupUMaxNonUniformAMD")]
        GroupUMaxNonUniformAmd = 0x138E,
        [NativeName("Name", "SpvOpGroupSMaxNonUniformAMD")]
        GroupSMaxNonUniformAmd = 0x138F,
        [NativeName("Name", "SpvOpFragmentMaskFetchAMD")]
        FragmentMaskFetchAmd = 0x1393,
        [NativeName("Name", "SpvOpFragmentFetchAMD")]
        FragmentFetchAmd = 0x1394,
        [NativeName("Name", "SpvOpReadClockKHR")]
        ReadClockKhr = 0x13C0,
        [NativeName("Name", "SpvOpFinalizeNodePayloadsAMDX")]
        FinalizeNodePayloadsAmdx = 0x13D3,
        [NativeName("Name", "SpvOpFinishWritingNodePayloadAMDX")]
        FinishWritingNodePayloadAmdx = 0x13D6,
        [NativeName("Name", "SpvOpInitializeNodePayloadsAMDX")]
        InitializeNodePayloadsAmdx = 0x13E2,
        [NativeName("Name", "SpvOpGroupNonUniformQuadAllKHR")]
        GroupNonUniformQuadAllKhr = 0x13F6,
        [NativeName("Name", "SpvOpGroupNonUniformQuadAnyKHR")]
        GroupNonUniformQuadAnyKhr = 0x13F7,
        [NativeName("Name", "SpvOpHitObjectRecordHitMotionNV")]
        HitObjectRecordHitMotionNV = 0x1481,
        [NativeName("Name", "SpvOpHitObjectRecordHitWithIndexMotionNV")]
        HitObjectRecordHitWithIndexMotionNV = 0x1482,
        [NativeName("Name", "SpvOpHitObjectRecordMissMotionNV")]
        HitObjectRecordMissMotionNV = 0x1483,
        [NativeName("Name", "SpvOpHitObjectGetWorldToObjectNV")]
        HitObjectGetWorldToObjectNV = 0x1484,
        [NativeName("Name", "SpvOpHitObjectGetObjectToWorldNV")]
        HitObjectGetObjectToWorldNV = 0x1485,
        [NativeName("Name", "SpvOpHitObjectGetObjectRayDirectionNV")]
        HitObjectGetObjectRayDirectionNV = 0x1486,
        [NativeName("Name", "SpvOpHitObjectGetObjectRayOriginNV")]
        HitObjectGetObjectRayOriginNV = 0x1487,
        [NativeName("Name", "SpvOpHitObjectTraceRayMotionNV")]
        HitObjectTraceRayMotionNV = 0x1488,
        [NativeName("Name", "SpvOpHitObjectGetShaderRecordBufferHandleNV")]
        HitObjectGetShaderRecordBufferHandleNV = 0x1489,
        [NativeName("Name", "SpvOpHitObjectGetShaderBindingTableRecordIndexNV")]
        HitObjectGetShaderBindingTableRecordIndexNV = 0x148A,
        [NativeName("Name", "SpvOpHitObjectRecordEmptyNV")]
        HitObjectRecordEmptyNV = 0x148B,
        [NativeName("Name", "SpvOpHitObjectTraceRayNV")]
        HitObjectTraceRayNV = 0x148C,
        [NativeName("Name", "SpvOpHitObjectRecordHitNV")]
        HitObjectRecordHitNV = 0x148D,
        [NativeName("Name", "SpvOpHitObjectRecordHitWithIndexNV")]
        HitObjectRecordHitWithIndexNV = 0x148E,
        [NativeName("Name", "SpvOpHitObjectRecordMissNV")]
        HitObjectRecordMissNV = 0x148F,
        [NativeName("Name", "SpvOpHitObjectExecuteShaderNV")]
        HitObjectExecuteShaderNV = 0x1490,
        [NativeName("Name", "SpvOpHitObjectGetCurrentTimeNV")]
        HitObjectGetCurrentTimeNV = 0x1491,
        [NativeName("Name", "SpvOpHitObjectGetAttributesNV")]
        HitObjectGetAttributesNV = 0x1492,
        [NativeName("Name", "SpvOpHitObjectGetHitKindNV")]
        HitObjectGetHitKindNV = 0x1493,
        [NativeName("Name", "SpvOpHitObjectGetPrimitiveIndexNV")]
        HitObjectGetPrimitiveIndexNV = 0x1494,
        [NativeName("Name", "SpvOpHitObjectGetGeometryIndexNV")]
        HitObjectGetGeometryIndexNV = 0x1495,
        [NativeName("Name", "SpvOpHitObjectGetInstanceIdNV")]
        HitObjectGetInstanceIdNV = 0x1496,
        [NativeName("Name", "SpvOpHitObjectGetInstanceCustomIndexNV")]
        HitObjectGetInstanceCustomIndexNV = 0x1497,
        [NativeName("Name", "SpvOpHitObjectGetWorldRayDirectionNV")]
        HitObjectGetWorldRayDirectionNV = 0x1498,
        [NativeName("Name", "SpvOpHitObjectGetWorldRayOriginNV")]
        HitObjectGetWorldRayOriginNV = 0x1499,
        [NativeName("Name", "SpvOpHitObjectGetRayTMaxNV")]
        HitObjectGetRayTMaxNV = 0x149A,
        [NativeName("Name", "SpvOpHitObjectGetRayTMinNV")]
        HitObjectGetRayTMinNV = 0x149B,
        [NativeName("Name", "SpvOpHitObjectIsEmptyNV")]
        HitObjectIsEmptyNV = 0x149C,
        [NativeName("Name", "SpvOpHitObjectIsHitNV")]
        HitObjectIsHitNV = 0x149D,
        [NativeName("Name", "SpvOpHitObjectIsMissNV")]
        HitObjectIsMissNV = 0x149E,
        [NativeName("Name", "SpvOpReorderThreadWithHitObjectNV")]
        ReorderThreadWithHitObjectNV = 0x149F,
        [NativeName("Name", "SpvOpReorderThreadWithHintNV")]
        ReorderThreadWithHintNV = 0x14A0,
        [NativeName("Name", "SpvOpTypeHitObjectNV")]
        TypeHitObjectNV = 0x14A1,
        [NativeName("Name", "SpvOpImageSampleFootprintNV")]
        ImageSampleFootprintNV = 0x14A3,
        [NativeName("Name", "SpvOpEmitMeshTasksEXT")]
        EmitMeshTasksExt = 0x14AE,
        [NativeName("Name", "SpvOpSetMeshOutputsEXT")]
        SetMeshOutputsExt = 0x14AF,
        [NativeName("Name", "SpvOpGroupNonUniformPartitionNV")]
        GroupNonUniformPartitionNV = 0x14B0,
        [NativeName("Name", "SpvOpWritePackedPrimitiveIndices4x8NV")]
        WritePackedPrimitiveIndices4x8NV = 0x14B3,
        [NativeName("Name", "SpvOpFetchMicroTriangleVertexPositionNV")]
        FetchMicroTriangleVertexPositionNV = 0x14B4,
        [NativeName("Name", "SpvOpFetchMicroTriangleVertexBarycentricNV")]
        FetchMicroTriangleVertexBarycentricNV = 0x14B5,
        [NativeName("Name", "SpvOpReportIntersectionKHR")]
        ReportIntersectionKhr = 0x14D6,
        [NativeName("Name", "SpvOpReportIntersectionNV")]
        ReportIntersectionNV = 0x14D6,
        [NativeName("Name", "SpvOpIgnoreIntersectionNV")]
        IgnoreIntersectionNV = 0x14D7,
        [NativeName("Name", "SpvOpTerminateRayNV")]
        TerminateRayNV = 0x14D8,
        [NativeName("Name", "SpvOpTraceNV")]
        TraceNV = 0x14D9,
        [NativeName("Name", "SpvOpTraceMotionNV")]
        TraceMotionNV = 0x14DA,
        [NativeName("Name", "SpvOpTraceRayMotionNV")]
        TraceRayMotionNV = 0x14DB,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionTriangleVertexPositionsKHR")]
        RayQueryGetIntersectionTriangleVertexPositionsKhr = 0x14DC,
        [NativeName("Name", "SpvOpTypeAccelerationStructureKHR")]
        TypeAccelerationStructureKhr = 0x14DD,
        [NativeName("Name", "SpvOpTypeAccelerationStructureNV")]
        TypeAccelerationStructureNV = 0x14DD,
        [NativeName("Name", "SpvOpExecuteCallableNV")]
        ExecuteCallableNV = 0x14E0,
        [NativeName("Name", "SpvOpTypeCooperativeMatrixNV")]
        TypeCooperativeMatrixNV = 0x14EE,
        [NativeName("Name", "SpvOpCooperativeMatrixLoadNV")]
        CooperativeMatrixLoadNV = 0x14EF,
        [NativeName("Name", "SpvOpCooperativeMatrixStoreNV")]
        CooperativeMatrixStoreNV = 0x14F0,
        [NativeName("Name", "SpvOpCooperativeMatrixMulAddNV")]
        CooperativeMatrixMulAddNV = 0x14F1,
        [NativeName("Name", "SpvOpCooperativeMatrixLengthNV")]
        CooperativeMatrixLengthNV = 0x14F2,
        [NativeName("Name", "SpvOpBeginInvocationInterlockEXT")]
        BeginInvocationInterlockExt = 0x14F4,
        [NativeName("Name", "SpvOpEndInvocationInterlockEXT")]
        EndInvocationInterlockExt = 0x14F5,
        [NativeName("Name", "SpvOpDemoteToHelperInvocation")]
        DemoteToHelperInvocation = 0x1504,
        [NativeName("Name", "SpvOpDemoteToHelperInvocationEXT")]
        DemoteToHelperInvocationExt = 0x1504,
        [NativeName("Name", "SpvOpIsHelperInvocationEXT")]
        IsHelperInvocationExt = 0x1505,
        [NativeName("Name", "SpvOpConvertUToImageNV")]
        ConvertUToImageNV = 0x150F,
        [NativeName("Name", "SpvOpConvertUToSamplerNV")]
        ConvertUToSamplerNV = 0x1510,
        [NativeName("Name", "SpvOpConvertImageToUNV")]
        ConvertImageToUnv = 0x1511,
        [NativeName("Name", "SpvOpConvertSamplerToUNV")]
        ConvertSamplerToUnv = 0x1512,
        [NativeName("Name", "SpvOpConvertUToSampledImageNV")]
        ConvertUToSampledImageNV = 0x1513,
        [NativeName("Name", "SpvOpConvertSampledImageToUNV")]
        ConvertSampledImageToUnv = 0x1514,
        [NativeName("Name", "SpvOpSamplerImageAddressingModeNV")]
        SamplerImageAddressingModeNV = 0x1515,
        [NativeName("Name", "SpvOpRawAccessChainNV")]
        RawAccessChainNV = 0x1516,
        [NativeName("Name", "SpvOpSubgroupShuffleINTEL")]
        SubgroupShuffleIntel = 0x15C3,
        [NativeName("Name", "SpvOpSubgroupShuffleDownINTEL")]
        SubgroupShuffleDownIntel = 0x15C4,
        [NativeName("Name", "SpvOpSubgroupShuffleUpINTEL")]
        SubgroupShuffleUpIntel = 0x15C5,
        [NativeName("Name", "SpvOpSubgroupShuffleXorINTEL")]
        SubgroupShuffleXorIntel = 0x15C6,
        [NativeName("Name", "SpvOpSubgroupBlockReadINTEL")]
        SubgroupBlockReadIntel = 0x15C7,
        [NativeName("Name", "SpvOpSubgroupBlockWriteINTEL")]
        SubgroupBlockWriteIntel = 0x15C8,
        [NativeName("Name", "SpvOpSubgroupImageBlockReadINTEL")]
        SubgroupImageBlockReadIntel = 0x15C9,
        [NativeName("Name", "SpvOpSubgroupImageBlockWriteINTEL")]
        SubgroupImageBlockWriteIntel = 0x15CA,
        [NativeName("Name", "SpvOpSubgroupImageMediaBlockReadINTEL")]
        SubgroupImageMediaBlockReadIntel = 0x15CC,
        [NativeName("Name", "SpvOpSubgroupImageMediaBlockWriteINTEL")]
        SubgroupImageMediaBlockWriteIntel = 0x15CD,
        [NativeName("Name", "SpvOpUCountLeadingZerosINTEL")]
        UCountLeadingZerosIntel = 0x15D1,
        [NativeName("Name", "SpvOpUCountTrailingZerosINTEL")]
        UCountTrailingZerosIntel = 0x15D2,
        [NativeName("Name", "SpvOpAbsISubINTEL")]
        AbsISubIntel = 0x15D3,
        [NativeName("Name", "SpvOpAbsUSubINTEL")]
        AbsUSubIntel = 0x15D4,
        [NativeName("Name", "SpvOpIAddSatINTEL")]
        IAddSatIntel = 0x15D5,
        [NativeName("Name", "SpvOpUAddSatINTEL")]
        UAddSatIntel = 0x15D6,
        [NativeName("Name", "SpvOpIAverageINTEL")]
        IAverageIntel = 0x15D7,
        [NativeName("Name", "SpvOpUAverageINTEL")]
        UAverageIntel = 0x15D8,
        [NativeName("Name", "SpvOpIAverageRoundedINTEL")]
        IAverageRoundedIntel = 0x15D9,
        [NativeName("Name", "SpvOpUAverageRoundedINTEL")]
        UAverageRoundedIntel = 0x15DA,
        [NativeName("Name", "SpvOpISubSatINTEL")]
        ISubSatIntel = 0x15DB,
        [NativeName("Name", "SpvOpUSubSatINTEL")]
        USubSatIntel = 0x15DC,
        [NativeName("Name", "SpvOpIMul32x16INTEL")]
        IMul32x16intel = 0x15DD,
        [NativeName("Name", "SpvOpUMul32x16INTEL")]
        UMul32x16intel = 0x15DE,
        [NativeName("Name", "SpvOpConstantFunctionPointerINTEL")]
        ConstantFunctionPointerIntel = 0x15E0,
        [NativeName("Name", "SpvOpFunctionPointerCallINTEL")]
        FunctionPointerCallIntel = 0x15E1,
        [NativeName("Name", "SpvOpAsmTargetINTEL")]
        AsmTargetIntel = 0x15E9,
        [NativeName("Name", "SpvOpAsmINTEL")]
        AsmIntel = 0x15EA,
        [NativeName("Name", "SpvOpAsmCallINTEL")]
        AsmCallIntel = 0x15EB,
        [NativeName("Name", "SpvOpAtomicFMinEXT")]
        AtomicFMinExt = 0x15EE,
        [NativeName("Name", "SpvOpAtomicFMaxEXT")]
        AtomicFMaxExt = 0x15EF,
        [NativeName("Name", "SpvOpAssumeTrueKHR")]
        AssumeTrueKhr = 0x15FE,
        [NativeName("Name", "SpvOpExpectKHR")]
        ExpectKhr = 0x15FF,
        [NativeName("Name", "SpvOpDecorateString")]
        DecorateString = 0x1600,
        [NativeName("Name", "SpvOpDecorateStringGOOGLE")]
        DecorateStringGoogle = 0x1600,
        [NativeName("Name", "SpvOpMemberDecorateString")]
        MemberDecorateString = 0x1601,
        [NativeName("Name", "SpvOpMemberDecorateStringGOOGLE")]
        MemberDecorateStringGoogle = 0x1601,
        [NativeName("Name", "SpvOpVmeImageINTEL")]
        VmeImageIntel = 0x1643,
        [NativeName("Name", "SpvOpTypeVmeImageINTEL")]
        TypeVmeImageIntel = 0x1644,
        [NativeName("Name", "SpvOpTypeAvcImePayloadINTEL")]
        TypeAvcImePayloadIntel = 0x1645,
        [NativeName("Name", "SpvOpTypeAvcRefPayloadINTEL")]
        TypeAvcRefPayloadIntel = 0x1646,
        [NativeName("Name", "SpvOpTypeAvcSicPayloadINTEL")]
        TypeAvcSicPayloadIntel = 0x1647,
        [NativeName("Name", "SpvOpTypeAvcMcePayloadINTEL")]
        TypeAvcMcePayloadIntel = 0x1648,
        [NativeName("Name", "SpvOpTypeAvcMceResultINTEL")]
        TypeAvcMceResultIntel = 0x1649,
        [NativeName("Name", "SpvOpTypeAvcImeResultINTEL")]
        TypeAvcImeResultIntel = 0x164A,
        [NativeName("Name", "SpvOpTypeAvcImeResultSingleReferenceStreamoutINTEL")]
        TypeAvcImeResultSingleReferenceStreamoutIntel = 0x164B,
        [NativeName("Name", "SpvOpTypeAvcImeResultDualReferenceStreamoutINTEL")]
        TypeAvcImeResultDualReferenceStreamoutIntel = 0x164C,
        [NativeName("Name", "SpvOpTypeAvcImeSingleReferenceStreaminINTEL")]
        TypeAvcImeSingleReferenceStreaminIntel = 0x164D,
        [NativeName("Name", "SpvOpTypeAvcImeDualReferenceStreaminINTEL")]
        TypeAvcImeDualReferenceStreaminIntel = 0x164E,
        [NativeName("Name", "SpvOpTypeAvcRefResultINTEL")]
        TypeAvcRefResultIntel = 0x164F,
        [NativeName("Name", "SpvOpTypeAvcSicResultINTEL")]
        TypeAvcSicResultIntel = 0x1650,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL")]
        SubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyIntel = 0x1651,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL")]
        SubgroupAvcMceSetInterBaseMultiReferencePenaltyIntel = 0x1652,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL")]
        SubgroupAvcMceGetDefaultInterShapePenaltyIntel = 0x1653,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetInterShapePenaltyINTEL")]
        SubgroupAvcMceSetInterShapePenaltyIntel = 0x1654,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL")]
        SubgroupAvcMceGetDefaultInterDirectionPenaltyIntel = 0x1655,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetInterDirectionPenaltyINTEL")]
        SubgroupAvcMceSetInterDirectionPenaltyIntel = 0x1656,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL")]
        SubgroupAvcMceGetDefaultIntraLumaShapePenaltyIntel = 0x1657,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL")]
        SubgroupAvcMceGetDefaultInterMotionVectorCostTableIntel = 0x1658,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL")]
        SubgroupAvcMceGetDefaultHighPenaltyCostTableIntel = 0x1659,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL")]
        SubgroupAvcMceGetDefaultMediumPenaltyCostTableIntel = 0x165A,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL")]
        SubgroupAvcMceGetDefaultLowPenaltyCostTableIntel = 0x165B,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL")]
        SubgroupAvcMceSetMotionVectorCostFunctionIntel = 0x165C,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL")]
        SubgroupAvcMceGetDefaultIntraLumaModePenaltyIntel = 0x165D,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL")]
        SubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyIntel = 0x165E,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL")]
        SubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyIntel = 0x165F,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetAcOnlyHaarINTEL")]
        SubgroupAvcMceSetAcOnlyHaarIntel = 0x1660,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL")]
        SubgroupAvcMceSetSourceInterlacedFieldPolarityIntel = 0x1661,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL")]
        SubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityIntel = 0x1662,
        [NativeName("Name", "SpvOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL")]
        SubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesIntel = 0x1663,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToImePayloadINTEL")]
        SubgroupAvcMceConvertToImePayloadIntel = 0x1664,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToImeResultINTEL")]
        SubgroupAvcMceConvertToImeResultIntel = 0x1665,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToRefPayloadINTEL")]
        SubgroupAvcMceConvertToRefPayloadIntel = 0x1666,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToRefResultINTEL")]
        SubgroupAvcMceConvertToRefResultIntel = 0x1667,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToSicPayloadINTEL")]
        SubgroupAvcMceConvertToSicPayloadIntel = 0x1668,
        [NativeName("Name", "SpvOpSubgroupAvcMceConvertToSicResultINTEL")]
        SubgroupAvcMceConvertToSicResultIntel = 0x1669,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetMotionVectorsINTEL")]
        SubgroupAvcMceGetMotionVectorsIntel = 0x166A,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterDistortionsINTEL")]
        SubgroupAvcMceGetInterDistortionsIntel = 0x166B,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetBestInterDistortionsINTEL")]
        SubgroupAvcMceGetBestInterDistortionsIntel = 0x166C,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterMajorShapeINTEL")]
        SubgroupAvcMceGetInterMajorShapeIntel = 0x166D,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterMinorShapeINTEL")]
        SubgroupAvcMceGetInterMinorShapeIntel = 0x166E,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterDirectionsINTEL")]
        SubgroupAvcMceGetInterDirectionsIntel = 0x166F,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterMotionVectorCountINTEL")]
        SubgroupAvcMceGetInterMotionVectorCountIntel = 0x1670,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterReferenceIdsINTEL")]
        SubgroupAvcMceGetInterReferenceIdsIntel = 0x1671,
        [NativeName("Name", "SpvOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL")]
        SubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesIntel = 0x1672,
        [NativeName("Name", "SpvOpSubgroupAvcImeInitializeINTEL")]
        SubgroupAvcImeInitializeIntel = 0x1673,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetSingleReferenceINTEL")]
        SubgroupAvcImeSetSingleReferenceIntel = 0x1674,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetDualReferenceINTEL")]
        SubgroupAvcImeSetDualReferenceIntel = 0x1675,
        [NativeName("Name", "SpvOpSubgroupAvcImeRefWindowSizeINTEL")]
        SubgroupAvcImeRefWindowSizeIntel = 0x1676,
        [NativeName("Name", "SpvOpSubgroupAvcImeAdjustRefOffsetINTEL")]
        SubgroupAvcImeAdjustRefOffsetIntel = 0x1677,
        [NativeName("Name", "SpvOpSubgroupAvcImeConvertToMcePayloadINTEL")]
        SubgroupAvcImeConvertToMcePayloadIntel = 0x1678,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetMaxMotionVectorCountINTEL")]
        SubgroupAvcImeSetMaxMotionVectorCountIntel = 0x1679,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL")]
        SubgroupAvcImeSetUnidirectionalMixDisableIntel = 0x167A,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL")]
        SubgroupAvcImeSetEarlySearchTerminationThresholdIntel = 0x167B,
        [NativeName("Name", "SpvOpSubgroupAvcImeSetWeightedSadINTEL")]
        SubgroupAvcImeSetWeightedSadIntel = 0x167C,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL")]
        SubgroupAvcImeEvaluateWithSingleReferenceIntel = 0x167D,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithDualReferenceINTEL")]
        SubgroupAvcImeEvaluateWithDualReferenceIntel = 0x167E,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL")]
        SubgroupAvcImeEvaluateWithSingleReferenceStreaminIntel = 0x167F,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL")]
        SubgroupAvcImeEvaluateWithDualReferenceStreaminIntel = 0x1680,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL")]
        SubgroupAvcImeEvaluateWithSingleReferenceStreamoutIntel = 0x1681,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL")]
        SubgroupAvcImeEvaluateWithDualReferenceStreamoutIntel = 0x1682,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL")]
        SubgroupAvcImeEvaluateWithSingleReferenceStreaminoutIntel = 0x1683,
        [NativeName("Name", "SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL")]
        SubgroupAvcImeEvaluateWithDualReferenceStreaminoutIntel = 0x1684,
        [NativeName("Name", "SpvOpSubgroupAvcImeConvertToMceResultINTEL")]
        SubgroupAvcImeConvertToMceResultIntel = 0x1685,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetSingleReferenceStreaminINTEL")]
        SubgroupAvcImeGetSingleReferenceStreaminIntel = 0x1686,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetDualReferenceStreaminINTEL")]
        SubgroupAvcImeGetDualReferenceStreaminIntel = 0x1687,
        [NativeName("Name", "SpvOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL")]
        SubgroupAvcImeStripSingleReferenceStreamoutIntel = 0x1688,
        [NativeName("Name", "SpvOpSubgroupAvcImeStripDualReferenceStreamoutINTEL")]
        SubgroupAvcImeStripDualReferenceStreamoutIntel = 0x1689,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL")]
        SubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsIntel = 0x168A,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL")]
        SubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsIntel = 0x168B,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL")]
        SubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsIntel = 0x168C,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL")]
        SubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsIntel = 0x168D,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL")]
        SubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsIntel = 0x168E,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL")]
        SubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsIntel = 0x168F,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetBorderReachedINTEL")]
        SubgroupAvcImeGetBorderReachedIntel = 0x1690,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL")]
        SubgroupAvcImeGetTruncatedSearchIndicationIntel = 0x1691,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL")]
        SubgroupAvcImeGetUnidirectionalEarlySearchTerminationIntel = 0x1692,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL")]
        SubgroupAvcImeGetWeightingPatternMinimumMotionVectorIntel = 0x1693,
        [NativeName("Name", "SpvOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL")]
        SubgroupAvcImeGetWeightingPatternMinimumDistortionIntel = 0x1694,
        [NativeName("Name", "SpvOpSubgroupAvcFmeInitializeINTEL")]
        SubgroupAvcFmeInitializeIntel = 0x1695,
        [NativeName("Name", "SpvOpSubgroupAvcBmeInitializeINTEL")]
        SubgroupAvcBmeInitializeIntel = 0x1696,
        [NativeName("Name", "SpvOpSubgroupAvcRefConvertToMcePayloadINTEL")]
        SubgroupAvcRefConvertToMcePayloadIntel = 0x1697,
        [NativeName("Name", "SpvOpSubgroupAvcRefSetBidirectionalMixDisableINTEL")]
        SubgroupAvcRefSetBidirectionalMixDisableIntel = 0x1698,
        [NativeName("Name", "SpvOpSubgroupAvcRefSetBilinearFilterEnableINTEL")]
        SubgroupAvcRefSetBilinearFilterEnableIntel = 0x1699,
        [NativeName("Name", "SpvOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL")]
        SubgroupAvcRefEvaluateWithSingleReferenceIntel = 0x169A,
        [NativeName("Name", "SpvOpSubgroupAvcRefEvaluateWithDualReferenceINTEL")]
        SubgroupAvcRefEvaluateWithDualReferenceIntel = 0x169B,
        [NativeName("Name", "SpvOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL")]
        SubgroupAvcRefEvaluateWithMultiReferenceIntel = 0x169C,
        [NativeName("Name", "SpvOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL")]
        SubgroupAvcRefEvaluateWithMultiReferenceInterlacedIntel = 0x169D,
        [NativeName("Name", "SpvOpSubgroupAvcRefConvertToMceResultINTEL")]
        SubgroupAvcRefConvertToMceResultIntel = 0x169E,
        [NativeName("Name", "SpvOpSubgroupAvcSicInitializeINTEL")]
        SubgroupAvcSicInitializeIntel = 0x169F,
        [NativeName("Name", "SpvOpSubgroupAvcSicConfigureSkcINTEL")]
        SubgroupAvcSicConfigureSkcIntel = 0x16A0,
        [NativeName("Name", "SpvOpSubgroupAvcSicConfigureIpeLumaINTEL")]
        SubgroupAvcSicConfigureIpeLumaIntel = 0x16A1,
        [NativeName("Name", "SpvOpSubgroupAvcSicConfigureIpeLumaChromaINTEL")]
        SubgroupAvcSicConfigureIpeLumaChromaIntel = 0x16A2,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetMotionVectorMaskINTEL")]
        SubgroupAvcSicGetMotionVectorMaskIntel = 0x16A3,
        [NativeName("Name", "SpvOpSubgroupAvcSicConvertToMcePayloadINTEL")]
        SubgroupAvcSicConvertToMcePayloadIntel = 0x16A4,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL")]
        SubgroupAvcSicSetIntraLumaShapePenaltyIntel = 0x16A5,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL")]
        SubgroupAvcSicSetIntraLumaModeCostFunctionIntel = 0x16A6,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL")]
        SubgroupAvcSicSetIntraChromaModeCostFunctionIntel = 0x16A7,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetBilinearFilterEnableINTEL")]
        SubgroupAvcSicSetBilinearFilterEnableIntel = 0x16A8,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL")]
        SubgroupAvcSicSetSkcForwardTransformEnableIntel = 0x16A9,
        [NativeName("Name", "SpvOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL")]
        SubgroupAvcSicSetBlockBasedRawSkipSadIntel = 0x16AA,
        [NativeName("Name", "SpvOpSubgroupAvcSicEvaluateIpeINTEL")]
        SubgroupAvcSicEvaluateIpeIntel = 0x16AB,
        [NativeName("Name", "SpvOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL")]
        SubgroupAvcSicEvaluateWithSingleReferenceIntel = 0x16AC,
        [NativeName("Name", "SpvOpSubgroupAvcSicEvaluateWithDualReferenceINTEL")]
        SubgroupAvcSicEvaluateWithDualReferenceIntel = 0x16AD,
        [NativeName("Name", "SpvOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL")]
        SubgroupAvcSicEvaluateWithMultiReferenceIntel = 0x16AE,
        [NativeName("Name", "SpvOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL")]
        SubgroupAvcSicEvaluateWithMultiReferenceInterlacedIntel = 0x16AF,
        [NativeName("Name", "SpvOpSubgroupAvcSicConvertToMceResultINTEL")]
        SubgroupAvcSicConvertToMceResultIntel = 0x16B0,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetIpeLumaShapeINTEL")]
        SubgroupAvcSicGetIpeLumaShapeIntel = 0x16B1,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL")]
        SubgroupAvcSicGetBestIpeLumaDistortionIntel = 0x16B2,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL")]
        SubgroupAvcSicGetBestIpeChromaDistortionIntel = 0x16B3,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetPackedIpeLumaModesINTEL")]
        SubgroupAvcSicGetPackedIpeLumaModesIntel = 0x16B4,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetIpeChromaModeINTEL")]
        SubgroupAvcSicGetIpeChromaModeIntel = 0x16B5,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL")]
        SubgroupAvcSicGetPackedSkcLumaCountThresholdIntel = 0x16B6,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL")]
        SubgroupAvcSicGetPackedSkcLumaSumThresholdIntel = 0x16B7,
        [NativeName("Name", "SpvOpSubgroupAvcSicGetInterRawSadsINTEL")]
        SubgroupAvcSicGetInterRawSadsIntel = 0x16B8,
        [NativeName("Name", "SpvOpVariableLengthArrayINTEL")]
        VariableLengthArrayIntel = 0x16BA,
        [NativeName("Name", "SpvOpSaveMemoryINTEL")]
        SaveMemoryIntel = 0x16BB,
        [NativeName("Name", "SpvOpRestoreMemoryINTEL")]
        RestoreMemoryIntel = 0x16BC,
        [NativeName("Name", "SpvOpArbitraryFloatSinCosPiINTEL")]
        ArbitraryFloatSinCosPiIntel = 0x16D0,
        [NativeName("Name", "SpvOpArbitraryFloatCastINTEL")]
        ArbitraryFloatCastIntel = 0x16D1,
        [NativeName("Name", "SpvOpArbitraryFloatCastFromIntINTEL")]
        ArbitraryFloatCastFromIntIntel = 0x16D2,
        [NativeName("Name", "SpvOpArbitraryFloatCastToIntINTEL")]
        ArbitraryFloatCastToIntIntel = 0x16D3,
        [NativeName("Name", "SpvOpArbitraryFloatAddINTEL")]
        ArbitraryFloatAddIntel = 0x16D6,
        [NativeName("Name", "SpvOpArbitraryFloatSubINTEL")]
        ArbitraryFloatSubIntel = 0x16D7,
        [NativeName("Name", "SpvOpArbitraryFloatMulINTEL")]
        ArbitraryFloatMulIntel = 0x16D8,
        [NativeName("Name", "SpvOpArbitraryFloatDivINTEL")]
        ArbitraryFloatDivIntel = 0x16D9,
        [NativeName("Name", "SpvOpArbitraryFloatGTINTEL")]
        ArbitraryFloatGtintel = 0x16DA,
        [NativeName("Name", "SpvOpArbitraryFloatGEINTEL")]
        ArbitraryFloatGeintel = 0x16DB,
        [NativeName("Name", "SpvOpArbitraryFloatLTINTEL")]
        ArbitraryFloatLtintel = 0x16DC,
        [NativeName("Name", "SpvOpArbitraryFloatLEINTEL")]
        ArbitraryFloatLeintel = 0x16DD,
        [NativeName("Name", "SpvOpArbitraryFloatEQINTEL")]
        ArbitraryFloatEqintel = 0x16DE,
        [NativeName("Name", "SpvOpArbitraryFloatRecipINTEL")]
        ArbitraryFloatRecipIntel = 0x16DF,
        [NativeName("Name", "SpvOpArbitraryFloatRSqrtINTEL")]
        ArbitraryFloatRSqrtIntel = 0x16E0,
        [NativeName("Name", "SpvOpArbitraryFloatCbrtINTEL")]
        ArbitraryFloatCbrtIntel = 0x16E1,
        [NativeName("Name", "SpvOpArbitraryFloatHypotINTEL")]
        ArbitraryFloatHypotIntel = 0x16E2,
        [NativeName("Name", "SpvOpArbitraryFloatSqrtINTEL")]
        ArbitraryFloatSqrtIntel = 0x16E3,
        [NativeName("Name", "SpvOpArbitraryFloatLogINTEL")]
        ArbitraryFloatLogIntel = 0x16E4,
        [NativeName("Name", "SpvOpArbitraryFloatLog2INTEL")]
        ArbitraryFloatLog2intel = 0x16E5,
        [NativeName("Name", "SpvOpArbitraryFloatLog10INTEL")]
        ArbitraryFloatLog10intel = 0x16E6,
        [NativeName("Name", "SpvOpArbitraryFloatLog1pINTEL")]
        ArbitraryFloatLog1pIntel = 0x16E7,
        [NativeName("Name", "SpvOpArbitraryFloatExpINTEL")]
        ArbitraryFloatExpIntel = 0x16E8,
        [NativeName("Name", "SpvOpArbitraryFloatExp2INTEL")]
        ArbitraryFloatExp2intel = 0x16E9,
        [NativeName("Name", "SpvOpArbitraryFloatExp10INTEL")]
        ArbitraryFloatExp10intel = 0x16EA,
        [NativeName("Name", "SpvOpArbitraryFloatExpm1INTEL")]
        ArbitraryFloatExpm1intel = 0x16EB,
        [NativeName("Name", "SpvOpArbitraryFloatSinINTEL")]
        ArbitraryFloatSinIntel = 0x16EC,
        [NativeName("Name", "SpvOpArbitraryFloatCosINTEL")]
        ArbitraryFloatCosIntel = 0x16ED,
        [NativeName("Name", "SpvOpArbitraryFloatSinCosINTEL")]
        ArbitraryFloatSinCosIntel = 0x16EE,
        [NativeName("Name", "SpvOpArbitraryFloatSinPiINTEL")]
        ArbitraryFloatSinPiIntel = 0x16EF,
        [NativeName("Name", "SpvOpArbitraryFloatCosPiINTEL")]
        ArbitraryFloatCosPiIntel = 0x16F0,
        [NativeName("Name", "SpvOpArbitraryFloatASinINTEL")]
        ArbitraryFloatASinIntel = 0x16F1,
        [NativeName("Name", "SpvOpArbitraryFloatASinPiINTEL")]
        ArbitraryFloatASinPiIntel = 0x16F2,
        [NativeName("Name", "SpvOpArbitraryFloatACosINTEL")]
        ArbitraryFloatACosIntel = 0x16F3,
        [NativeName("Name", "SpvOpArbitraryFloatACosPiINTEL")]
        ArbitraryFloatACosPiIntel = 0x16F4,
        [NativeName("Name", "SpvOpArbitraryFloatATanINTEL")]
        ArbitraryFloatATanIntel = 0x16F5,
        [NativeName("Name", "SpvOpArbitraryFloatATanPiINTEL")]
        ArbitraryFloatATanPiIntel = 0x16F6,
        [NativeName("Name", "SpvOpArbitraryFloatATan2INTEL")]
        ArbitraryFloatATan2intel = 0x16F7,
        [NativeName("Name", "SpvOpArbitraryFloatPowINTEL")]
        ArbitraryFloatPowIntel = 0x16F8,
        [NativeName("Name", "SpvOpArbitraryFloatPowRINTEL")]
        ArbitraryFloatPowRintel = 0x16F9,
        [NativeName("Name", "SpvOpArbitraryFloatPowNINTEL")]
        ArbitraryFloatPowNintel = 0x16FA,
        [NativeName("Name", "SpvOpLoopControlINTEL")]
        LoopControlIntel = 0x16FF,
        [NativeName("Name", "SpvOpAliasDomainDeclINTEL")]
        AliasDomainDeclIntel = 0x1717,
        [NativeName("Name", "SpvOpAliasScopeDeclINTEL")]
        AliasScopeDeclIntel = 0x1718,
        [NativeName("Name", "SpvOpAliasScopeListDeclINTEL")]
        AliasScopeListDeclIntel = 0x1719,
        [NativeName("Name", "SpvOpFixedSqrtINTEL")]
        FixedSqrtIntel = 0x1723,
        [NativeName("Name", "SpvOpFixedRecipINTEL")]
        FixedRecipIntel = 0x1724,
        [NativeName("Name", "SpvOpFixedRsqrtINTEL")]
        FixedRsqrtIntel = 0x1725,
        [NativeName("Name", "SpvOpFixedSinINTEL")]
        FixedSinIntel = 0x1726,
        [NativeName("Name", "SpvOpFixedCosINTEL")]
        FixedCosIntel = 0x1727,
        [NativeName("Name", "SpvOpFixedSinCosINTEL")]
        FixedSinCosIntel = 0x1728,
        [NativeName("Name", "SpvOpFixedSinPiINTEL")]
        FixedSinPiIntel = 0x1729,
        [NativeName("Name", "SpvOpFixedCosPiINTEL")]
        FixedCosPiIntel = 0x172A,
        [NativeName("Name", "SpvOpFixedSinCosPiINTEL")]
        FixedSinCosPiIntel = 0x172B,
        [NativeName("Name", "SpvOpFixedLogINTEL")]
        FixedLogIntel = 0x172C,
        [NativeName("Name", "SpvOpFixedExpINTEL")]
        FixedExpIntel = 0x172D,
        [NativeName("Name", "SpvOpPtrCastToCrossWorkgroupINTEL")]
        PtrCastToCrossWorkgroupIntel = 0x172E,
        [NativeName("Name", "SpvOpCrossWorkgroupCastToPtrINTEL")]
        CrossWorkgroupCastToPtrIntel = 0x1732,
        [NativeName("Name", "SpvOpReadPipeBlockingINTEL")]
        ReadPipeBlockingIntel = 0x173A,
        [NativeName("Name", "SpvOpWritePipeBlockingINTEL")]
        WritePipeBlockingIntel = 0x173B,
        [NativeName("Name", "SpvOpFPGARegINTEL")]
        FpgaRegIntel = 0x173D,
        [NativeName("Name", "SpvOpRayQueryGetRayTMinKHR")]
        RayQueryGetRayTMinKhr = 0x1780,
        [NativeName("Name", "SpvOpRayQueryGetRayFlagsKHR")]
        RayQueryGetRayFlagsKhr = 0x1781,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionTKHR")]
        RayQueryGetIntersectionTkhr = 0x1782,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionInstanceCustomIndexKHR")]
        RayQueryGetIntersectionInstanceCustomIndexKhr = 0x1783,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionInstanceIdKHR")]
        RayQueryGetIntersectionInstanceIdKhr = 0x1784,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR")]
        RayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKhr = 0x1785,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionGeometryIndexKHR")]
        RayQueryGetIntersectionGeometryIndexKhr = 0x1786,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionPrimitiveIndexKHR")]
        RayQueryGetIntersectionPrimitiveIndexKhr = 0x1787,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionBarycentricsKHR")]
        RayQueryGetIntersectionBarycentricsKhr = 0x1788,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionFrontFaceKHR")]
        RayQueryGetIntersectionFrontFaceKhr = 0x1789,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionCandidateAABBOpaqueKHR")]
        RayQueryGetIntersectionCandidateAabbOpaqueKhr = 0x178A,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionObjectRayDirectionKHR")]
        RayQueryGetIntersectionObjectRayDirectionKhr = 0x178B,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionObjectRayOriginKHR")]
        RayQueryGetIntersectionObjectRayOriginKhr = 0x178C,
        [NativeName("Name", "SpvOpRayQueryGetWorldRayDirectionKHR")]
        RayQueryGetWorldRayDirectionKhr = 0x178D,
        [NativeName("Name", "SpvOpRayQueryGetWorldRayOriginKHR")]
        RayQueryGetWorldRayOriginKhr = 0x178E,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionObjectToWorldKHR")]
        RayQueryGetIntersectionObjectToWorldKhr = 0x178F,
        [NativeName("Name", "SpvOpRayQueryGetIntersectionWorldToObjectKHR")]
        RayQueryGetIntersectionWorldToObjectKhr = 0x1790,
        [NativeName("Name", "SpvOpAtomicFAddEXT")]
        AtomicFAddExt = 0x1793,
        [NativeName("Name", "SpvOpTypeBufferSurfaceINTEL")]
        TypeBufferSurfaceIntel = 0x17C6,
        [NativeName("Name", "SpvOpTypeStructContinuedINTEL")]
        TypeStructContinuedIntel = 0x17CA,
        [NativeName("Name", "SpvOpConstantCompositeContinuedINTEL")]
        ConstantCompositeContinuedIntel = 0x17CB,
        [NativeName("Name", "SpvOpSpecConstantCompositeContinuedINTEL")]
        SpecConstantCompositeContinuedIntel = 0x17CC,
        [NativeName("Name", "SpvOpCompositeConstructContinuedINTEL")]
        CompositeConstructContinuedIntel = 0x17D0,
        [NativeName("Name", "SpvOpConvertFToBF16INTEL")]
        ConvertFToBF16intel = 0x17E4,
        [NativeName("Name", "SpvOpConvertBF16ToFINTEL")]
        ConvertBF16ToFintel = 0x17E5,
        [NativeName("Name", "SpvOpControlBarrierArriveINTEL")]
        ControlBarrierArriveIntel = 0x17FE,
        [NativeName("Name", "SpvOpControlBarrierWaitINTEL")]
        ControlBarrierWaitIntel = 0x17FF,
        [NativeName("Name", "SpvOpSubgroupBlockPrefetchINTEL")]
        SubgroupBlockPrefetchIntel = 0x184D,
        [NativeName("Name", "SpvOpGroupIMulKHR")]
        GroupIMulKhr = 0x1901,
        [NativeName("Name", "SpvOpGroupFMulKHR")]
        GroupFMulKhr = 0x1902,
        [NativeName("Name", "SpvOpGroupBitwiseAndKHR")]
        GroupBitwiseAndKhr = 0x1903,
        [NativeName("Name", "SpvOpGroupBitwiseOrKHR")]
        GroupBitwiseOrKhr = 0x1904,
        [NativeName("Name", "SpvOpGroupBitwiseXorKHR")]
        GroupBitwiseXorKhr = 0x1905,
        [NativeName("Name", "SpvOpGroupLogicalAndKHR")]
        GroupLogicalAndKhr = 0x1906,
        [NativeName("Name", "SpvOpGroupLogicalOrKHR")]
        GroupLogicalOrKhr = 0x1907,
        [NativeName("Name", "SpvOpGroupLogicalXorKHR")]
        GroupLogicalXorKhr = 0x1908,
        [NativeName("Name", "SpvOpMaskedGatherINTEL")]
        MaskedGatherIntel = 0x191C,
        [NativeName("Name", "SpvOpMaskedScatterINTEL")]
        MaskedScatterIntel = 0x191D,
        [NativeName("Name", "SpvOpMax")]
        Max = 0x7FFFFFFF,
    }
}
