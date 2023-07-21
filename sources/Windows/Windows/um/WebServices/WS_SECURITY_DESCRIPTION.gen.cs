// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_DESCRIPTION.xml' path='doc/member[@name="WS_SECURITY_DESCRIPTION"]/*' />
public unsafe partial struct WS_SECURITY_DESCRIPTION
{
    /// <include file='WS_SECURITY_DESCRIPTION.xml' path='doc/member[@name="WS_SECURITY_DESCRIPTION.securityBindings"]/*' />
    public WS_SECURITY_BINDING** securityBindings;

    /// <include file='WS_SECURITY_DESCRIPTION.xml' path='doc/member[@name="WS_SECURITY_DESCRIPTION.securityBindingCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint securityBindingCount;

    /// <include file='WS_SECURITY_DESCRIPTION.xml' path='doc/member[@name="WS_SECURITY_DESCRIPTION.properties"]/*' />
    public WS_SECURITY_PROPERTY* properties;

    /// <include file='WS_SECURITY_DESCRIPTION.xml' path='doc/member[@name="WS_SECURITY_DESCRIPTION.propertyCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint propertyCount;
}
