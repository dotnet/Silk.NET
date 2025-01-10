// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct KNOWNFOLDER_DEFINITION
{
    public KF_CATEGORY category;

    [NativeTypeName("LPWSTR")]
    public ushort* pszName;

    [NativeTypeName("LPWSTR")]
    public ushort* pszDescription;

    [NativeTypeName("KNOWNFOLDERID")]
    public Guid fidParent;

    [NativeTypeName("LPWSTR")]
    public ushort* pszRelativePath;

    [NativeTypeName("LPWSTR")]
    public ushort* pszParsingName;

    [NativeTypeName("LPWSTR")]
    public ushort* pszTooltip;

    [NativeTypeName("LPWSTR")]
    public ushort* pszLocalizedName;

    [NativeTypeName("LPWSTR")]
    public ushort* pszIcon;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSecurity;

    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    [NativeTypeName("KF_DEFINITION_FLAGS")]
    public uint kfdFlags;

    [NativeTypeName("FOLDERTYPEID")]
    public Guid ftidType;
}
