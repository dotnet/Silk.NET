// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_ENDPOINT_POLICY_EXTENSION
{
    public WS_POLICY_EXTENSION policyExtension;
    public WS_XML_STRING* assertionName;
    public WS_XML_STRING* assertionNs;

    [NativeTypeName("__AnonymousRecord_WebServices_L6349_C5")]
    public _out_e__Struct @out;

    public unsafe partial struct _out_e__Struct
    {
        [NativeTypeName("WS_XML_BUFFER*")]
        public void* assertionValue;
    }
}
