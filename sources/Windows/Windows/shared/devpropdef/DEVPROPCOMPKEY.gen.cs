// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVPROPCOMPKEY.xml' path='doc/member[@name="DEVPROPCOMPKEY"]/*' />
public unsafe partial struct DEVPROPCOMPKEY
{
    /// <include file='DEVPROPCOMPKEY.xml' path='doc/member[@name="DEVPROPCOMPKEY.Key"]/*' />
    public DEVPROPKEY Key;

    /// <include file='DEVPROPCOMPKEY.xml' path='doc/member[@name="DEVPROPCOMPKEY.Store"]/*' />
    public DEVPROPSTORE Store;

    /// <include file='DEVPROPCOMPKEY.xml' path='doc/member[@name="DEVPROPCOMPKEY.LocaleName"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* LocaleName;
}
