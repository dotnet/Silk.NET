// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT"]/*'/>
public unsafe partial struct WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT
{
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.bindingConstraint"]/*'/>
    public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.bindingUsage"]/*'/>
    public WS_MESSAGE_SECURITY_USAGE bindingUsage;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.claimConstraints"]/*'/>
    public WS_XML_STRING* claimConstraints;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.claimConstraintCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint claimConstraintCount;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.requestSecurityTokenPropertyConstraints"]/*'/>
    public WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT* requestSecurityTokenPropertyConstraints;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.requestSecurityTokenPropertyConstraintCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint requestSecurityTokenPropertyConstraintCount;
    /// <include file='WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT.@out"]/*'/>
    [NativeTypeName("__AnonymousRecord_WebServices_L6262_C5")]
    public _out_e__Struct @out;
    /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct"]/*'/>
    public unsafe partial struct _out_e__Struct
    {
        /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct.issuerAddress"]/*'/>
        public WS_ENDPOINT_ADDRESS* issuerAddress;
        /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct.requestSecurityTokenTemplate"]/*'/>
        [NativeTypeName("WS_XML_BUFFER*")]
        public IntPtr requestSecurityTokenTemplate;
    }
}