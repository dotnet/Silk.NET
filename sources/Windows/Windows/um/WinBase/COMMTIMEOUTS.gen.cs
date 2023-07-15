// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS"]/*'/>
public partial struct COMMTIMEOUTS
{
    /// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS.ReadIntervalTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReadIntervalTimeout;
    /// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS.ReadTotalTimeoutMultiplier"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReadTotalTimeoutMultiplier;
    /// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS.ReadTotalTimeoutConstant"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReadTotalTimeoutConstant;
    /// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS.WriteTotalTimeoutMultiplier"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WriteTotalTimeoutMultiplier;
    /// <include file='COMMTIMEOUTS.xml' path='doc/member[@name="COMMTIMEOUTS.WriteTotalTimeoutConstant"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WriteTotalTimeoutConstant;
}