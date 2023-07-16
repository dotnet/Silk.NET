// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.Windows;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "MFP_POSITIONTYPE_100NS"/> property is correct.</summary>
    [Test]
    public static void MFP_POSITIONTYPE_100NSTest()
    {
        Assert.That(MFP_POSITIONTYPE_100NS, Is.EqualTo(new Guid(0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0)));
    }

    /// <summary>Validates that the value of the <see cref = "MFP_PKEY_StreamIndex"/> property is correct.</summary>
    [Test]
    public static void MFP_PKEY_StreamIndexTest()
    {
        Assert.That(MFP_PKEY_StreamIndex.fmtid, Is.EqualTo(new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad)));
        Assert.That(MFP_PKEY_StreamIndex.pid, Is.EqualTo(0x00));
    }

    /// <summary>Validates that the value of the <see cref = "MFP_PKEY_StreamRenderingResults"/> property is correct.</summary>
    [Test]
    public static void MFP_PKEY_StreamRenderingResultsTest()
    {
        Assert.That(MFP_PKEY_StreamRenderingResults.fmtid, Is.EqualTo(new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad)));
        Assert.That(MFP_PKEY_StreamRenderingResults.pid, Is.EqualTo(0x01));
    }
}