// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KCRM_MARSHAL_HEADER
{
    [NativeTypeName("ULONG")]
    public uint VersionMajor;

    [NativeTypeName("ULONG")]
    public uint VersionMinor;

    [NativeTypeName("ULONG")]
    public uint NumProtocols;

    [NativeTypeName("ULONG")]
    public uint Unused;
}
