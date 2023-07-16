// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MsftWriteEngine2"/> struct.</summary>
public static unsafe partial class MsftWriteEngine2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftWriteEngine2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftWriteEngine2).GUID, Is.EqualTo(CLSID_MsftWriteEngine2));
    }

    /// <summary>Validates that the <see cref = "MsftWriteEngine2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MsftWriteEngine2>(), Is.EqualTo(sizeof(MsftWriteEngine2)));
    }

    /// <summary>Validates that the <see cref = "MsftWriteEngine2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftWriteEngine2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftWriteEngine2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftWriteEngine2), Is.EqualTo(1));
    }
}