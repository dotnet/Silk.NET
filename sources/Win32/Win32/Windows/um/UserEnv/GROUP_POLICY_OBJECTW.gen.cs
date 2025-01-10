// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct GROUP_POLICY_OBJECTW
{
    [NativeTypeName("DWORD")]
    public uint dwOptions;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("LPWSTR")]
    public ushort* lpDSPath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpFileSysPath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpDisplayName;

    [NativeTypeName("WCHAR[50]")]
    public _szGPOName_e__FixedBuffer szGPOName;
    public GPO_LINK GPOLink;
    public LPARAM lParam;

    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pNext;

    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pPrev;

    [NativeTypeName("LPWSTR")]
    public ushort* lpExtensions;
    public LPARAM lParam2;

    [NativeTypeName("LPWSTR")]
    public ushort* lpLink;

    [InlineArray(50)]
    public partial struct _szGPOName_e__FixedBuffer
    {
        public ushort e0;
    }
}
