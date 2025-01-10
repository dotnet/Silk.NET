// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct XML_ERROR
{
    [NativeTypeName("unsigned int")]
    public uint _nLine;

    [NativeTypeName("BSTR")]
    public ushort* _pchBuf;

    [NativeTypeName("unsigned int")]
    public uint _cchBuf;

    [NativeTypeName("unsigned int")]
    public uint _ich;

    [NativeTypeName("BSTR")]
    public ushort* _pszFound;

    [NativeTypeName("BSTR")]
    public ushort* _pszExpected;

    [NativeTypeName("DWORD")]
    public uint _reserved1;

    [NativeTypeName("DWORD")]
    public uint _reserved2;
}
