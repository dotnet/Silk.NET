// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NMCBEDRAGBEGINA
{
    public NMHDR hdr;
    public int iItemid;

    [NativeTypeName("char[260]")]
    public _szText_e__FixedBuffer szText;

    [InlineArray(260)]
    public partial struct _szText_e__FixedBuffer
    {
        public sbyte e0;
    }
}
