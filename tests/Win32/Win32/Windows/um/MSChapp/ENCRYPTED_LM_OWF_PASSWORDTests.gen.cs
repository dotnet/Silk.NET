// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ENCRYPTED_LM_OWF_PASSWORD"/> struct.</summary>
public static unsafe partial class ENCRYPTED_LM_OWF_PASSWORDTests
{
    /// <summary>Validates that the <see cref = "ENCRYPTED_LM_OWF_PASSWORD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ENCRYPTED_LM_OWF_PASSWORD>(),
            Is.EqualTo(sizeof(ENCRYPTED_LM_OWF_PASSWORD))
        );
    }

    /// <summary>Validates that the <see cref = "ENCRYPTED_LM_OWF_PASSWORD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ENCRYPTED_LM_OWF_PASSWORD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ENCRYPTED_LM_OWF_PASSWORD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ENCRYPTED_LM_OWF_PASSWORD), Is.EqualTo(16));
    }
}
