// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RIFFCPPO
{
    [NativeTypeName("#define RIFFCPPO_objr mmioFOURCC('o','b','j','r')")]
    public const uint RIFFCPPO_objr = ((uint)((byte)('o')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('r')) << 24));
    [NativeTypeName("#define RIFFCPPO_obji mmioFOURCC('o','b','j','i')")]
    public const uint RIFFCPPO_obji = ((uint)((byte)('o')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('i')) << 24));
    [NativeTypeName("#define RIFFCPPO_clsr mmioFOURCC('c','l','s','r')")]
    public const uint RIFFCPPO_clsr = ((uint)((byte)('c')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('r')) << 24));
    [NativeTypeName("#define RIFFCPPO_clsi mmioFOURCC('c','l','s','i')")]
    public const uint RIFFCPPO_clsi = ((uint)((byte)('c')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('i')) << 24));
    [NativeTypeName("#define RIFFCPPO_mbr mmioFOURCC('m','b','r',' ')")]
    public const uint RIFFCPPO_mbr = ((uint)((byte)('m')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)(' ')) << 24));
    [NativeTypeName("#define RIFFCPPO_char mmioFOURCC('c','h','a','r')")]
    public const uint RIFFCPPO_char = ((uint)((byte)('c')) | ((uint)((byte)('h')) << 8) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('r')) << 24));
    [NativeTypeName("#define RIFFCPPO_byte mmioFOURCC('b','y','t','e')")]
    public const uint RIFFCPPO_byte = ((uint)((byte)('b')) | ((uint)((byte)('y')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('e')) << 24));
    [NativeTypeName("#define RIFFCPPO_int mmioFOURCC('i','n','t',' ')")]
    public const uint RIFFCPPO_int = ((uint)((byte)('i')) | ((uint)((byte)('n')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)(' ')) << 24));
    [NativeTypeName("#define RIFFCPPO_word mmioFOURCC('w','o','r','d')")]
    public const uint RIFFCPPO_word = ((uint)((byte)('w')) | ((uint)((byte)('o')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('d')) << 24));
    [NativeTypeName("#define RIFFCPPO_long mmioFOURCC('l','o','n','g')")]
    public const uint RIFFCPPO_long = ((uint)((byte)('l')) | ((uint)((byte)('o')) << 8) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('g')) << 24));
    [NativeTypeName("#define RIFFCPPO_dwrd mmioFOURCC('d','w','r','d')")]
    public const uint RIFFCPPO_dwrd = ((uint)((byte)('d')) | ((uint)((byte)('w')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('d')) << 24));
    [NativeTypeName("#define RIFFCPPO_flt mmioFOURCC('f','l','t',' ')")]
    public const uint RIFFCPPO_flt = ((uint)((byte)('f')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)(' ')) << 24));
    [NativeTypeName("#define RIFFCPPO_dbl mmioFOURCC('d','b','l',' ')")]
    public const uint RIFFCPPO_dbl = ((uint)((byte)('d')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('l')) << 16) | ((uint)((byte)(' ')) << 24));
    [NativeTypeName("#define RIFFCPPO_str mmioFOURCC('s','t','r',' ')")]
    public const uint RIFFCPPO_str = ((uint)((byte)('s')) | ((uint)((byte)('t')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)(' ')) << 24));
}