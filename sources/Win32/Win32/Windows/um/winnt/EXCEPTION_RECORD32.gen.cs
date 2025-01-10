// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EXCEPTION_RECORD32
{
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;

    [NativeTypeName("DWORD")]
    public uint ExceptionFlags;

    [NativeTypeName("DWORD")]
    public uint ExceptionRecord;

    [NativeTypeName("DWORD")]
    public uint ExceptionAddress;

    [NativeTypeName("DWORD")]
    public uint NumberParameters;

    [NativeTypeName("DWORD[15]")]
    public _ExceptionInformation_e__FixedBuffer ExceptionInformation;

    [InlineArray(15)]
    public partial struct _ExceptionInformation_e__FixedBuffer
    {
        public uint e0;
    }
}
