package uk.co.ultz.silkdroid;

import android.util.Log;

public class SilkMain implements Runnable {
    @Override
    public void run() {
        Log.v("SDL", "Running Silk.NET main function");
        try {
            SilkActivity.getSingleton().onRun();
        } catch (IllegalAccessException e) {
            e.printStackTrace();
        }

        Log.v("SDL", "Finished main function");
    }
}
