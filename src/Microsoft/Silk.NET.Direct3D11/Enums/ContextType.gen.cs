// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CONTEXT_TYPE")]
    public enum ContextType : int
    {
        [Obsolete("Deprecated in favour of \"TypeAll\"")]
        [NativeName("Name", "D3D11_CONTEXT_TYPE_ALL")]
        ContextTypeAll = 0x0,
        [Obsolete("Deprecated in favour of \"Type3D\"")]
        [NativeName("Name", "D3D11_CONTEXT_TYPE_3D")]
        ContextType3D = 0x1,
        [Obsolete("Deprecated in favour of \"TypeCompute\"")]
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COMPUTE")]
        ContextTypeCompute = 0x2,
        [Obsolete("Deprecated in favour of \"TypeCopy\"")]
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COPY")]
        ContextTypeCopy = 0x3,
        [Obsolete("Deprecated in favour of \"TypeVideo\"")]
        [NativeName("Name", "D3D11_CONTEXT_TYPE_VIDEO")]
        ContextTypeVideo = 0x4,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_ALL")]
        TypeAll = 0x0,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_3D")]
        Type3D = 0x1,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COMPUTE")]
        TypeCompute = 0x2,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COPY")]
        TypeCopy = 0x3,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_VIDEO")]
        TypeVideo = 0x4,
    }
}
