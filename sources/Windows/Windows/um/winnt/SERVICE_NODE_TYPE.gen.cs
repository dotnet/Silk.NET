// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE"]/*'/>
[Flags]
public enum SERVICE_NODE_TYPE
{
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.DriverType"]/*'/>
    DriverType = 0x00000001,
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.FileSystemType"]/*'/>
    FileSystemType = 0x00000002,
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.Win32ServiceOwnProcess"]/*'/>
    Win32ServiceOwnProcess = 0x00000010,
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.Win32ServiceShareProcess"]/*'/>
    Win32ServiceShareProcess = 0x00000020,
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.AdapterType"]/*'/>
    AdapterType = 0x00000004,
    /// <include file='SERVICE_NODE_TYPE.xml' path='doc/member[@name="SERVICE_NODE_TYPE.RecognizerType"]/*'/>
    RecognizerType = 0x00000008,
}