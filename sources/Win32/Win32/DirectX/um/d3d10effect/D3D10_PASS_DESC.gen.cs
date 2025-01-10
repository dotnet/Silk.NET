// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D10_PASS_DESC
{
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    public uint Annotations;
    public byte* pIAInputSignature;

    [NativeTypeName("SIZE_T")]
    public nuint IAInputSignatureSize;
    public uint StencilRef;
    public uint SampleMask;

    [NativeTypeName("FLOAT[4]")]
    public _BlendFactor_e__FixedBuffer BlendFactor;

    [InlineArray(4)]
    public partial struct _BlendFactor_e__FixedBuffer
    {
        public float e0;
    }
}
