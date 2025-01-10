// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIDEVICEOBJECTDATA
{
    [NativeTypeName("DWORD")]
    public uint dwOfs;

    [NativeTypeName("DWORD")]
    public uint dwData;

    [NativeTypeName("DWORD")]
    public uint dwTimeStamp;

    [NativeTypeName("DWORD")]
    public uint dwSequence;

    [NativeTypeName("UINT_PTR")]
    public nuint uAppData;
}
