// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SpMMAudioIn"/> struct.</summary>
public static unsafe partial class SpMMAudioInTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SpMMAudioIn"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpMMAudioIn).GUID, Is.EqualTo(CLSID_SpMMAudioIn));
    }

    /// <summary>Validates that the <see cref = "SpMMAudioIn"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpMMAudioIn>(), Is.EqualTo(sizeof(SpMMAudioIn)));
    }

    /// <summary>Validates that the <see cref = "SpMMAudioIn"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpMMAudioIn).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpMMAudioIn"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpMMAudioIn), Is.EqualTo(1));
    }
}