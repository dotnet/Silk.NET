// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DML_ONE_HOT_OPERATOR_DESC.xml' path='doc/member[@name="DML_ONE_HOT_OPERATOR_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DML_ONE_HOT_OPERATOR_DESC
{
    /// <include file='DML_ONE_HOT_OPERATOR_DESC.xml' path='doc/member[@name="DML_ONE_HOT_OPERATOR_DESC.IndicesTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* IndicesTensor;
    /// <include file='DML_ONE_HOT_OPERATOR_DESC.xml' path='doc/member[@name="DML_ONE_HOT_OPERATOR_DESC.ValuesTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ValuesTensor;
    /// <include file='DML_ONE_HOT_OPERATOR_DESC.xml' path='doc/member[@name="DML_ONE_HOT_OPERATOR_DESC.OutputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
    /// <include file='DML_ONE_HOT_OPERATOR_DESC.xml' path='doc/member[@name="DML_ONE_HOT_OPERATOR_DESC.Axis"]/*'/>
    public uint Axis;
}