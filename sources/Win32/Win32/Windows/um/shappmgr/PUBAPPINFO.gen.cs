// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PUBAPPINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSource;
    public SYSTEMTIME stAssigned;
    public SYSTEMTIME stPublished;
    public SYSTEMTIME stScheduled;
    public SYSTEMTIME stExpire;
}
