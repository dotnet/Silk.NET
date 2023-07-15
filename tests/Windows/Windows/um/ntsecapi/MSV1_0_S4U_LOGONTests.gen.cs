// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MSV1_0_S4U_LOGON"/> struct.</summary>
public static unsafe partial class MSV1_0_S4U_LOGONTests
{
    /// <summary>Validates that the <see cref = "MSV1_0_S4U_LOGON"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSV1_0_S4U_LOGON>(), Is.EqualTo(sizeof(MSV1_0_S4U_LOGON)));
    }

    /// <summary>Validates that the <see cref = "MSV1_0_S4U_LOGON"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSV1_0_S4U_LOGON).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MSV1_0_S4U_LOGON"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MSV1_0_S4U_LOGON), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(MSV1_0_S4U_LOGON), Is.EqualTo(24));
        }
    }
}