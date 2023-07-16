// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS"]/*'/>
public enum PROCESSINFOCLASS
{
    /// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS.ProcessBasicInformation"]/*'/>
    ProcessBasicInformation = 0,
    /// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS.ProcessDebugPort"]/*'/>
    ProcessDebugPort = 7,
    /// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS.ProcessWow64Information"]/*'/>
    ProcessWow64Information = 26,
    /// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS.ProcessImageFileName"]/*'/>
    ProcessImageFileName = 27,
    /// <include file='PROCESSINFOCLASS.xml' path='doc/member[@name="PROCESSINFOCLASS.ProcessBreakOnTermination"]/*'/>
    ProcessBreakOnTermination = 29,
}