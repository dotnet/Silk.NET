// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RIFFINFO
{
    [NativeTypeName("#define RIFFINFO_IARL mmioFOURCC ('I', 'A', 'R', 'L')")]
    public const uint RIFFINFO_IARL = ((uint)((byte)('I')) | ((uint)((byte)('A')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('L')) << 24));
    [NativeTypeName("#define RIFFINFO_IART mmioFOURCC ('I', 'A', 'R', 'T')")]
    public const uint RIFFINFO_IART = ((uint)((byte)('I')) | ((uint)((byte)('A')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_ICMS mmioFOURCC ('I', 'C', 'M', 'S')")]
    public const uint RIFFINFO_ICMS = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('S')) << 24));
    [NativeTypeName("#define RIFFINFO_ICMT mmioFOURCC ('I', 'C', 'M', 'T')")]
    public const uint RIFFINFO_ICMT = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_ICOP mmioFOURCC ('I', 'C', 'O', 'P')")]
    public const uint RIFFINFO_ICOP = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('P')) << 24));
    [NativeTypeName("#define RIFFINFO_ICRD mmioFOURCC ('I', 'C', 'R', 'D')")]
    public const uint RIFFINFO_ICRD = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('D')) << 24));
    [NativeTypeName("#define RIFFINFO_ICRP mmioFOURCC ('I', 'C', 'R', 'P')")]
    public const uint RIFFINFO_ICRP = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('P')) << 24));
    [NativeTypeName("#define RIFFINFO_IDIM mmioFOURCC ('I', 'D', 'I', 'M')")]
    public const uint RIFFINFO_IDIM = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('M')) << 24));
    [NativeTypeName("#define RIFFINFO_IDPI mmioFOURCC ('I', 'D', 'P', 'I')")]
    public const uint RIFFINFO_IDPI = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('I')) << 24));
    [NativeTypeName("#define RIFFINFO_IENG mmioFOURCC ('I', 'E', 'N', 'G')")]
    public const uint RIFFINFO_IENG = ((uint)((byte)('I')) | ((uint)((byte)('E')) << 8) | ((uint)((byte)('N')) << 16) | ((uint)((byte)('G')) << 24));
    [NativeTypeName("#define RIFFINFO_IGNR mmioFOURCC ('I', 'G', 'N', 'R')")]
    public const uint RIFFINFO_IGNR = ((uint)((byte)('I')) | ((uint)((byte)('G')) << 8) | ((uint)((byte)('N')) << 16) | ((uint)((byte)('R')) << 24));
    [NativeTypeName("#define RIFFINFO_IKEY mmioFOURCC ('I', 'K', 'E', 'Y')")]
    public const uint RIFFINFO_IKEY = ((uint)((byte)('I')) | ((uint)((byte)('K')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('Y')) << 24));
    [NativeTypeName("#define RIFFINFO_ILGT mmioFOURCC ('I', 'L', 'G', 'T')")]
    public const uint RIFFINFO_ILGT = ((uint)((byte)('I')) | ((uint)((byte)('L')) << 8) | ((uint)((byte)('G')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_IMED mmioFOURCC ('I', 'M', 'E', 'D')")]
    public const uint RIFFINFO_IMED = ((uint)((byte)('I')) | ((uint)((byte)('M')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('D')) << 24));
    [NativeTypeName("#define RIFFINFO_INAM mmioFOURCC ('I', 'N', 'A', 'M')")]
    public const uint RIFFINFO_INAM = ((uint)((byte)('I')) | ((uint)((byte)('N')) << 8) | ((uint)((byte)('A')) << 16) | ((uint)((byte)('M')) << 24));
    [NativeTypeName("#define RIFFINFO_IPLT mmioFOURCC ('I', 'P', 'L', 'T')")]
    public const uint RIFFINFO_IPLT = ((uint)((byte)('I')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('L')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_IPRD mmioFOURCC ('I', 'P', 'R', 'D')")]
    public const uint RIFFINFO_IPRD = ((uint)((byte)('I')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('D')) << 24));
    [NativeTypeName("#define RIFFINFO_ISBJ mmioFOURCC ('I', 'S', 'B', 'J')")]
    public const uint RIFFINFO_ISBJ = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('J')) << 24));
    [NativeTypeName("#define RIFFINFO_ISFT mmioFOURCC ('I', 'S', 'F', 'T')")]
    public const uint RIFFINFO_ISFT = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('F')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_ISHP mmioFOURCC ('I', 'S', 'H', 'P')")]
    public const uint RIFFINFO_ISHP = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('H')) << 16) | ((uint)((byte)('P')) << 24));
    [NativeTypeName("#define RIFFINFO_ISRC mmioFOURCC ('I', 'S', 'R', 'C')")]
    public const uint RIFFINFO_ISRC = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('C')) << 24));
    [NativeTypeName("#define RIFFINFO_ISRF mmioFOURCC ('I', 'S', 'R', 'F')")]
    public const uint RIFFINFO_ISRF = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('F')) << 24));
    [NativeTypeName("#define RIFFINFO_ITCH mmioFOURCC ('I', 'T', 'C', 'H')")]
    public const uint RIFFINFO_ITCH = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('C')) << 16) | ((uint)((byte)('H')) << 24));
    [NativeTypeName("#define RIFFINFO_ISMP mmioFOURCC ('I', 'S', 'M', 'P')")]
    public const uint RIFFINFO_ISMP = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('P')) << 24));
    [NativeTypeName("#define RIFFINFO_IDIT mmioFOURCC ('I', 'D', 'I', 'T')")]
    public const uint RIFFINFO_IDIT = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('T')) << 24));
    [NativeTypeName("#define RIFFINFO_ITRK mmioFOURCC ('I', 'T', 'R', 'K')")]
    public const uint RIFFINFO_ITRK = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('K')) << 24));
    [NativeTypeName("#define RIFFINFO_ITOC mmioFOURCC ('I', 'T', 'O', 'C')")]
    public const uint RIFFINFO_ITOC = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('C')) << 24));
}