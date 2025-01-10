// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PIN_INFO
{
    public IBaseFilter pFilter;
    public PIN_DIRECTION dir;

    [NativeTypeName("WCHAR[128]")]
    public _achName_e__FixedBuffer achName;

    [InlineArray(128)]
    public partial struct _achName_e__FixedBuffer
    {
        public ushort e0;
    }
}
