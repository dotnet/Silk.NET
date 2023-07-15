// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRGLSBOUNDEDRECORD"/> struct.</summary>
public static unsafe partial class EMRGLSBOUNDEDRECORDTests
{
    /// <summary>Validates that the <see cref = "EMRGLSBOUNDEDRECORD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRGLSBOUNDEDRECORD>(), Is.EqualTo(sizeof(EMRGLSBOUNDEDRECORD)));
    }

    /// <summary>Validates that the <see cref = "EMRGLSBOUNDEDRECORD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRGLSBOUNDEDRECORD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRGLSBOUNDEDRECORD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRGLSBOUNDEDRECORD), Is.EqualTo(32));
    }
}