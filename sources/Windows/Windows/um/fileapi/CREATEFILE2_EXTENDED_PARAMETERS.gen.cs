// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CREATEFILE2_EXTENDED_PARAMETERS
{
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwFileFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileFlags;
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwSecurityQosFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSecurityQosFlags;
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.lpSecurityAttributes"]/*'/>
    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpSecurityAttributes;
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.hTemplateFile"]/*'/>
    public HANDLE hTemplateFile;
}