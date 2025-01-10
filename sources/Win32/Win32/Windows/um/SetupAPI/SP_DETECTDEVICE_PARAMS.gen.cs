// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SP_DETECTDEVICE_PARAMS
{
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    [NativeTypeName("PDETECT_PROGRESS_NOTIFY")]
    public delegate* unmanaged<void*, uint, BOOL> DetectProgressNotify;

    [NativeTypeName("PVOID")]
    public void* ProgressNotifyParam;
}
