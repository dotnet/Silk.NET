// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DLLVERSIONINFO2"/> struct.</summary>
public static unsafe partial class DLLVERSIONINFO2Tests
{
    /// <summary>Validates that the <see cref = "DLLVERSIONINFO2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DLLVERSIONINFO2>(), Is.EqualTo(sizeof(DLLVERSIONINFO2)));
    }

    /// <summary>Validates that the <see cref = "DLLVERSIONINFO2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DLLVERSIONINFO2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DLLVERSIONINFO2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DLLVERSIONINFO2), Is.EqualTo(32));
    }
}