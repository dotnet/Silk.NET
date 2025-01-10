// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MT_CUSTOM_VIDEO_PRIMARIES
{
    public float fRx;
    public float fRy;
    public float fGx;
    public float fGy;
    public float fBx;
    public float fBy;
    public float fWx;
    public float fWy;
}
