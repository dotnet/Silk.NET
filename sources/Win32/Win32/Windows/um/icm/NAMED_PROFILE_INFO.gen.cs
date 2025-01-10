// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NAMED_PROFILE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwCount;

    [NativeTypeName("DWORD")]
    public uint dwCountDevCoordinates;

    [NativeTypeName("COLOR_NAME")]
    public _szPrefix_e__FixedBuffer szPrefix;

    [NativeTypeName("COLOR_NAME")]
    public _szSuffix_e__FixedBuffer szSuffix;

    [InlineArray(32)]
    public partial struct _szPrefix_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(32)]
    public partial struct _szSuffix_e__FixedBuffer
    {
        public sbyte e0;
    }
}
