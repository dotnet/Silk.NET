// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/asyncinfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.WinRT;
/// <include file='AsyncStatus.xml' path='doc/member[@name="AsyncStatus"]/*'/>
public enum AsyncStatus
{
    /// <include file='AsyncStatus.xml' path='doc/member[@name="AsyncStatus.Started"]/*'/>
    Started = 0,
    /// <include file='AsyncStatus.xml' path='doc/member[@name="AsyncStatus.Completed"]/*'/>
    Completed,
    /// <include file='AsyncStatus.xml' path='doc/member[@name="AsyncStatus.Canceled"]/*'/>
    Canceled,
    /// <include file='AsyncStatus.xml' path='doc/member[@name="AsyncStatus.Error"]/*'/>
    Error,
}