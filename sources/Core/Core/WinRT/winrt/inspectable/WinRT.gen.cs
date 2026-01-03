// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserFree"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserFree")]
    [SupportedOSPlatform("windows6.2")]
    public static extern void Free(
        [NativeTypeName("unsigned long *")] uint* param0,
        HString* param1
    );

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserFree")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Free(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        Ref<HString> param1
    )
    {
        fixed (HString* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            Free(__dsl_param0, __dsl_param1);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserFree64"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserFree64")]
    [SupportedOSPlatform("windows6.2")]
    public static extern void Free64(
        [NativeTypeName("unsigned long *")] uint* param0,
        HString* param1
    );

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserFree64")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Free64(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        Ref<HString> param1
    )
    {
        fixed (HString* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            Free64(__dsl_param0, __dsl_param1);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserMarshal"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserMarshal")]
    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    public static extern byte* Marshal(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned char *")] byte* param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserMarshal")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<byte> Marshal(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned char *")] Ref<byte> param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (byte* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            return (byte*)Marshal(__dsl_param0, __dsl_param1, __dsl_param2);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserMarshal64"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserMarshal64")]
    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    public static extern byte* Marshal64(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned char *")] byte* param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserMarshal64")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<byte> Marshal64(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned char *")] Ref<byte> param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (byte* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            return (byte*)Marshal64(__dsl_param0, __dsl_param1, __dsl_param2);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserSize"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserSize")]
    [return: NativeTypeName("unsigned long")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint Size(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned long")] uint param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned long")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserSize")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Size(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned long")] uint param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (uint* __dsl_param0 = param0)
        {
            return (uint)Size(__dsl_param0, param1, __dsl_param2);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserSize64"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserSize64")]
    [return: NativeTypeName("unsigned long")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint Size64(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned long")] uint param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned long")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserSize64")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Size64(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned long")] uint param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (uint* __dsl_param0 = param0)
        {
            return (uint)Size64(__dsl_param0, param1, __dsl_param2);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserUnmarshal"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserUnmarshal")]
    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    public static extern byte* Unmarshal(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned char *")] byte* param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserUnmarshal")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<byte> Unmarshal(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned char *")] Ref<byte> param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (byte* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            return (byte*)Unmarshal(__dsl_param0, __dsl_param1, __dsl_param2);
        }
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.HSTRING_UserUnmarshal64"]/*'/>

    [DllImport("combase", ExactSpelling = true, EntryPoint = "HSTRING_UserUnmarshal64")]
    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    public static extern byte* Unmarshal64(
        [NativeTypeName("unsigned long *")] uint* param0,
        [NativeTypeName("unsigned char *")] byte* param1,
        HString* param2
    );

    [return: NativeTypeName("unsigned char *")]
    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [NativeFunction("combase", EntryPoint = "HSTRING_UserUnmarshal64")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<byte> Unmarshal64(
        [NativeTypeName("unsigned long *")] Ref<uint> param0,
        [NativeTypeName("unsigned char *")] Ref<byte> param1,
        Ref<HString> param2
    )
    {
        fixed (HString* __dsl_param2 = param2)
        fixed (byte* __dsl_param1 = param1)
        fixed (uint* __dsl_param0 = param0)
        {
            return (byte*)Unmarshal64(__dsl_param0, __dsl_param1, __dsl_param2);
        }
    }
}
