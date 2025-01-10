// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CompositionFrameDisplayInstance
{
    public LUID displayAdapterLUID;
    public uint displayVidPnSourceId;
    public uint displayUniqueId;
    public LUID renderAdapterLUID;
    public CompositionFrameInstanceKind instanceKind;
    public PresentationTransform finalTransform;

    [NativeTypeName("boolean")]
    public byte requiredCrossAdapterCopy;
    public DXGI_COLOR_SPACE_TYPE colorSpace;
}
