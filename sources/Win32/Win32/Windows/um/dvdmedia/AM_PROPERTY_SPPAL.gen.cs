// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AM_PROPERTY_SPPAL
{
    [NativeTypeName("AM_DVD_YUV[16]")]
    public _sppal_e__FixedBuffer sppal;

    [InlineArray(16)]
    public partial struct _sppal_e__FixedBuffer
    {
        public AM_DVD_YUV e0;
    }
}
