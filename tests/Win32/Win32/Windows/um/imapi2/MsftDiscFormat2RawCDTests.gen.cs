// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MsftDiscFormat2RawCD"/> struct.</summary>
public static unsafe partial class MsftDiscFormat2RawCDTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftDiscFormat2RawCD"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftDiscFormat2RawCD).GUID, Is.EqualTo(CLSID_MsftDiscFormat2RawCD));
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2RawCD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MsftDiscFormat2RawCD>(),
            Is.EqualTo(sizeof(MsftDiscFormat2RawCD))
        );
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2RawCD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftDiscFormat2RawCD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2RawCD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftDiscFormat2RawCD), Is.EqualTo(1));
    }
}
