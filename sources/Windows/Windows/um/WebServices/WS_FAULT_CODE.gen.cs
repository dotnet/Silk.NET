// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_FAULT_CODE.xml' path='doc/member[@name="WS_FAULT_CODE"]/*'/>
public unsafe partial struct WS_FAULT_CODE
{
    /// <include file='WS_FAULT_CODE.xml' path='doc/member[@name="WS_FAULT_CODE.value"]/*'/>
    public WS_XML_QNAME value;
    /// <include file='WS_FAULT_CODE.xml' path='doc/member[@name="WS_FAULT_CODE.subCode"]/*'/>
    [NativeTypeName("struct _WS_FAULT_CODE *")]
    public WS_FAULT_CODE* subCode;
}