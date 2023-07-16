// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA"]/*'/>
public unsafe partial struct DICONFIGUREDEVICESPARAMSA
{
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.dwcUsers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcUsers;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.lptszUserNames"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lptszUserNames;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.dwcFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcFormats;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.lprgFormats"]/*'/>
    [NativeTypeName("LPDIACTIONFORMATA")]
    public DIACTIONFORMATA* lprgFormats;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.dics"]/*'/>
    public DICOLORSET dics;
    /// <include file='DICONFIGUREDEVICESPARAMSA.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSA.lpUnkDDSTarget"]/*'/>
    public IUnknown* lpUnkDDSTarget;
}