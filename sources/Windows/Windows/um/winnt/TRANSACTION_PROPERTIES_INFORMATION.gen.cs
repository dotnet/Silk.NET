// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION"]/*'/>
public unsafe partial struct TRANSACTION_PROPERTIES_INFORMATION
{
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.IsolationLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IsolationLevel;
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.IsolationFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IsolationFlags;
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Timeout"]/*'/>
    public LARGE_INTEGER Timeout;
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Outcome"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Outcome;
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.DescriptionLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DescriptionLength;
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Description"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Description[1];
}