// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHANGER_EXCHANGE_MEDIUM
{
    public CHANGER_ELEMENT Transport;
    public CHANGER_ELEMENT Source;
    public CHANGER_ELEMENT Destination1;
    public CHANGER_ELEMENT Destination2;

    [NativeTypeName("BOOLEAN")]
    public byte Flip1;

    [NativeTypeName("BOOLEAN")]
    public byte Flip2;
}
