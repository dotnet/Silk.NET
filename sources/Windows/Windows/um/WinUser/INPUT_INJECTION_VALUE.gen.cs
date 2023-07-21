// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INPUT_INJECTION_VALUE.xml' path='doc/member[@name="INPUT_INJECTION_VALUE"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct INPUT_INJECTION_VALUE
{
    /// <include file='INPUT_INJECTION_VALUE.xml' path='doc/member[@name="INPUT_INJECTION_VALUE.page"]/*' />
    public ushort page;

    /// <include file='INPUT_INJECTION_VALUE.xml' path='doc/member[@name="INPUT_INJECTION_VALUE.usage"]/*' />
    public ushort usage;

    /// <include file='INPUT_INJECTION_VALUE.xml' path='doc/member[@name="INPUT_INJECTION_VALUE.value"]/*' />
    [NativeTypeName("INT32")]
    public int value;

    /// <include file='INPUT_INJECTION_VALUE.xml' path='doc/member[@name="INPUT_INJECTION_VALUE.index"]/*' />
    public ushort index;
}
