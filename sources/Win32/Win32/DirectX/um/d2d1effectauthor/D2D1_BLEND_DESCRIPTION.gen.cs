// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_BLEND_DESCRIPTION
{
    public D2D1_BLEND sourceBlend;
    public D2D1_BLEND destinationBlend;
    public D2D1_BLEND_OPERATION blendOperation;
    public D2D1_BLEND sourceBlendAlpha;
    public D2D1_BLEND destinationBlendAlpha;
    public D2D1_BLEND_OPERATION blendOperationAlpha;

    [NativeTypeName("FLOAT[4]")]
    public _blendFactor_e__FixedBuffer blendFactor;

    [InlineArray(4)]
    public partial struct _blendFactor_e__FixedBuffer
    {
        public float e0;
    }
}
