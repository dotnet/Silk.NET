// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NEGOTIATE_PACKAGE_PREFIXES"/> struct.</summary>
public static unsafe partial class NEGOTIATE_PACKAGE_PREFIXESTests
{
    /// <summary>Validates that the <see cref = "NEGOTIATE_PACKAGE_PREFIXES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NEGOTIATE_PACKAGE_PREFIXES>(), Is.EqualTo(sizeof(NEGOTIATE_PACKAGE_PREFIXES)));
    }

    /// <summary>Validates that the <see cref = "NEGOTIATE_PACKAGE_PREFIXES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NEGOTIATE_PACKAGE_PREFIXES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NEGOTIATE_PACKAGE_PREFIXES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NEGOTIATE_PACKAGE_PREFIXES), Is.EqualTo(16));
    }
}