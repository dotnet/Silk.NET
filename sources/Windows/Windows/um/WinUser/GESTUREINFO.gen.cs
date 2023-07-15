// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO"]/*'/>
public partial struct GESTUREINFO
{
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.dwID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwID;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.hwndTarget"]/*'/>
    public HWND hwndTarget;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.ptsLocation"]/*'/>
    public POINTS ptsLocation;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.dwInstanceID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInstanceID;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.dwSequenceID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSequenceID;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.ullArguments"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullArguments;
    /// <include file='GESTUREINFO.xml' path='doc/member[@name="GESTUREINFO.cbExtraArgs"]/*'/>
    public uint cbExtraArgs;
}