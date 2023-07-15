// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS"]/*'/>
public enum EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS
{
    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.EcRuntimeStatusActiveStatusDisabled"]/*'/>
    EcRuntimeStatusActiveStatusDisabled = 1,
    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.EcRuntimeStatusActiveStatusActive"]/*'/>
    EcRuntimeStatusActiveStatusActive,
    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.EcRuntimeStatusActiveStatusInactive"]/*'/>
    EcRuntimeStatusActiveStatusInactive,
    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_ACTIVE_STATUS.EcRuntimeStatusActiveStatusTrying"]/*'/>
    EcRuntimeStatusActiveStatusTrying,
}