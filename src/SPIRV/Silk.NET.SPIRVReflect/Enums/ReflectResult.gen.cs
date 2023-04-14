// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectResult")]
    public enum ReflectResult : int
    {
        [NativeName("Name", "SPV_REFLECT_RESULT_SUCCESS")]
        Success = 0x0,
        [NativeName("Name", "SPV_REFLECT_RESULT_NOT_READY")]
        NotReady = 0x1,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_PARSE_FAILED")]
        ErrorParseFailed = 0x2,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_ALLOC_FAILED")]
        ErrorAllocFailed = 0x3,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_RANGE_EXCEEDED")]
        ErrorRangeExceeded = 0x4,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_NULL_POINTER")]
        ErrorNullPointer = 0x5,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_INTERNAL_ERROR")]
        ErrorInternalError = 0x6,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_COUNT_MISMATCH")]
        ErrorCountMismatch = 0x7,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_ELEMENT_NOT_FOUND")]
        ErrorElementNotFound = 0x8,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_CODE_SIZE")]
        ErrorSpirvInvalidCodeSize = 0x9,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_MAGIC_NUMBER")]
        ErrorSpirvInvalidMagicNumber = 0xA,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_UNEXPECTED_EOF")]
        ErrorSpirvUnexpectedEof = 0xB,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_ID_REFERENCE")]
        ErrorSpirvInvalidIDReference = 0xC,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_SET_NUMBER_OVERFLOW")]
        ErrorSpirvSetNumberOverflow = 0xD,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_STORAGE_CLASS")]
        ErrorSpirvInvalidStorageClass = 0xE,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_RECURSION")]
        ErrorSpirvRecursion = 0xF,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_INSTRUCTION")]
        ErrorSpirvInvalidInstruction = 0x10,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_UNEXPECTED_BLOCK_DATA")]
        ErrorSpirvUnexpectedBlockData = 0x11,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_BLOCK_MEMBER_REFERENCE")]
        ErrorSpirvInvalidBlockMemberReference = 0x12,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_ENTRY_POINT")]
        ErrorSpirvInvalidEntryPoint = 0x13,
        [NativeName("Name", "SPV_REFLECT_RESULT_ERROR_SPIRV_INVALID_EXECUTION_MODE")]
        ErrorSpirvInvalidExecutionMode = 0x14,
    }
}
