// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SchGetExtensionsOptions.xml' path='doc/member[@name="SchGetExtensionsOptions"]/*' />
[Flags]
public enum SchGetExtensionsOptions
{
    /// <include file='SchGetExtensionsOptions.xml' path='doc/member[@name="SchGetExtensionsOptions.SCH_EXTENSIONS_OPTIONS_NONE"]/*' />
    SCH_EXTENSIONS_OPTIONS_NONE = 0x0,

    /// <include file='SchGetExtensionsOptions.xml' path='doc/member[@name="SchGetExtensionsOptions.SCH_NO_RECORD_HEADER"]/*' />
    SCH_NO_RECORD_HEADER = 0x1,
}
