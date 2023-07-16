// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/Wsdevlicensing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CheckDeveloperLicense"]/*'/>
    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT CheckDeveloperLicense(FILETIME* pExpiration);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.AcquireDeveloperLicense"]/*'/>
    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT AcquireDeveloperLicense(HWND hwndParent, FILETIME* pExpiration);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RemoveDeveloperLicense"]/*'/>
    [DllImport("wsclient", ExactSpelling = true)]
    public static extern HRESULT RemoveDeveloperLicense(HWND hwndParent);
}