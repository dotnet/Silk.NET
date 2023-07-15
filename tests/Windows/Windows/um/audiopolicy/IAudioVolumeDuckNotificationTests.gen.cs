// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAudioVolumeDuckNotification"/> struct.</summary>
public static unsafe partial class IAudioVolumeDuckNotificationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAudioVolumeDuckNotification"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioVolumeDuckNotification).GUID, Is.EqualTo(IID_IAudioVolumeDuckNotification));
    }

    /// <summary>Validates that the <see cref = "IAudioVolumeDuckNotification"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAudioVolumeDuckNotification>(), Is.EqualTo(sizeof(IAudioVolumeDuckNotification)));
    }

    /// <summary>Validates that the <see cref = "IAudioVolumeDuckNotification"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioVolumeDuckNotification).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAudioVolumeDuckNotification"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioVolumeDuckNotification), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioVolumeDuckNotification), Is.EqualTo(4));
        }
    }
}