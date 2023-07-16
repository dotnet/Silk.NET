// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RPCOPT_SERVER_LOCALITY_VALUES.xml' path='doc/member[@name="RPCOPT_SERVER_LOCALITY_VALUES"]/*'/>
public enum RPCOPT_SERVER_LOCALITY_VALUES
{
    /// <include file='RPCOPT_SERVER_LOCALITY_VALUES.xml' path='doc/member[@name="RPCOPT_SERVER_LOCALITY_VALUES.SERVER_LOCALITY_PROCESS_LOCAL"]/*'/>
    SERVER_LOCALITY_PROCESS_LOCAL = 0,
    /// <include file='RPCOPT_SERVER_LOCALITY_VALUES.xml' path='doc/member[@name="RPCOPT_SERVER_LOCALITY_VALUES.SERVER_LOCALITY_MACHINE_LOCAL"]/*'/>
    SERVER_LOCALITY_MACHINE_LOCAL = 1,
    /// <include file='RPCOPT_SERVER_LOCALITY_VALUES.xml' path='doc/member[@name="RPCOPT_SERVER_LOCALITY_VALUES.SERVER_LOCALITY_REMOTE"]/*'/>
    SERVER_LOCALITY_REMOTE = 2,
}