// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DICONFIGUREDEVICESPARAMSA
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwcUsers;

    [NativeTypeName("LPSTR")]
    public sbyte* lptszUserNames;

    [NativeTypeName("DWORD")]
    public uint dwcFormats;

    [NativeTypeName("LPDIACTIONFORMATA")]
    public DIACTIONFORMATA* lprgFormats;
    public HWND hwnd;
    public DICOLORSET dics;
    public IUnknown lpUnkDDSTarget;
}
