// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DXGI_INFO_QUEUE_MESSAGE
{
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.Producer"]/*'/>
    [NativeTypeName("DXGI_DEBUG_ID")]
    public Guid Producer;
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.Category"]/*'/>
    public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.Severity"]/*'/>
    public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.ID"]/*'/>
    [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")]
    public int ID;
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.pDescription"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* pDescription;
    /// <include file='DXGI_INFO_QUEUE_MESSAGE.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE.DescriptionByteLength"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}