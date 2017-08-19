﻿using System;

namespace ProjectMarkdown.Statics
{
    public static class FolderPaths
    {
        public static readonly string DefaultLogFolderPath = AppDomain.CurrentDomain.BaseDirectory + "Log";
        public static readonly string PreferencesFolderPath = AppDomain.CurrentDomain.BaseDirectory + "Configuration";
    }
}