// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='COMPOSITION_FRAME_ID_TYPE.xml' path='doc/member[@name="COMPOSITION_FRAME_ID_TYPE"]/*'/>
public enum COMPOSITION_FRAME_ID_TYPE
{
    /// <include file='COMPOSITION_FRAME_ID_TYPE.xml' path='doc/member[@name="COMPOSITION_FRAME_ID_TYPE.COMPOSITION_FRAME_ID_CREATED"]/*'/>
    COMPOSITION_FRAME_ID_CREATED = 0,
    /// <include file='COMPOSITION_FRAME_ID_TYPE.xml' path='doc/member[@name="COMPOSITION_FRAME_ID_TYPE.COMPOSITION_FRAME_ID_CONFIRMED"]/*'/>
    COMPOSITION_FRAME_ID_CONFIRMED = 1,
    /// <include file='COMPOSITION_FRAME_ID_TYPE.xml' path='doc/member[@name="COMPOSITION_FRAME_ID_TYPE.COMPOSITION_FRAME_ID_COMPLETED"]/*'/>
    COMPOSITION_FRAME_ID_COMPLETED = 2,
}