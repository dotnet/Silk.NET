// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_GAMMA_CONTROL
{
    public DXGI_RGB Scale;
    public DXGI_RGB Offset;

    [NativeTypeName("DXGI_RGB[1025]")]
    public _GammaCurve_e__FixedBuffer GammaCurve;

    [InlineArray(1025)]
    public partial struct _GammaCurve_e__FixedBuffer
    {
        public DXGI_RGB e0;
    }
}
