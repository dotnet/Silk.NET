// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYMSRV_EXTENDED_OUTPUT_DATA
{
    [NativeTypeName("DWORD")]
    public uint sizeOfStruct;

    [NativeTypeName("DWORD")]
    public uint version;

    [NativeTypeName("WCHAR[261]")]
    public _filePtrMsg_e__FixedBuffer filePtrMsg;

    [InlineArray(261)]
    public partial struct _filePtrMsg_e__FixedBuffer
    {
        public ushort e0;
    }
}
