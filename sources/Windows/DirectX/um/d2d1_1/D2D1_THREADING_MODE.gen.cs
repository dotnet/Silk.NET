// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.DirectX.D2D1_FACTORY_TYPE;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_THREADING_MODE.xml' path='doc/member[@name="D2D1_THREADING_MODE"]/*'/>
public enum D2D1_THREADING_MODE
{
    /// <include file='D2D1_THREADING_MODE.xml' path='doc/member[@name="D2D1_THREADING_MODE.D2D1_THREADING_MODE_SINGLE_THREADED"]/*'/>
    D2D1_THREADING_MODE_SINGLE_THREADED = D2D1_FACTORY_TYPE_SINGLE_THREADED,
    /// <include file='D2D1_THREADING_MODE.xml' path='doc/member[@name="D2D1_THREADING_MODE.D2D1_THREADING_MODE_MULTI_THREADED"]/*'/>
    D2D1_THREADING_MODE_MULTI_THREADED = D2D1_FACTORY_TYPE_MULTI_THREADED,
    /// <include file='D2D1_THREADING_MODE.xml' path='doc/member[@name="D2D1_THREADING_MODE.D2D1_THREADING_MODE_FORCE_DWORD"]/*'/>
    D2D1_THREADING_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}