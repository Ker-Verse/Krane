﻿namespace Krane.Core;
public static class GameTime
{
    private static Clock gameTime = new();
    public static Time deltaTime;
    public static Time totalTime = new();
    public static ulong Ticks = 0;
    public static void Tick()
    {
        deltaTime = gameTime.Restart();
        totalTime += deltaTime;
        Ticks++;
    }
}


