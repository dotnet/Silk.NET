// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MsftDiscFormat2Data"/> struct.</summary>
public static unsafe partial class MsftDiscFormat2DataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftDiscFormat2Data"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftDiscFormat2Data).GUID, Is.EqualTo(CLSID_MsftDiscFormat2Data));
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2Data"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MsftDiscFormat2Data>(), Is.EqualTo(sizeof(MsftDiscFormat2Data)));
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2Data"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftDiscFormat2Data).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftDiscFormat2Data"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftDiscFormat2Data), Is.EqualTo(1));
    }
}