// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct COMPOSITIONSTRING
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCompReadAttrLen;

    [NativeTypeName("DWORD")]
    public uint dwCompReadAttrOffset;

    [NativeTypeName("DWORD")]
    public uint dwCompReadClauseLen;

    [NativeTypeName("DWORD")]
    public uint dwCompReadClauseOffset;

    [NativeTypeName("DWORD")]
    public uint dwCompReadStrLen;

    [NativeTypeName("DWORD")]
    public uint dwCompReadStrOffset;

    [NativeTypeName("DWORD")]
    public uint dwCompAttrLen;

    [NativeTypeName("DWORD")]
    public uint dwCompAttrOffset;

    [NativeTypeName("DWORD")]
    public uint dwCompClauseLen;

    [NativeTypeName("DWORD")]
    public uint dwCompClauseOffset;

    [NativeTypeName("DWORD")]
    public uint dwCompStrLen;

    [NativeTypeName("DWORD")]
    public uint dwCompStrOffset;

    [NativeTypeName("DWORD")]
    public uint dwCursorPos;

    [NativeTypeName("DWORD")]
    public uint dwDeltaStart;

    [NativeTypeName("DWORD")]
    public uint dwResultReadClauseLen;

    [NativeTypeName("DWORD")]
    public uint dwResultReadClauseOffset;

    [NativeTypeName("DWORD")]
    public uint dwResultReadStrLen;

    [NativeTypeName("DWORD")]
    public uint dwResultReadStrOffset;

    [NativeTypeName("DWORD")]
    public uint dwResultClauseLen;

    [NativeTypeName("DWORD")]
    public uint dwResultClauseOffset;

    [NativeTypeName("DWORD")]
    public uint dwResultStrLen;

    [NativeTypeName("DWORD")]
    public uint dwResultStrOffset;

    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;
}
