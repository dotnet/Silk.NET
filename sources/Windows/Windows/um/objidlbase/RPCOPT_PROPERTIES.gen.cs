// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES"]/*'/>
public enum RPCOPT_PROPERTIES
{
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RPCTIMEOUT"]/*'/>
    COMBND_RPCTIMEOUT = 0x1,
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_SERVER_LOCALITY"]/*'/>
    COMBND_SERVER_LOCALITY = 0x2,
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED1"]/*'/>
    COMBND_RESERVED1 = 0x4,
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED2"]/*'/>
    COMBND_RESERVED2 = 0x5,
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED3"]/*'/>
    COMBND_RESERVED3 = 0x8,
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED4"]/*'/>
    COMBND_RESERVED4 = 0x10,
}