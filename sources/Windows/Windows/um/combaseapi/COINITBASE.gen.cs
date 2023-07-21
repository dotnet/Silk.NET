// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='COINITBASE.xml' path='doc/member[@name="COINITBASE"]/*' />
[Flags]
public enum COINITBASE
{
    /// <include file='COINITBASE.xml' path='doc/member[@name="COINITBASE.COINITBASE_MULTITHREADED"]/*' />
    COINITBASE_MULTITHREADED = 0x0,
}
