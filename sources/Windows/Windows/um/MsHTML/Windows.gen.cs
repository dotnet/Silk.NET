// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_EditStateCommands
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define COOKIEACTION_NONE 0x00000000")]
    public const int COOKIEACTION_NONE = 0x00000000;
    [NativeTypeName("#define COOKIEACTION_ACCEPT 0x00000001")]
    public const int COOKIEACTION_ACCEPT = 0x00000001;
    [NativeTypeName("#define COOKIEACTION_REJECT 0x00000002")]
    public const int COOKIEACTION_REJECT = 0x00000002;
    [NativeTypeName("#define COOKIEACTION_DOWNGRADE 0x00000004")]
    public const int COOKIEACTION_DOWNGRADE = 0x00000004;
    [NativeTypeName("#define COOKIEACTION_LEASH 0x00000008")]
    public const int COOKIEACTION_LEASH = 0x00000008;
    [NativeTypeName("#define COOKIEACTION_SUPPRESS 0x00000010")]
    public const int COOKIEACTION_SUPPRESS = 0x00000010;
    [NativeTypeName("#define COOKIEACTION_READ 0x00000020")]
    public const int COOKIEACTION_READ = 0x00000020;
    [NativeTypeName("#define PRIVACY_URLISTOPLEVEL 0x00010000")]
    public const int PRIVACY_URLISTOPLEVEL = 0x00010000;
    [NativeTypeName("#define PRIVACY_URLHASCOMPACTPOLICY 0x00020000")]
    public const int PRIVACY_URLHASCOMPACTPOLICY = 0x00020000;
    [NativeTypeName("#define PRIVACY_URLHASPOSTDATA 0x00080000")]
    public const int PRIVACY_URLHASPOSTDATA = 0x00080000;
    [NativeTypeName("#define PRIVACY_URLHASPOLICYREFLINK 0x00100000")]
    public const int PRIVACY_URLHASPOLICYREFLINK = 0x00100000;
    [NativeTypeName("#define PRIVACY_URLHASPOLICYREFHEADER 0x00200000")]
    public const int PRIVACY_URLHASPOLICYREFHEADER = 0x00200000;
    [NativeTypeName("#define PRIVACY_URLHASP3PHEADER 0x00400000")]
    public const int PRIVACY_URLHASP3PHEADER = 0x00400000;
    [NativeTypeName("#define DEBUGCALLBACKNOTIFICATION_TIMEOUT 0x00000001")]
    public const int DEBUGCALLBACKNOTIFICATION_TIMEOUT = 0x00000001;
    [NativeTypeName("#define DEBUGCALLBACKNOTIFICATION_INTERVAL 0x00000002")]
    public const int DEBUGCALLBACKNOTIFICATION_INTERVAL = 0x00000002;
    [NativeTypeName("#define DEBUGCALLBACKNOTIFICATION_IMMEDIATE 0x00000004")]
    public const int DEBUGCALLBACKNOTIFICATION_IMMEDIATE = 0x00000004;
    [NativeTypeName("#define DEBUGCALLBACKNOTIFICATION_ANIMATIONFRAME 0x00000008")]
    public const int DEBUGCALLBACKNOTIFICATION_ANIMATIONFRAME = 0x00000008;
    [NativeTypeName("#define DEBUGCALLBACKNOTIFICATION_DOMEVENT 0x00000010")]
    public const int DEBUGCALLBACKNOTIFICATION_DOMEVENT = 0x00000010;
    [NativeTypeName("#define DEBUGDOMEVENTPROPAGATIONSTATUS_DEFAULTCANCELED 0x00000001")]
    public const int DEBUGDOMEVENTPROPAGATIONSTATUS_DEFAULTCANCELED = 0x00000001;
    [NativeTypeName("#define DEBUGDOMEVENTPROPAGATIONSTATUS_STOPIMMEDIATEPROPAGATION 0x00000002")]
    public const int DEBUGDOMEVENTPROPAGATIONSTATUS_STOPIMMEDIATEPROPAGATION = 0x00000002;
    [NativeTypeName("#define DEBUGDOMEVENTPROPAGATIONSTATUS_STOPPROPAGATION 0x00000004")]
    public const int DEBUGDOMEVENTPROPAGATIONSTATUS_STOPPROPAGATION = 0x00000004;
}