// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public partial struct DDSCAPS2
{
    /// <include file='DDSCAPS2.xml' path='doc/member[@name="DDSCAPS2.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    /// <include file='DDSCAPS2.xml' path='doc/member[@name="DDSCAPS2.dwCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps2;
    /// <include file='DDSCAPS2.xml' path='doc/member[@name="DDSCAPS2.dwCaps3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps3;
    /// <include file='DDSCAPS2.xml' path='doc/member[@name="DDSCAPS2.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L371_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwCaps4"]/*'/>
    [UnscopedRef]
    public ref uint dwCaps4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwCaps4;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwVolumeDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwVolumeDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwVolumeDepth;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwCaps4"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwCaps4;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwVolumeDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVolumeDepth;
    }

    [NativeTypeName("#define DDSCAPS2_RESERVED4 0x00000002L")]
    public const int DDSCAPS2_RESERVED4 = 0x00000002;
    [NativeTypeName("#define DDSCAPS2_HARDWAREDEINTERLACE 0x00000000L")]
    public const int DDSCAPS2_HARDWAREDEINTERLACE = 0x00000000;
    [NativeTypeName("#define DDSCAPS2_HINTDYNAMIC 0x00000004L")]
    public const int DDSCAPS2_HINTDYNAMIC = 0x00000004;
    [NativeTypeName("#define DDSCAPS2_HINTSTATIC 0x00000008L")]
    public const int DDSCAPS2_HINTSTATIC = 0x00000008;
    [NativeTypeName("#define DDSCAPS2_TEXTUREMANAGE 0x00000010L")]
    public const int DDSCAPS2_TEXTUREMANAGE = 0x00000010;
    [NativeTypeName("#define DDSCAPS2_RESERVED1 0x00000020L")]
    public const int DDSCAPS2_RESERVED1 = 0x00000020;
    [NativeTypeName("#define DDSCAPS2_RESERVED2 0x00000040L")]
    public const int DDSCAPS2_RESERVED2 = 0x00000040;
    [NativeTypeName("#define DDSCAPS2_OPAQUE 0x00000080L")]
    public const int DDSCAPS2_OPAQUE = 0x00000080;
    [NativeTypeName("#define DDSCAPS2_HINTANTIALIASING 0x00000100L")]
    public const int DDSCAPS2_HINTANTIALIASING = 0x00000100;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP 0x00000200L")]
    public const int DDSCAPS2_CUBEMAP = 0x00000200;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEX 0x00000400L")]
    public const int DDSCAPS2_CUBEMAP_POSITIVEX = 0x00000400;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEX 0x00000800L")]
    public const int DDSCAPS2_CUBEMAP_NEGATIVEX = 0x00000800;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEY 0x00001000L")]
    public const int DDSCAPS2_CUBEMAP_POSITIVEY = 0x00001000;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEY 0x00002000L")]
    public const int DDSCAPS2_CUBEMAP_NEGATIVEY = 0x00002000;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEZ 0x00004000L")]
    public const int DDSCAPS2_CUBEMAP_POSITIVEZ = 0x00004000;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEZ 0x00008000L")]
    public const int DDSCAPS2_CUBEMAP_NEGATIVEZ = 0x00008000;
    [NativeTypeName("#define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEX |\\\r\n                                    DDSCAPS2_CUBEMAP_POSITIVEY |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEY |\\\r\n                                    DDSCAPS2_CUBEMAP_POSITIVEZ |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEZ )")]
    public const int DDSCAPS2_CUBEMAP_ALLFACES = (0x00000400 | 0x00000800 | 0x00001000 | 0x00002000 | 0x00004000 | 0x00008000);
    [NativeTypeName("#define DDSCAPS2_MIPMAPSUBLEVEL 0x00010000L")]
    public const int DDSCAPS2_MIPMAPSUBLEVEL = 0x00010000;
    [NativeTypeName("#define DDSCAPS2_D3DTEXTUREMANAGE 0x00020000L")]
    public const int DDSCAPS2_D3DTEXTUREMANAGE = 0x00020000;
    [NativeTypeName("#define DDSCAPS2_DONOTPERSIST 0x00040000L")]
    public const int DDSCAPS2_DONOTPERSIST = 0x00040000;
    [NativeTypeName("#define DDSCAPS2_STEREOSURFACELEFT 0x00080000L")]
    public const int DDSCAPS2_STEREOSURFACELEFT = 0x00080000;
    [NativeTypeName("#define DDSCAPS2_VOLUME 0x00200000L")]
    public const int DDSCAPS2_VOLUME = 0x00200000;
    [NativeTypeName("#define DDSCAPS2_NOTUSERLOCKABLE 0x00400000L")]
    public const int DDSCAPS2_NOTUSERLOCKABLE = 0x00400000;
    [NativeTypeName("#define DDSCAPS2_POINTS 0x00800000L")]
    public const int DDSCAPS2_POINTS = 0x00800000;
    [NativeTypeName("#define DDSCAPS2_RTPATCHES 0x01000000L")]
    public const int DDSCAPS2_RTPATCHES = 0x01000000;
    [NativeTypeName("#define DDSCAPS2_NPATCHES 0x02000000L")]
    public const int DDSCAPS2_NPATCHES = 0x02000000;
    [NativeTypeName("#define DDSCAPS2_RESERVED3 0x04000000L")]
    public const int DDSCAPS2_RESERVED3 = 0x04000000;
    [NativeTypeName("#define DDSCAPS2_DISCARDBACKBUFFER 0x10000000L")]
    public const int DDSCAPS2_DISCARDBACKBUFFER = 0x10000000;
    [NativeTypeName("#define DDSCAPS2_ENABLEALPHACHANNEL 0x20000000L")]
    public const int DDSCAPS2_ENABLEALPHACHANNEL = 0x20000000;
    [NativeTypeName("#define DDSCAPS2_EXTENDEDFORMATPRIMARY 0x40000000L")]
    public const int DDSCAPS2_EXTENDEDFORMATPRIMARY = 0x40000000;
    [NativeTypeName("#define DDSCAPS2_ADDITIONALPRIMARY 0x80000000L")]
    public const uint DDSCAPS2_ADDITIONALPRIMARY = 0x80000000;
}