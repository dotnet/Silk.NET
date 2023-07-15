// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SID_IDENTIFIER_AUTHORITY"/> struct.</summary>
public static unsafe partial class SID_IDENTIFIER_AUTHORITYTests
{
    /// <summary>Validates that the <see cref = "SID_IDENTIFIER_AUTHORITY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SID_IDENTIFIER_AUTHORITY>(), Is.EqualTo(sizeof(SID_IDENTIFIER_AUTHORITY)));
    }

    /// <summary>Validates that the <see cref = "SID_IDENTIFIER_AUTHORITY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SID_IDENTIFIER_AUTHORITY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SID_IDENTIFIER_AUTHORITY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SID_IDENTIFIER_AUTHORITY), Is.EqualTo(6));
    }
}