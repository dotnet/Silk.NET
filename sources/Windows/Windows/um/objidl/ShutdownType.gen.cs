// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ShutdownType.xml' path='doc/member[@name="ShutdownType"]/*'/>
public enum ShutdownType
{
    /// <include file='ShutdownType.xml' path='doc/member[@name="ShutdownType.IdleShutdown"]/*'/>
    IdleShutdown = 0,
    /// <include file='ShutdownType.xml' path='doc/member[@name="ShutdownType.ForcedShutdown"]/*'/>
    ForcedShutdown = (IdleShutdown + 1),
}