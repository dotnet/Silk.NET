// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_KaraokeAttributes
{
    public byte bVersion;
    public BOOL fMasterOfCeremoniesInGuideVocal1;
    public BOOL fDuet;
    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment;

    [NativeTypeName("WORD[8]")]
    public _wChannelContents_e__FixedBuffer wChannelContents;

    [InlineArray(8)]
    public partial struct _wChannelContents_e__FixedBuffer
    {
        public ushort e0;
    }
}
