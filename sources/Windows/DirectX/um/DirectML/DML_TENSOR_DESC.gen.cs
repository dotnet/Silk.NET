// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC"]/*' />
public unsafe partial struct DML_TENSOR_DESC
{
    /// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC.Type"]/*' />
    public DML_TENSOR_TYPE Type;

    /// <include file='DML_TENSOR_DESC.xml' path='doc/member[@name="DML_TENSOR_DESC.Desc"]/*' />
    [NativeTypeName("const void *")]
    public void* Desc;
}
