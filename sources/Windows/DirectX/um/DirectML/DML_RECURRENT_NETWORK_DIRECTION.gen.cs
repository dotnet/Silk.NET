// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION"]/*'/>
public enum DML_RECURRENT_NETWORK_DIRECTION
{
    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_FORWARD"]/*'/>
    DML_RECURRENT_NETWORK_DIRECTION_FORWARD,
    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BACKWARD"]/*'/>
    DML_RECURRENT_NETWORK_DIRECTION_BACKWARD,
    /// <include file='DML_RECURRENT_NETWORK_DIRECTION.xml' path='doc/member[@name="DML_RECURRENT_NETWORK_DIRECTION.DML_RECURRENT_NETWORK_DIRECTION_BIDIRECTIONAL"]/*'/>
    DML_RECURRENT_NETWORK_DIRECTION_BIDIRECTIONAL,
}