﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common.Interfaces;
using Wpf.Ui.Gallery.ViewModels.Pages.Navigation;

namespace Wpf.Ui.Gallery.Views.Pages.Navigation;

public partial class TabControlPage : INavigableView<TabControlViewModel>
{
    public TabControlViewModel ViewModel { get; }

    public TabControlPage(TabControlViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}
