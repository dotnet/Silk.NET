// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SAFEARRAYBOUND"/> struct.</summary>
public static unsafe partial class SAFEARRAYBOUNDTests
{
    /// <summary>Validates that the <see cref = "SAFEARRAYBOUND"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SAFEARRAYBOUND>(), Is.EqualTo(sizeof(SAFEARRAYBOUND)));
    }

    /// <summary>Validates that the <see cref = "SAFEARRAYBOUND"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SAFEARRAYBOUND).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SAFEARRAYBOUND"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SAFEARRAYBOUND), Is.EqualTo(8));
    }
}