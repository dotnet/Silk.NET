// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT
{
    public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;
    public WS_MESSAGE_SECURITY_USAGE bindingUsage;
    public WS_XML_STRING* claimConstraints;

    [NativeTypeName("ULONG")]
    public uint claimConstraintCount;
    public WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT* requestSecurityTokenPropertyConstraints;

    [NativeTypeName("ULONG")]
    public uint requestSecurityTokenPropertyConstraintCount;

    [NativeTypeName("__AnonymousRecord_WebServices_L6262_C5")]
    public _out_e__Struct @out;

    public unsafe partial struct _out_e__Struct
    {
        public WS_ENDPOINT_ADDRESS* issuerAddress;

        [NativeTypeName("WS_XML_BUFFER*")]
        public void* requestSecurityTokenTemplate;
    }
}
