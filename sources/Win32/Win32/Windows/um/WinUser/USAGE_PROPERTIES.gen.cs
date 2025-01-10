// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct USAGE_PROPERTIES
{
    public ushort level;
    public ushort page;
    public ushort usage;

    [NativeTypeName("INT32")]
    public int logicalMinimum;

    [NativeTypeName("INT32")]
    public int logicalMaximum;
    public ushort unit;
    public ushort exponent;
    public byte count;

    [NativeTypeName("INT32")]
    public int physicalMinimum;

    [NativeTypeName("INT32")]
    public int physicalMaximum;
}
