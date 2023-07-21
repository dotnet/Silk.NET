// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_SpNotifyTranslator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x72, 0x53, 0xAE, 0xE2,
                0x40, 0x5D,
                0xD2, 0x11,
                0x96,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpObjectTokenCategory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7F, 0x18, 0x10, 0xA9,
                0x7A, 0x0C,
                0xAC, 0x45,
                0x92,
                0xCC,
                0x59,
                0xED,
                0xAF,
                0xB7,
                0x7B,
                0x53
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpObjectToken
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x52, 0x17, 0x41, 0xEF,
                0x36, 0x37,
                0xB4, 0x4C,
                0x9C,
                0x8C,
                0x8E,
                0xF4,
                0xCC,
                0xB5,
                0x8E,
                0xFE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpResourceManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x73, 0x93, 0x74, 0x96,
                0x91, 0x33,
                0xD2, 0x11,
                0x9E,
                0xE3,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x73,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpStreamFormatConverter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0x94, 0x13, 0x70,
                0xEC, 0xE2,
                0xD2, 0x11,
                0xA0,
                0x86,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xF9,
                0xB5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpMMAudioEnum
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0x90, 0x18, 0xAB,
                0x1F, 0xE9,
                0xD2, 0x11,
                0xBB,
                0x91,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0xC0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpMMAudioIn
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x50, 0x2E, 0x3D, 0xCF,
                0xF2, 0x53,
                0xD2, 0x11,
                0x96,
                0x0C,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpMMAudioOut
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEB, 0x80, 0xC6, 0xA8,
                0x32, 0x3D,
                0xD2, 0x11,
                0x9E,
                0xE7,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x73,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x59, 0x9C, 0x5D, 0x71,
                0x42, 0x44,
                0xD2, 0x11,
                0x96,
                0x05,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpVoice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x77, 0x93, 0x74, 0x96,
                0x91, 0x33,
                0xD2, 0x11,
                0x9E,
                0xE3,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x73,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpSharedRecoContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x04, 0x62, 0x20, 0x47,
                0xCA, 0x5E,
                0xD2, 0x11,
                0x96,
                0x0F,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpInprocRecognizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6B, 0x9B, 0xB8, 0x41,
                0x99, 0x93,
                0xD2, 0x11,
                0x96,
                0x23,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xE6,
                0x28
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpSharedRecognizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x90, 0x48, 0xEE, 0x3B,
                0xE9, 0x4F,
                0x37, 0x4A,
                0x8C,
                0x1E,
                0x5E,
                0x7E,
                0x12,
                0x79,
                0x1C,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpLexicon
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x96, 0xE3, 0x55, 0x06,
                0xD0, 0x25,
                0xD3, 0x11,
                0x9C,
                0x26,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xF8,
                0x7C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpUnCompressedLexicon
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x15, 0x7C, 0xE3, 0xC9,
                0x92, 0xDF,
                0x27, 0x47,
                0x85,
                0xD6,
                0x72,
                0xE5,
                0xEE,
                0xB6,
                0x99,
                0x5A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpCompressedLexicon
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x16, 0x37, 0x90, 0x90,
                0x42, 0x2F,
                0xD3, 0x11,
                0x9C,
                0x26,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xF8,
                0x7C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpShortcut
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1A, 0x2F, 0x72, 0x0D,
                0xCF, 0x9F,
                0x62, 0x4E,
                0x96,
                0xD8,
                0x6D,
                0xF8,
                0xF0,
                0x1A,
                0x26,
                0xAA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpPhoneConverter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x43, 0xF7, 0x85, 0x91,
                0x43, 0x11,
                0x28, 0x4C,
                0x86,
                0xB5,
                0xBF,
                0xF1,
                0x4F,
                0x20,
                0xE5,
                0xC8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpNullPhoneConverter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE9, 0x24, 0x5F, 0x45,
                0x96, 0x73,
                0x16, 0x4A,
                0x97,
                0x15,
                0x7C,
                0x0F,
                0xDB,
                0xE3,
                0xEF,
                0xE3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpPhraseInfoBuilder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8D, 0xC2, 0x3F, 0xC2,
                0x5F, 0xC5,
                0x20, 0x47,
                0x8B,
                0x32,
                0x91,
                0xF7,
                0x3C,
                0x2B,
                0xD5,
                0xD1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpAudioFormat
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x70, 0x68, 0xF9, 0x9E,
                0x60, 0xE1,
                0x92, 0x47,
                0x82,
                0x0D,
                0x48,
                0xCF,
                0x06,
                0x49,
                0xE4,
                0xEC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpWaveFormatEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4C, 0x57, 0x9A, 0xC7,
                0xBE, 0x63,
                0xB9, 0x44,
                0x80,
                0x1F,
                0x28,
                0x3F,
                0x87,
                0xF8,
                0x98,
                0xBE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpInProcRecoContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x42, 0x68, 0xAD, 0x73,
                0xE0, 0xAC,
                0xE8, 0x45,
                0xA4,
                0xDD,
                0x87,
                0x95,
                0x88,
                0x1A,
                0x2C,
                0x2A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpCustomStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3F, 0xF1, 0xBE, 0x8D,
                0x48, 0x19,
                0xA8, 0x4A,
                0x8C,
                0xF0,
                0x04,
                0x8E,
                0xEB,
                0xED,
                0x95,
                0xD8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpFileStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB3, 0x12, 0x78, 0x94,
                0xE1, 0x2A,
                0x44, 0x46,
                0xBA,
                0x86,
                0x9E,
                0x90,
                0xDE,
                0xD7,
                0xEC,
                0x91
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_SpMemoryStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7D, 0xEF, 0xB7, 0x5F,
                0xF4, 0xDF,
                0x8A, 0x46,
                0xB6,
                0xB7,
                0x2F,
                0xCB,
                0xD1,
                0x88,
                0xF9,
                0x94
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
