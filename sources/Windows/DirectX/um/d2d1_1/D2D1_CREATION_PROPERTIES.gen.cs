// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_CREATION_PROPERTIES.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES"]/*'/>
public partial struct D2D1_CREATION_PROPERTIES
{
    /// <include file='D2D1_CREATION_PROPERTIES.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES.threadingMode"]/*'/>
    public D2D1_THREADING_MODE threadingMode;
    /// <include file='D2D1_CREATION_PROPERTIES.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES.debugLevel"]/*'/>
    public D2D1_DEBUG_LEVEL debugLevel;
    /// <include file='D2D1_CREATION_PROPERTIES.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES.options"]/*'/>
    public D2D1_DEVICE_CONTEXT_OPTIONS options;
}