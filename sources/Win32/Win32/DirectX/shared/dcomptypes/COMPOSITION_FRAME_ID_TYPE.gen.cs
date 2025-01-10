// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum COMPOSITION_FRAME_ID_TYPE
{
    COMPOSITION_FRAME_ID_CREATED = 0,
    COMPOSITION_FRAME_ID_CONFIRMED = 1,
    COMPOSITION_FRAME_ID_COMPLETED = 2,
}
