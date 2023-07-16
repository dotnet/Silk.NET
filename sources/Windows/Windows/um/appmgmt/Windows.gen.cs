// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InstallApplication"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InstallApplication([NativeTypeName("PINSTALLDATA")] INSTALLDATA* pInstallInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninstallApplication"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint UninstallApplication([NativeTypeName("LPWSTR")] ushort* ProductCode, [NativeTypeName("DWORD")] uint dwStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CommandLineFromMsiDescriptor"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CommandLineFromMsiDescriptor([NativeTypeName("LPWSTR")] ushort* Descriptor, [NativeTypeName("LPWSTR")] ushort* CommandLine, [NativeTypeName("DWORD *")] uint* CommandLineLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetManagedApplications"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetManagedApplications(Guid* pCategory, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPDWORD")] uint* pdwApps, [NativeTypeName("PMANAGEDAPPLICATION *")] MANAGEDAPPLICATION** prgManagedApps);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLocalManagedApplications"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLocalManagedApplications(BOOL bUserApps, [NativeTypeName("LPDWORD")] uint* pdwApps, [NativeTypeName("PLOCALMANAGEDAPPLICATION *")] LOCALMANAGEDAPPLICATION** prgLocalApps);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLocalManagedApplicationData"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void GetLocalManagedApplicationData([NativeTypeName("LPWSTR")] ushort* ProductCode, [NativeTypeName("LPWSTR *")] ushort** DisplayName, [NativeTypeName("LPWSTR *")] ushort** SupportUrl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetManagedApplicationCategories"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetManagedApplicationCategories([NativeTypeName("DWORD")] uint dwReserved, APPCATEGORYINFOLIST* pAppCategory);
    [NativeTypeName("#define LOCALSTATE_ASSIGNED 0x1")]
    public const int LOCALSTATE_ASSIGNED = 0x1;
    [NativeTypeName("#define LOCALSTATE_PUBLISHED 0x2")]
    public const int LOCALSTATE_PUBLISHED = 0x2;
    [NativeTypeName("#define LOCALSTATE_UNINSTALL_UNMANAGED 0x4")]
    public const int LOCALSTATE_UNINSTALL_UNMANAGED = 0x4;
    [NativeTypeName("#define LOCALSTATE_POLICYREMOVE_ORPHAN 0x8")]
    public const int LOCALSTATE_POLICYREMOVE_ORPHAN = 0x8;
    [NativeTypeName("#define LOCALSTATE_POLICYREMOVE_UNINSTALL 0x10")]
    public const int LOCALSTATE_POLICYREMOVE_UNINSTALL = 0x10;
    [NativeTypeName("#define LOCALSTATE_ORPHANED 0x20")]
    public const int LOCALSTATE_ORPHANED = 0x20;
    [NativeTypeName("#define LOCALSTATE_UNINSTALLED 0x40")]
    public const int LOCALSTATE_UNINSTALLED = 0x40;
    [NativeTypeName("#define MANAGED_APPS_USERAPPLICATIONS 0x1")]
    public const int MANAGED_APPS_USERAPPLICATIONS = 0x1;
    [NativeTypeName("#define MANAGED_APPS_FROMCATEGORY 0x2")]
    public const int MANAGED_APPS_FROMCATEGORY = 0x2;
    [NativeTypeName("#define MANAGED_APPS_INFOLEVEL_DEFAULT 0x10000")]
    public const int MANAGED_APPS_INFOLEVEL_DEFAULT = 0x10000;
    [NativeTypeName("#define MANAGED_APPTYPE_WINDOWSINSTALLER 0x1")]
    public const int MANAGED_APPTYPE_WINDOWSINSTALLER = 0x1;
    [NativeTypeName("#define MANAGED_APPTYPE_SETUPEXE 0x2")]
    public const int MANAGED_APPTYPE_SETUPEXE = 0x2;
    [NativeTypeName("#define MANAGED_APPTYPE_UNSUPPORTED 0x3")]
    public const int MANAGED_APPTYPE_UNSUPPORTED = 0x3;
}