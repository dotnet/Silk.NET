// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_ORIGINAL_FILE_INFO_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("CHAR[260]")]
    public _OriginalInfName_e__FixedBuffer OriginalInfName;

    [NativeTypeName("CHAR[260]")]
    public _OriginalCatalogName_e__FixedBuffer OriginalCatalogName;

    [InlineArray(260)]
    public partial struct _OriginalInfName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _OriginalCatalogName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
