// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ITfCandidateString
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x31,
                0x1F,
                0x58,
                0x9D,
                0xFD,
                0x3F,
                0x44,
                0xB9,
                0x72,
                0xED,
                0x00,
                0x46,
                0x7C,
                0x5D,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfCandidates
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x19,
                0xFB,
                0xDE,
                0x80,
                0x6C,
                0xE8,
                0x4C,
                0x87,
                0xD4,
                0xD6,
                0xB7,
                0x2B,
                0x81,
                0x2B,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCandidateList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x50,
                0xAD,
                0xA3,
                0xDB,
                0x9B,
                0xE3,
                0x49,
                0xA8,
                0x43,
                0x6C,
                0x76,
                0x52,
                0x0F,
                0xBF,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnReconversion
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x93,
                0xEA,
                0x4C,
                0x58,
                0x0A,
                0xD3,
                0x11,
                0x8D,
                0xF0,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnPlayBack
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x16,
                0xA4,
                0xA3,
                0x64,
                0x0F,
                0xD3,
                0x11,
                0xB5,
                0xB7,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x24,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnLangProfileUtil
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x85,
                0x7A,
                0xA8,
                0xC1,
                0xA6,
                0x15,
                0x4E,
                0x99,
                0xF0,
                0x3D,
                0x39,
                0x65,
                0xF5,
                0x48,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnConfigure
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x67,
                0xF5,
                0x88,
                0x57,
                0x17,
                0xF8,
                0x49,
                0xA1,
                0xB2,
                0x89,
                0x23,
                0x4C,
                0x1E,
                0xEF,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnConfigureRegisterWord
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x80,
                0x95,
                0xBB,
                0x8F,
                0x6D,
                0xCA,
                0x4B,
                0x84,
                0x00,
                0x53,
                0x90,
                0xB5,
                0x86,
                0xAE,
                0xDF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnConfigureRegisterEudc
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x6F,
                0xE2,
                0xB5,
                0xAD,
                0xD7,
                0x04,
                0x43,
                0x91,
                0x3F,
                0x21,
                0xA2,
                0xED,
                0x95,
                0xA1,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnShowHelp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xD3,
                0xB1,
                0x5A,
                0x4D,
                0x09,
                0x29,
                0x4C,
                0x8E,
                0xA5,
                0x0B,
                0xF5,
                0x9B,
                0xE8,
                0x7B,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnBalloon
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x89,
                0xAB,
                0x3B,
                0xBE,
                0x5F,
                0xF4,
                0x45,
                0xA5,
                0xBC,
                0xDC,
                0xA3,
                0x6A,
                0xD2,
                0x25,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnGetSAPIObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0xB7,
                0x0A,
                0x5C,
                0x7D,
                0x16,
                0x59,
                0x4F,
                0xBF,
                0xB5,
                0x46,
                0x93,
                0x75,
                0x5E,
                0x90,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnPropertyUIStatus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6E,
                0xAC,
                0x38,
                0x23,
                0x9D,
                0x2B,
                0xC0,
                0x44,
                0xA7,
                0x5E,
                0xEE,
                0x64,
                0xF2,
                0x56,
                0xB3,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumSpeechCommands
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xAC,
                0x5D,
                0x8C,
                0x3C,
                0x08,
                0x85,
                0x4B,
                0xA4,
                0xC9,
                0x71,
                0x74,
                0x60,
                0x48,
                0xAD,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpeechCommandProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x9D,
                0xE0,
                0x38,
                0x6D,
                0x58,
                0x5A,
                0x43,
                0xB5,
                0x92,
                0xC8,
                0xA8,
                0x66,
                0x91,
                0xDE,
                0xC6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnCustomSpeechCommand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xC3,
                0xA6,
                0xFC,
                0x2F,
                0xA1,
                0xA3,
                0x43,
                0x8D,
                0xD6,
                0x5A,
                0x5A,
                0x42,
                0x82,
                0x57,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnLMProcessor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xF8,
                0xFB,
                0x7A,
                0x4B,
                0xAC,
                0x82,
                0x40,
                0xB0,
                0x58,
                0x89,
                0x08,
                0x99,
                0xD3,
                0xA0,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnLMInternal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0x25,
                0xB8,
                0x04,
                0x9A,
                0xAC,
                0x7B,
                0x4F,
                0xB5,
                0xAD,
                0xC7,
                0x16,
                0x8F,
                0x1E,
                0xE4,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfLatticeElements
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x80,
                0x98,
                0x56,
                0xDA,
                0x47,
                0x05,
                0x4A,
                0x91,
                0x1A,
                0xE3,
                0xD9,
                0x41,
                0xF1,
                0x71,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLMLattice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x66,
                0x23,
                0xD4,
                0xBF,
                0xA5,
                0x70,
                0x45,
                0x9D,
                0x42,
                0x5D,
                0x6D,
                0x7B,
                0x02,
                0xD5,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnAdviseText
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x26,
                0x27,
                0x35,
                0x53,
                0x7D,
                0xD9,
                0x4D,
                0x92,
                0xB7,
                0x72,
                0x96,
                0xAE,
                0x46,
                0x12,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnSearchCandidateProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xAD,
                0xA2,
                0x87,
                0x7B,
                0xF2,
                0x20,
                0x49,
                0x85,
                0x01,
                0x67,
                0x60,
                0x22,
                0x80,
                0x17,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfIntegratableCandidateListUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xF5,
                0xA6,
                0xC7,
                0x80,
                0xB1,
                0x6F,
                0x41,
                0xB2,
                0xBF,
                0x7B,
                0xF2,
                0xE4,
                0x68,
                0x3D,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnGetPreferredTouchKeyboardLayout
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x9A,
                0x30,
                0x5F,
                0x0A,
                0x59,
                0xCC,
                0x4A,
                0xA9,
                0x7F,
                0xD8,
                0xEF,
                0xFF,
                0x13,
                0xFD,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFnGetLinguisticAlternates
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x3C,
                0x16,
                0xEA,
                0x65,
                0x7A,
                0x06,
                0x45,
                0x82,
                0xA3,
                0xC5,
                0x28,
                0x21,
                0x5D,
                0xA6,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUIManagerEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0xD6,
                0x91,
                0xCD,
                0xE8,
                0xA7,
                0x65,
                0x42,
                0x9B,
                0x38,
                0x8B,
                0xB3,
                0xBB,
                0xAB,
                0xA7,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}