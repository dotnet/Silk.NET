// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IWpfListenerChannelCallback"/> struct.</summary>
public static unsafe partial class IWpfListenerChannelCallbackTests
{
    /// <summary>Validates that the <see cref = "IWpfListenerChannelCallback"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IWpfListenerChannelCallback>(),
            Is.EqualTo(sizeof(IWpfListenerChannelCallback))
        );
    }

    /// <summary>Validates that the <see cref = "IWpfListenerChannelCallback"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWpfListenerChannelCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWpfListenerChannelCallback"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWpfListenerChannelCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWpfListenerChannelCallback), Is.EqualTo(4));
        }
    }
}
