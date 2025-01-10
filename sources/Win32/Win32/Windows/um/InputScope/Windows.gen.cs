// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScope(HWND hwnd, InputScope inputscope);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopes(
        HWND hwnd,
        [NativeTypeName("const InputScope *")] InputScope* pInputScopes,
        uint cInputScopes,
        [NativeTypeName("PWSTR *")] ushort** ppszPhraseList,
        uint cPhrases,
        [NativeTypeName("PWSTR")] ushort* pszRegExp,
        [NativeTypeName("PWSTR")] ushort* pszSRGS
    );

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopeXML(
        HWND hwnd,
        [NativeTypeName("PWSTR")] ushort* pszXML
    );

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopes2(
        HWND hwnd,
        [NativeTypeName("const InputScope *")] InputScope* pInputScopes,
        uint cInputScopes,
        IEnumString pEnumString,
        [NativeTypeName("PWSTR")] ushort* pszRegExp,
        [NativeTypeName("PWSTR")] ushort* pszSRGS
    );
}
