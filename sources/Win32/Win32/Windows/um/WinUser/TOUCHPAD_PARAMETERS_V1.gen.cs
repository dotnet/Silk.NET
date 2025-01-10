// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TOUCHPAD_PARAMETERS_V1
{
    public uint versionNumber;
    public uint maxSupportedContacts;
    public LEGACY_TOUCHPAD_FEATURES legacyTouchpadFeatures;
    public BOOL _bitfield1;

    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 31) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~0x1) | ((BOOL)(value) & 0x1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL legacyTouchpadPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 30) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL externalMousePresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 29) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 28) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadActive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 27) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL feedbackSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 26) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL clickForceSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 25) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6); }
    }

    [NativeTypeName("BOOL : 25")]
    public BOOL Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield1 << 0) >> 7); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (_bitfield1 & ~(0x1FFFFFF << 7)) | (((BOOL)(value) & 0x1FFFFFF) << 7); }
    }
    public BOOL _bitfield2;

    [NativeTypeName("BOOL : 1")]
    public BOOL allowActiveWhenMousePresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 31) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~0x1) | ((BOOL)(value) & 0x1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL feedbackEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 30) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL tapEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 29) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL tapAndDragEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 28) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL twoFingerTapEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 27) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL rightClickZoneEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 26) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL mouseAccelSettingHonored
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 25) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL panEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 24) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL zoomEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 23) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8); }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL scrollDirectionReversed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 22) >> 31); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x1 << 9)) | (((BOOL)(value) & 0x1) << 9); }
    }

    [NativeTypeName("BOOL : 22")]
    public BOOL Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (BOOL)((_bitfield2 << 0) >> 10); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (_bitfield2 & ~(0x3FFFFF << 10)) | (((BOOL)(value) & 0x3FFFFF) << 10); }
    }
    public TOUCHPAD_SENSITIVITY_LEVEL sensitivityLevel;
    public uint cursorSpeed;
    public uint feedbackIntensity;
    public uint clickForceSensitivity;
    public uint rightClickZoneWidth;
    public uint rightClickZoneHeight;
}
