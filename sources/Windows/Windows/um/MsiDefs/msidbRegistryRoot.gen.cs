// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='msidbRegistryRoot.xml' path='doc/member[@name="msidbRegistryRoot"]/*' />
public enum msidbRegistryRoot
{
    /// <include file='msidbRegistryRoot.xml' path='doc/member[@name="msidbRegistryRoot.msidbRegistryRootClassesRoot"]/*' />
    msidbRegistryRootClassesRoot = 0,

    /// <include file='msidbRegistryRoot.xml' path='doc/member[@name="msidbRegistryRoot.msidbRegistryRootCurrentUser"]/*' />
    msidbRegistryRootCurrentUser = 1,

    /// <include file='msidbRegistryRoot.xml' path='doc/member[@name="msidbRegistryRoot.msidbRegistryRootLocalMachine"]/*' />
    msidbRegistryRootLocalMachine = 2,

    /// <include file='msidbRegistryRoot.xml' path='doc/member[@name="msidbRegistryRoot.msidbRegistryRootUsers"]/*' />
    msidbRegistryRootUsers = 3,
}
