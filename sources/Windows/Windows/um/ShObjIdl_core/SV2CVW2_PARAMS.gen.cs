// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS"]/*'/>
public unsafe partial struct SV2CVW2_PARAMS
{
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.psvPrev"]/*'/>
    public IShellView* psvPrev;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.pfs"]/*'/>
    [NativeTypeName("LPCFOLDERSETTINGS")]
    public FOLDERSETTINGS* pfs;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.psbOwner"]/*'/>
    public IShellBrowser* psbOwner;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.prcView"]/*'/>
    public RECT* prcView;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.pvid"]/*'/>
    [NativeTypeName("const SHELLVIEWID *")]
    public Guid* pvid;
    /// <include file='SV2CVW2_PARAMS.xml' path='doc/member[@name="SV2CVW2_PARAMS.hwndView"]/*'/>
    public HWND hwndView;
}