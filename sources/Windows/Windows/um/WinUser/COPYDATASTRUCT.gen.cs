// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COPYDATASTRUCT.xml' path='doc/member[@name="COPYDATASTRUCT"]/*'/>
public unsafe partial struct COPYDATASTRUCT
{
    /// <include file='COPYDATASTRUCT.xml' path='doc/member[@name="COPYDATASTRUCT.dwData"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwData;
    /// <include file='COPYDATASTRUCT.xml' path='doc/member[@name="COPYDATASTRUCT.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='COPYDATASTRUCT.xml' path='doc/member[@name="COPYDATASTRUCT.lpData"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpData;
}