// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT D3DDisassemble11Trace(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3D11ShaderTrace pTrace,
        uint StartStep,
        uint NumSteps,
        uint Flags,
        [NativeTypeName("struct ID3D10Blob **")] ID3DBlob* ppDisassembly
    );
}
