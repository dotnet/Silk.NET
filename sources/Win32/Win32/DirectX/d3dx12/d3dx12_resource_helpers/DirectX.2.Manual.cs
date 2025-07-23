// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_TEXTURE_LAYOUT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12ResourceDesc0ToDesc1"]/*'/>

    public static D3D12_RESOURCE_DESC1 D3DX12ResourceDesc0ToDesc1(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] D3D12_RESOURCE_DESC* desc0
    )
    {
        D3D12_RESOURCE_DESC1 desc1 = new D3D12_RESOURCE_DESC1()
        {
            Dimension = desc0->Dimension,
            Alignment = desc0->Alignment,
            Width = desc0->Width,
            Height = desc0->Height,
            DepthOrArraySize = desc0->DepthOrArraySize,
            MipLevels = desc0->MipLevels,
            Format = desc0->Format,
            SampleDesc = new DXGI_SAMPLE_DESC
            {
                Count = desc0->SampleDesc.Count,
                Quality = desc0->SampleDesc.Quality,
            },
            Layout = desc0->Layout,
            Flags = desc0->Flags,
            SamplerFeedbackMipRegion = new D3D12_MIP_REGION
            {
                Width = 0,
                Height = 0,
                Depth = 0,
            },
        };
        return desc1;
    }
}
