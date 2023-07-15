// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SENDCMDOUTPARAMS"/> struct.</summary>
public static unsafe partial class SENDCMDOUTPARAMSTests
{
    /// <summary>Validates that the <see cref = "SENDCMDOUTPARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SENDCMDOUTPARAMS>(), Is.EqualTo(sizeof(SENDCMDOUTPARAMS)));
    }

    /// <summary>Validates that the <see cref = "SENDCMDOUTPARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SENDCMDOUTPARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SENDCMDOUTPARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SENDCMDOUTPARAMS), Is.EqualTo(17));
    }
}