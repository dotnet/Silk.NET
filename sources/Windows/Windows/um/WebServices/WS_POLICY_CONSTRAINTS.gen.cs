// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS"]/*'/>
public unsafe partial struct WS_POLICY_CONSTRAINTS
{
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.channelBinding"]/*'/>
    public WS_CHANNEL_BINDING channelBinding;
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.channelPropertyConstraints"]/*'/>
    public WS_CHANNEL_PROPERTY_CONSTRAINT* channelPropertyConstraints;
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.channelPropertyConstraintCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint channelPropertyConstraintCount;
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.securityConstraints"]/*'/>
    public WS_SECURITY_CONSTRAINTS* securityConstraints;
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.policyExtensions"]/*'/>
    public WS_POLICY_EXTENSION** policyExtensions;
    /// <include file='WS_POLICY_CONSTRAINTS.xml' path='doc/member[@name="WS_POLICY_CONSTRAINTS.policyExtensionCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint policyExtensionCount;
}