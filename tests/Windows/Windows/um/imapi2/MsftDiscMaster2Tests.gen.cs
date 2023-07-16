// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MsftDiscMaster2"/> struct.</summary>
public static unsafe partial class MsftDiscMaster2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftDiscMaster2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftDiscMaster2).GUID, Is.EqualTo(IID_MsftDiscMaster2));
    }

    /// <summary>Validates that the <see cref = "MsftDiscMaster2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MsftDiscMaster2>(), Is.EqualTo(sizeof(MsftDiscMaster2)));
    }

    /// <summary>Validates that the <see cref = "MsftDiscMaster2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftDiscMaster2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftDiscMaster2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftDiscMaster2), Is.EqualTo(1));
    }
}