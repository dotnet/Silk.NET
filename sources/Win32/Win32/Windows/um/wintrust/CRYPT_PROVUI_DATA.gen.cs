// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PROVUI_DATA
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwFinalError;

    [NativeTypeName("WCHAR *")]
    public ushort* pYesButtonText;

    [NativeTypeName("WCHAR *")]
    public ushort* pNoButtonText;

    [NativeTypeName("WCHAR *")]
    public ushort* pMoreInfoButtonText;

    [NativeTypeName("WCHAR *")]
    public ushort* pAdvancedLinkText;

    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionText;

    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionTextNoTS;

    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionTextNotSigned;
}
