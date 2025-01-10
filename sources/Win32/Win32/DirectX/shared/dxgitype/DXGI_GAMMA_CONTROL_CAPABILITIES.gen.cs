// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
{
    public BOOL ScaleAndOffsetSupported;
    public float MaxConvertedValue;
    public float MinConvertedValue;
    public uint NumGammaControlPoints;

    [NativeTypeName("float[1025]")]
    public _ControlPointPositions_e__FixedBuffer ControlPointPositions;

    [InlineArray(1025)]
    public partial struct _ControlPointPositions_e__FixedBuffer
    {
        public float e0;
    }
}
