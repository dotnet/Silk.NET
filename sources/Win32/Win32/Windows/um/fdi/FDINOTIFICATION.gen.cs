// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FDINOTIFICATION
{
    [NativeTypeName("long")]
    public int cb;

    [NativeTypeName("char *")]
    public sbyte* psz1;

    [NativeTypeName("char *")]
    public sbyte* psz2;

    [NativeTypeName("char *")]
    public sbyte* psz3;
    public void* pv;

    [NativeTypeName("INT_PTR")]
    public nint hf;
    public ushort date;
    public ushort time;
    public ushort attribs;
    public ushort setID;
    public ushort iCabinet;
    public ushort iFolder;
    public FDIERROR fdie;
}
