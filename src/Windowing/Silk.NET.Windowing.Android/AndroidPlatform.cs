using System;
using Android.App;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Android
{
    public class AndroidPlatform : IWindowPlatform
    {
        public bool IsApplicable => Activity != null;
        public static Activity Activity { get; set; }
        public static AndroidWindow Current { get; set; }

        public IWindow GetWindow(WindowOptions options)
        {
            if (Current != null)
            {
                throw new NotSupportedException("Multiple windows are not supported on Android.");
            }

            if (Activity == null)
            {
                throw new InvalidOperationException
                (
                    "AndroidPlatform has not been initialized. To initialize it, pass the current Activity " +
                    "as an argument to Window.Init(Activity)"
                );
            }
            return Current = new AndroidWindow(Activity, options);
        }
        
        public static void Init(Activity activity)
        {
            Activity = activity;
        }
    }
}
