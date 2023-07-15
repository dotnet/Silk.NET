// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SECURITY_OBJECT_AI_PARAMS"/> struct.</summary>
public static unsafe partial class SECURITY_OBJECT_AI_PARAMSTests
{
    /// <summary>Validates that the <see cref = "SECURITY_OBJECT_AI_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SECURITY_OBJECT_AI_PARAMS>(), Is.EqualTo(sizeof(SECURITY_OBJECT_AI_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "SECURITY_OBJECT_AI_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SECURITY_OBJECT_AI_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SECURITY_OBJECT_AI_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SECURITY_OBJECT_AI_PARAMS), Is.EqualTo(8));
    }
}