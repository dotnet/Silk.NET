// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TF_INPUTPROCESSORPROFILE
{
    [NativeTypeName("DWORD")]
    public uint dwProfileType;

    [NativeTypeName("LANGID")]
    public ushort langid;

    [NativeTypeName("CLSID")]
    public Guid clsid;
    public Guid guidProfile;
    public Guid catid;
    public HKL hklSubstitute;

    [NativeTypeName("DWORD")]
    public uint dwCaps;
    public HKL hkl;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
