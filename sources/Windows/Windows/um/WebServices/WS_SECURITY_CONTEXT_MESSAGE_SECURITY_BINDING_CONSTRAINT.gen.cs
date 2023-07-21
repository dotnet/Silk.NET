// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT"]/*' />
public unsafe partial struct WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT
{
    /// <include file='WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.bindingConstraint"]/*' />
    public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;

    /// <include file='WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.bindingUsage"]/*' />
    public WS_MESSAGE_SECURITY_USAGE bindingUsage;

    /// <include file='WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT.bootstrapSecurityConstraint"]/*' />
    public WS_SECURITY_CONSTRAINTS* bootstrapSecurityConstraint;
}
