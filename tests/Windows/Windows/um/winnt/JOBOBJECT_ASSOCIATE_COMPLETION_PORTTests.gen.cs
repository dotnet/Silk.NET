// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/> struct.</summary>
public static unsafe partial class JOBOBJECT_ASSOCIATE_COMPLETION_PORTTests
{
    /// <summary>Validates that the <see cref = "JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<JOBOBJECT_ASSOCIATE_COMPLETION_PORT>(), Is.EqualTo(sizeof(JOBOBJECT_ASSOCIATE_COMPLETION_PORT)));
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(JOBOBJECT_ASSOCIATE_COMPLETION_PORT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(JOBOBJECT_ASSOCIATE_COMPLETION_PORT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(JOBOBJECT_ASSOCIATE_COMPLETION_PORT), Is.EqualTo(8));
        }
    }
}