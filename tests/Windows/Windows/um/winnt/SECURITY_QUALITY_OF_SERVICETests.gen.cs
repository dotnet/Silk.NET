// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SECURITY_QUALITY_OF_SERVICE"/> struct.</summary>
public static unsafe partial class SECURITY_QUALITY_OF_SERVICETests
{
    /// <summary>Validates that the <see cref = "SECURITY_QUALITY_OF_SERVICE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SECURITY_QUALITY_OF_SERVICE>(), Is.EqualTo(sizeof(SECURITY_QUALITY_OF_SERVICE)));
    }

    /// <summary>Validates that the <see cref = "SECURITY_QUALITY_OF_SERVICE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SECURITY_QUALITY_OF_SERVICE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SECURITY_QUALITY_OF_SERVICE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SECURITY_QUALITY_OF_SERVICE), Is.EqualTo(12));
    }
}