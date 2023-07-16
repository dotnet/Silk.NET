// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WSL_DISTRIBUTION_FLAGS.xml' path='doc/member[@name="WSL_DISTRIBUTION_FLAGS"]/*'/>
[Flags]
public enum WSL_DISTRIBUTION_FLAGS
{
    /// <include file='WSL_DISTRIBUTION_FLAGS.xml' path='doc/member[@name="WSL_DISTRIBUTION_FLAGS.WSL_DISTRIBUTION_FLAGS_NONE"]/*'/>
    WSL_DISTRIBUTION_FLAGS_NONE = 0x0,
    /// <include file='WSL_DISTRIBUTION_FLAGS.xml' path='doc/member[@name="WSL_DISTRIBUTION_FLAGS.WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP"]/*'/>
    WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP = 0x1,
    /// <include file='WSL_DISTRIBUTION_FLAGS.xml' path='doc/member[@name="WSL_DISTRIBUTION_FLAGS.WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH"]/*'/>
    WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH = 0x2,
    /// <include file='WSL_DISTRIBUTION_FLAGS.xml' path='doc/member[@name="WSL_DISTRIBUTION_FLAGS.WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING"]/*'/>
    WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING = 0x4,
}