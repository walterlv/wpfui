﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Wpf.Ui.Common;
using Wpf.Ui.Gallery.Models;

namespace Wpf.Ui.Gallery.ViewModels.Pages;

public partial class AllControlsViewModel : ObservableObject
{
    [ObservableProperty]
    private ICollection<NavigationCard> _navigationCards;

    public AllControlsViewModel()
    {
        NavigationCards = new ObservableCollection<NavigationCard>
        {
            new()
            {
                Name = "Anchor",
                Icon = SymbolRegular.CubeLink20,
                Description = "Button which opens a link.",
                Link = "Anchor"
            },
            new()
            {
                Name = "Button",
                Icon = SymbolRegular.ControlButton24,
                Description = "Simple button.",
                Link = "Button"
            },
            new()
            {
                Name = "Hyperlink",
                Icon = SymbolRegular.Link24,
                Description = "Opens a link.",
                Link = "Hyperlink"
            },
            new()
            {
                Name = "ToggleButton",
                Icon = SymbolRegular.ToggleRight24,
                Description = "Toggleable button.",
                Link = "ToggleButton"
            },
            new()
            {
                Name = "ToggleSwitch",
                Icon = SymbolRegular.ToggleLeft24,
                Description = "Switchable button with a ball.",
                Link = "ToggleSwitch"
            },
            new()
            {
                Name = "CheckBox",
                Icon = SymbolRegular.CheckmarkSquare24,
                Description = "Button with binary choice.",
                Link = "CheckBox"
            },
            new()
            {
                Name = "ComboBox",
                Icon = SymbolRegular.Filter16,
                Description = "Button with binary choice.",
                Link = "ComboBox"
            },
            new()
            {
                Name = "RadioButton",
                Icon = SymbolRegular.RadioButton24,
                Description = "Set of options as buttons.",
                Link = "RadioButton"
            },
            new()
            {
                Name = "Rating",
                Icon = SymbolRegular.Star24,
                Description = "Rating using stars.",
                Link = "Rating"
            },
            new()
            {
                Name = "ThumbRate",
                Icon = SymbolRegular.ThumbLike24,
                Description = "Like or dislike.",
                Link = "ThumbRate"
            },
            new()
            {
                Name = "Slider",
                Icon = SymbolRegular.HandDraw24,
                Description = "Sliding control.",
                Link = "Slider"
            },
            new()
            {
                Name = "Snackbar",
                Icon = SymbolRegular.PlayingCards20,
                Description = "Information card at the bottom.",
                Link = "Snackbar"
            },
            new()
            {
                Name = "Dialog",
                Icon = SymbolRegular.CalendarMultiple24,
                Description = "Card covering the app content",
                Link = "Dialog"
            },
            new()
            {
                Name = "Flyout",
                Icon = SymbolRegular.AppTitle24,
                Description = "Contextual popup.",
                Link = "Flyout"
            },
            new()
            {
                Name = "MessageBox",
                Icon = SymbolRegular.CalendarInfo20,
                Description = "MessageBox",
                Link = "MessageBox"
            },
            new()
            {
                Name = "WebView",
                Icon = SymbolRegular.GlobeDesktop24,
                Description = "Embedded browser window.",
                Link = "WebView"
            },
            new()
            {
                Name = "NavigationView",
                Icon = SymbolRegular.Navigation24,
                Description = "Main navigation for the app.",
                Link = "NavigationView"
            },
            new()
            {
                Name = "TabControl",
                Icon = SymbolRegular.NavigationUnread24,
                Description = "Tab control like in browser.",
                Link = "TabControl"
            },
            new()
            {
                Name = "InfoBar",
                Icon = SymbolRegular.ErrorCircle24,
                Description = "Inline message card.",
                Link = "InfoBar"
            },
            new()
            {
                Name = "ProgressBar",
                Icon = SymbolRegular.ArrowDownload24,
                Description = "Shows the app progress on a task.",
                Link = "ProgressBar"
            },
            new()
            {
                Name = "ProgressRing",
                Icon = SymbolRegular.ArrowClockwise24,
                Description = "Shows the app progress on a task.",
                Link = "ProgressRing"
            },
            new()
            {
                Name = "ToolTip",
                Icon = SymbolRegular.Comment24,
                Description = "Information in popup window.",
                Link = "ToolTip"
            },
            new()
            {
                Name = "AutoSuggestBox",
                Icon = SymbolRegular.TextBulletListSquare24,
                Description = "Control with suggestions.",
                Link = "AutoSuggestBox"
            },
            new()
            {
                Name = "NumberBox",
                Icon = SymbolRegular.NumberSymbol24,
                Description = "Control for numeric input.",
                Link = "NumberBox"
            },
            new()
            {
                Name = "PasswordBox",
                Icon = SymbolRegular.Password24,
                Description = "A control for entering passwords.",
                Link = "PasswordBox"
            },
            new()
            {
                Name = "RichTextBox",
                Icon = SymbolRegular.DrawText24,
                Description = "A rich editing control.",
                Link = "RichTextBox"
            },
            new()
            {
                Name = "Label",
                Icon = SymbolRegular.TextBaseline20,
                Description = "Caption of an item.",
                Link = "Label"
            },
            new()
            {
                Name = "TextBlock",
                Icon = SymbolRegular.TextCaseLowercase24,
                Description = "Control for displaying text.",
                Link = "TextBlock"
            },
            new()
            {
                Name = "TextBox",
                Icon = SymbolRegular.TextColor24,
                Description = "Plain text field.",
                Link = "TextBox"
            },
            new()
            {
                Name = "SymbolIcon",
                Icon = SymbolRegular.Fluent24,
                Description = "Single icon.",
                Link = "SymbolIcon"
            },
            new()
            {
                Name = "FontIcon",
                Icon = SymbolRegular.TextFont24,
                Description = "Control displaying a single font glyph.",
                Link = "FontIcon"
            }
        };
    }
}
