// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OUTPUT_DEBUG_STRING_INFO
{
    [NativeTypeName("LPSTR")]
    public sbyte* lpDebugStringData;

    [NativeTypeName("WORD")]
    public ushort fUnicode;

    [NativeTypeName("WORD")]
    public ushort nDebugStringLength;
}
