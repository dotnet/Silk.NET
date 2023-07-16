// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SAFEARR_VARIANT"/> struct.</summary>
public static unsafe partial class SAFEARR_VARIANTTests
{
    /// <summary>Validates that the <see cref = "SAFEARR_VARIANT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SAFEARR_VARIANT>(), Is.EqualTo(sizeof(SAFEARR_VARIANT)));
    }

    /// <summary>Validates that the <see cref = "SAFEARR_VARIANT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SAFEARR_VARIANT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SAFEARR_VARIANT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SAFEARR_VARIANT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SAFEARR_VARIANT), Is.EqualTo(8));
        }
    }
}