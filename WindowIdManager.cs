using System;

namespace CheatMod
{
    public static class WindowIdManager
    {
        private static int m_NextId = 2222; // I just start a bit higher to keep space for hardcoded window ids.
        public static int GetWindowId()
        {
            return m_NextId++;
        }
    }
}

