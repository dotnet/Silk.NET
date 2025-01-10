// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/Wsdevlicensing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT CheckDeveloperLicense(FILETIME* pExpiration);

    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT AcquireDeveloperLicense(HWND hwndParent, FILETIME* pExpiration);

    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT RemoveDeveloperLicense(HWND hwndParent);
}
