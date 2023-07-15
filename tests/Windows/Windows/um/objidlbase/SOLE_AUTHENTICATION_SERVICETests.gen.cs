// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SOLE_AUTHENTICATION_SERVICE"/> struct.</summary>
public static unsafe partial class SOLE_AUTHENTICATION_SERVICETests
{
    /// <summary>Validates that the <see cref = "SOLE_AUTHENTICATION_SERVICE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOLE_AUTHENTICATION_SERVICE>(), Is.EqualTo(sizeof(SOLE_AUTHENTICATION_SERVICE)));
    }

    /// <summary>Validates that the <see cref = "SOLE_AUTHENTICATION_SERVICE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOLE_AUTHENTICATION_SERVICE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOLE_AUTHENTICATION_SERVICE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SOLE_AUTHENTICATION_SERVICE), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SOLE_AUTHENTICATION_SERVICE), Is.EqualTo(16));
        }
    }
}