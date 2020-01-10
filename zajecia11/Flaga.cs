using System;

namespace zajecia11
{
    [Flags]
    public enum PersonType
    {
        None = 0,
        Toddler = 1,
        Child = 2,
        Teenager = 4,
        Adult = 8,
        Elder = 16
    }

    [Flags]
    enum Interests
    {
        None = 0,
        Electronics = 1,
        Automotive = 2,
        Gaming = 4,
        Education = 8
    }
}