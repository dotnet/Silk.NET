// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3"]/*'/>
[Flags]
public enum DXGI_ADAPTER_FLAG3
{
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_NONE"]/*'/>
    DXGI_ADAPTER_FLAG3_NONE = 0,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_REMOTE"]/*'/>
    DXGI_ADAPTER_FLAG3_REMOTE = 1,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SOFTWARE"]/*'/>
    DXGI_ADAPTER_FLAG3_SOFTWARE = 2,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE"]/*'/>
    DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE = 4,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES"]/*'/>
    DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES = 8,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES"]/*'/>
    DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES = 0x10,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE"]/*'/>
    DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE = 0x20,
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_FORCE_DWORD"]/*'/>
    DXGI_ADAPTER_FLAG3_FORCE_DWORD = unchecked((int)(0xffffffff)),
}