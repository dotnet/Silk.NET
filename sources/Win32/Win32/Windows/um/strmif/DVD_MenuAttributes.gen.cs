// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_MenuAttributes
{
    [NativeTypeName("BOOL[8]")]
    public _fCompatibleRegion_e__FixedBuffer fCompatibleRegion;
    public DVD_VideoAttributes VideoAttributes;
    public BOOL fAudioPresent;
    public DVD_AudioAttributes AudioAttributes;
    public BOOL fSubpicturePresent;
    public DVD_SubpictureAttributes SubpictureAttributes;

    [InlineArray(8)]
    public partial struct _fCompatibleRegion_e__FixedBuffer
    {
        public BOOL e0;
    }
}
