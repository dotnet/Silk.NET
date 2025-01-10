// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/winstring.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsCreateString(
        [NativeTypeName("PCNZWCH")] ushort* sourceString,
        [NativeTypeName("UINT32")] uint length,
        HSTRING* @string
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsCreateStringReference(
        [NativeTypeName("PCWSTR")] ushort* sourceString,
        [NativeTypeName("UINT32")] uint length,
        HSTRING_HEADER* hstringHeader,
        HSTRING* @string
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsDeleteString(HSTRING @string);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsDuplicateString(HSTRING @string, HSTRING* newString);

    [DllImport("combase", ExactSpelling = true)]
    [return: NativeTypeName("UINT32")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WindowsGetStringLen(HSTRING @string);

    [DllImport("combase", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    [SupportedOSPlatform("windows6.2")]
    public static extern ushort* WindowsGetStringRawBuffer(
        HSTRING @string,
        [NativeTypeName("UINT32 *")] uint* length
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL WindowsIsStringEmpty(HSTRING @string);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsStringHasEmbeddedNull(HSTRING @string, BOOL* hasEmbedNull);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsCompareStringOrdinal(
        HSTRING string1,
        HSTRING string2,
        [NativeTypeName("INT32 *")] int* result
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsSubstring(
        HSTRING @string,
        [NativeTypeName("UINT32")] uint startIndex,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsSubstringWithSpecifiedLength(
        HSTRING @string,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint length,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsConcatString(
        HSTRING string1,
        HSTRING string2,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsReplaceString(
        HSTRING @string,
        HSTRING stringReplaced,
        HSTRING stringReplaceWith,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsTrimStringStart(
        HSTRING @string,
        HSTRING trimString,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsTrimStringEnd(
        HSTRING @string,
        HSTRING trimString,
        HSTRING* newString
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsPreallocateStringBuffer(
        [NativeTypeName("UINT32")] uint length,
        [NativeTypeName("WCHAR **")] ushort** charBuffer,
        HSTRING_BUFFER* bufferHandle
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsPromoteStringBuffer(
        HSTRING_BUFFER bufferHandle,
        HSTRING* @string
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsDeleteStringBuffer(HSTRING_BUFFER bufferHandle);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsInspectString(
        [NativeTypeName("UINT_PTR")] nuint targetHString,
        ushort machine,
        [NativeTypeName("PINSPECT_HSTRING_CALLBACK")]
            delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> callback,
        void* context,
        [NativeTypeName("UINT32 *")] uint* length,
        [NativeTypeName("UINT_PTR *")] nuint* targetStringAddress
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WindowsInspectString2(
        [NativeTypeName("UINT64")] ulong targetHString,
        ushort machine,
        [NativeTypeName("PINSPECT_HSTRING_CALLBACK2")]
            delegate* unmanaged<void*, ulong, uint, byte*, HRESULT> callback,
        void* context,
        [NativeTypeName("UINT32 *")] uint* length,
        [NativeTypeName("UINT64 *")] ulong* targetStringAddress
    );
}
