// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct INTLIST
{
    public int iValueCount;

    [NativeTypeName("int[402]")]
    public _iValues_e__FixedBuffer iValues;

    [InlineArray(402)]
    public partial struct _iValues_e__FixedBuffer
    {
        public int e0;
    }
}
