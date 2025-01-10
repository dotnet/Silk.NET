// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGEHLP_SYMBOL_PACKAGE
{
    public IMAGEHLP_SYMBOL sym;

    [NativeTypeName("CHAR[2001]")]
    public _name_e__FixedBuffer name;

    [InlineArray(2001)]
    public partial struct _name_e__FixedBuffer
    {
        public sbyte e0;
    }
}
