// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BIN_COUNT.xml' path='doc/member[@name="BIN_COUNT"]/*'/>
public partial struct BIN_COUNT
{
    /// <include file='BIN_COUNT.xml' path='doc/member[@name="BIN_COUNT.BinRange"]/*'/>
    public BIN_RANGE BinRange;
    /// <include file='BIN_COUNT.xml' path='doc/member[@name="BIN_COUNT.BinCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BinCount;
}