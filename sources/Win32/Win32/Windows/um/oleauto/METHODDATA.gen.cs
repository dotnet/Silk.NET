// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct METHODDATA
{
    [NativeTypeName("OLECHAR *")]
    public ushort* szName;
    public PARAMDATA* ppdata;

    [NativeTypeName("DISPID")]
    public int dispid;
    public uint iMeth;
    public CALLCONV cc;
    public uint cArgs;

    [NativeTypeName("WORD")]
    public ushort wFlags;

    [NativeTypeName("VARTYPE")]
    public ushort vtReturn;
}
