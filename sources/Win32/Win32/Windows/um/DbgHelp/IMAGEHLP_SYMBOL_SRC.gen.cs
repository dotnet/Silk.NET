// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGEHLP_SYMBOL_SRC
{
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;

    [NativeTypeName("DWORD")]
    public uint type;

    [NativeTypeName("char[260]")]
    public _file_e__FixedBuffer file;

    [InlineArray(260)]
    public partial struct _file_e__FixedBuffer
    {
        public sbyte e0;
    }
}
