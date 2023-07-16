// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE"]/*'/>
public enum EC_VARIANT_TYPE
{
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarTypeNull"]/*'/>
    EcVarTypeNull = 0,
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarTypeBoolean"]/*'/>
    EcVarTypeBoolean,
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarTypeUInt32"]/*'/>
    EcVarTypeUInt32,
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarTypeDateTime"]/*'/>
    EcVarTypeDateTime,
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarTypeString"]/*'/>
    EcVarTypeString,
    /// <include file='EC_VARIANT_TYPE.xml' path='doc/member[@name="EC_VARIANT_TYPE.EcVarObjectArrayPropertyHandle"]/*'/>
    EcVarObjectArrayPropertyHandle,
}