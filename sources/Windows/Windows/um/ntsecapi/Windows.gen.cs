// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System_SecurityStateChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System_SecuritySubsystemExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x11, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System_Integrity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x12, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System_IPSecDriverEvents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x13, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x14, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_Logon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x15, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_Logoff
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x16, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_AccountLockout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x17, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_IPSecMainMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x18, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_IPSecQuickMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x19, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_IPSecUserMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1A, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_SpecialLogon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1B, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1C, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_FileSystem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1D, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Registry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1E, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Kernel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1F, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Sam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_CertificationServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x21, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_ApplicationGenerated
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x22, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Handle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x23, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Share
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_FirewallPacketDrops
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x25, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_FirewallConnection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x26, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_Other
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x27, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PrivilegeUse_Sensitive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x28, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PrivilegeUse_NonSensitive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x29, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PrivilegeUse_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2A, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_ProcessCreation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2B, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_ProcessTermination
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2C, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_DpapiActivity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_RpcCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2E, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_AuditPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2F, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_AuthenticationPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x30, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_AuthorizationPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x31, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_MpsscvRulePolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x32, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_WfpIPSecPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x33, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x34, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_UserAccount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x35, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_ComputerAccount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x36, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_SecurityGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x37, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_DistributionGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x38, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_ApplicationGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x39, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3A, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DSAccess_DSAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3B, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DsAccess_AdAuditChanges
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3C, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Ds_Replication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3D, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Ds_DetailedReplication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3E, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountLogon_CredentialValidation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3F, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountLogon_Kerberos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountLogon_Others
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountLogon_KerbCredentialValidation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x42, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_NPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x43, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_DetailedFileShare
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x44, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_RemovableStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess_CbacStaging
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x46, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_Claims
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x47, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_PnpActivity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x48, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon_Groups
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x49, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking_TokenRightAdjusted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4A, 0x92, 0xCE, 0x0C,
                0xAE, 0x69,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_System
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x48, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_Logon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x49, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_ObjectAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4A, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PrivilegeUse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4B, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DetailedTracking
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4C, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_PolicyChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4D, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountManagement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4E, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_DirectoryServiceAccess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4F, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid Audit_AccountLogon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x50, 0x98, 0x97, 0x69,
                0x7A, 0x79,
                0xD9, 0x11,
                0xBE,
                0xD3,
                0x50,
                0x50,
                0x54,
                0x50,
                0x30,
                0x30
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaRegisterLogonProcess"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaRegisterLogonProcess([NativeTypeName("PLSA_STRING")] LSA_STRING* LogonProcessName, [NativeTypeName("PHANDLE")] HANDLE* LsaHandle, [NativeTypeName("PLSA_OPERATIONAL_MODE")] uint* SecurityMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLogonUser"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLogonUser(HANDLE LsaHandle, [NativeTypeName("PLSA_STRING")] LSA_STRING* OriginName, SECURITY_LOGON_TYPE LogonType, [NativeTypeName("ULONG")] uint AuthenticationPackage, [NativeTypeName("PVOID")] void* AuthenticationInformation, [NativeTypeName("ULONG")] uint AuthenticationInformationLength, [NativeTypeName("PTOKEN_GROUPS")] TOKEN_GROUPS* LocalGroups, [NativeTypeName("PTOKEN_SOURCE")] TOKEN_SOURCE* SourceContext, [NativeTypeName("PVOID *")] void** ProfileBuffer, [NativeTypeName("PULONG")] uint* ProfileBufferLength, [NativeTypeName("PLUID")] LUID* LogonId, [NativeTypeName("PHANDLE")] HANDLE* Token, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* Quotas, [NativeTypeName("PNTSTATUS")] int* SubStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLookupAuthenticationPackage"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupAuthenticationPackage(HANDLE LsaHandle, [NativeTypeName("PLSA_STRING")] LSA_STRING* PackageName, [NativeTypeName("PULONG")] uint* AuthenticationPackage);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaFreeReturnBuffer"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaFreeReturnBuffer([NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaCallAuthenticationPackage"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaCallAuthenticationPackage(HANDLE LsaHandle, [NativeTypeName("ULONG")] uint AuthenticationPackage, [NativeTypeName("PVOID")] void* ProtocolSubmitBuffer, [NativeTypeName("ULONG")] uint SubmitBufferLength, [NativeTypeName("PVOID *")] void** ProtocolReturnBuffer, [NativeTypeName("PULONG")] uint* ReturnBufferLength, [NativeTypeName("PNTSTATUS")] int* ProtocolStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaDeregisterLogonProcess"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaDeregisterLogonProcess(HANDLE LsaHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaConnectUntrusted"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaConnectUntrusted([NativeTypeName("PHANDLE")] HANDLE* LsaHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaFreeMemory"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaFreeMemory([NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaClose"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaClose([NativeTypeName("LSA_HANDLE")] void* ObjectHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaEnumerateLogonSessions"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaEnumerateLogonSessions([NativeTypeName("PULONG")] uint* LogonSessionCount, [NativeTypeName("PLUID *")] LUID** LogonSessionList);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaGetLogonSessionData"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaGetLogonSessionData([NativeTypeName("PLUID")] LUID* LogonId, [NativeTypeName("PSECURITY_LOGON_SESSION_DATA *")] SECURITY_LOGON_SESSION_DATA** ppLogonSessionData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaOpenPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaOpenPolicy([NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* SystemName, [NativeTypeName("PLSA_OBJECT_ATTRIBUTES")] LSA_OBJECT_ATTRIBUTES* ObjectAttributes, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("PLSA_HANDLE")] void** PolicyHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetCAPs"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetCAPs([NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* CAPDNs, [NativeTypeName("ULONG")] uint CAPDNCount, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaGetAppliedCAPIDs"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaGetAppliedCAPIDs([NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* SystemName, [NativeTypeName("PSID **")] void*** CAPIDs, [NativeTypeName("PULONG")] uint* CAPIDCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryCAPs"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryCAPs([NativeTypeName("PSID *")] void** CAPIDs, [NativeTypeName("ULONG")] uint CAPIDCount, [NativeTypeName("PCENTRAL_ACCESS_POLICY *")] CENTRAL_ACCESS_POLICY** CAPs, [NativeTypeName("PULONG")] uint* CAPCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryInformationPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryInformationPolicy([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, POLICY_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID *")] void** Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetInformationPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetInformationPolicy([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, POLICY_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryDomainInformationPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryDomainInformationPolicy([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, POLICY_DOMAIN_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID *")] void** Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetDomainInformationPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetDomainInformationPolicy([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, POLICY_DOMAIN_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaRegisterPolicyChangeNotification"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaRegisterPolicyChangeNotification(POLICY_NOTIFICATION_INFORMATION_CLASS InformationClass, HANDLE NotificationEventHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaUnregisterPolicyChangeNotification"]/*' />
    [DllImport("secur32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaUnregisterPolicyChangeNotification(POLICY_NOTIFICATION_INFORMATION_CLASS InformationClass, HANDLE NotificationEventHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaEnumerateTrustedDomains"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaEnumerateTrustedDomains([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_ENUMERATION_HANDLE")] uint* EnumerationContext, [NativeTypeName("PVOID *")] void** Buffer, [NativeTypeName("ULONG")] uint PreferedMaximumLength, [NativeTypeName("PULONG")] uint* CountReturned);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLookupNames"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupNames([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("ULONG")] uint Count, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* Names, [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")] LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains, [NativeTypeName("PLSA_TRANSLATED_SID *")] LSA_TRANSLATED_SID** Sids);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLookupNames2"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int LsaLookupNames2([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("ULONG")] uint Count, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* Names, [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")] LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains, [NativeTypeName("PLSA_TRANSLATED_SID2 *")] LSA_TRANSLATED_SID2** Sids);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLookupSids"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaLookupSids([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("ULONG")] uint Count, [NativeTypeName("PSID *")] void** Sids, [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")] LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains, [NativeTypeName("PLSA_TRANSLATED_NAME *")] LSA_TRANSLATED_NAME** Names);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaLookupSids2"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int LsaLookupSids2([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("ULONG")] uint LookupOptions, [NativeTypeName("ULONG")] uint Count, [NativeTypeName("PSID *")] void** Sids, [NativeTypeName("PLSA_REFERENCED_DOMAIN_LIST *")] LSA_REFERENCED_DOMAIN_LIST** ReferencedDomains, [NativeTypeName("PLSA_TRANSLATED_NAME *")] LSA_TRANSLATED_NAME** Names);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaEnumerateAccountsWithUserRight"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaEnumerateAccountsWithUserRight([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* UserRight, [NativeTypeName("PVOID *")] void** Buffer, [NativeTypeName("PULONG")] uint* CountReturned);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaEnumerateAccountRights"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaEnumerateAccountRights([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* AccountSid, [NativeTypeName("PLSA_UNICODE_STRING *")] LSA_UNICODE_STRING** UserRights, [NativeTypeName("PULONG")] uint* CountOfRights);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaAddAccountRights"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaAddAccountRights([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* AccountSid, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* UserRights, [NativeTypeName("ULONG")] uint CountOfRights);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaRemoveAccountRights"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaRemoveAccountRights([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* AccountSid, [NativeTypeName("BOOLEAN")] byte AllRights, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* UserRights, [NativeTypeName("ULONG")] uint CountOfRights);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaOpenTrustedDomainByName"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaOpenTrustedDomainByName([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("PLSA_HANDLE")] void** TrustedDomainHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryTrustedDomainInfo"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryTrustedDomainInfo([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* TrustedDomainSid, TRUSTED_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID *")] void** Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetTrustedDomainInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetTrustedDomainInformation([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* TrustedDomainSid, TRUSTED_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaDeleteTrustedDomain"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaDeleteTrustedDomain([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PSID")] void* TrustedDomainSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryTrustedDomainInfoByName"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryTrustedDomainInfoByName([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, TRUSTED_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID *")] void** Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetTrustedDomainInfoByName"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetTrustedDomainInfoByName([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, TRUSTED_INFORMATION_CLASS InformationClass, [NativeTypeName("PVOID")] void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaEnumerateTrustedDomainsEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaEnumerateTrustedDomainsEx([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_ENUMERATION_HANDLE")] uint* EnumerationContext, [NativeTypeName("PVOID *")] void** Buffer, [NativeTypeName("ULONG")] uint PreferedMaximumLength, [NativeTypeName("PULONG")] uint* CountReturned);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaCreateTrustedDomainEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaCreateTrustedDomainEx([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PTRUSTED_DOMAIN_INFORMATION_EX")] TRUSTED_DOMAIN_INFORMATION_EX* TrustedDomainInformation, [NativeTypeName("PTRUSTED_DOMAIN_AUTH_INFORMATION")] TRUSTED_DOMAIN_AUTH_INFORMATION* AuthenticationInformation, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("PLSA_HANDLE")] void** TrustedDomainHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryForestTrustInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryForestTrustInformation([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, [NativeTypeName("PLSA_FOREST_TRUST_INFORMATION *")] LSA_FOREST_TRUST_INFORMATION** ForestTrustInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetForestTrustInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetForestTrustInformation([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, [NativeTypeName("PLSA_FOREST_TRUST_INFORMATION")] LSA_FOREST_TRUST_INFORMATION* ForestTrustInfo, [NativeTypeName("BOOLEAN")] byte CheckOnly, [NativeTypeName("PLSA_FOREST_TRUST_COLLISION_INFORMATION *")] LSA_FOREST_TRUST_COLLISION_INFORMATION** CollisionInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaStorePrivateData"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaStorePrivateData([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* KeyName, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* PrivateData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaRetrievePrivateData"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaRetrievePrivateData([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* KeyName, [NativeTypeName("PLSA_UNICODE_STRING *")] LSA_UNICODE_STRING** PrivateData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaNtStatusToWinError"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint LsaNtStatusToWinError([NativeTypeName("NTSTATUS")] int Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaQueryForestTrustInformation2"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaQueryForestTrustInformation2([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, LSA_FOREST_TRUST_RECORD_TYPE HighestRecordType, [NativeTypeName("PLSA_FOREST_TRUST_INFORMATION2 *")] LSA_FOREST_TRUST_INFORMATION2** ForestTrustInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LsaSetForestTrustInformation2"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int LsaSetForestTrustInformation2([NativeTypeName("LSA_HANDLE")] void* PolicyHandle, [NativeTypeName("PLSA_UNICODE_STRING")] LSA_UNICODE_STRING* TrustedDomainName, LSA_FOREST_TRUST_RECORD_TYPE HighestRecordType, [NativeTypeName("PLSA_FOREST_TRUST_INFORMATION2")] LSA_FOREST_TRUST_INFORMATION2* ForestTrustInfo, [NativeTypeName("BOOLEAN")] byte CheckOnly, [NativeTypeName("PLSA_FOREST_TRUST_COLLISION_INFORMATION *")] LSA_FOREST_TRUST_COLLISION_INFORMATION** CollisionInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemFunction036"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte SystemFunction036([NativeTypeName("PVOID")] void* RandomBuffer, [NativeTypeName("ULONG")] uint RandomBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemFunction040"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int SystemFunction040([NativeTypeName("PVOID")] void* Memory, [NativeTypeName("ULONG")] uint MemorySize, [NativeTypeName("ULONG")] uint OptionFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemFunction041"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int SystemFunction041([NativeTypeName("PVOID")] void* Memory, [NativeTypeName("ULONG")] uint MemorySize, [NativeTypeName("ULONG")] uint OptionFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditSetSystemPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditSetSystemPolicy([NativeTypeName("PCAUDIT_POLICY_INFORMATION")] AUDIT_POLICY_INFORMATION* pAuditPolicy, [NativeTypeName("ULONG")] uint dwPolicyCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditSetPerUserPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditSetPerUserPolicy([NativeTypeName("const PSID")] void* pSid, [NativeTypeName("PCAUDIT_POLICY_INFORMATION")] AUDIT_POLICY_INFORMATION* pAuditPolicy, [NativeTypeName("ULONG")] uint dwPolicyCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditQuerySystemPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditQuerySystemPolicy([NativeTypeName("const GUID *")] Guid* pSubCategoryGuids, [NativeTypeName("ULONG")] uint dwPolicyCount, [NativeTypeName("PAUDIT_POLICY_INFORMATION *")] AUDIT_POLICY_INFORMATION** ppAuditPolicy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditQueryPerUserPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditQueryPerUserPolicy([NativeTypeName("const PSID")] void* pSid, [NativeTypeName("const GUID *")] Guid* pSubCategoryGuids, [NativeTypeName("ULONG")] uint dwPolicyCount, [NativeTypeName("PAUDIT_POLICY_INFORMATION *")] AUDIT_POLICY_INFORMATION** ppAuditPolicy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditEnumeratePerUserPolicy"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditEnumeratePerUserPolicy([NativeTypeName("PPOLICY_AUDIT_SID_ARRAY *")] POLICY_AUDIT_SID_ARRAY** ppAuditSidArray);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditComputeEffectivePolicyBySid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditComputeEffectivePolicyBySid([NativeTypeName("const PSID")] void* pSid, [NativeTypeName("const GUID *")] Guid* pSubCategoryGuids, [NativeTypeName("ULONG")] uint dwPolicyCount, [NativeTypeName("PAUDIT_POLICY_INFORMATION *")] AUDIT_POLICY_INFORMATION** ppAuditPolicy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditComputeEffectivePolicyByToken"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditComputeEffectivePolicyByToken(HANDLE hTokenHandle, [NativeTypeName("const GUID *")] Guid* pSubCategoryGuids, [NativeTypeName("ULONG")] uint dwPolicyCount, [NativeTypeName("PAUDIT_POLICY_INFORMATION *")] AUDIT_POLICY_INFORMATION** ppAuditPolicy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditEnumerateCategories"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditEnumerateCategories(Guid** ppAuditCategoriesArray, [NativeTypeName("PULONG")] uint* pdwCountReturned);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditEnumerateSubCategories"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditEnumerateSubCategories([NativeTypeName("const GUID *")] Guid* pAuditCategoryGuid, [NativeTypeName("BOOLEAN")] byte bRetrieveAllSubCategories, Guid** ppAuditSubCategoriesArray, [NativeTypeName("PULONG")] uint* pdwCountReturned);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupCategoryNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupCategoryNameW([NativeTypeName("const GUID *")] Guid* pAuditCategoryGuid, [NativeTypeName("PWSTR *")] ushort** ppszCategoryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupCategoryNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupCategoryNameA([NativeTypeName("const GUID *")] Guid* pAuditCategoryGuid, [NativeTypeName("PSTR *")] sbyte** ppszCategoryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupSubCategoryNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupSubCategoryNameW([NativeTypeName("const GUID *")] Guid* pAuditSubCategoryGuid, [NativeTypeName("PWSTR *")] ushort** ppszSubCategoryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupSubCategoryNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupSubCategoryNameA([NativeTypeName("const GUID *")] Guid* pAuditSubCategoryGuid, [NativeTypeName("PSTR *")] sbyte** ppszSubCategoryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupCategoryIdFromCategoryGuid"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupCategoryIdFromCategoryGuid([NativeTypeName("const GUID *")] Guid* pAuditCategoryGuid, [NativeTypeName("PPOLICY_AUDIT_EVENT_TYPE")] POLICY_AUDIT_EVENT_TYPE* pAuditCategoryId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditLookupCategoryGuidFromCategoryId"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditLookupCategoryGuidFromCategoryId(POLICY_AUDIT_EVENT_TYPE AuditCategoryId, Guid* pAuditCategoryGuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditSetSecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditSetSecurity([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditQuerySecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditQuerySecurity([NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** ppSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditSetGlobalSaclW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditSetGlobalSaclW([NativeTypeName("PCWSTR")] ushort* ObjectTypeName, [NativeTypeName("PACL")] ACL* Acl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditSetGlobalSaclA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditSetGlobalSaclA([NativeTypeName("PCSTR")] sbyte* ObjectTypeName, [NativeTypeName("PACL")] ACL* Acl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditQueryGlobalSaclW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditQueryGlobalSaclW([NativeTypeName("PCWSTR")] ushort* ObjectTypeName, [NativeTypeName("PACL *")] ACL** Acl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditQueryGlobalSaclA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte AuditQueryGlobalSaclA([NativeTypeName("PCSTR")] sbyte* ObjectTypeName, [NativeTypeName("PACL *")] ACL** Acl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AuditFree"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void AuditFree([NativeTypeName("PVOID")] void* Buffer);

    [NativeTypeName("#define LSA_MODE_PASSWORD_PROTECTED (0x00000001L)")]
    public const int LSA_MODE_PASSWORD_PROTECTED = (0x00000001);

    [NativeTypeName("#define LSA_MODE_INDIVIDUAL_ACCOUNTS (0x00000002L)")]
    public const int LSA_MODE_INDIVIDUAL_ACCOUNTS = (0x00000002);

    [NativeTypeName("#define LSA_MODE_MANDATORY_ACCESS (0x00000004L)")]
    public const int LSA_MODE_MANDATORY_ACCESS = (0x00000004);

    [NativeTypeName("#define LSA_MODE_LOG_FULL (0x00000008L)")]
    public const int LSA_MODE_LOG_FULL = (0x00000008);

    [NativeTypeName("#define VALID_PER_USER_AUDIT_POLICY_FLAG (PER_USER_AUDIT_SUCCESS_INCLUDE | \\\r\n                                          PER_USER_AUDIT_SUCCESS_EXCLUDE | \\\r\n                                          PER_USER_AUDIT_FAILURE_INCLUDE | \\\r\n                                          PER_USER_AUDIT_FAILURE_EXCLUDE | \\\r\n                                          PER_USER_AUDIT_NONE)")]
    public const int VALID_PER_USER_AUDIT_POLICY_FLAG = ((0x01) | (0x02) | (0x04) | (0x08) | (0x10));

    [NativeTypeName("#define LSAD_AES_CRYPT_SHA512_HASH_SIZE 64")]
    public const int LSAD_AES_CRYPT_SHA512_HASH_SIZE = 64;

    [NativeTypeName("#define LSAD_AES_KEY_SIZE 16")]
    public const int LSAD_AES_KEY_SIZE = 16;

    [NativeTypeName("#define LSAD_AES_SALT_SIZE 16")]
    public const int LSAD_AES_SALT_SIZE = 16;

    [NativeTypeName("#define LSAD_AES_BLOCK_SIZE 16")]
    public const int LSAD_AES_BLOCK_SIZE = 16;

    [NativeTypeName("#define LSA_FTRECORD_DISABLED_REASONS ( 0x0000FFFFL )")]
    public const int LSA_FTRECORD_DISABLED_REASONS = (0x0000FFFF);

    [NativeTypeName("#define LSA_SID_DISABLED_ADMIN ( 0x00000001L )")]
    public const int LSA_SID_DISABLED_ADMIN = (0x00000001);

    [NativeTypeName("#define LSA_SID_DISABLED_CONFLICT ( 0x00000002L )")]
    public const int LSA_SID_DISABLED_CONFLICT = (0x00000002);

    [NativeTypeName("#define LSA_NB_DISABLED_ADMIN ( 0x00000004L )")]
    public const int LSA_NB_DISABLED_ADMIN = (0x00000004);

    [NativeTypeName("#define LSA_NB_DISABLED_CONFLICT ( 0x00000008L )")]
    public const int LSA_NB_DISABLED_CONFLICT = (0x00000008);

    [NativeTypeName("#define LSA_SCANNER_INFO_DISABLE_AUTH_TARGET_VALIDATION ( 0x00000001L )")]
    public const int LSA_SCANNER_INFO_DISABLE_AUTH_TARGET_VALIDATION = (0x00000001);

    [NativeTypeName("#define LSA_SCANNER_INFO_ADMIN_ALL_FLAGS (LSA_SCANNER_INFO_DISABLE_AUTH_TARGET_VALIDATION)")]
    public const int LSA_SCANNER_INFO_ADMIN_ALL_FLAGS = ((0x00000001));

    [NativeTypeName("#define LSASETCAPS_RELOAD_FLAG 0x00000001")]
    public const int LSASETCAPS_RELOAD_FLAG = 0x00000001;

    [NativeTypeName("#define LSASETCAPS_VALID_FLAG_MASK (                                                   \\\r\n            LSASETCAPS_RELOAD_FLAG                         \\\r\n        )")]
    public const int LSASETCAPS_VALID_FLAG_MASK = (0x00000001);

    [NativeTypeName("#define NEGOTIATE_MAX_PREFIX 32")]
    public const int NEGOTIATE_MAX_PREFIX = 32;

    [NativeTypeName("#define SAM_PASSWORD_CHANGE_NOTIFY_ROUTINE \"PasswordChangeNotify\"")]
    public static ReadOnlySpan<byte> SAM_PASSWORD_CHANGE_NOTIFY_ROUTINE => "PasswordChangeNotify"u8;

    [NativeTypeName("#define SAM_INIT_NOTIFICATION_ROUTINE \"InitializeChangeNotify\"")]
    public static ReadOnlySpan<byte> SAM_INIT_NOTIFICATION_ROUTINE => "InitializeChangeNotify"u8;

    [NativeTypeName("#define SAM_PASSWORD_FILTER_ROUTINE \"PasswordFilter\"")]
    public static ReadOnlySpan<byte> SAM_PASSWORD_FILTER_ROUTINE => "PasswordFilter"u8;

    [NativeTypeName("#define RtlGenRandom SystemFunction036")]
    public static delegate*<void*, uint, byte> RtlGenRandom => &SystemFunction036;

    [NativeTypeName("#define RtlEncryptMemory SystemFunction040")]
    public static delegate*<void*, uint, uint, int> RtlEncryptMemory => &SystemFunction040;

    [NativeTypeName("#define RtlDecryptMemory SystemFunction041")]
    public static delegate*<void*, uint, uint, int> RtlDecryptMemory => &SystemFunction041;

    [NativeTypeName("#define RTL_ENCRYPT_MEMORY_SIZE 8")]
    public const int RTL_ENCRYPT_MEMORY_SIZE = 8;

    [NativeTypeName("#define RTL_ENCRYPT_OPTION_CROSS_PROCESS 0x01")]
    public const int RTL_ENCRYPT_OPTION_CROSS_PROCESS = 0x01;

    [NativeTypeName("#define RTL_ENCRYPT_OPTION_SAME_LOGON 0x02")]
    public const int RTL_ENCRYPT_OPTION_SAME_LOGON = 0x02;

    [NativeTypeName("#define RTL_ENCRYPT_OPTION_FOR_SYSTEM 0x04")]
    public const int RTL_ENCRYPT_OPTION_FOR_SYSTEM = 0x04;

    [NativeTypeName("#define KERBEROS_VERSION 5")]
    public const int KERBEROS_VERSION = 5;

    [NativeTypeName("#define KERBEROS_REVISION 6")]
    public const int KERBEROS_REVISION = 6;

    [NativeTypeName("#define MICROSOFT_KERBEROS_NAME_A \"Kerberos\"")]
    public static ReadOnlySpan<byte> MICROSOFT_KERBEROS_NAME_A => "Kerberos"u8;

    [NativeTypeName("#define MICROSOFT_KERBEROS_NAME_W L\"Kerberos\"")]
    public const string MICROSOFT_KERBEROS_NAME_W = "Kerberos";

    [NativeTypeName("#define MICROSOFT_KERBEROS_NAME MICROSOFT_KERBEROS_NAME_W")]
    public const string MICROSOFT_KERBEROS_NAME = "Kerberos";

    [NativeTypeName("#define AUDIT_SET_SYSTEM_POLICY (0x0001)")]
    public const int AUDIT_SET_SYSTEM_POLICY = (0x0001);

    [NativeTypeName("#define AUDIT_QUERY_SYSTEM_POLICY (0x0002)")]
    public const int AUDIT_QUERY_SYSTEM_POLICY = (0x0002);

    [NativeTypeName("#define AUDIT_SET_USER_POLICY (0x0004)")]
    public const int AUDIT_SET_USER_POLICY = (0x0004);

    [NativeTypeName("#define AUDIT_QUERY_USER_POLICY (0x0008)")]
    public const int AUDIT_QUERY_USER_POLICY = (0x0008);

    [NativeTypeName("#define AUDIT_ENUMERATE_USERS (0x0010)")]
    public const int AUDIT_ENUMERATE_USERS = (0x0010);

    [NativeTypeName("#define AUDIT_SET_MISC_POLICY (0x0020)")]
    public const int AUDIT_SET_MISC_POLICY = (0x0020);

    [NativeTypeName("#define AUDIT_QUERY_MISC_POLICY (0x0040)")]
    public const int AUDIT_QUERY_MISC_POLICY = (0x0040);

    [NativeTypeName("#define AUDIT_GENERIC_ALL (STANDARD_RIGHTS_REQUIRED  |\\\r\n                                      AUDIT_SET_SYSTEM_POLICY   |\\\r\n                                      AUDIT_QUERY_SYSTEM_POLICY |\\\r\n                                      AUDIT_SET_USER_POLICY     |\\\r\n                                      AUDIT_QUERY_USER_POLICY   |\\\r\n                                      AUDIT_ENUMERATE_USERS     |\\\r\n                                      AUDIT_SET_MISC_POLICY     |\\\r\n                                      AUDIT_QUERY_MISC_POLICY)")]
    public const int AUDIT_GENERIC_ALL = ((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040));

    [NativeTypeName("#define AUDIT_GENERIC_READ (STANDARD_RIGHTS_READ      |\\\r\n                                      AUDIT_QUERY_SYSTEM_POLICY |\\\r\n                                      AUDIT_QUERY_USER_POLICY   |\\\r\n                                      AUDIT_ENUMERATE_USERS     |\\\r\n                                      AUDIT_QUERY_MISC_POLICY)")]
    public const int AUDIT_GENERIC_READ = (((0x00020000)) | (0x0002) | (0x0008) | (0x0010) | (0x0040));

    [NativeTypeName("#define AUDIT_GENERIC_WRITE (STANDARD_RIGHTS_WRITE     |\\\r\n                                      AUDIT_SET_USER_POLICY     |\\\r\n                                      AUDIT_SET_MISC_POLICY     |\\\r\n                                      AUDIT_SET_SYSTEM_POLICY)")]
    public const int AUDIT_GENERIC_WRITE = (((0x00020000)) | (0x0004) | (0x0020) | (0x0001));

    [NativeTypeName("#define AUDIT_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
    public const int AUDIT_GENERIC_EXECUTE = (((0x00020000)));

    [NativeTypeName("#define AuditLookupCategoryName AuditLookupCategoryNameW")]
    public static delegate*<Guid*, ushort**, byte> AuditLookupCategoryName => &AuditLookupCategoryNameW;

    [NativeTypeName("#define AuditLookupSubCategoryName AuditLookupSubCategoryNameW")]
    public static delegate*<Guid*, ushort**, byte> AuditLookupSubCategoryName => &AuditLookupSubCategoryNameW;

    [NativeTypeName("#define AuditSetGlobalSacl AuditSetGlobalSaclW")]
    public static delegate*<ushort*, ACL*, byte> AuditSetGlobalSacl => &AuditSetGlobalSaclW;

    [NativeTypeName("#define AuditQueryGlobalSacl AuditQueryGlobalSaclW")]
    public static delegate*<ushort*, ACL**, byte> AuditQueryGlobalSacl => &AuditQueryGlobalSaclW;

    [NativeTypeName("#define PKU2U_PACKAGE_NAME_A \"pku2u\"")]
    public static ReadOnlySpan<byte> PKU2U_PACKAGE_NAME_A => "pku2u"u8;

    [NativeTypeName("#define PKU2U_PACKAGE_NAME L\"pku2u\"")]
    public const string PKU2U_PACKAGE_NAME = "pku2u";

    [NativeTypeName("#define PKU2U_PACKAGE_NAME_W PKU2U_PACKAGE_NAME")]
    public const string PKU2U_PACKAGE_NAME_W = "pku2u";

    [NativeTypeName("#define PKU2U_CREDUI_CONTEXT_VERSION 0x4154414454524543i64")]
    public const long PKU2U_CREDUI_CONTEXT_VERSION = 0x4154414454524543L;
}
