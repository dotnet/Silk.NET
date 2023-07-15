// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/winstring.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsCreateString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsCreateString([NativeTypeName("PCNZWCH")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, HSTRING* @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsCreateStringReference"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsCreateStringReference([NativeTypeName("PCWSTR")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, HSTRING_HEADER* hstringHeader, HSTRING* @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsDeleteString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsDeleteString(HSTRING @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsDuplicateString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsDuplicateString(HSTRING @string, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsGetStringLen"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    [return: NativeTypeName("UINT32")]
    public static extern uint WindowsGetStringLen(HSTRING @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsGetStringRawBuffer"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* WindowsGetStringRawBuffer(HSTRING @string, [NativeTypeName("UINT32 *")] uint* length);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsIsStringEmpty"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL WindowsIsStringEmpty(HSTRING @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsStringHasEmbeddedNull"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsStringHasEmbeddedNull(HSTRING @string, BOOL* hasEmbedNull);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsCompareStringOrdinal"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsCompareStringOrdinal(HSTRING string1, HSTRING string2, [NativeTypeName("INT32 *")] int* result);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsSubstring"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsSubstring(HSTRING @string, [NativeTypeName("UINT32")] uint startIndex, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsSubstringWithSpecifiedLength"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsSubstringWithSpecifiedLength(HSTRING @string, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint length, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsConcatString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsConcatString(HSTRING string1, HSTRING string2, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsReplaceString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsReplaceString(HSTRING @string, HSTRING stringReplaced, HSTRING stringReplaceWith, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsTrimStringStart"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsTrimStringStart(HSTRING @string, HSTRING trimString, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsTrimStringEnd"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsTrimStringEnd(HSTRING @string, HSTRING trimString, HSTRING* newString);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsPreallocateStringBuffer"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsPreallocateStringBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("WCHAR **")] ushort** charBuffer, HSTRING_BUFFER* bufferHandle);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsPromoteStringBuffer"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsPromoteStringBuffer(HSTRING_BUFFER bufferHandle, HSTRING* @string);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsDeleteStringBuffer"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsDeleteStringBuffer(HSTRING_BUFFER bufferHandle);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsInspectString"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsInspectString([NativeTypeName("UINT_PTR")] nuint targetHString, ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> callback, void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT_PTR *")] nuint* targetStringAddress);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WindowsInspectString2"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT WindowsInspectString2([NativeTypeName("UINT64")] ulong targetHString, ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK2")] delegate* unmanaged<void*, ulong, uint, byte*, HRESULT> callback, void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT64 *")] ulong* targetStringAddress);
}