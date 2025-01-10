// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DML_TENSOR_DATA_TYPE
{
    DML_TENSOR_DATA_TYPE_UNKNOWN,
    DML_TENSOR_DATA_TYPE_FLOAT32,
    DML_TENSOR_DATA_TYPE_FLOAT16,
    DML_TENSOR_DATA_TYPE_UINT32,
    DML_TENSOR_DATA_TYPE_UINT16,
    DML_TENSOR_DATA_TYPE_UINT8,
    DML_TENSOR_DATA_TYPE_INT32,
    DML_TENSOR_DATA_TYPE_INT16,
    DML_TENSOR_DATA_TYPE_INT8,
    DML_TENSOR_DATA_TYPE_FLOAT64,
    DML_TENSOR_DATA_TYPE_UINT64,
    DML_TENSOR_DATA_TYPE_INT64,
}
