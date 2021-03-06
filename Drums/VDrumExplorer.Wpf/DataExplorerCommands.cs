﻿// Copyright 2019 Jon Skeet. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using System.Windows.Input;

namespace VDrumExplorer.Wpf
{
    public static class DataExplorerCommands
    {
        public static RoutedCommand OpenCopyInKitExplorer { get; } = new RoutedCommand(nameof(OpenCopyInKitExplorer), typeof(DataExplorerCommands));
        public static RoutedCommand CopyKit { get; } = new RoutedCommand(nameof(CopyKit), typeof(DataExplorerCommands));
        public static RoutedCommand ImportKitFromFile { get; } = new RoutedCommand(nameof(ImportKitFromFile), typeof(DataExplorerCommands));
        public static RoutedCommand ExportKit { get; } = new RoutedCommand(nameof(ExportKit), typeof(DataExplorerCommands));
    }
}
