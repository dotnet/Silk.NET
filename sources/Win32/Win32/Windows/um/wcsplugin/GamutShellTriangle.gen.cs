// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct GamutShellTriangle
{
    [NativeTypeName("UINT[3]")]
    public _aVertexIndex_e__FixedBuffer aVertexIndex;

    [InlineArray(3)]
    public partial struct _aVertexIndex_e__FixedBuffer
    {
        public uint e0;
    }
}
