// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG"]/*'/>
[Flags]
public enum DXGI_ADAPTER_FLAG
{
    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_NONE"]/*'/>
    DXGI_ADAPTER_FLAG_NONE = 0,
    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_REMOTE"]/*'/>
    DXGI_ADAPTER_FLAG_REMOTE = 1,
    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_SOFTWARE"]/*'/>
    DXGI_ADAPTER_FLAG_SOFTWARE = 2,
    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_FORCE_DWORD"]/*'/>
    DXGI_ADAPTER_FLAG_FORCE_DWORD = unchecked((int)(0xffffffff)),
}