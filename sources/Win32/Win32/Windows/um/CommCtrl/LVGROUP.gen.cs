// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct LVGROUP
{
    public uint cbSize;
    public uint mask;

    [NativeTypeName("LPWSTR")]
    public ushort* pszHeader;
    public int cchHeader;

    [NativeTypeName("LPWSTR")]
    public ushort* pszFooter;
    public int cchFooter;
    public int iGroupId;
    public uint stateMask;
    public uint state;
    public uint uAlign;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSubtitle;
    public uint cchSubtitle;

    [NativeTypeName("LPWSTR")]
    public ushort* pszTask;
    public uint cchTask;

    [NativeTypeName("LPWSTR")]
    public ushort* pszDescriptionTop;
    public uint cchDescriptionTop;

    [NativeTypeName("LPWSTR")]
    public ushort* pszDescriptionBottom;
    public uint cchDescriptionBottom;
    public int iTitleImage;
    public int iExtendedImage;
    public int iFirstItem;
    public uint cItems;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSubsetTitle;
    public uint cchSubsetTitle;
}
