// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class TF
{
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateThreadMgr(ITfThreadMgr* pptim);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_GetThreadMgr(ITfThreadMgr* pptim);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateInputProcessorProfiles(ITfInputProcessorProfiles* ppipr);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateDisplayAttributeMgr(ITfDisplayAttributeMgr* ppdam);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateLangBarMgr(ITfLangBarMgr* pppbm);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateLangBarItemMgr(ITfLangBarItemMgr* pplbim);

    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT TF_CreateCategoryMgr(ITfCategoryMgr* ppcat);

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_NEWPHONETIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xC5,
                0xF9,
                0xB2,
                0x42,
                0x17,
                0xD4,
                0x11,
                0x97,
                0x90,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_PHONETIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x09,
                0x13,
                0x76,
                0x7A,
                0x31,
                0xD4,
                0x11,
                0x9B,
                0x5D,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_NEWCHANGJIE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x90,
                0xBA,
                0xF3,
                0x7E,
                0x6C,
                0xD4,
                0x11,
                0x97,
                0xFA,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_CHANGJIE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x9F,
                0xDF,
                0x4B,
                0xD3,
                0xC7,
                0xD4,
                0x11,
                0xB2,
                0xAB,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_NEWQUICK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x3B,
                0x88,
                0x0B,
                0xC7,
                0xC1,
                0xD4,
                0x11,
                0x87,
                0xF9,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_QUICK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xB4,
                0x24,
                0x60,
                0x54,
                0x5C,
                0xD4,
                0x11,
                0xB9,
                0x21,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_CANTONESE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x10,
                0xEC,
                0x0A,
                0x96,
                0x7E,
                0xD4,
                0x11,
                0xB2,
                0xEF,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_PINYIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x90,
                0xBA,
                0xF3,
                0x7E,
                0x6C,
                0xD4,
                0x11,
                0x97,
                0xFA,
                0x00,
                0x80,
                0xC8,
                0x82,
                0x68,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_SIMPLEFAST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x0B,
                0x55,
                0xFA,
                0xD7,
                0x5A,
                0x1F,
                0x41,
                0xA5,
                0xAC,
                0xCA,
                0x03,
                0x8E,
                0xC5,
                0x15,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_WUBI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x0C,
                0x59,
                0x82,
                0xDD,
                0xF4,
                0xF4,
                0x44,
                0xBA,
                0x1D,
                0x86,
                0x67,
                0x24,
                0x6F,
                0xDF,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_DAYI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x2C,
                0x7B,
                0x03,
                0x0C,
                0x48,
                0x7F,
                0x4D,
                0xB0,
                0x27,
                0xD6,
                0xCA,
                0x6B,
                0x69,
                0x78,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_ARRAY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xFF,
                0x8E,
                0xD3,
                0x46,
                0xAA,
                0xD5,
                0x4F,
                0x91,
                0xA7,
                0x67,
                0x84,
                0x5F,
                0xB0,
                0x2F,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_YI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x83,
                0x9C,
                0x40,
                0x7B,
                0x00,
                0x57,
                0x43,
                0xAE,
                0x8E,
                0x26,
                0x31,
                0x6E,
                0xE3,
                0xFB,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid TF_PROFILE_TIGRINYA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x88,
                0xAB,
                0x3C,
                0x3E,
                0xCC,
                0xA6,
                0x46,
                0x97,
                0x65,
                0xB7,
                0x72,
                0xAD,
                0x77,
                0x61,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define TF_E_LOCKED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0500)")]
    public const int TF_E_LOCKED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0500)))
    );

    [NativeTypeName("#define TF_E_STACKFULL MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0501)")]
    public const int TF_E_STACKFULL = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0501)))
    );

    [NativeTypeName(
        "#define TF_E_NOTOWNEDRANGE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0502)"
    )]
    public const int TF_E_NOTOWNEDRANGE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0502)))
    );

    [NativeTypeName("#define TF_E_NOPROVIDER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0503)")]
    public const int TF_E_NOPROVIDER = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0503)))
    );

    [NativeTypeName("#define TF_E_DISCONNECTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0504)")]
    public const int TF_E_DISCONNECTED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0504)))
    );

    [NativeTypeName("#define TF_E_INVALIDVIEW MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0505)")]
    public const int TF_E_INVALIDVIEW = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0505)))
    );

    [NativeTypeName(
        "#define TF_E_ALREADY_EXISTS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0506)"
    )]
    public const int TF_E_ALREADY_EXISTS = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0506)))
    );

    [NativeTypeName(
        "#define TF_E_RANGE_NOT_COVERED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0507)"
    )]
    public const int TF_E_RANGE_NOT_COVERED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0507)))
    );

    [NativeTypeName(
        "#define TF_E_COMPOSITION_REJECTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0508)"
    )]
    public const int TF_E_COMPOSITION_REJECTED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0508)))
    );

    [NativeTypeName("#define TF_E_EMPTYCONTEXT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0509)")]
    public const int TF_E_EMPTYCONTEXT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0509)))
    );

    [NativeTypeName("#define TF_E_INVALIDPOS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0200)")]
    public const int TF_E_INVALIDPOS = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0200)))
    );

    [NativeTypeName("#define TF_E_NOLOCK MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0201)")]
    public const int TF_E_NOLOCK = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0201)))
    );

    [NativeTypeName("#define TF_E_NOOBJECT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0202)")]
    public const int TF_E_NOOBJECT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0202)))
    );

    [NativeTypeName("#define TF_E_NOSERVICE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0203)")]
    public const int TF_E_NOSERVICE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0203)))
    );

    [NativeTypeName("#define TF_E_NOINTERFACE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0204)")]
    public const int TF_E_NOINTERFACE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0204)))
    );

    [NativeTypeName("#define TF_E_NOSELECTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0205)")]
    public const int TF_E_NOSELECTION = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0205)))
    );

    [NativeTypeName("#define TF_E_NOLAYOUT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0206)")]
    public const int TF_E_NOLAYOUT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0206)))
    );

    [NativeTypeName("#define TF_E_INVALIDPOINT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0207)")]
    public const int TF_E_INVALIDPOINT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0207)))
    );

    [NativeTypeName("#define TF_E_SYNCHRONOUS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0208)")]
    public const int TF_E_SYNCHRONOUS = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0208)))
    );

    [NativeTypeName("#define TF_E_READONLY MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0209)")]
    public const int TF_E_READONLY = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0209)))
    );

    [NativeTypeName("#define TF_E_FORMAT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x020a)")]
    public const int TF_E_FORMAT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x020a)))
    );

    [NativeTypeName("#define TF_S_ASYNC MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_ITF, 0x0300)")]
    public const int TF_S_ASYNC = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0300)))
    );

    [NativeTypeName("#define TF_RCM_COMLESS 0x00000001")]
    public const int TF_RCM_COMLESS = 0x00000001;

    [NativeTypeName("#define TF_RCM_VKEY 0x00000002")]
    public const int TF_RCM_VKEY = 0x00000002;

    [NativeTypeName("#define TF_RCM_HINT_READING_LENGTH 0x00000004")]
    public const int TF_RCM_HINT_READING_LENGTH = 0x00000004;

    [NativeTypeName("#define TF_RCM_HINT_COLLISION 0x00000008")]
    public const int TF_RCM_HINT_COLLISION = 0x00000008;

    [NativeTypeName("#define TF_INVALID_GUIDATOM ((TfGuidAtom)0)")]
    public const uint TF_INVALID_GUIDATOM = ((uint)(0));

    [NativeTypeName("#define TF_CLIENTID_NULL ((TfClientId)0)")]
    public const uint TF_CLIENTID_NULL = ((uint)(0));

    [NativeTypeName("#define TF_TMAE_NOACTIVATETIP 0x00000001")]
    public const int TF_TMAE_NOACTIVATETIP = 0x00000001;

    [NativeTypeName("#define TF_TMAE_SECUREMODE 0x00000002")]
    public const int TF_TMAE_SECUREMODE = 0x00000002;

    [NativeTypeName("#define TF_TMAE_UIELEMENTENABLEDONLY 0x00000004")]
    public const int TF_TMAE_UIELEMENTENABLEDONLY = 0x00000004;

    [NativeTypeName("#define TF_TMAE_COMLESS 0x00000008")]
    public const int TF_TMAE_COMLESS = 0x00000008;

    [NativeTypeName("#define TF_TMAE_WOW16 0x00000010")]
    public const int TF_TMAE_WOW16 = 0x00000010;

    [NativeTypeName("#define TF_TMAE_NOACTIVATEKEYBOARDLAYOUT 0x00000020")]
    public const int TF_TMAE_NOACTIVATEKEYBOARDLAYOUT = 0x00000020;

    [NativeTypeName("#define TF_TMAE_CONSOLE 0x00000040")]
    public const int TF_TMAE_CONSOLE = 0x00000040;

    [NativeTypeName("#define TF_TMF_NOACTIVATETIP TF_TMAE_NOACTIVATETIP")]
    public const int TF_TMF_NOACTIVATETIP = 0x00000001;

    [NativeTypeName("#define TF_TMF_SECUREMODE TF_TMAE_SECUREMODE")]
    public const int TF_TMF_SECUREMODE = 0x00000002;

    [NativeTypeName("#define TF_TMF_UIELEMENTENABLEDONLY TF_TMAE_UIELEMENTENABLEDONLY")]
    public const int TF_TMF_UIELEMENTENABLEDONLY = 0x00000004;

    [NativeTypeName("#define TF_TMF_COMLESS TF_TMAE_COMLESS")]
    public const int TF_TMF_COMLESS = 0x00000008;

    [NativeTypeName("#define TF_TMF_WOW16 TF_TMAE_WOW16")]
    public const int TF_TMF_WOW16 = 0x00000010;

    [NativeTypeName("#define TF_TMF_CONSOLE TF_TMAE_CONSOLE")]
    public const int TF_TMF_CONSOLE = 0x00000040;

    [NativeTypeName("#define TF_TMF_IMMERSIVEMODE 0x40000000")]
    public const int TF_TMF_IMMERSIVEMODE = 0x40000000;

    [NativeTypeName("#define TF_TMF_ACTIVATED 0x80000000")]
    public const uint TF_TMF_ACTIVATED = 0x80000000;

    [NativeTypeName("#define TF_MOD_ALT 0x0001")]
    public const int TF_MOD_ALT = 0x0001;

    [NativeTypeName("#define TF_MOD_CONTROL 0x0002")]
    public const int TF_MOD_CONTROL = 0x0002;

    [NativeTypeName("#define TF_MOD_SHIFT 0x0004")]
    public const int TF_MOD_SHIFT = 0x0004;

    [NativeTypeName("#define TF_MOD_RALT 0x0008")]
    public const int TF_MOD_RALT = 0x0008;

    [NativeTypeName("#define TF_MOD_RCONTROL 0x0010")]
    public const int TF_MOD_RCONTROL = 0x0010;

    [NativeTypeName("#define TF_MOD_RSHIFT 0x0020")]
    public const int TF_MOD_RSHIFT = 0x0020;

    [NativeTypeName("#define TF_MOD_LALT 0x0040")]
    public const int TF_MOD_LALT = 0x0040;

    [NativeTypeName("#define TF_MOD_LCONTROL 0x0080")]
    public const int TF_MOD_LCONTROL = 0x0080;

    [NativeTypeName("#define TF_MOD_LSHIFT 0x0100")]
    public const int TF_MOD_LSHIFT = 0x0100;

    [NativeTypeName("#define TF_MOD_ON_KEYUP 0x0200")]
    public const int TF_MOD_ON_KEYUP = 0x0200;

    [NativeTypeName("#define TF_MOD_IGNORE_ALL_MODIFIER 0x0400")]
    public const int TF_MOD_IGNORE_ALL_MODIFIER = 0x0400;

    [NativeTypeName("#define TF_US_HIDETIPUI 0x00000001")]
    public const int TF_US_HIDETIPUI = 0x00000001;

    [NativeTypeName("#define TF_DISABLE_SPEECH 0x00000001")]
    public const int TF_DISABLE_SPEECH = 0x00000001;

    [NativeTypeName("#define TF_DISABLE_DICTATION 0x00000002")]
    public const int TF_DISABLE_DICTATION = 0x00000002;

    [NativeTypeName("#define TF_DISABLE_COMMANDING 0x00000004")]
    public const int TF_DISABLE_COMMANDING = 0x00000004;

    [NativeTypeName("#define TF_PROCESS_ATOM TEXT(\"_CTF_PROCESS_ATOM_\")")]
    public const string TF_PROCESS_ATOM = "_CTF_PROCESS_ATOM_";

    [NativeTypeName("#define TF_ENABLE_PROCESS_ATOM TEXT(\"_CTF_ENABLE_PROCESS_ATOM_\")")]
    public const string TF_ENABLE_PROCESS_ATOM = "_CTF_ENABLE_PROCESS_ATOM_";

    [NativeTypeName("#define TF_INVALID_UIELEMENTID DWORD(-1)")]
    public const uint TF_INVALID_UIELEMENTID = unchecked((uint)(-1));

    [NativeTypeName("#define TF_CLUIE_DOCUMENTMGR 0x00000001")]
    public const int TF_CLUIE_DOCUMENTMGR = 0x00000001;

    [NativeTypeName("#define TF_CLUIE_COUNT 0x00000002")]
    public const int TF_CLUIE_COUNT = 0x00000002;

    [NativeTypeName("#define TF_CLUIE_SELECTION 0x00000004")]
    public const int TF_CLUIE_SELECTION = 0x00000004;

    [NativeTypeName("#define TF_CLUIE_STRING 0x00000008")]
    public const int TF_CLUIE_STRING = 0x00000008;

    [NativeTypeName("#define TF_CLUIE_PAGEINDEX 0x00000010")]
    public const int TF_CLUIE_PAGEINDEX = 0x00000010;

    [NativeTypeName("#define TF_CLUIE_CURRENTPAGE 0x00000020")]
    public const int TF_CLUIE_CURRENTPAGE = 0x00000020;

    [NativeTypeName("#define TF_RIUIE_CONTEXT 0x00000001")]
    public const int TF_RIUIE_CONTEXT = 0x00000001;

    [NativeTypeName("#define TF_RIUIE_STRING 0x00000002")]
    public const int TF_RIUIE_STRING = 0x00000002;

    [NativeTypeName("#define TF_RIUIE_MAXREADINGSTRINGLENGTH 0x00000004")]
    public const int TF_RIUIE_MAXREADINGSTRINGLENGTH = 0x00000004;

    [NativeTypeName("#define TF_RIUIE_ERRORINDEX 0x00000008")]
    public const int TF_RIUIE_ERRORINDEX = 0x00000008;

    [NativeTypeName("#define TF_RIUIE_VERTICALORDER 0x00000010")]
    public const int TF_RIUIE_VERTICALORDER = 0x00000010;

    [NativeTypeName("#define TF_CONVERSIONMODE_ALPHANUMERIC 0x0000")]
    public const int TF_CONVERSIONMODE_ALPHANUMERIC = 0x0000;

    [NativeTypeName("#define TF_CONVERSIONMODE_NATIVE 0x0001")]
    public const int TF_CONVERSIONMODE_NATIVE = 0x0001;

    [NativeTypeName("#define TF_CONVERSIONMODE_KATAKANA 0x0002")]
    public const int TF_CONVERSIONMODE_KATAKANA = 0x0002;

    [NativeTypeName("#define TF_CONVERSIONMODE_FULLSHAPE 0x0008")]
    public const int TF_CONVERSIONMODE_FULLSHAPE = 0x0008;

    [NativeTypeName("#define TF_CONVERSIONMODE_ROMAN 0x0010")]
    public const int TF_CONVERSIONMODE_ROMAN = 0x0010;

    [NativeTypeName("#define TF_CONVERSIONMODE_CHARCODE 0x0020")]
    public const int TF_CONVERSIONMODE_CHARCODE = 0x0020;

    [NativeTypeName("#define TF_CONVERSIONMODE_SOFTKEYBOARD 0x0080")]
    public const int TF_CONVERSIONMODE_SOFTKEYBOARD = 0x0080;

    [NativeTypeName("#define TF_CONVERSIONMODE_NOCONVERSION 0x0100")]
    public const int TF_CONVERSIONMODE_NOCONVERSION = 0x0100;

    [NativeTypeName("#define TF_CONVERSIONMODE_EUDC 0x0200")]
    public const int TF_CONVERSIONMODE_EUDC = 0x0200;

    [NativeTypeName("#define TF_CONVERSIONMODE_SYMBOL 0x0400")]
    public const int TF_CONVERSIONMODE_SYMBOL = 0x0400;

    [NativeTypeName("#define TF_CONVERSIONMODE_FIXED 0x0800")]
    public const int TF_CONVERSIONMODE_FIXED = 0x0800;

    [NativeTypeName("#define TF_SENTENCEMODE_NONE 0x0000")]
    public const int TF_SENTENCEMODE_NONE = 0x0000;

    [NativeTypeName("#define TF_SENTENCEMODE_PLAURALCLAUSE 0x0001")]
    public const int TF_SENTENCEMODE_PLAURALCLAUSE = 0x0001;

    [NativeTypeName("#define TF_SENTENCEMODE_SINGLECONVERT 0x0002")]
    public const int TF_SENTENCEMODE_SINGLECONVERT = 0x0002;

    [NativeTypeName("#define TF_SENTENCEMODE_AUTOMATIC 0x0004")]
    public const int TF_SENTENCEMODE_AUTOMATIC = 0x0004;

    [NativeTypeName("#define TF_SENTENCEMODE_PHRASEPREDICT 0x0008")]
    public const int TF_SENTENCEMODE_PHRASEPREDICT = 0x0008;

    [NativeTypeName("#define TF_SENTENCEMODE_CONVERSATION 0x0010")]
    public const int TF_SENTENCEMODE_CONVERSATION = 0x0010;

    [NativeTypeName("#define TF_TRANSITORYEXTENSION_NONE 0x0000")]
    public const int TF_TRANSITORYEXTENSION_NONE = 0x0000;

    [NativeTypeName("#define TF_TRANSITORYEXTENSION_FLOATING 0x0001")]
    public const int TF_TRANSITORYEXTENSION_FLOATING = 0x0001;

    [NativeTypeName("#define TF_TRANSITORYEXTENSION_ATSELECTION 0x0002")]
    public const int TF_TRANSITORYEXTENSION_ATSELECTION = 0x0002;

    [NativeTypeName("#define TF_PROFILETYPE_INPUTPROCESSOR 0x0001")]
    public const int TF_PROFILETYPE_INPUTPROCESSOR = 0x0001;

    [NativeTypeName("#define TF_PROFILETYPE_KEYBOARDLAYOUT 0x0002")]
    public const int TF_PROFILETYPE_KEYBOARDLAYOUT = 0x0002;

    [NativeTypeName("#define TF_RIP_FLAG_FREEUNUSEDLIBRARIES 0x00000001")]
    public const int TF_RIP_FLAG_FREEUNUSEDLIBRARIES = 0x00000001;

    [NativeTypeName("#define TF_IPP_FLAG_ACTIVE 0x00000001")]
    public const int TF_IPP_FLAG_ACTIVE = 0x00000001;

    [NativeTypeName("#define TF_IPP_FLAG_ENABLED 0x00000002")]
    public const int TF_IPP_FLAG_ENABLED = 0x00000002;

    [NativeTypeName("#define TF_IPP_FLAG_SUBSTITUTEDBYINPUTPROCESSOR 0x00000004")]
    public const int TF_IPP_FLAG_SUBSTITUTEDBYINPUTPROCESSOR = 0x00000004;

    [NativeTypeName("#define TF_IPP_CAPS_DISABLEONTRANSITORY 0x00000001")]
    public const int TF_IPP_CAPS_DISABLEONTRANSITORY = 0x00000001;

    [NativeTypeName("#define TF_IPP_CAPS_SECUREMODESUPPORT 0x00000002")]
    public const int TF_IPP_CAPS_SECUREMODESUPPORT = 0x00000002;

    [NativeTypeName("#define TF_IPP_CAPS_UIELEMENTENABLED 0x00000004")]
    public const int TF_IPP_CAPS_UIELEMENTENABLED = 0x00000004;

    [NativeTypeName("#define TF_IPP_CAPS_COMLESSSUPPORT 0x00000008")]
    public const int TF_IPP_CAPS_COMLESSSUPPORT = 0x00000008;

    [NativeTypeName("#define TF_IPP_CAPS_WOW16SUPPORT 0x00000010")]
    public const int TF_IPP_CAPS_WOW16SUPPORT = 0x00000010;

    [NativeTypeName("#define TF_IPP_CAPS_IMMERSIVESUPPORT 0x00010000")]
    public const int TF_IPP_CAPS_IMMERSIVESUPPORT = 0x00010000;

    [NativeTypeName("#define TF_IPP_CAPS_SYSTRAYSUPPORT 0x00020000")]
    public const int TF_IPP_CAPS_SYSTRAYSUPPORT = 0x00020000;

    [NativeTypeName("#define TF_IPPMF_FORPROCESS 0x10000000")]
    public const int TF_IPPMF_FORPROCESS = 0x10000000;

    [NativeTypeName("#define TF_IPPMF_FORSESSION 0x20000000")]
    public const int TF_IPPMF_FORSESSION = 0x20000000;

    [NativeTypeName("#define TF_IPPMF_FORSYSTEMALL 0x40000000")]
    public const int TF_IPPMF_FORSYSTEMALL = 0x40000000;

    [NativeTypeName("#define TF_IPPMF_ENABLEPROFILE 0x00000001")]
    public const int TF_IPPMF_ENABLEPROFILE = 0x00000001;

    [NativeTypeName("#define TF_IPPMF_DISABLEPROFILE 0x00000002")]
    public const int TF_IPPMF_DISABLEPROFILE = 0x00000002;

    [NativeTypeName("#define TF_IPPMF_DONTCARECURRENTINPUTLANGUAGE 0x00000004")]
    public const int TF_IPPMF_DONTCARECURRENTINPUTLANGUAGE = 0x00000004;

    [NativeTypeName("#define TF_RP_HIDDENINSETTINGUI 0x00000002")]
    public const int TF_RP_HIDDENINSETTINGUI = 0x00000002;

    [NativeTypeName("#define TF_RP_LOCALPROCESS 0x00000004")]
    public const int TF_RP_LOCALPROCESS = 0x00000004;

    [NativeTypeName("#define TF_RP_LOCALTHREAD 0x00000008")]
    public const int TF_RP_LOCALTHREAD = 0x00000008;

    [NativeTypeName("#define TF_RP_SUBITEMINSETTINGUI 0x00000010")]
    public const int TF_RP_SUBITEMINSETTINGUI = 0x00000010;

    [NativeTypeName("#define TF_URP_ALLPROFILES 0x00000002")]
    public const int TF_URP_ALLPROFILES = 0x00000002;

    [NativeTypeName("#define TF_URP_LOCALPROCESS 0x00000004")]
    public const int TF_URP_LOCALPROCESS = 0x00000004;

    [NativeTypeName("#define TF_URP_LOCALTHREAD 0x00000008")]
    public const int TF_URP_LOCALTHREAD = 0x00000008;

    [NativeTypeName("#define TF_IPSINK_FLAG_ACTIVE 0x0001")]
    public const int TF_IPSINK_FLAG_ACTIVE = 0x0001;

    [NativeTypeName("#define TF_INVALID_EDIT_COOKIE ( 0 )")]
    public const int TF_INVALID_EDIT_COOKIE = (0);

    [NativeTypeName("#define TF_POPF_ALL ( 0x1 )")]
    public const int TF_POPF_ALL = (0x1);

    [NativeTypeName("#define TF_ES_ASYNCDONTCARE ( 0 )")]
    public const int TF_ES_ASYNCDONTCARE = (0);

    [NativeTypeName("#define TF_ES_SYNC ( 0x1 )")]
    public const int TF_ES_SYNC = (0x1);

    [NativeTypeName("#define TF_ES_READ ( 0x2 )")]
    public const int TF_ES_READ = (0x2);

    [NativeTypeName("#define TF_ES_READWRITE ( 0x6 )")]
    public const int TF_ES_READWRITE = (0x6);

    [NativeTypeName("#define TF_ES_ASYNC ( 0x8 )")]
    public const int TF_ES_ASYNC = (0x8);

    [NativeTypeName("#define TF_DEFAULT_SELECTION ( TS_DEFAULT_SELECTION )")]
    public const uint TF_DEFAULT_SELECTION = unchecked(((uint)(-1)));

    [NativeTypeName("#define TF_SD_READONLY ( TS_SD_READONLY )")]
    public const int TF_SD_READONLY = ((0x1));

    [NativeTypeName("#define TF_SD_LOADING ( TS_SD_LOADING )")]
    public const int TF_SD_LOADING = ((0x2));

    [NativeTypeName("#define TF_SS_DISJOINTSEL ( TS_SS_DISJOINTSEL )")]
    public const int TF_SS_DISJOINTSEL = ((0x1));

    [NativeTypeName("#define TF_SS_REGIONS ( TS_SS_REGIONS )")]
    public const int TF_SS_REGIONS = ((0x2));

    [NativeTypeName("#define TF_SS_TRANSITORY ( TS_SS_TRANSITORY )")]
    public const int TF_SS_TRANSITORY = ((0x4));

    [NativeTypeName("#define TF_SS_TKBAUTOCORRECTENABLE ( TS_SS_TKBAUTOCORRECTENABLE )")]
    public const int TF_SS_TKBAUTOCORRECTENABLE = ((0x10));

    [NativeTypeName("#define TF_SS_TKBPREDICTIONENABLE ( TS_SS_TKBPREDICTIONENABLE )")]
    public const int TF_SS_TKBPREDICTIONENABLE = ((0x20));

    [NativeTypeName("#define TF_IAS_NOQUERY ( 0x1 )")]
    public const int TF_IAS_NOQUERY = (0x1);

    [NativeTypeName("#define TF_IAS_QUERYONLY ( 0x2 )")]
    public const int TF_IAS_QUERYONLY = (0x2);

    [NativeTypeName("#define TF_IAS_NO_DEFAULT_COMPOSITION ( 0x80000000 )")]
    public const uint TF_IAS_NO_DEFAULT_COMPOSITION = (0x80000000);

    [NativeTypeName("#define TF_GTP_INCL_TEXT ( 0x1 )")]
    public const int TF_GTP_INCL_TEXT = (0x1);

    [NativeTypeName("#define TF_CHAR_EMBEDDED ( TS_CHAR_EMBEDDED )")]
    public const int TF_CHAR_EMBEDDED = ((0xfffc));

    [NativeTypeName("#define TF_HF_OBJECT ( 1 )")]
    public const int TF_HF_OBJECT = (1);

    [NativeTypeName("#define TF_TF_MOVESTART ( 1 )")]
    public const int TF_TF_MOVESTART = (1);

    [NativeTypeName("#define TF_TF_IGNOREEND ( 2 )")]
    public const int TF_TF_IGNOREEND = (2);

    [NativeTypeName("#define TF_ST_CORRECTION ( 1 )")]
    public const int TF_ST_CORRECTION = (1);

    [NativeTypeName("#define TF_IE_CORRECTION ( 1 )")]
    public const int TF_IE_CORRECTION = (1);

    [NativeTypeName("#define TF_TU_CORRECTION ( 0x1 )")]
    public const int TF_TU_CORRECTION = (0x1);

    [NativeTypeName("#define TF_INVALID_COOKIE ( 0xffffffff )")]
    public const uint TF_INVALID_COOKIE = (0xffffffff);
}
