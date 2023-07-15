// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NOTIFICATION_USER_INPUT_DATA"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class NOTIFICATION_USER_INPUT_DATATests
{
    /// <summary>Validates that the <see cref = "NOTIFICATION_USER_INPUT_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NOTIFICATION_USER_INPUT_DATA>(), Is.EqualTo(sizeof(NOTIFICATION_USER_INPUT_DATA)));
    }

    /// <summary>Validates that the <see cref = "NOTIFICATION_USER_INPUT_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NOTIFICATION_USER_INPUT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NOTIFICATION_USER_INPUT_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NOTIFICATION_USER_INPUT_DATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(NOTIFICATION_USER_INPUT_DATA), Is.EqualTo(8));
        }
    }
}