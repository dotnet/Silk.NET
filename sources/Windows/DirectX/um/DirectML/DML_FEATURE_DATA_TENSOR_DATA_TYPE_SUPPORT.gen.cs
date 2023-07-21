// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DML_FEATURE_DATA_TENSOR_DATA_TYPE_SUPPORT.xml' path='doc/member[@name="DML_FEATURE_DATA_TENSOR_DATA_TYPE_SUPPORT"]/*' />
public partial struct DML_FEATURE_DATA_TENSOR_DATA_TYPE_SUPPORT
{
    /// <include file='DML_FEATURE_DATA_TENSOR_DATA_TYPE_SUPPORT.xml' path='doc/member[@name="DML_FEATURE_DATA_TENSOR_DATA_TYPE_SUPPORT.IsSupported"]/*' />
    public BOOL IsSupported;
}
