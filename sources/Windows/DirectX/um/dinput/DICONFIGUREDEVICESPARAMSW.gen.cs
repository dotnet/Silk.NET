// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW"]/*'/>
public unsafe partial struct DICONFIGUREDEVICESPARAMSW
{
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.dwcUsers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcUsers;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.lptszUserNames"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lptszUserNames;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.dwcFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcFormats;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.lprgFormats"]/*'/>
    [NativeTypeName("LPDIACTIONFORMATW")]
    public DIACTIONFORMATW* lprgFormats;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.dics"]/*'/>
    public DICOLORSET dics;
    /// <include file='DICONFIGUREDEVICESPARAMSW.xml' path='doc/member[@name="DICONFIGUREDEVICESPARAMSW.lpUnkDDSTarget"]/*'/>
    public IUnknown* lpUnkDDSTarget;
}