// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_GRID_FIT_MODE.xml' path='doc/member[@name="DWRITE_GRID_FIT_MODE"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum DWRITE_GRID_FIT_MODE
{
    /// <include file='DWRITE_GRID_FIT_MODE.xml' path='doc/member[@name="DWRITE_GRID_FIT_MODE.DWRITE_GRID_FIT_MODE_DEFAULT"]/*'/>
    DWRITE_GRID_FIT_MODE_DEFAULT,
    /// <include file='DWRITE_GRID_FIT_MODE.xml' path='doc/member[@name="DWRITE_GRID_FIT_MODE.DWRITE_GRID_FIT_MODE_DISABLED"]/*'/>
    DWRITE_GRID_FIT_MODE_DISABLED,
    /// <include file='DWRITE_GRID_FIT_MODE.xml' path='doc/member[@name="DWRITE_GRID_FIT_MODE.DWRITE_GRID_FIT_MODE_ENABLED"]/*'/>
    DWRITE_GRID_FIT_MODE_ENABLED,
}